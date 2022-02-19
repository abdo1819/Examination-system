/* -------------------------------------------------------------------------- */
/*                        CRUDS for student, dept, instructor                 */
/* -------------------------------------------------------------------------- */

-- Fathy comment: Should we double check which procedures should go in [PRIVATE] schema?

USE Examination;
GO

/* -------------------------------------------------------------------------- */
/*                                 Create User                                */
/* -------------------------------------------------------------------------- */

-- User [usr_id, user_type, f_name, l_name, address, email, password]

CREATE OR ALTER PROCEDURE [PRIVATE].[Insert_User]
    @user_type varChar(1),
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @password varChar(255),
    @usr_id INTEGER OUTPUT
AS
BEGIN
    BEGIN TRY 
    
    

    DECLARE @hashed_password varChar(255);
    -- TODO define the seed globally
    SELECT @hashed_password = HASHBYTES('SHA2_256', @password+'seed');
    INSERT INTO [User]
        (user_type, f_name, l_name, address, email, [hashed_password])
    VALUES
        (
            @user_type,
            @f_name,
            @l_name,
            @address,
            @email,
            @hashed_password
    );
    
    SELECT @usr_id = scope_identity();
	RETURN 1;
    /* NOTE scope_identity() may give wrong result when queries run in parrallel
    ref:[1]:https://blog.sqlauthority.com/2009/03/24/sql-server-2008-scope_identity-bug-with-multi-processor-parallel-plan-and-solution/
    [2]:https://stackoverflow.com/questions/42648/sql-server-best-way-to-get-identity-of-inserted-row
    */
    END TRY
    BEGIN CATCH
    RETURN 0;
    -- select ERROR_MESSAGE() 'Error Message'
	-- , ERROR_NUMBER() 'Error Number'
	-- , ERROR_LINE () 'Error Line Number'
	-- , ERROR_SEVERITY () 'Error Severity Level'
	-- , ERROR_PROCEDURE() 'Error Procedure'
	-- , ERROR_STATE () 'Error State';
    -- IF (ERROR_NUMBER() = 2627)
        -- SELECT 'User already exists' as [Error Message];
   --  ELSE
       -- SELECT ERROR_NUMBER() 'Error Number', ERROR_MESSAGE() 'Error Message';
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                              Create Student                                */
/* -------------------------------------------------------------------------- */

-- Student [std_id, dept_id]
/*
user has type 'S' capital S
*/
CREATE OR ALTER PROCEDURE [dbo].[Insert_Student]
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @password varChar(255),
    @dept_id INTEGER,
    @stu_id INTEGER OUTPUT
AS
BEGIN
    begin try
    Exec [PRIVATE].[Insert_User] 'S', @f_name, @l_name, @address, @email, @password, @stu_id OUTPUT;
    INSERT INTO [Student]
    VALUES
        (
            @stu_id,
            @dept_id
    );
	RETURN 1;
    END TRY
    BEGIN CATCH
        RETURN 0;
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                           Create Instructor                                */
/* -------------------------------------------------------------------------- */

-- Instructor [ins_id, salary, degree, dept_id]
/*
user has type 'I' capital I
*/
CREATE OR ALTER PROCEDURE [dbo].[Insert_Instructor]
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @password varChar(255),
    @salary MONEY,
    @degree varChar(50),
    @dept_id INTEGER,
    @ins_id INTEGER OUTPUT
AS
BEGIN
    BEGIN TRY
    DECLARE @usr_id INTEGER;
    Exec [PRIVATE].[Insert_User] 'I', @f_name, @l_name, @address, @email, @password, @usr_id OUTPUT;
    INSERT INTO [Instructor]
        (ins_id, salary, degree, dept_id)
    VALUES
        (
            @usr_id,
            @salary,
            @degree,
            @dept_id
    );
    SET @ins_id = @usr_id;
    END TRY
    BEGIN CATCH
        SELECT 'failed to insert instructor' as [Error Message];
    END CATCH
END
GO

/* ----------------------- required helping procedure ----------------------- */

/* -------------------------------------------------------------------------- */
/*                            Create Department                               */
/* -------------------------------------------------------------------------- */

-- Department [dept_id, dept_name, mgr_id]
create or alter procedure Insert_Department @dept_name varchar(20), @id_mgr int, @dept_id int output
as
	if exists (select ins_id from [Instructor] where ins_id = @id_mgr)
	begin
		insert into [Department] values (@dept_name, @id_mgr)
		select @dept_id = dept_id from Department where dept_name = @dept_name
		return 1
	end
	else
	begin
		select 'no instructor with ID ' + cast(@id_mgr as varchar) +' found'
		return 0
	end
------------------------------------------------------------------------
GO

/* -------------------------------------------------------------------------- */
/*                     Create Department with manager                         */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE [dbo].[Insert_Department_With_Manager]
    @dept_name varChar(100),
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @password varChar(255),
    @salary MONEY,
    @degree varChar(50),
    @dept_id INTEGER OUTPUT,
    @mgr_id INTEGER OUTPUT
AS
BEGIN
    -- TODO use try catch for errors
    ALTER TABLE Instructor NOCHECK CONSTRAINT Instructor_fk_1;
    DECLARE @_no_dep INT = 0;
    Exec [dbo].[Insert_Instructor] @f_name, @l_name, @address, @email, @password, @salary, @degree, @_no_dep, @mgr_id OUTPUT;
    -- TODO replace this with the real procedure
    Exec [dbo].[Insert_Department] @dept_name, @mgr_id, @dept_id OUTPUT;
    UPDATE Instructor SET dept_id = @dept_id WHERE ins_id = @mgr_id;
    ALTER TABLE Instructor CHECK CONSTRAINT Instructor_fk_1;

END
GO

/* -------------------------------------------------------------------------- */
/*         Get User according to E-mail and password (used in login form)     */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROC GetUser @email VARCHAR(90), @password VARCHAR(255)
AS
BEGIN
DECLARE @hashed_password AS VARCHAR(255)
SELECT @hashed_password = HASHBYTES('SHA2_256', @password+'seed');
SELECT * 
FROM [User] U
WHERE U.email = @email AND @hashed_password = U.hashed_password
END
GO

/* -------------------------------------------------------------------------- */
/*                                Read Student                                */
/* -------------------------------------------------------------------------- */


CREATE OR ALTER PROCEDURE getAllStudents
AS
BEGIN
    SELECT *
    FROM v_Students;
END
GO

/* -------------------------------------------------------------------------- */
/*                              Read Instructor                               */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE getAllInstructors
AS
BEGIN
    SELECT *
    FROM v_Instructor;
END
GO

CREATE OR ALTER PROCEDURE getInstructorsInDepartment
    @dept_id INTEGER
AS
BEGIN
    SELECT usr_id, f_name,
        l_name,
        address,
        email,
        salary,
        degree
    FROM v_Instructors
    WHERE dept_id = @dept_id;
END
GO

/* -------------------------------------------------------------------------- */
/*                              Read Department                               */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE getAllDepartments
AS
BEGIN
    SELECT *
    FROM Department;
END
GO

CREATE OR ALTER PROCEDURE getDepartment
    @dept_id INT
AS
BEGIN
    IF EXISTS (SELECT dept_id FROM Department WHERE dept_id = @dept_id)
        BEGIN
            SELECT D.dept_name, D.mgr_id, U.f_name + ' ' + U.l_name AS [Manager Name]
            FROM Department D, [User] U
            WHERE D.mgr_id = U.usr_id
        END
    ELSE
        SELECT 'Department ID does not exist' AS [Error Message]
END
GO

/* -------------------------------------------------------------------------- */
/*                              update user data                              */
/* -------------------------------------------------------------------------- */

-- Fathy Comment Needed to add functionality to update password for desktop application

	CREATE OR ALTER PROCEDURE updateUserData
    @usr_id INTEGER,
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @password VARCHAR(255)
AS
BEGIN

    DECLARE @hashed_password varChar(255);
    SELECT @hashed_password = HASHBYTES('SHA2_256', @password+'seed');
    BEGIN TRY
    UPDATE [User]
    SET
        f_name = @f_name,
        l_name = @l_name,
        [address] = @address,
        hashed_password = @hashed_password
    WHERE usr_id = @usr_id;
		IF NOT EXISTS (SELECT *  FROM [User] U WHERE U.usr_id = @usr_id AND U.email = @email)
		BEGIN
			UPDATE [USER]
			SET
			email = @email
			WHERE usr_id = @usr_id
		END
		RETURN 1;
    END TRY
    BEGIN CATCH
        -- TODO send specific error message when email is already in database
        RETURN 0;
    END CATCH
END

GO

/* -------------------------------------------------------------------------- */
/*                           Update Student Data                              */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE updateStudentData
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @dept_id INTEGER,
    @std_id INTEGER
AS
BEGIN
    BEGIN TRY
    -- update the userInfo
    EXEC [dbo].[updateUserData] 
    @usr_id = @std_id,
    @f_name = @f_name,
    @l_name = @l_name,
    @address = @address,
    @email = @email;
    -- update student specificInfo
    UPDATE [Student]
    SET dept_id = @dept_id
    WHERE std_id = @std_id;
    END TRY
    BEGIN CATCH
        -- TODO send specific error message when department id is not in the database
        SELECT 'failed to update student' as [Error Message];
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                        Update Instructor Data                              */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE updateInstructorData
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90),
    @salary MONEY,
    @degree varChar(50),
    @dept_id INTEGER,
    @ins_id INTEGER
AS
BEGIN
    BEGIN TRY
    -- update the userInfo
    EXEC [dbo].[updateUserData] 
    @usr_id = @ins_id,
    @f_name = @f_name,
    @l_name = @l_name,
    @address = @address,
    @email = @email;
    -- update instructor specificInfo
    UPDATE [Instructor]
    SET salary = @salary,
        degree = @degree,
        dept_id = @dept_id
    WHERE ins_id = @ins_id;
    END TRY
    BEGIN CATCH
        -- TODO send specific error message when department id is not in the database
        SELECT 'failed to update instructor' as [Error Message];
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                     Update Department Manager                              */
/* -------------------------------------------------------------------------- */

create or alter procedure Update_Department_Manager @dept_name varchar(20), @mgr_id int
as
if exists (select dept_name from [Department] where dept_name = @dept_name)
begin
	begin try
		update [Department] set mgr_id = @mgr_id where dept_name = @dept_name
	end try
	begin catch
		select 'Error: There is no an instructor with ID ' + @mgr_id
	end catch
end
else 
	select 'No department with name ' + @dept_name
GO

/* -------------------------------------------------------------------------- */
/*                               Delete Student                               */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE deleteStudent
    @std_id INTEGER
AS
BEGIN
    BEGIN TRY
    -- FIXME delete course attendance
    -- FIXME delete exam answers
      
    DELETE FROM [Student]
    WHERE std_id = @std_id;
  
    DELETE FROM [User]
    WHERE usr_id = @std_id;
    END TRY
    BEGIN CATCH
        SELECT 'failed to delete student' as [Error Message];
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                             Delete Instructor                              */
/* -------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE deleteInstructor
    @ins_id INTEGER
AS
BEGIN
    BEGIN TRY
    -- FIXME delete course attendance
    -- FIXME handle Ins_Course
    -- FIXME handle if instructor is a manager of a department
    
    
    DELETE FROM [Instructor]
    WHERE ins_id = @ins_id;
  
    DELETE FROM [User]
    WHERE usr_id = @ins_id;
    END TRY
    BEGIN CATCH
        SELECT 'failed to delete instructor' as [Error Message];
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                             Delete Department                              */
/* -------------------------------------------------------------------------- */

create or alter procedure Delete_Department @dept_name varchar(20)
as
if exists (select dept_name from [Department] where dept_name = @dept_name)
begin
	begin try
		delete from [Department] where dept_name = @dept_name
		return  1 -- deleted successfully 
	end try
	begin catch
		select 'Please check for instructors and students in this department'
		return 0
	end catch
end
else 
begin
	select 'No department with name ' + @dept_name
	return 0
end

GO

/* -------------------------------------------------------------------------- */
/*                    Comments to be checked later?           */
/* -------------------------------------------------------------------------- */

------------------------------------------------------------------------
-- GO
-- create or alter procedure Insert_Student @f_name varchar(20), @l_name varchar(20), @address varchar(30), @email varchar(20), @password varchar(30), @dept_name varchar(20), @id_std int output
-- as
-- declare @id_dept int
-- 	begin try
-- 		insert into [User] values ('s', @f_name, @l_name, @address, @email, @password)
-- 		select @id_std = usr_id from [User] where email = @email
-- 		select @id_dept = dept_id from [Department] where dept_name = @dept_name
-- 		insert into [Student] values (@id_std, @id_dept)
-- 		return @id_std
-- 	end try
-- 	begin catch
-- 		select 'Duplicate Email'
-- 	end catch

-- ------------------------------------------------------------------------
-- GO


-- create or alter procedure Insert_Instructor @f_name varchar(20), @l_name varchar(20), @address varchar(30), @email varchar(20), @password varchar(30), @sal int, @degree varchar(50), @hire_date date = getdate, @dept_name varchar(20), @id_ins int output
-- as
-- declare @id_dept int
-- 	begin try
-- 		insert into [User] values ('i', @f_name, @l_name, @address, @email, @password)
-- 		select @id_ins = usr_id from [User] where email = @email
-- 		select @id_dept = dept_id from [Department] where dept_name = @dept_name
-- 		insert into [Instructor] values (@id_ins, @sal, @degree, @id_dept, @hire_date)
-- 		return @id_ins
-- 	end try
-- 	begin catch
-- 		select 'Duplicate Email'
-- 	end catch

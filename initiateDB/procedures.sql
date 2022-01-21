USE Examination;
GO

-- create PRIVATE schema if not exist in the database
-- PRIVATE schema is procedure not intended for end-user(developer)
IF NOT EXISTS (SELECT *
FROM sys.schemas
WHERE name = 'PRIVATE')
BEGIN
    EXEC('CREATE SCHEMA [PRIVATE] ');
END
GO

/* -------------------------------------------------------------------------- */
/*                                 create user                                */
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
    /* NOTE scope_identity() may give wrong result when queries run in parrallel
    ref:[1]:https://blog.sqlauthority.com/2009/03/24/sql-server-2008-scope_identity-bug-with-multi-processor-parallel-plan-and-solution/
    [2]:https://stackoverflow.com/questions/42648/sql-server-best-way-to-get-identity-of-inserted-row
    */
    END TRY
    BEGIN CATCH
    
    -- select ERROR_MESSAGE() 'Error Message'
	-- , ERROR_NUMBER() 'Error Number'
	-- , ERROR_LINE () 'Error Line Number'
	-- , ERROR_SEVERITY () 'Error Severity Level'
	-- , ERROR_PROCEDURE() 'Error Procedure'
	-- , ERROR_STATE () 'Error State';
    IF (ERROR_NUMBER() = 2627)
        SELECT "User already exists" as [Error Message];
    ELSE
        SELECT ERROR_NUMBER() 'Error Number', ERROR_MESSAGE() 'Error Message';
    END CATCH
END
GO

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
    END TRY
    BEGIN CATCH
        SELECT "failed to insert student" as [Error Message];
    END CATCH
END
GO


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
        SELECT "failed to insert instructor" as [Error Message];
    END CATCH
END
GO

/* ----------------------- required helping procedure ----------------------- */
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
-- create a department with it's manager
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
/*                                  read user                                 */
/* -------------------------------------------------------------------------- */


/* --------------------------------- student -------------------------------- */
/*
•	Report that returns the students information according to Department No parameter.
*/
CREATE OR ALTER PROCEDURE getAllStudents
AS
BEGIN
    SELECT *
    FROM v_Students;
END
GO

CREATE OR ALTER PROCEDURE getStudentsInDepartment
    @dept_id INTEGER
AS
BEGIN
    SELECT usr_id, f_name,
        l_name,
        address,
        email
    FROM v_Students
    WHERE dept_id = @dept_id;
END
GO

/* ------------------------------- instructor ------------------------------- */
CREATE OR ALTER PROCEDURE getAllInstructors
AS
BEGIN
    SELECT *
    FROM v_Instructors;
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
/*                              update user data                              */
/* -------------------------------------------------------------------------- */
CREATE OR ALTER PROCEDURE updateUserData
    @usr_id INTEGER,
    @f_name varChar(50),
    @l_name varChar(50),
    @address varChar(150),
    @email varChar(90)
AS
BEGIN
    BEGIN TRY
    UPDATE [User]
    SET
        f_name = @f_name,
        l_name = @l_name,
        address = @address,
        email = @email
    WHERE usr_id = @usr_id;
    END TRY
    BEGIN CATCH
        -- TODO send specific error message when email is already in database
        SELECT "failed to update user" as [Error Message];
    END CATCH
END

GO


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
        SELECT "failed to update student" as [Error Message];
    END CATCH
END
GO

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
        SELECT "failed to update instructor" as [Error Message];
    END CATCH
END
GO

/* -------------------------------------------------------------------------- */
/*                        delete student or instructor                        */
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
        SELECT "failed to delete student" as [Error Message];
    END CATCH
END
GO

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
        SELECT "failed to delete instructor" as [Error Message];
    END CATCH
END
GO




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

------------------------------------------------------------------------
GO
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
------------------------------------------------------------------------

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

------------------------------------------------------------------------
GO

create or alter procedure Insert_Course @crs_name varchar(20)
as
if not exists (select @crs_name from [Course] where crs_name = @crs_name)
	insert into [course] values(@crs_name)
else
	select 'This course already exists'

GO
------------------------------------------------------------------------

create or alter procedure Delete_Course @crs_name varchar(20)
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	delete from [Course] where crs_name = @crs_name
else 
	select 'There is no course named ' + @crs_name

------------------------------------------------------------------------
GO

create or alter procedure Insert_Topic @top_name varchar(20), @crs_name varchar(20)
as
declare @id_crs int
if not exists (select top_name from [Topic] where top_name = @top_name)
	begin
		begin try
			select @id_crs = crs_id from [Course] where crs_name = @crs_name
			insert into Topic values (@top_name, @id_crs)
		end try
		begin catch
			select 'There is no course named ' + @crs_name
		end catch
	end
else 
	select 'This Topic already exists'

GO
------------------------------------------------------------------------
create or alter procedure Delete_Topic @top_name varchar(20)
as
if exists (select top_name from [Topic] where top_name = @top_name)
	begin
	begin try
			delete from Topic where top_name = @top_name 
	end try
	begin catch
			select 'Error'
	end catch
	end 
else 
	select 'There is no topic named ' + @top_name
Go
------------------------------------------------------------------------

create or alter procedure Assign_Course_to_Instructor @crs_name varchar(20), @ins_id int
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select @ins_id from [Instructor] where ins_id = @ins_id)
			begin try
				insert into [Ins_Course] (crs_id, ins_id)
				values ((select crs_id from [Course] where crs_name = @crs_name), @ins_id)
			end try
			begin catch
				select 'the Instructor is already assgined to this course'
			end catch
		else
			select 'There is no Instructor ID ' + @ins_id
	end
else 
	select 'There is no Course named ' + @crs_name

Go
------------------------------------------------------------------------

create or alter procedure End_Course_with_Instructor @crs_name varchar(20), @ins_id int
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select ins_id from [Instructor] where ins_id = @ins_id)
			begin
				delete from [Ins_Course] where
				(ins_id = @ins_id and 
				crs_id = (select crs_id from [Course] where crs_name = @crs_name))
			end
		else
			select 'There is no Instructor with this ID'
	end
else 
	select 'There is no Course named ' + @crs_name

--------------------------------------------------------------------------
GO

create or alter procedure Student_Take_course_with_Instructor @std_id int, @crs_id int, @ins_id int
as
if not exists (select ins_id from [Instructor] where ins_id = @ins_id)
and not exists (select std_id from [Student] where std_id = @std_id)
	begin
		if not exists (select crs_id from [Course] where crs_id = @crs_id)
			begin
				if exists (select crs_id, ins_id from [Ins_Course] 
				where (crs_id = @crs_id and ins_id = @ins_id))
				insert into Course_Attendance (crs_id, std_id, ins_id)
				values(@crs_id, @std_id, @ins_id)
				
				else
					select 'This course is not assgined to this instructor'
			end 
		else
			select 'There is no course with this ID'
	end

else
	select 'Please check the Instructor and Student ID'

-----------------------------------------------------------------------
GO

create or alter procedure End_Course_for_Student @crs_name varchar(20), @std_id int
as
if exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if exists (select std_id from [Student] where std_id = @std_id)
			begin
				declare @id_course int
				select @id_course = crs_id from [Course] where crs_name = @crs_name
					if exists (select crs_id, std_id from [Course_Attendance] 
								where (crs_id = @id_course and std_id = @std_id))
						begin
							delete from [Course_Attendance]	
							where (crs_id = @id_course and std_id = @std_id)
						end
					else
						select 'This student does not take this course'
			end
		else
			select 'There is no Course with this ID'
	end
else 
	select 'There is no Course named ' + @crs_name

-----------------------------------------------------------------
-- Report that takes the instructor ID and returns the name of the courses
-- that he teaches and the number of student per course.

GO

create or alter proc Courses_and_Students_of_Instructor @ins_id int
as
if exists (select ins_id from [Instructor] where ins_id = @ins_id)
	begin
		select c.crs_name, count(ca.std_id) as 'number of students per course'  
		from Instructor i
		inner join Ins_Course ic
		on i.ins_id = ic.ins_id
		inner join Course c
		on ic.crs_id = c.crs_id
		inner join Course_Attendance ca
		on c.crs_id = ca.crs_id
		where i.ins_id = @ins_id
		group by c.crs_name
	end
else
	select CONCAT('There is no instructor with this ID ', @ins_id)

GO


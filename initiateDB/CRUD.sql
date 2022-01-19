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
-- TEMP 
-- TODO remove this and replace it with the real procedure
CREATE OR ALTER PROCEDURE [PRIVATE].[Insert_Department]
    @dept_name varChar(100),
    @mgr_id INTEGER,
    @dept_id INTEGER OUTPUT
AS
BEGIN
    INSERT INTO [Department]
    VALUES
        (
            @dept_name,
            @mgr_id
    );
    set @dept_id = scope_identity();
-- TODO handle case if mgr_id is not in the database
END
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
    Exec [PRIVATE].[Insert_Department] @dept_name, @mgr_id, @dept_id OUTPUT;
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
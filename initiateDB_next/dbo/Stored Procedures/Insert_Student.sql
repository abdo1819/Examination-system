/* -------------------------------------------------------------------------- */
/*                              Create Student                                */
/* -------------------------------------------------------------------------- */

-- Student [std_id, dept_id]
/*
user has type 'S' capital S
*/
CREATE PROCEDURE [dbo].[Insert_Student]
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
        SELECT 'failed to insert student' as [Error Message];
    END CATCH
END
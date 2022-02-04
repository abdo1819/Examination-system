/* -------------------------------------------------------------------------- */
/*                              update user data                              */
/* -------------------------------------------------------------------------- */

CREATE PROCEDURE updateUserData
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
        SELECT 'failed to update user' as [Error Message];
    END CATCH
END
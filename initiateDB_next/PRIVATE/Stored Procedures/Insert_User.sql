/* -------------------------------------------------------------------------- */
/*                                 Create User                                */
/* -------------------------------------------------------------------------- */

-- User [usr_id, user_type, f_name, l_name, address, email, password]

CREATE PROCEDURE [PRIVATE].[Insert_User]
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
        SELECT 'User already exists' as [Error Message];
    ELSE
        SELECT ERROR_NUMBER() 'Error Number', ERROR_MESSAGE() 'Error Message';
    END CATCH
END
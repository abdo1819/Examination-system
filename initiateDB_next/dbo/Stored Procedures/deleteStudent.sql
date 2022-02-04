/* -------------------------------------------------------------------------- */
/*                               Delete Student                               */
/* -------------------------------------------------------------------------- */

CREATE PROCEDURE deleteStudent
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
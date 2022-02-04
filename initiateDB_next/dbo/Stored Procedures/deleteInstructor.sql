/* -------------------------------------------------------------------------- */
/*                             Delete Instructor                              */
/* -------------------------------------------------------------------------- */

CREATE PROCEDURE deleteInstructor
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
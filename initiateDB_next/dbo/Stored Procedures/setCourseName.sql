/* ------------------------------------------------------------------------------- */
/*                           Update Course Name                                    */
/* ------------------------------------------------------------------------------- */

CREATE PROCEDURE setCourseName @crs_id INT, @crs_name VARCHAR(50)
AS
BEGIN
    IF EXISTS(SELECT crs_id FROM Course WHERE crs_id = @crs_id)
        BEGIN
            UPDATE [Course]
            SET crs_name = @crs_name
            WHERE crs_id = @crs_id
        END

    ELSE
        SELECT 'Course ID not found' AS [Error Message]
END
/* -------------------------------------------------------------------------- */
/*                              Read Instructor                               */
/* -------------------------------------------------------------------------- */

CREATE PROCEDURE getAllInstructors
AS
BEGIN
    SELECT *
    FROM v_Instructors;
END
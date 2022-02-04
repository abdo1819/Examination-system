/*      -------------------------------------------------------------------------------     */
/*    Report that returns the students information according to Department No parameter     */
/*     -------------------------------------------------------------------------------      */

CREATE PROCEDURE getStudentsInDepartment
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
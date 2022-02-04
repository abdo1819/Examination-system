/* -------------------------------------------------------------------------- */
/*                              Read Department                               */
/* -------------------------------------------------------------------------- */

CREATE PROCEDURE getDepartment
    @dept_id INT
AS
BEGIN
    IF EXISTS (SELECT dept_id FROM Department WHERE dept_id = @dept_id)
        BEGIN
            SELECT D.dept_name, D.mgr_id, U.f_name + ' ' + U.l_name AS [Manager Name]
            FROM Department D, [User] U
            WHERE D.mgr_id = U.usr_id
        END
    ELSE
        SELECT 'Department ID does not exist' AS [Error Message]
END
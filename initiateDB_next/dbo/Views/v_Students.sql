-- Create the view in the specified schema
CREATE VIEW dbo.v_Students
AS
    -- body of the view
    SELECT usr_id,
        f_name,
        l_name,
        address,
        email,
        d.dept_id,
        dept_name
    from [User] u
        INNER JOIN [Student] s ON u.usr_id = s.std_id
        INNER JOIN Department d on s.dept_id = d.dept_id
    WHERE user_type = 'S'
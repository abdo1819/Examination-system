-- Create the view in the specified schema
CREATE VIEW dbo.v_Instructor
AS
    -- body of the view
    SELECT usr_id,
        f_name,
        l_name,
        address,
        email,
        salary,
        degree,
        d.dept_id,
        dept_name
    from [User] u
        INNER JOIN [Instructor] i ON u.usr_id = i.ins_id
        INNER JOIN Department d on i.dept_id = d.dept_id
    WHERE user_type = 'I'
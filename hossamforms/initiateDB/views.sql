USE EXAMINATION;
GO
-- Create a new view called 'v_Students' in schema 'dbo'
-- Drop the view if it already exists
IF EXISTS (
SELECT *
FROM sys.views
    JOIN sys.schemas
    ON sys.views.schema_id = sys.schemas.schema_id
WHERE sys.schemas.name = N'dbo'
    AND sys.views.name = N'v_Students'
)
DROP VIEW dbo.v_Students
GO
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
GO

-- Create a new view called 'v_Instructor' in schema 'dbo'
-- Drop the view if it already exists
IF EXISTS (
SELECT *
    FROM sys.views
    JOIN sys.schemas
    ON sys.views.schema_id = sys.schemas.schema_id
    WHERE sys.schemas.name = N'dbo'
    AND sys.views.name = N'v_Instructor'
)
DROP VIEW dbo.v_Instructor
GO
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
GO
use Examination;
GO
BEGIN TRANSACTION;

    DECLARE @dept_id INTEGER, @mgr_id INTEGER;
    
    EXEC Insert_Department_With_Manager 'Computer Science', 'Mikasa', 'Ackermann', '123 Main St', 'Mikasa@mail.com', 'password', 10500, NULL, @dept_id OUTPUT,@mgr_id OUTPUT;
    select @dept_id, @mgr_id;
    IF (@dept_id IS NOT NULL and @mgr_id IS NOT NULL)
        select 'Insert_Department_With_Manager passed' msg;
    
    declare @ins_id INTEGER;
    EXEC Insert_Instructor 'Daz', 'Daz', '123 Main St', 'Daz@mail.com', 'password', 10500, 'Computer Science', @dept_id, @ins_id;
    select @ins_id;
    IF (@ins_id IS NOT NULL)
        PRINT 'Insert_Instructor passed';

    DECLARE @student_id INTEGER;
    EXEC Insert_Student 'Armin', 'Arlelt', '123 Main St', 'Armin@mail.com', 'password', @dept_id, @student_id;
    select @student_id;
    IF (@student_id IS NOT NULL)
        PRINT 'Insert_Student passed';
COMMIT

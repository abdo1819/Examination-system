use Examination;
GO
BEGIN TRANSACTION;

/* -------------------------------------------------------------------------- */
/*                        create student and instructor                       */
/* -------------------------------------------------------------------------- */

/* ------------- should insert new instructor and deparment ------------ */
DECLARE @test_result TABLE (test_name VARCHAR(100),
    test_result int);
DECLARE @dept_id INTEGER, @mgr_id INTEGER;

EXEC Insert_Department_With_Manager @dept_name = 'Computer Science',
    @f_name =  'Mikasa',
    @l_name =  'Ackermann',
    @address =  '123 Main St',
    @email =  'Mikasa@mail.com',
    @password =  'password',
    @salary =  10500,
    @degree =  NULL,
    @dept_id =  @dept_id OUTPUT,
    @mgr_id = @mgr_id OUTPUT;

-- select @dept_id, @mgr_id;
IF (@dept_id IS NOT NULL and @mgr_id IS NOT NULL)
        insert into @test_result
VALUES('Insert_Department_With_Manager', 1);
    ELSE
        insert into @test_result
VALUES('Insert_Department_With_Manager', 0);

/* ------------ should insert new instructor if department exist ------------ */
declare @ins_id INTEGER;
EXEC Insert_Instructor @f_name = 'Daz',
    @l_name =  'Daz',
    @address =  '123 Main St',
    @email =  'Daz@mail.com',
    @password =  'password',
    @salary =  10500,
    @degree =  'Computer Science',
    @dept_id =  @dept_id,
    @ins_id =  @ins_id OUTPUT;
IF (@ins_id IS NOT NULL)
        insert into @test_result
VALUES('Insert_Instructor', 1);
    ELSE
        insert into @test_result
VALUES('Insert_Instructor', 0);


/* ------------------------ should insert new student ----------------------- */
DECLARE @student_id INTEGER;
EXEC Insert_Student @f_name ='Armin',
    @l_name = 'Arlelt',
    @address = '123 Main St',
    @email = 'Armin@mail.com',
    @password = 'password',
    @dept_id = @dept_id,
    @stu_id = @student_id OUTPUT;
-- select @student_id;
IF (@student_id IS NOT NULL)
    insert into @test_result
VALUES('Insert_Student', 1);
ELSE
        insert into @test_result
VALUES('Insert_Student', 0);

/* -------------------------------------------------------------------------- */
/*                         read student and instructor                        */
/* -------------------------------------------------------------------------- */

-- exec getAllStudents;
-- exec getAllStudents @dept_id = @dept_id;

-- exec getAllInstructors;
-- exec getAllInstructors @dept_id = @dept_id;


/* -------------------------------------------------------------------------- */
/*                        update student or instuctor                        */
/* -------------------------------------------------------------------------- */
-- TODO

/* -------------------------------------------------------------------------- */
/*                        delete student or instructor                        */
/* -------------------------------------------------------------------------- */


SELECT *
from @test_result;
COMMIT

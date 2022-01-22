/* ------------------------------------------------------------------------------- */
/*                                Reporting Procedures		                       */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*               Report that takes std_id returns student grades 			       */
/* ------------------------------------------------------------------------------- */

USE Examination
GO

CREATE OR ALTER PROCEDURE dbo.returnGrades
@std_id INT

AS
BEGIN
	DECLARE @t TABLE
	(
		crs_id INT,
		crs_name VARCHAR(100),
		std_grade INT
	)
    IF EXISTS (SELECT std_id FROM Student WHERE std_id = @std_id)
		BEGIN
			INSERT INTO @t (crs_id, crs_name, std_grade) 
			SELECT CA.crs_id, C.crs_name, CA.grade 
			FROM Course_Attendance CA, Course C
			WHERE CA.crs_id = C.crs_id AND CA.std_id = @std_id
			SELECT * FROM @t
		END
    ELSE
        SELECT 'Student ID does not exist' AS [Error Message]  
END
GO

/* ------------------------------------------------------------------------------- */
/*    Report that takes the instructor ID and returns the name of the courses      */
/*    that he teaches and the number of student per course.                        */
/* ------------------------------------------------------------------------------- */

create or alter proc Courses_and_Students_of_Instructor @ins_id int
as
if exists (select ins_id from [Instructor] where ins_id = @ins_id)
	begin
		select c.crs_name, count(ca.std_id) as 'number of students per course'  
		from Instructor i
		inner join Ins_Course ic
		on i.ins_id = ic.ins_id
		inner join Course c
		on ic.crs_id = c.crs_id
		inner join Course_Attendance ca
		on (c.crs_id = ca.crs_id and ca.ins_id = @ins_id)
		where i.ins_id = @ins_id
		group by c.crs_name
	end
else
	select CONCAT('There is no instructor with this ID ', @ins_id)

GO

/* ------------------------------------------------------------------------------- */
/*   			 Report that takes course ID and returns its topics 	           */
/* ------------------------------------------------------------------------------- */

create or alter procedure Topics_of_Course @crs_name varchar(20)
as
if exists(select crs_name from Course where crs_name = @crs_name)
begin
	select t.top_name
	from Course c
	inner join Topic t
	on c.crs_id = t.crs_id
	where c.crs_name = @crs_name
end
else
	select 'There is no course named ' + @crs_name
GO

/* ------------------------------------------------------------------------------- */
/*    Report that takes exam number and returns the Questions in it and choices	   */
/* ------------------------------------------------------------------------------- */

-- Fathy Comment: It is mentioned it should be a "Freeform report", refer to this link
-- https://www2.microstrategy.com/producthelp/current/ReportDesigner/WebHelp/Lang_1033/Content/creating_a_freeform_sql_report.htm#:~:text=Unlike%20standard%20reports%20which%20can,returned%20by%20your%20SQL%20statement.

create or alter procedure Get_Questions_in_Exam @ex_id int
as
if exists(select ex_id from Exam where ex_id = @ex_id)
begin
	select q.q_text, q.q_type, mcq.ch_a, mcq.ch_b, mcq.ch_c, mcq.ch_d
	from Exam e
	inner join Exam_Question eq
	on e.ex_id = eq.ex_id
	inner join Question q
	on eq.q_id = q.q_id
	left join MCQ mcq
	on q.q_id = mcq.q_id
	where e.ex_id = @ex_id
end
else
	select 'Wrong Exam ID'
GO

/*      -------------------------------------------------------------------------------     */
/*    Report that returns the students information according to Department No parameter     */
/*     -------------------------------------------------------------------------------      */

CREATE OR ALTER PROCEDURE getStudentsInDepartment
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
GO


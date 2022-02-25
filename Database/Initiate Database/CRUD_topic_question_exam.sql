/* -------------------------------------------------------------------------- */
/*                        CRUDS for topic, question, exam                     */
/* -------------------------------------------------------------------------- */

-- Fathy comment: Should we double check which procedures should go in [PRIVATE] schema?
-- Link for using a function in check constraint (could be needed for take exam procedure later)
-- https://stackoverflow.com/questions/26693571/custom-function-with-check-constraint-sql-server-2008/26694344

USE Examination;
GO

/* ------------------------------------------------------------------------------- */
/*                                  Course CRUDs                                   */
/* ------------------------------------------------------------------------------- */

/* -------------------------------------------------------------------------- */
/*                               get all courses                              */
/* -------------------------------------------------------------------------- */


CREATE OR ALTER PROCEDURE [dbo].[getAllCourses]
AS
BEGIN
	SELECT * FROM [dbo].[Course];
END
GO

/* ------------------------------------------------------------------------------- */
/*                               Insert Course                                     */
/* ------------------------------------------------------------------------------- */

create or alter procedure Insert_Course @crs_name varchar(20)
as
BEGIN
if not exists (select @crs_name from [Course] where crs_name = @crs_name)
	insert into [course] values(@crs_name)
else
	RETURN 0;

RETURN 1;
END
GO

/* ------------------------------------------------------------------------------- */
/*                           Update Course Name                                    */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROCEDURE setCourseName @crs_id INT, @crs_name VARCHAR(50)
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
GO
/* ------------------------------------------------------------------------------- */
/*                                Delete Course                                    */
/* ------------------------------------------------------------------------------- */

create or alter procedure Delete_Course @crs_name varchar(20)
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	delete from [Course] where crs_name = @crs_name
else 
	select 'There is no course named ' + @crs_name
GO

/* ------------------------------------------------------------------------------- */
/*                                  Topic CRUDs                                    */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                                  Insert Topic                                   */
/* ------------------------------------------------------------------------------- */

create or alter procedure Insert_Topic @top_name varchar(20), @crs_name varchar(20)
as
BEGIN
declare @id_crs int
if not exists (select top_name from [Topic] where top_name = @top_name)
	begin
		begin try
			select @id_crs = crs_id from [Course] where crs_name = @crs_name
			insert into Topic values (@top_name, @id_crs)
		end try
		begin catch
			RETURN 0;
		end catch
	end
else 
	RETURN 0;
RETURN 1;
END

GO

/* ------------------------------------------------------------------------------- */
/*                                 Update Topic Name                               */
/* ------------------------------------------------------------------------------- */


CREATE OR ALTER PROCEDURE setTopicName @top_id INT, @top_name VARCHAR(50)
AS
BEGIN
    IF EXISTS(SELECT top_id FROM Topic WHERE top_id = @top_id)
        BEGIN
            UPDATE [Topic]
            SET top_name = @top_name
            WHERE top_id = @top_id
        END

    ELSE
        SELECT 'Topic ID not found' AS [Error Message]
END
GO

/* ------------------------------------------------------------------------------- */
/*                                   Delete Topic                                  */
/* ------------------------------------------------------------------------------- */

create or alter procedure Delete_Topic @top_name varchar(20)
as
if exists (select top_name from [Topic] where top_name = @top_name)
	begin
	begin try
			delete from Topic where top_name = @top_name 
	end try
	begin catch
			select 'Error'
	end catch
	end 
else 
	select 'There is no topic named ' + @top_name
Go

/* ------------------------------------------------------------------------------- */
/*                    Course, Instructor CRUDs (Ins_Course table)                  */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                           Assign Instructor to Course                           */
/* ------------------------------------------------------------------------------- */

create or alter procedure Assign_Course_to_Instructor @crs_name varchar(20), @ins_id int
as
if exists (select crs_name from [Course] where crs_name = @crs_name)
	begin
		if exists (select @ins_id from [Instructor] where ins_id = @ins_id)
			begin try
				insert into [Ins_Course] (crs_id, ins_id)
				values ((select crs_id from [Course] where crs_name = @crs_name), @ins_id)
			end try
			begin catch
				select 'the Instructor is already assgined to this course'
			end catch
		else
			select 'There is no Instructor ID ' + @ins_id
	end
else 
	select 'There is no Course named ' + @crs_name

Go

/* ------------------------------------------------------------------------------- */
/*                           End Course with Instructor                            */
/* ------------------------------------------------------------------------------- */

create or alter procedure End_Course_with_Instructor @crs_name varchar(20), @ins_id int
as
if not exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if not exists (select ins_id from [Instructor] where ins_id = @ins_id)
			begin
				delete from [Ins_Course] where
				(ins_id = @ins_id and 
				crs_id = (select crs_id from [Course] where crs_name = @crs_name))
			end
		else
			select 'There is no Instructor with this ID'
	end
else 
	select 'There is no Course named ' + @crs_name
GO

/* ------------------------------------------------------------------------------- */
/*            Student, Course, Instructor CRUDs (Course_Attendance table)          */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                      Student Take Course with Instructor                        */
/* ------------------------------------------------------------------------------- */

create or alter procedure Student_Take_course_with_Instructor @std_id int, @crs_id int, @ins_id int
as 
BEGIN TRY
if exists (select ins_id from [Instructor] where ins_id = @ins_id) 
and exists (select std_id from [Student] where std_id = @std_id)
	begin
		if exists (select crs_id from [Course] where crs_id = @crs_id)
			begin
				if exists (select crs_id, ins_id from [Ins_Course] 
				where (crs_id = @crs_id and ins_id = @ins_id))
				insert into Course_Attendance (crs_id, std_id, ins_id)
				values(@crs_id, @std_id, @ins_id)
				
				else
					RETURN 0;
			end 
		else
			RETURN 0;
	end

else
	RETURN 0;
END TRY
BEGIN CATCH
	RETURN 0;
END CATCH
RETURN 1;
GO

/* ------------------------------------------------------------------------------- */
/*                               End Course for Student                            */
/* ------------------------------------------------------------------------------- */

create or alter procedure End_Course_for_Student @crs_name varchar(20), @std_id int
as
BEGIN
if exists (select crs_name from [course] where crs_name = @crs_name)
	begin
		if exists (select std_id from [Student] where std_id = @std_id)
			begin
				declare @id_course int
				select @id_course = crs_id from [Course] where crs_name = @crs_name
					if exists (select crs_id, std_id from [Course_Attendance] 
								where (crs_id = @id_course and std_id = @std_id))
						begin
							delete from [Course_Attendance]	
							where (crs_id = @id_course and std_id = @std_id)
						end
					else
						RETURN 0;
			end
		else
			RETURN 0;
	end
else 
	RETURN 0;

	RETURN 1;
	END
GO

/* ------------------------------------------------------------------------------- */
/*                         Question Table CRUDs                                    */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                              Insert Question                                    */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC [PRIVATE].insertQuestion
		@top_id int, 
		@q_type varchar(3), 
		@q_text varchar(300), 
		@corr_answer varchar(1),
		@q_id int output
AS
BEGIN
	IF NOT EXISTS( SELECT top_id FROM Topic WHERE top_id = @top_id)
		SELECT 'Make sure topic already exists'
	ELSE
		BEGIN
			BEGIN TRY
				INSERT INTO Question(q_type, q_text, corr_answer, top_id)
					VALUES(@q_type, @q_text, @corr_answer, @top_id)
				SELECT @q_id = SCOPE_IDENTITY();
			END TRY
			BEGIN CATCH
				SELECT 'Make sure you entered the data correctly'
			END CATCH
		END
END

GO

/* ------------------------------------------------------------------------------- */
/*                              MCQ Question                                       */
/* ------------------------------------------------------------------------------- */

-- MCQ [q_id, ch_a, ch_b, ch_c, ch_d]
CREATE OR ALTER PROC insertMCQ
		@top_id int, 
		@q_text varchar(300), 
		@ch_a varchar(300), 
		@ch_b varchar(300), 
		@ch_c varchar(300),
		@ch_d varchar(300), 
		@corr_answer varchar(1),
		@q_id int output
AS
BEGIN
	IF NOT EXISTS( SELECT top_id FROM Topic WHERE top_id = @top_id)
		SELECT 'Make sure topic already exists'
	ELSE
		BEGIN
			BEGIN TRY
				EXECUTE [PRIVATE].insertQuestion @top_id, 'MCQ', @q_text, @corr_answer, @q_id output
				INSERT INTO MCQ (q_id, ch_a, ch_b, ch_c, ch_d)
					VALUES(@q_id, @ch_a, @ch_b, @ch_c, @ch_d)
			END TRY
			BEGIN CATCH
				select 'Make sure you entered the data correctly'
			END CATCH 
		END
END
GO

/* ------------------------------------------------------------------------------- */
/*                        True or False Question                                   */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC insertTFQ 
		@top_id int, 
		@q_text varchar(300), 
		@corr_answer varchar(1),
		@q_id int output
AS
BEGIN
	IF NOT EXISTS( SELECT top_id FROM Topic WHERE top_id = @top_id)
		SELECT 'Make sure topic already exists'
	ELSE
		BEGIN
			BEGIN TRY
				EXECUTE [PRIVATE].insertQuestion @top_id, 'TF', @q_text, @corr_answer, @q_id output
			END TRY
			BEGIN CATCH 
				SELECT 'Make sure data is correct'
			END CATCH
		END
END

GO

/* ------------------------------------------------------------------------------- */
/*                              Update Question                                    */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                                 Update MCQ                                      */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC updateMCQ
		@q_id int,
		@top_id int, 
		@q_text varchar(300), 
		@ch_a varchar(300), 
		@ch_b varchar(300), 
		@ch_c varchar(300),
		@ch_d varchar(300), 
		@corr_answer varchar(1)
AS
BEGIN
-- Check for question existence 
	IF NOT EXISTS( SELECT q_id FROM Question where q_id = @q_id)
		SELECT 'Question does not exist'
	ELSE
		BEGIN
			IF NOT EXISTS( SELECT top_id FROM Topic WHERE top_id = @top_id)
				SELECT 'Make sure topic already exists'
			ELSE
				BEGIN
					BEGIN TRY
					BEGIN TRANSACTION
						UPDATE Question
						SET
							top_id = @top_id,
							q_text = @q_text,
							corr_answer = @corr_answer
						WHERE q_id = @q_id;
						-------------------
						UPDATE MCQ
						SET
							ch_a = @ch_a, 
							ch_b = @ch_b, 
							ch_c = @ch_c, 
							ch_d = @ch_d
						WHERE q_id = @q_id
					COMMIT
					END TRY
					BEGIN CATCH
						select 'Make sure you entered the data correctly'
						ROLLBACK;
					END CATCH 
				END
		END
END
GO

/* ------------------------------------------------------------------------------- */
/*                             Update True/False                                   */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC updateTFQ
		@q_id int,
		@top_id int, 
		@q_text varchar(300), 
		@corr_answer varchar(1)
AS
BEGIN
IF NOT EXISTS(SELECT q_id FROM Question where q_id = @q_id)
	SELECT 'Question does not exist'
ELSE
BEGIN
		IF NOT EXISTS( SELECT top_id FROM Topic WHERE top_id = @top_id)
		SELECT 'Make sure topic already exists'
	ELSE
		BEGIN
			BEGIN TRY
				UPDATE Question
				SET
					top_id = @top_id,
					q_text = @q_text,
					corr_answer = @corr_answer
				WHERE q_id = @q_id;
			END TRY
			BEGIN CATCH
				select 'Make sure you entered the data correctly'
			END CATCH 
		END
END
END
GO

/* ------------------------------------------------------------------------------- */
/*                               Delete Question                                   */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC deleteQuestion @q_id int
AS
BEGIN 
	IF EXISTS (select q_id from MCQ where q_id = @q_id)
	BEGIN
		BEGIN TRY
			DELETE FROM MCQ 
			WHERE q_id = @q_id
			---------------------
			DELETE FROM Question
			WHERE q_id = @q_id
		END TRY
		BEGIN CATCH
			select 'This MCQ has been answered in an exam before'
		END CATCH
	END
	ELSE
	BEGIN
		BEGIN TRY
			DELETE FROM Question
			WHERE q_id = @q_id
		END TRY
		BEGIN CATCH
			select 'This TFQ has been answered in an exam before'
		END CATCH
	END
END
GO

/* ------------------------------------------------------------------------------- */
/*                               Read Question                                     */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                    Display MCQ Question for a certain topic                     */
/* ------------------------------------------------------------------------------- */

-- Fathy Comment : Is this procedure a report? Should it instead be reading question data using question id?

CREATE OR ALTER PROC viewTopicMCQ @top_name varchar(200)
AS
BEGIN
	IF NOT EXISTS(select top_id from Topic where top_name = @top_name)
		RETURN 0;
	ELSE
	BEGIN
		Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		m.ch_a AS [Choice a], 
		m.ch_b AS [Choice b], 
		m.ch_c AS [Choice c], 
		m.ch_d AS [Choice d], 
		q.corr_answer AS [Correct Answer]
		from Question q, MCQ m, Topic t, Course c
		where q.q_id = m.q_id and t.top_id = q.top_id and c.crs_id = t.crs_id and t.top_name = @top_name
		RETURN 1;
	END
END
GO

/* ------------------------------------------------------------------------------- */
/*                 Display True/False Question for a certain topic                 */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC viewTopicTFQ @top_name varchar(200)
AS
BEGIN
	IF NOT EXISTS(select top_id from Topic where top_name = @top_name)
		RETURN 0;
	ELSE
	BEGIN
		Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		q.corr_answer AS [Correct Answer]
		from Question q, Topic t, Course c
		where t.top_id = q.top_id and c.crs_id = t.crs_id and t.top_name = @top_name and q.q_type = 'TF';
		RETURN 1;
	END
END
GO

/* ------------------------------------------------------------------------------- */
/*                 Display MCQ Question for a certain Course                       */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC viewCourseMCQ @crs_name varchar(100)
AS
BEGIN
	IF NOT EXISTS(select crs_id from Course where crs_name = @crs_name)
		SELECT 'Course not found'
	ELSE
	BEGIN
		Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		m.ch_a AS [Choice a], 
		m.ch_b AS [Choice b], 
		m.ch_c AS [Choice c], 
		m.ch_d AS [Choice d], 
		q.corr_answer AS [Correct Answer]
		from Question q, MCQ m, Topic t, Course c
		where q.q_id = m.q_id and t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = @crs_name;
	END
END
GO

/* ------------------------------------------------------------------------------- */
/*                 Display True/False Question for a certain Course                */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC viewCourseTFQ @crs_name varchar(100)
AS
BEGIN
	IF NOT EXISTS(select crs_id from Course where crs_name = @crs_name)
		SELECT 'Course not found'
	ELSE
	BEGIN
		Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		q.corr_answer AS [Correct Answer]
		from Question q, Topic t, Course c
		where t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = @crs_name and q.q_type = 'TF';
	END
END
GO

/* ------------------------------------------------------------------------------- */
/*                 Display MCQ with choices and correct answer                     */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC viewMCQ
AS
BEGIN
	Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		m.ch_a AS [Choice a], 
		m.ch_b AS [Choice b], 
		m.ch_c AS [Choice c], 
		m.ch_d AS [Choice d], 
		q.corr_answer AS [Correct Answer]
	from Question q, MCQ m, Topic t, Course c
	where q.q_id = m.q_id and t.top_id = q.top_id and c.crs_id = t.crs_id
END
GO

/* ------------------------------------------------------------------------------- */
/*                 Display True/False with choices and correct answer              */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC viewTFQ
AS
BEGIN
	Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		q.corr_answer AS [Correct Answer]
	From Question q, Topic t, Course c
	Where q_type = 'TF'
END
GO

/* ------------------------------------------------------------------------------- */
/*                                  Exam table CRUDs                               */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                           Generate Exam for a specific course                   */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC getAllExams 
AS
	SELECT * from Exam;
GO

CREATE OR ALTER PROC generateExam @crs_name varchar(100), @std_id int, @ex_id int output
AS
BEGIN
	IF NOT EXISTS(SELECT crs_name FROM Course WHERE crs_name = @crs_name) OR NOT EXISTS (Select std_id from Student WHERE std_id = @std_id)
		SELECT 'Course or Student not found'
	ELSE
		BEGIN
		-- Get course ID
			DECLARE @crs_id int;
			SELECT @crs_id = crs_id FROM Course Where crs_name = @crs_name
		IF NOT EXISTS (Select std_id from Course_Attendance WHERE std_id = @std_id AND crs_id = @crs_id)
			SELECT 'Student not enrolled in this course'
		ELSE
			BEGIN
				-- Create exam instance and get the exam ID
				INSERT INTO Exam(date, crs_id)
					VALUES(GETDATE(), @crs_id)
				SELECT @ex_id = SCOPE_IDENTITY()

				-- Create Cursor for row by row insertion in other tables
				DECLARE C1 Cursor
				-- Statement will return 10 random questions IDs for specified course
				-- with this assumption in mind ( 3 TF & 7 MCQ )
				FOR SELECT *
						FROM (SELECT top(3)q.q_id
								FROM Question q, Topic t, Course c
								WHERE q_type ='TF'
									AND q.top_id = t.top_id
									AND c.crs_id = t.crs_id
									AND c.crs_name = @crs_name
								ORDER BY NEWID()) TF
						UNION ALL
						SELECT *
						FROM (
								SELECT top(7)q.q_id
								FROM Question q, Topic t, Course c
								WHERE q_type ='MCQ'
									AND q.top_id = t.top_id
									AND c.crs_id = t.crs_id
									AND c.crs_name = @crs_name
								ORDER BY NEWID()) M
				FOR read only
				DECLARE @q_id int
				OPEN C1
				FETCH C1 INTO @q_id

				WHILE @@FETCH_STATUS = 0
				BEGIN
					-- INSERT the q_id in tables Exam_Answer & Exam_Question
					INSERT INTO Exam_Question (ex_id, q_id)
						VALUES (@ex_id, @q_id)
						-- NOTE: @ex_id is a fixed value and doesn't change with the cursor

					INSERT INTO Exam_Answer( std_id, ex_id, q_id)
						VALUES(@std_id, @ex_id, @q_id)
						-- NOTE: @ex_id and @std_id are fixed values and don't change with the cursor

					FETCH C1 INTO @q_id
				END
				CLOSE C1
				DEALLOCATE C1
			END

		END
END
GO
-- TODO : Handle Student/Course enrollement

/* -------------------------------------------------------------------------- */
/*                               view exam by id                              */
/* -------------------------------------------------------------------------- */


CREATE OR ALTER Proc getAllExamsInfo
AS
select e.ex_id , c.crs_name, s.dept_name
from Exam e
	inner join course c
	on c.crs_id = e.crs_id
	inner join Exam_Answer ea
	on e.ex_id = ea.ex_id
	inner join v_Students s
	on s.usr_id = ea.std_id
GO



CREATE OR ALTER PROC getExamInfo @ex_id int
AS
BEGIN
select e.ex_id , c.crs_name, s.dept_name
from Exam e
	inner join course c
	on c.crs_id = e.crs_id
	inner join Exam_Answer ea
	on e.ex_id = ea.ex_id
	inner join v_Students s
	on s.usr_id = ea.std_id
where @ex_id = e.ex_id
end
GO
/* ------------------------------------------------------------------------------- */
/*                                       Delete Exam                               */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC deleteExam @ex_id int
AS
BEGIN
	IF NOT EXISTS(select ex_id from Exam where ex_id = @ex_id)
		SELECT 'Exam not found'
	ELSE
		BEGIN
			BEGIN TRY
			BEGIN TRANSACTION -- Fathy Comment: Should we adjust other update procedures to include transaction as well? Because If update fails, identity values get messed up
				-- Get the corresponding student and course and delete the grades of that student
				DECLARE @std_id int, @crs_id int
				SELECT @std_id = std_id from Exam_Answer WHERE ex_id = @ex_id 
				SELECT @crs_id = crs_id from Exam WHERE ex_id = @ex_id
						
				-- Delete the Exam Answers
				DELETE FROM Exam_Answer
				WHERE ex_id = @ex_id

				-- Delete the Exam Questions
				DELETE FROM Exam_Question
				WHERE ex_id = @ex_id

				-- Delete the Exam itself
				DELETE FROM Exam
				WHERE ex_id = @ex_id
			COMMIT
			END TRY
			BEGIN CATCH
				SELECT 'Failed to delete the exam'
				ROLLBACK;
			END CATCH
		END
END
GO
/* ------------------------------------------------------------------------------- */
/*                                Get All Exam Answers                             */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC GetAllExamAnswers
AS
BEGIN
SELECT * FROM Exam_Answer
END
RETURN
go
/* ------------------------------------------------------------------------------- */
/*                           Display Exam without Answers                          */
/* ------------------------------------------------------------------------------- */

CREATE OR ALTER PROC viewExamQuestions @ex_id int
AS
BEGIN
	IF NOT EXISTS(select ex_id from Exam where ex_id = @ex_id)
		SELECT 'Exam not found'
	ELSE
		BEGIN
			SELECT e.ex_id, q.q_id, q.q_text, q.q_type
			FROM Exam e, Question q, Exam_Question eq
			WHERE e.ex_id = eq.ex_id 
				AND q.q_id = eq.q_id 
				AND q.q_type='TF'
				AND e.ex_id = @ex_id
			
			SELECT e.ex_id, q.q_id, q.q_text, q.q_type, M.ch_a, M.ch_b, M.ch_c, M.ch_d
			FROM Exam e, Question q, Exam_Question eq, MCQ M
			WHERE e.ex_id = eq.ex_id
				AND q.q_id = eq.q_id 
				AND M.q_id = q.q_id 
				AND q.q_type='MCQ' 
				AND e.ex_id = @ex_id
		END
END
GO

CREATE OR ALTER PROC answerExamQuestion @ex_id int, @q_id int, @std_answer varchar(1)
AS 
BEGIN
	Update Exam_Answer
	SET std_answer = @std_answer
	WHERE q_id = @q_id AND ex_id = @ex_id
END
GO

CREATE OR ALTER PROC getAvailableCoursesForExam @std_id int
AS
	BEGIN
		select c.crs_name
		from Course c, Course_Attendance ca, Student s
		where c.crs_id = ca.crs_id and ca.std_id = s.std_id and s.std_id = @std_id AND ca.grade IS NULL
	END
go

CREATE OR ALTER PROC answerExamQuestionV2 @std_id int, @ex_id int, @q_id int, @answer varchar(1)
AS
BEGIN
	IF NOT EXISTS(select ex_id from Exam where ex_id = @ex_id)
		SELECT 'Exam not found'
	ELSE
		BEGIN
			IF NOT EXISTS(select q_id from Question where q_id = @q_id)
				SELECT 'Question not found'
			ELSE
				BEGIN
					IF NOT EXISTS(select std_id from Exam_Answer where std_id = @std_id AND ex_id = @ex_id AND q_id = @q_id)
						SELECT 'exam is not generated for student yet'
					ELSE
						BEGIN
							BEGIN TRY
							BEGIN TRANSACTION 
								UPDATE Exam_Answer
								SET std_answer = @answer
								WHERE std_id = @std_id AND ex_id = @ex_id AND q_id = @q_id
							COMMIT
							END TRY
							BEGIN CATCH
								SELECT 'Failed to answer the question'
								ROLLBACK;
							END CATCH
						END
				END
		END
END
GO


CREATE OR ALTER PROCEDURE answerExam @std_id int, @ex_id int, @answer1 varchar(1), 
						@answer2 varchar(1), @answer3 varchar(1),@answer4 varchar(1),
						 @answer5 varchar(1),@answer6 varchar(1), @answer7 varchar(1),
						  @answer8 varchar(1), @answer9 varchar(1),@answer10 varchar(1)
AS
BEGIN
	IF NOT EXISTS(select ex_id from Exam where ex_id = @ex_id)
		SELECT 'Exam not found'
	ELSE
		BEGIN
			IF NOT EXISTS(select std_id from Exam_Answer where std_id = @std_id AND ex_id = @ex_id)
				SELECT 'exam is not generated for student yet'
			ELSE
				BEGIN
					-- select the question ids from the exam_question table using cursor
					declare q_id_cursor cursor for 
					select eq.q_id
					from Exam e
					inner join Exam_Question eq
					on e.ex_id = eq.ex_id
					where e.ex_id = @ex_id;

					-- add the answers to temp table and for answer cursor
					DECLARE @answers_table TABLE (answer varchar(1))
					INSERT INTO @answers_table values 
								(@answer1), (@answer2), (@answer3),
								(@answer4), (@answer5), (@answer6),
								(@answer7), (@answer8), (@answer9), (@answer10);
					
					DECLARE answers_cursor CURSOR FOR
						SELECT answer
						FROM @answers_table

					declare @q_counter int = 0;

					-- update the answers
					OPEN answers_cursor
					OPEN q_id_cursor
					declare @q_id int
					declare @answer varchar(1)
					FETCH NEXT FROM q_id_cursor INTO @q_id
					WHILE @@FETCH_STATUS = 0 and @q_counter < 10
					BEGIN
						FETCH NEXT FROM answers_cursor INTO @answer
						UPDATE Exam_Answer
						SET std_answer = @answer
						WHERE ex_id = @ex_id AND std_id = @std_id AND q_id = @q_id
						FETCH NEXT FROM q_id_cursor INTO @q_id
						select @q_counter = @q_counter + 1;
					END
					CLOSE q_id_cursor
					CLOSE answers_cursor
					DEALLOCATE q_id_cursor
					DEALLOCATE answers_cursor
					
				END
		END
END
GO
CREATE OR ALTER PROC getQuestionAndStudentAnswer @ex_id int
AS 
BEGIN
	select ea.*, c.crs_name, t.top_name
	from Exam_Answer ea, Course c, Topic t, Question q, Exam e
	where ea.ex_id = @ex_id AND ea.q_id = q.q_id AND t.top_id = q.top_id AND e.crs_id = c.crs_id AND t.crs_id = c.crs_id AND e.ex_id = @ex_id
END

go

CREATE OR ALTER FUNCTION getStudentsWhoSolvedExams ()
RETURNS TABLE 
RETURN
	SELECT distinct s.usr_id , f_name, l_name ,dept_id,dept_name from exam_answer ea
	inner JOIN v_Students s
	on ea.std_id = s.usr_id
	where std_answer is not null
GO

CREATE OR ALTER FUNCTION getSolvedExamsForStudents (@std_id int)
RETURNS TABLE
RETURN
	SELECT distinct ex_id from exam_answer where std_id = @std_id
GO

create OR ALTER   PROC [dbo].[getAvailableCoursesForExam] @std_id int
AS
    BEGIN
        select c.crs_name
        from Course c, Course_Attendance ca, Student s
        where c.crs_id = ca.crs_id and ca.std_id = s.std_id and s.std_id = @std_id
        EXCEPT
		select c.crs_name
		from Course c
		INNER JOIN Course_Attendance ca
		ON c.crs_id = ca.crs_id
		INNER JOIN Student s
		ON ca.std_id = s.std_id
		INNER JOIN Exam e
		ON c.crs_id = e.crs_id 
		and e.ex_id in (select ex_id from getSolvedExamsForStudents(@std_id))
		where s.std_id = @std_id
	END
	
GO
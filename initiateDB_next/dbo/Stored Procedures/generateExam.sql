/* ------------------------------------------------------------------------------- */
/*                                  Exam table CRUDs                               */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                           Generate Exam for a specific course                   */
/* ------------------------------------------------------------------------------- */

CREATE PROC generateExam @crs_name varchar(100), @std_id int, @ex_id int output
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
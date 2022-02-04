-- TODO : Handle Student/Course enrollement

/* ------------------------------------------------------------------------------- */
/*                                       Delete Exam                               */
/* ------------------------------------------------------------------------------- */

CREATE PROC deleteExam @ex_id int
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
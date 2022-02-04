/* ------------------------------------------------------------------------------- */
/*                               Delete Question                                   */
/* ------------------------------------------------------------------------------- */

CREATE PROC deleteQuestion @q_id int
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
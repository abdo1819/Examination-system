/* ------------------------------------------------------------------------------- */
/*                             Update True/False                                   */
/* ------------------------------------------------------------------------------- */

CREATE PROC updateTFQ
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
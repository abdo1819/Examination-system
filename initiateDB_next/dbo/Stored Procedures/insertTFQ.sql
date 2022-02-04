/* ------------------------------------------------------------------------------- */
/*                        True or False Question                                   */
/* ------------------------------------------------------------------------------- */

CREATE PROC insertTFQ 
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
/* ------------------------------------------------------------------------------- */
/*                              MCQ Question                                       */
/* ------------------------------------------------------------------------------- */

-- MCQ [q_id, ch_a, ch_b, ch_c, ch_d]
CREATE PROC insertMCQ
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
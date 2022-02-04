/* ------------------------------------------------------------------------------- */
/*                         Question Table CRUDs                                    */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                              Insert Question                                    */
/* ------------------------------------------------------------------------------- */

CREATE PROC [PRIVATE].insertQuestion
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
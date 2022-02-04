/* ------------------------------------------------------------------------------- */
/*                              Update Question                                    */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                                 Update MCQ                                      */
/* ------------------------------------------------------------------------------- */

CREATE PROC updateMCQ
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
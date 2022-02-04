/* ------------------------------------------------------------------------------- */
/*                           Display Exam without Answers                          */
/* ------------------------------------------------------------------------------- */

CREATE PROC viewExamQuestions @ex_id int
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
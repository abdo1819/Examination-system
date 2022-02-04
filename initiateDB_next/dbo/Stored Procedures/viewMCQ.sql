/* ------------------------------------------------------------------------------- */
/*                 Display MCQ with choices and correct answer                     */
/* ------------------------------------------------------------------------------- */

CREATE PROC viewMCQ
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
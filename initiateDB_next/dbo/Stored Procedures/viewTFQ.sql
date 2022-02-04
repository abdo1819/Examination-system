/* ------------------------------------------------------------------------------- */
/*                 Display True/False with choices and correct answer              */
/* ------------------------------------------------------------------------------- */

CREATE PROC viewTFQ
AS
BEGIN
	Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		q.corr_answer AS [Correct Answer]
	From Question q, Topic t, Course c
	Where q_type = 'TF'
END
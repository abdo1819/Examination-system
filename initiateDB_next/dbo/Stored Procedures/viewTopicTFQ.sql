/* ------------------------------------------------------------------------------- */
/*                 Display True/False Question for a certain topic                 */
/* ------------------------------------------------------------------------------- */

CREATE PROC viewTopicTFQ @top_name varchar(200)
AS
BEGIN
	IF NOT EXISTS(select top_id from Topic where top_name = @top_name)
		SELECT 'Topic not found'
	ELSE
	BEGIN
		Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		q.corr_answer AS [Correct Answer]
		from Question q, Topic t, Course c
		where t.top_id = q.top_id and c.crs_id = t.crs_id and t.top_name = @top_name and q.q_type = 'TF';
	END
END
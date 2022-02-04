/* ------------------------------------------------------------------------------- */
/*                 Display True/False Question for a certain Course                */
/* ------------------------------------------------------------------------------- */

CREATE PROC viewCourseTFQ @crs_name varchar(100)
AS
BEGIN
	IF NOT EXISTS(select crs_id from Course where crs_name = @crs_name)
		SELECT 'Course not found'
	ELSE
	BEGIN
		Select q.q_id AS QID,
		c.crs_name AS [Course],
		T.top_name AS [Topic], 
		q.q_text AS [Question], 
		q.corr_answer AS [Correct Answer]
		from Question q, Topic t, Course c
		where t.top_id = q.top_id and c.crs_id = t.crs_id and c.crs_name = @crs_name and q.q_type = 'TF';
	END
END
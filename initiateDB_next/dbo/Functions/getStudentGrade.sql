CREATE  FUNCTION getStudentGrade(@crs_id INT, @std_id INT)
RETURNS INT
AS
BEGIN
	DECLARE @result INT
	SELECT @result = 
	(
		SELECT SUM(EA.std_mark) 
		FROM Exam_Answer EA, Exam E 
		WHERE EA.ex_id = E.ex_id AND E.crs_id = @crs_id AND EA.std_id = @std_id 
	)
		RETURN @result
END
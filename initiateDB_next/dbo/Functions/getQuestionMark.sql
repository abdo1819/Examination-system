CREATE  FUNCTION getQuestionMark(@q_id INT)
RETURNS INT
AS
BEGIN
DECLARE @result INT, @corr_answer VARCHAR(1), @std_answer VARCHAR(1)
	SELECT @corr_answer = (SELECT corr_answer FROM Question WHERE q_id = @q_id)
	SELECT @std_answer = (SELECT std_answer FROM Exam_Answer WHERE q_id = @q_id)
	IF (@corr_answer = @std_answer)
		SET @result = 1
	ELSE
		SET @result = 0

	RETURN @result
END
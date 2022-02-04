CREATE PROCEDURE dbo.returnGrades
@std_id INT

AS
BEGIN
	DECLARE @t TABLE
	(
		crs_id INT,
		crs_name VARCHAR(100),
		std_grade INT
	)
    IF EXISTS (SELECT std_id FROM Student WHERE std_id = @std_id)
		BEGIN
			INSERT INTO @t (crs_id, crs_name, std_grade) 
			SELECT CA.crs_id, C.crs_name, CA.grade 
			FROM Course_Attendance CA, Course C
			WHERE CA.crs_id = C.crs_id AND CA.std_id = @std_id
			SELECT * FROM @t
		END
    ELSE
        SELECT 'Student ID does not exist' AS [Error Message]  
END
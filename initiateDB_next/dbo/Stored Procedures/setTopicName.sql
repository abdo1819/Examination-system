/* ------------------------------------------------------------------------------- */
/*                                 Update Topic Name                               */
/* ------------------------------------------------------------------------------- */


CREATE PROCEDURE setTopicName @top_id INT, @top_name VARCHAR(50)
AS
BEGIN
    IF EXISTS(SELECT top_id FROM Topic WHERE top_id = @top_id)
        BEGIN
            UPDATE [Topic]
            SET top_name = @top_name
            WHERE top_id = @top_id
        END

    ELSE
        SELECT 'Topic ID not found' AS [Error Message]
END
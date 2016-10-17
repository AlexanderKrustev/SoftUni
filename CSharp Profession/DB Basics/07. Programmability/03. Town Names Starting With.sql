CREATE PROCEDURE usp_GetTownsStartingWith(@InputSTR VARCHAR(MAX))
AS
BEGIN
     DECLARE @Pattern VARCHAR(MAX)
	 SET @Pattern = CONCAT(@InputSTR,'%')
	 SELECT t.Name FROM [dbo].[Towns] AS t
	 WHERE t.Name LIKE @Pattern
END

EXEC usp_GetTownsStartingWith 'b'
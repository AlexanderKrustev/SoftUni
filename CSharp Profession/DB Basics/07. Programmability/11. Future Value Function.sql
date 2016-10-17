ALTER FUNCTION ufn_CalculateFutureValue(@i DECIMAL(19,8), @r DECIMAL(19,8),@T INT)
RETURNS decimal (19,4)
AS
BEGIN
     DECLARE @Result decimal (19,4)
	 DECLARE @POWERr decimal (19,4)
	 SET  @POWERr=POWER((1.00+@R),@T)
	 SET @Result= @i*(@POWERr)
	 RETURN @Result
END 

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
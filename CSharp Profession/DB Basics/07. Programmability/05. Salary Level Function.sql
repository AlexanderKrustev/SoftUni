CREATE FUNCTION ufn_GetSalaryLevel(@salary MONEY) 
RETURNS VARCHAR(10)
AS
BEGIN
      DECLARE @Result VARCHAR(10)
      IF(@salary<30000)
	  BEGIN
	       SET @Result='Low'
	  END
	  ELSE IF(@salary>=30000 AND @salary<=50000)
	  BEGIN 
	        SET @Result='Average'
	  END
	  ELSE
	  BEGIN
			SET @Result='High'
	  END

	  RETURN @Result
END

SELECT e.Salary,dbo.ufn_GetSalaryLevel(e.Salary) AS 'Salary Level'  FROM Employees AS e


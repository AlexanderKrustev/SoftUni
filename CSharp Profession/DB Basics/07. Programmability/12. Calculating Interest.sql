CREATE PROCEDURE usp_CalculateFutureValueForAccount(@AccountID INT, @InterestRate DECIMAL(19, 8))
AS
BEGIN
     SELECT a.Id, ah.FirstName, ah.LastName, a.Balance AS 'Current Balance', dbo.ufn_CalculateFutureValue(a.id,@InterestRate) AS 'Balance in 5 years'  FROM AccountHolders AS ah
	  INNER JOIN Account AS a
		 ON ah.Id=a.AccountHolderId
	  WHERE a.Id =   @AccountID
END
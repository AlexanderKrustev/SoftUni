CREATE PROCEDURE usp_DepositMoney(@AccountId INT, @moneyAmount MONEY)
AS
BEGIN
     BEGIN TRAN
			   UPDATE Accounts
				  SET Balance+=@moneyAmount
				WHERE Id = @AccountId

	COMMIT
END
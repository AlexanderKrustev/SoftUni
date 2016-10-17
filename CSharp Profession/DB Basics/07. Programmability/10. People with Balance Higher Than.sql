
CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@Input MONEY)
AS
BEGIN
SELECT final.FirstName,final.LastName From
	 (SELECT ah.FirstName, ah.LastName, SUM(a.Balance) AS Total FROM [AccountHolders]	AS ah
	 INNER JOIN Accounts AS a
	         ON a.AccountHolderId=ah.Id
	 GROUP BY ah.FirstName, ah.LastName
	 HAVING SUM(a.Balance)>@Input) AS final

END
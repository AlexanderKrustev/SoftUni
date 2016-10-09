 SELECT  SUM(previous.DepositAmount-cur.DepositAmount) as Result
FROM WizzardDeposits cur
LEFT OUTER JOIN WizzardDeposits previous
ON cur.Id = previous.Id + 1
     
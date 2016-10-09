SELECT  SUBSTRING(w.FirstName,1,1) AS FirstLetter
  FROM WizzardDeposits AS w
  WHERE w.DepositGroup='Troll Chest'
  GROUP BY SUBSTRING(w.FirstName,1,1)
  ORDER BY  SUBSTRING(w.FirstName,1,1) 
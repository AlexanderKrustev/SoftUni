SELECT w.DepositGroup, SUM(w.DepositAmount) AS TotalSum
         FROM WizzardDeposits AS w
GROUP BY w.DepositGroup, w.MagicWandCreator
HAVING w.MagicWandCreator='Ollivander family'

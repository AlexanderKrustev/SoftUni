SELECT a.DepositGroup
	FROM WizzardDeposits a
	GROUP BY a.DepositGroup
	HAVING AVG(a.MagicWandSize) = 
                (SELECT MIN(asset_sums)
                FROM(SELECT w.DepositGroup, AVG(w.MagicWandSize) AS asset_sums
    FROM WizzardDeposits AS w
    GROUP BY w.DepositGroup
	) AS n )
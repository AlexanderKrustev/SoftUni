SELECT w.DepositGroup, SUM(w.DepositAmount)
		 FROM WizzardDeposits AS w
	GROUP BY w.DepositGroup
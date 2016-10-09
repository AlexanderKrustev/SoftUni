SELECT 
CASE 
	WHEN w.Age <= 10 THEN '[0-10]'
	WHEN w.Age >=11 AND w.Age<=20  THEN '[11-20]'
	WHEN w.Age >=21 AND w.Age<=30  THEN '[21-30]'
	WHEN w.Age >=31 AND w.Age<=40  THEN '[31-40]'
	WHEN w.Age >=41 AND w.Age<=50  THEN '[41-50]'
	WHEN w.Age >=51 AND w.Age<=60  THEN '[11-20]'
	WHEN w.Age >=61   THEN '[61+]'
	END AS AgeGroup,
	COUNT(*) AS 'WizardCount'
  FROM WizzardDeposits AS w
  GROUP BY CASE 
	WHEN w.Age <= 10 THEN '[0-10]'
	WHEN w.Age >=11 AND w.Age<=20  THEN '[11-20]'
	WHEN w.Age >=21 AND w.Age<=30  THEN '[21-30]'
	WHEN w.Age >=31 AND w.Age<=40  THEN '[31-40]'
	WHEN w.Age >=41 AND w.Age<=50  THEN '[41-50]'
	WHEN w.Age >=51 AND w.Age<=60  THEN '[11-20]'
	WHEN w.Age >=61   THEN '[61+]' END

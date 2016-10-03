SELECT g.Name,
	CASE 
		WHEN (DATEPART(HOUR, g.Start)>=0 AND DATEPART(HOUR, g.Start)<12) THEN 'Morning'
		WHEN (DATEPART(HOUR, g.Start)>=12 AND DATEPART(HOUR, g.Start)<18) THEN 'Afternoon'
		WHEN (DATEPART(HOUR, g.Start)>=18 AND DATEPART(HOUR, g.Start)<24) THEN 'Evening'
	END AS 'Part of the Day',
	CASE
		WHEN g.Duration<=3 THEN 'Extra Short'
		WHEN g.Duration>=4 AND g.Duration<=6 THEN 'Short'
		WHEN g.Duration>6  THEN 'Long'
		WHEN g.Duration IS NULL THEN 'Extra Long'
	END AS 'Duration'
	FROM Games AS g
	ORDER BY g.Name, 'Duration','Part of the Day' 
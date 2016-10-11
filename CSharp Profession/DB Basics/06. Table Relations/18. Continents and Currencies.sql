SELECT final.ContinentCode,c1.CurrencyCode, final.CurrencyUsage FROM
(SELECT cr.ContinentCode, MAX(cr.CurrencyCount) AS CurrencyUsage  FROM
    (SELECT c.ContinentCode, c.CurrencyCode, COUNT(C.CurrencyCode) AS CurrencyCount FROM Countries AS c
	GROUP BY c.ContinentCode, c.CurrencyCode
	HAVING COUNT(c.CurrencyCode)>1) AS cr
	GROUP BY cr.ContinentCode) AS final
	   INNER JOIN (SELECT c.ContinentCode, c.CurrencyCode, COUNT(C.CurrencyCode) AS CurrencyCount FROM Countries AS c
	GROUP BY c.ContinentCode, c.CurrencyCode
	HAVING COUNT(c.CurrencyCode)>1) AS c1
         ON final.ContinentCode=c1.ContinentCode
		 AND final.CurrencyUsage=c1.CurrencyCount

SELECT c.CountryName, c.CountryCode,
	CASE c.CurrencyCode 
		WHEN 'EUR' THEN 'Euro'
		ELSE 'Not Euro'
		END AS Currency
	FROM Countries AS c
ORDER BY c.CountryName
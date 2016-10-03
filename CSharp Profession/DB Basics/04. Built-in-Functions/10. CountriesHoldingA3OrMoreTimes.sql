SELECT c.CountryName, c.IsoCode FROM Countries AS c
	WHERE LEN(c.CountryName) >= (LEN(REPLACE(c.CountryName,'a',''))+3)
	ORDER BY c.IsoCode
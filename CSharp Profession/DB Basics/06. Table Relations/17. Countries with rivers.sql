SELECT TOP 5 c.CountryName, r.RiverName FROM Countries AS c
	 LEFT JOIN CountriesRivers AS ar
			ON c.CountryCode=ar.CountryCode
	 LEFT JOIN Rivers AS r
			ON r.Id=ar.RiverId
	     WHERE c.ContinentCode= 'AF'
	  ORDER BY c.CountryName

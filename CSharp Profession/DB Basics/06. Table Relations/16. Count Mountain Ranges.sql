SELECT c.CountryCode, COUNT(m.MountainRange) AS MountainRange  FROM Countries AS c
   INNER JOIN MountainsCountries AS mc
		   ON c.CountryCode=mc.CountryCode		   
   INNER JOIN Mountains AS m
		   ON mc.MountainId=m.Id
		   WHERE c.CountryCode='BG'
		   OR  c.CountryCode='US'	   
		   OR  c.CountryCode='RU'  
   GROUP BY c.CountryCode
	
SELECT c.CountryCode, m.MountainRange,p.PeakName,p.Elevation FROM Countries AS c
   INNER JOIN MountainsCountries AS mc
		   ON c.CountryCode=mc.CountryCode
		   AND c.CountryCode='BG'		   		   
   INNER JOIN Mountains AS m
		   ON mc.MountainId=m.Id
   INNER JOIN Peaks AS p
		   ON p.MountainId=mc.MountainId
		   AND p.Elevation>2835
		   ORDER BY p.Elevation DESC
	
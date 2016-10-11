
SELECT   s.CountryName,
CASE 
   WHEN S.HighestPeakElevation IS  NULL THEN '(no highest peak)'
   ELSE p.PeakName
 END AS HighestPeakName, 
CASE 
   WHEN S.HighestPeakElevation IS  NULL THEN 0
   ELSE S.HighestPeakElevation
 END AS HighestPeakElevation,  
   CASE 
		WHEN m.MountainRange IS NULL THEN '(no mountain)'
	    ELSE m.MountainRange
		END AS MountainRange
    FROM
(SELECT  fin.CountryName, MAX(fin.Elevation) AS HighestPeakElevation  FROM 
   (SELECT  c.CountryName, p.Elevation  FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc
		   ON c.CountryCode=mc.CountryCode
	LEFT JOIN Peaks AS p
		   ON mc.MountainId=p.MountainId
	LEFT JOIN Mountains AS m
	       ON p.MountainId=m.Id 
	) AS fin
	GROUP BY fin.CountryName
	)AS S
  INNER JOIN Countries AS c
         ON s.CountryName=c.CountryName
  LEFT JOIN MountainsCountries AS mc
         ON c.CountryCode=mc.CountryCode
  LEFT JOIN Mountains AS m
		 ON mc.MountainId=m.Id
  LEFT JOIN Peaks AS p
         ON mc.MountainId=p.MountainId
ORDER BY c.CountryName, p.PeakName

	
  
	

		
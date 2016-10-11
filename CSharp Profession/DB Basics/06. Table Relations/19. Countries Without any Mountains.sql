SELECT COUNT(cn.InitialCount) AS CountryCode FROM
(SELECT c.CountryCode, COUNT(mc.MountainId) AS InitialCount FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc
	       ON c.CountryCode=mc.CountryCode
	GROUP BY c.CountryCode
	HAVING COUNT(mc.MountainId)=0 ) AS cn
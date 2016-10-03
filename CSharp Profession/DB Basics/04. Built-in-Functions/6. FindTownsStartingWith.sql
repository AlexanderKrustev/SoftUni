SELECT t.TownID, t.Name FROM Towns AS t
	WHERE SUBSTRING(t.Name,1,1)='M'
	   OR SUBSTRING(t.Name,1,1)='K'
	   OR SUBSTRING(t.Name,1,1)='B'
	   OR SUBSTRING(t.Name,1,1)='E'
	ORDER BY t.Name
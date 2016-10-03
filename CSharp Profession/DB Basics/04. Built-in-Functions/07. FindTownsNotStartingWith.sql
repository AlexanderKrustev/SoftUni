SELECT t.TownID, T.Name FROM Towns AS t
	WHERE SUBSTRING(t.Name,1,1)<>'R'
	  AND SUBSTRING(t.Name,1,1)<>'B'
	  AND SUBSTRING(t.Name,1,1)<>'D' 
	ORDER BY t.Name
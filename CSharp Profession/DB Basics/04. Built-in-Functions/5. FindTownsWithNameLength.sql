SELECT t.Name FROM  Towns AS t
	WHERE LEN(t.Name)=5 
	   OR LEN(t.Name)=6
	ORDER BY t.Name
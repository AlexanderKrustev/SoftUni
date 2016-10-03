SELECT e.FirstName, e.LastName FROM Employees AS e
	WHERE CHARINDEX('ei',e.LastName,1)>0
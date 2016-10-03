SELECT e.FirstName, e.LastName FROM Employees AS e
	WHERE CHARINDEX('engineer', e.JobTitle,1)=0
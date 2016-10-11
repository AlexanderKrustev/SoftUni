SELECT TOP (3) E.EmployeeID,E.FirstName FROM Employees AS e
	LEFT JOIN EmployeesProjects AS ep
		   ON e.EmployeeID = ep.EmployeeID
		   WHERE ep.EmployeeID IS NULL
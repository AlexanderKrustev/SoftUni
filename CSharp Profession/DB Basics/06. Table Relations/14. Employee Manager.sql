SELECT em.EmployeeID, em.FirstName, em.ManagerID, e.FirstName AS ManagerName FROM Employees AS e
	INNER JOIN Employees AS em
			ON e.EmployeeID = em.ManagerID
			WHERE em.ManagerID=3 OR em.ManagerID=7
			ORDER BY em.EmployeeID 
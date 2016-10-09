SELECT e.DepartmentID, MIN(e.Salary) AS MinimumSalary
	 FROM Employees AS e
	 WHERE e.HireDate>'2000-01-01'
	 GROUP BY e.DepartmentID
	 HAVING e.DepartmentID=2 OR e.DepartmentID=5 OR e.DepartmentID=7
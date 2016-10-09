SELECT * 
INTO NewEmployees
FROM Employees AS e
WHERE e.Salary>30000

DELETE FROM NewEmployees 
WHERE ManagerID=42

UPDATE NewEmployees
SET Salary=Salary+5000
WHERE DepartmentID=1

SELECT n.DepartmentID, AVG(n.Salary) AS AverageSalary
	 FROM NewEmployees AS n
	 GROUP BY n.DepartmentID
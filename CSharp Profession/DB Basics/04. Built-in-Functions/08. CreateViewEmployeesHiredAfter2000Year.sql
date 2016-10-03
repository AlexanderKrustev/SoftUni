CREATE VIEW V_EmployeesHiredAfter200 AS
	SELECT e.FirstName,e.LastName FROM Employees AS e
		WHERE YEAR(e.HireDate)>'2000'
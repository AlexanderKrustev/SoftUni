CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber(@ExcpectedSalary money)
AS 
BEGIN
     SELECT e.FirstName,e.LastName FROM Employees AS e
	 WHERE e.Salary>=@ExcpectedSalary
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100
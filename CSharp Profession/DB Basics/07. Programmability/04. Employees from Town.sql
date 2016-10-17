CREATE PROCEDURE usp_GetEmployeesFromTown(@TownName VARCHAR(50))
AS
BEGIN
    SELECT e.FirstName,e.LastName FROM Employees AS e
	 INNER JOIN Addresses AS a
		ON a.AddressID=e.AddressID
	 INNER JOIN Towns AS t
		ON t.TownID=a.TownID
	 WHERE t.Name= @TownName 

END

EXEC usp_GetEmployeesFromTown 'Sofia'
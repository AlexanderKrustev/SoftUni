CREATE VIEW V_EmployeeNameJobTitle AS
	SELECT CASE WHEN E.MiddleName IS NULL
	            THEN E.FirstName+'  '+E.LastName 
	            WHEN E.MiddleName IS NOT NULL THEN E.FirstName+' '+E.MiddleName+' '+E.LastName END
	  AS "Full Name", E.JobTitle
    FROM Employees AS E
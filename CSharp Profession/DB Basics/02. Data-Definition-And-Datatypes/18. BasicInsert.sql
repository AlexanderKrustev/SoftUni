
INSERT INTO [dbo].[Towns](Name)
VALUES ('Sofia'), ('Plovdiv'), ('Varna'), ('Burgas')


INSERT INTO [dbo].[Department](Name)
VALUES ('Engineering'), ('Sales'), ('Marketing'), ('Software Development'), ('Quality Assurance')

 			02/03/2004	4000.00
 			28/08/2016	525.25
 			09/12/2007	3000.00
 			28/08/2016	599.88


INSERT INTO [dbo].[Employees] (FirstName, LastName, JobTitle, DepartmentId, HireDate, Salary)
VALUES('Ivan','Ivanov Ivanov','.NET Developer', 4, '20130201',3500.00),
('Petar','Petrov Petrov','Senior Engineer', 1, '20040302',3500.00),
('Maria','Petrova Ivanova','Intern', 5, '20160828',3500.00),
('Georgi','Teziev Ivanov','CEO', 2, '20071209',3500.00),
('Peter','Pan Pan','Intern', 3, '20160828',3500.00)
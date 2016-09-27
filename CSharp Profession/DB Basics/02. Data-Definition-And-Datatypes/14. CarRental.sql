USE[CarRental]

CREATE TABLE Categories
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Category VARCHAR(40) NOT NULL,
DailyRate DECIMAL NOT NULL,
WeeklyRate DECIMAL,
MonthlyRate DECIMAL,
WeekendRate DECIMAL
)

CREATE TABLE Cars
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
PlateNumber VARCHAR(10) NOT NULL,
Make NVARCHAR (4),
Model NVARCHAR (10),
CarYear NVARCHAR (4),
CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
Doors INT,
Picture VARBINARY(MAX),
Condition BIT,
Available BIT NOT NULL
)

CREATE TABLE Employees
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
FirstName NVARCHAR(50),
LastName NVARCHAR(50) NOT NULL,
Title NVARCHAR(10),
Notes NVARCHAR(MAX)
)

CREATE TABLE Customers
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
DriverLicenceNumber BIGINT NOT NULL,
FullName NVARCHAR(50) NOT NULL,
CustomerAddress NVARCHAR(200),
City NVARCHAR(30),
ZIPCode INT,
Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(Id),
CarId INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
CarContions	NVARCHAR(10),
TankLevel FLOAT,
KilometrageStart INT,
KilometrageEnd INT,
TotalKilometrage INT,
StartDate Date NOT NULL,
EndData Date NOT NULL,
TotalDays SMALLINT,
RateApplied FLOAT NOT NULL,
TaxRate FLOAT,
OrderStatus NVARCHAR(10),
Notes NVARCHAR(MAX)
)

INSERT INTO Categories(Category, DailyRate) Values('Sedan',50.0)
INSERT INTO Categories(Category, DailyRate) Values('Pickup',50.0)
INSERT INTO Categories(Category, DailyRate) Values('Sportback',50.0)

INSERT INTO Cars(PlateNumber, Model, CarYear, CategoryId, Available) Values('MIAMI 195', 'FireBird' , '1963', 1, 0)
INSERT INTO Cars(PlateNumber, Model, CarYear, CategoryId, Available) Values('MIAMI 598', 'GMS' , '2005', 2, 1)
INSERT INTO Cars(PlateNumber, Model, CarYear, CategoryId, Available) Values('MIAMI 9987', 'Courvet' , '1986', 3, 1)

INSERT INTO Employees(FirstName, LastName, Title) Values('John', 'Doe' , 'Mr')
INSERT INTO Employees(FirstName, LastName, Title) Values('John2', 'Doe2' , 'Mr')
INSERT INTO Employees(FirstName, LastName, Title) Values('John4', 'Doe2' , 'Mr')


INSERT INTO Customers(DriverLicenceNumber, FullName) Values(21564678641, 'Ivan Ivanov')
INSERT INTO Customers(DriverLicenceNumber, FullName) Values(21564678641, 'Krum Kurtev')
INSERT INTO Customers(DriverLicenceNumber, FullName) Values(2123123,'Bogdanka Grueva')

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, CarContions, StartDate, EndData, RateApplied) Values(1,1,3,'OK','2016-09-21','2016-09-21',50.5)
INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, CarContions, StartDate, EndData, RateApplied) Values(2,3,1,'OK','2016-09-21','2016-09-21',50.5)
INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, CarContions, StartDate, EndData, RateApplied) Values(3,2,2,'OK','2016-09-21','2016-09-21',50.5)



CREATE TABLE Employees
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
FirstName NVARCHAR(20) NOT NULL,
LastName NVARCHAR(20) NOT NULL,
Title NVARCHAR(10),
Notes NVARCHAR(MAX)
)

CREATE TABLE Customers
(
AccountNumber BIGINT NOT NULL PRIMARY KEY,
FirstName NVARCHAR(20) NOT NULL,
LastName NVARCHAR(20) NOT NULL,
PhoneNumber NVARCHAR(20),
EmergencyName NVARCHAR(100),
EmergencyNumber NVARCHAR(20)
)

CREATE TABLE RoomStatus
(
RoomStatus NVARCHAR(20) NOT NULL PRIMARY KEY,
Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes
(
RoomType NVARCHAR(20) NOT NULL PRIMARY KEY,
Notes NVARCHAR(MAX)
)

CREATE TABLE BedTypes
(
BedType NVARCHAR(20) NOT NULL PRIMARY KEY,
Notes NVARCHAR(MAX)
)

CREATE TABLE Rooms
(
RoomNumber SMALLINT NOT NULL PRIMARY KEY,
RoomType NVARCHAR(20) FOREIGN KEY REFERENCES RoomTypes(RoomType),
BedType NVARCHAR(20) FOREIGN KEY REFERENCES BedTypes(BedType),
Rate FLOAT NOT NULL,
RoomStatus NVARCHAR(20) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
Notes NVARCHAR(MAX)
)

CREATE TABLE Payments
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
PaymentDate DATE NOT NULL,
AccountNumber BIGINT NOT NULL FOREIGN KEY REFERENCES Customers(AccountNumber),
FirstDateOccupied DATE NOT NULL,
LastDateOccupied DATE NOT NULL,
TotalDay INT,
AmountCharged FLOAT NOT NULL,
TaxRate FLOAT,
TaxAmount FLOAT,
PaymentTotal FLOAT NOT NULL,
Notes NVARCHAR(MAX)
)

CREATE TABLE Occupancies
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
DateOccupied DATE NOT NULL,
AccountNumber BIGINT NOT NULL FOREIGN KEY REFERENCES Customers(AccountNumber),
RoomNumber SMALLINT NOT NULL FOREIGN KEY REFERENCES Rooms(RoomNumber),
RateApplied FLOAT NOT NULL,
PhoneCharge FLOAT,
Notes NVARCHAR(MAX)
)

INSERT INTO Employees(FirstName, LastName) VALUES('Ivan', 'Ivanov')
INSERT INTO Employees(FirstName, LastName) VALUES('Ivan2', 'Ivanov2')
INSERT INTO Employees(FirstName, LastName) VALUES('Ivan3', 'Ivanov3')

INSERT INTO Customers(AccountNumber, FirstName, LastName) VALUES(12584, 'Joro', 'Ivanov')
INSERT INTO Customers(AccountNumber,FirstName, LastName) VALUES(258874, 'Dragan', 'Ivanov')
INSERT INTO Customers(AccountNumber,FirstName, LastName) VALUES(987561,'Petkan', 'Ivanov')

INSERT INTO RoomStatus(RoomStatus) VALUES('Processing')
INSERT INTO RoomStatus(RoomStatus) VALUES('Ready')
INSERT INTO RoomStatus(RoomStatus) VALUES('Occupied')


INSERT INTO RoomTypes(RoomType) VALUES('Single')
INSERT INTO RoomTypes(RoomType) VALUES('Double')
INSERT INTO RoomTypes(RoomType) VALUES('2+1')

INSERT INTO BedTypes(BedType) VALUES('King Size')
INSERT INTO BedTypes(BedType) VALUES('Single')
INSERT INTO BedTypes(BedType) VALUES('3')

INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus) VALUES(125, 'Single','Single', 155.00, 'Ready')
INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus) VALUES(225, 'Double','King Size', 255.00, 'Processing')
INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus) VALUES(325, '2+1','3', 455.00, 'Occupied')

INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, AmountCharged, PaymentTotal) VALUES(1, '2016-10-21', 12584,'2016-10-19','2016-10-21', 1000, 1200)
INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, AmountCharged, PaymentTotal) VALUES(2, '2016-10-21', 12584,'2016-10-19','2016-10-21', 1000, 1200)
INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, AmountCharged, PaymentTotal) VALUES(3, '2016-10-21', 12584,'2016-10-19','2016-10-21', 1000, 1200)

INSERT INTO Occupancies(EmployeeId,DateOccupied, AccountNumber , RoomNumber,RateApplied) VALUES(1, '2016-10-21', 12584, 225 , 155)
INSERT INTO Occupancies(EmployeeId,DateOccupied, AccountNumber ,RoomNumber,RateApplied) VALUES(1, '2016-10-21', 12584, 225 , 155)
INSERT INTO Occupancies(EmployeeId,DateOccupied, AccountNumber ,RoomNumber,RateApplied) VALUES(1, '2016-10-21', 12584, 225 , 155)
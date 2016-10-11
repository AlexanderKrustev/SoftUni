CREATE TABLE Manufacturers(
ManufacturerID INT NOT NULL,
Name VARCHAR(30),
EstablishedOn DATE
)

CREATE TABLE Models(
ModelId INT NOT NULL,
Name VARCHAR(30),
ManufacturerID INT
)
INSERT INTO Manufacturers(ManufacturerID,Name,EstablishedOn)
VALUES (1,'BMW', '07/03/1916') ,(2,'Tesla', '01/01/2003') ,(3,'Lada', '01/05/1966') 

INSERT INTO Models(ModelId,Name,ManufacturerID)
VALUES (101,'X1',1),(102,'i6',1),(103,'Model S',2),(104,'Model X',2),(105,'Model 3',2),(106,'Nova',3)

ALTER TABLE Manufacturers
ADD PRIMARY KEY (ManufacturerID)

ALTER TABLE Models
ADD PRIMARY KEY (ModelId)

ALTER TABLE Models
ADD CONSTRAINT FK_Models_Manufacturers
FOREIGN KEY (ManufacturerID)
REFERENCES Manufacturers(ManufacturerID)



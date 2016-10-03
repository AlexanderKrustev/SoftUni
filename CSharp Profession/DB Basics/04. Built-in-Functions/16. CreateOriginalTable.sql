CREATE TABLE Orders
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
ProductName NVARCHAR(100),
OrderDate Datetime
)

INSERT INTO Orders(ProductName,OrderDate)
VALUES('Butter', '2016-09-19 00:00:00.000'),
('Milk', '2016-09-30 00:00:00.000'),
('Cheese', '2016-09-04 00:00:00.000'),
('Bread', '2015-12-20 00:00:00.000'),
('Tomatoes', '2015-12-30 00:00:00.000')
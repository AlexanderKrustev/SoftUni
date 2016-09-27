CREATE TABLE Directors
(
Id INT NOT NULL PRIMARY KEY,
DirectorName VARCHAR(50) NOT NULL,
Notes VARCHAR(255)
)

CREATE TABLE Genres
(
Id INT NOT NULL PRIMARY KEY,
GenresName VARCHAR(50) NOT NULL,
Notes VARCHAR(255)
)

CREATE TABLE Categories
(
Id INT NOT NULL PRIMARY KEY,
CategoryName VARCHAR(50) NOT NULL,
Notes VARCHAR(255)
)

CREATE TABLE Movies
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Title VARCHAR(50) NOT NULL,
DirectorId INT NOT NULL FOREIGN KEY REFERENCES Directors(Id),
CopyrightYear VARCHAR(4),
Lenght int,
GenreId INT NOT NULL FOREIGN KEY REFERENCES Genres(Id),
CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
Rating VARCHAR(6),
Notes VARCHAR(255)
)

INSERT INTO Directors
VALUES 
(1,'Lucas','Great Director'),
(2,'Cameron','Great Director'),
(4,'Director',null),
(5,'Ivan',null),
(3,'Stamat','Poor Director')

INSERT INTO Genres
VALUES 
(1,'Horror','Prohibated for under 16'),
(2,'Turksih','Do not watch it please'),
(3,'Action','Same shit everyday'),
(4,'Series',null),
(5,'Drama','Poor Director')

INSERT INTO Categories
VALUES 
(1,'Category1', null),
(2,'Category2', null),
(3,'Category3', null),
(4,'Category4', null),
(5,'Category5', null)

INSERT INTO Movies
VALUES 
('Lethal Weapon 192', 1, '1929',120,3,1,0,'COMING SOON'),
('Lethal Weapon 193', 3, '1929',120,2,2,0,'COMING SOON'),
('Lethal Weapon 194', 4, '19',152,1,5,0,'COMING SOON'),
('Lethal Weapon 195', 1, '1929',180,3,4,0, null),
('Lethal Weapon 196', 1, '199',120,3,1,0,null)

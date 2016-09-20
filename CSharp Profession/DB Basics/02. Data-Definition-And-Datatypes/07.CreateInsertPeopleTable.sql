CREATE TABLE People
( 
Id int NOT NULL IDENTITY PRIMARY KEY,
Name varchar(200) NOT NULL,
Picture varbinary(max),
Height decimal(10,2),
Weight decimal(10,2),
Gender VARCHAR(1),
Birthday Date NOT NULL,
Biography VARCHAR(MAX)
)

INSERT INTO People(Name,Height,Weight,Gender,Birthday,Biography)
Values
('Asen1', 1.57, 20.55,'M','1986-10-21','asfdsajasdhf;asdhf;ahsd;fhas;kdfh;kasdhf'),
('Asen2', 1.57, 20.55,'M','1986-10-21','asfdsajasdhf;asdhf;ahsd;fhas;kdfh;kasdhf'),
('Asen3', 1.57, 20.55,'M','1986-10-21','asfdsajasdhf;asdhf;ahsd;fhas;kdfh;kasdhf'),
('Asen4', 1.57, 20.55,'M','1986-10-21','asfdsajasdhf;asdhf;ahsd;fhas;kdfh;kasdhf'),
('Asen5', 1.57, 20.55,'M','1986-10-21','asfdsajasdhf;asdhf;ahsd;fhas;kdfh;kasdhf')

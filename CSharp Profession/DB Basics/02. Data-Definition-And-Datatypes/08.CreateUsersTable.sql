CREATE TABLE Users
( 
Id bigint NOT NULL IDENTITY PRIMARY KEY,
Username VARCHAR(30) NOT NULL,
Password VARCHAR(26) NOT NULL,
ProfilePicture varbinary(8000),
LastLogin DATETIME,
IsDeleted VARCHAR(1)
)

INSERT INTO Users(Username,Password,ProfilePicture,LastLogin,IsDeleted)
Values
('Asen1Asen1Asen1Asen', 'Asen1Asen1', null,null,'T'),
('Asen1Asen1Asen1Asen', 'Asen1Asen1', null,null,'f'),
('Asen1Asen1Asen1Asen', 'Asen1Asen1', null,null,'f'),
('Asen1Asen1Asen1Asen', 'Asen1Asen1', null,null,'T'),
('Asen1Asen1Asen1Asen', 'Asen1Asen1', null,null,'f')

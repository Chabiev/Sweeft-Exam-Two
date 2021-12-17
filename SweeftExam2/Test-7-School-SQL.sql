CREATE TABLE Teacher 
(
	ID int IDENTITY (1,1) PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Gender int NOT NULL,
	[Subject] nvarchar(50) NOT NULL
	
)

CREATE TABLE Pupil 
(
	ID int IDENTITY (1,1) PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Gender int NOT NULL,
	Grade int NOT NULL
	
)

CREATE TABLE Relation
(

	TeacherID int FOREIGN KEY REFERENCES Teacher(ID) NOT NULL,
	PupilID int FOREIGN KEY REFERENCES Pupil(ID) NOT NULL
)

INSERT INTO Teacher (FirstName,LastName,Gender,[Subject])
VALUES
	('Remus', 'Lupin', 1, 'Defence against the dark arts'),
	('Severus', 'Snape', 1, 'Potions'),
	('Minerva', 'McGonagall', 2, 'Transfiguration'),
	('Pomona', 'Sprout', 2, 'Herbology');



INSERT INTO Pupil (FirstName,LastName,Gender,Grade)
VALUES
	('Irakli', 'Chabiev', 1, 5),
	('Giorgi', 'Giorgadze', 1, 4),
	('Giorgi', 'Tsiklauri', 1, 6),
	('Giorgi','Tsikhishvili',1, 2),
	('Mariam', 'Chabiev', 2, 5),
	('Neville', 'Longbottom', 1, 5),
	('Hermione', 'Granger', 2, 5),
	('Ronald', 'Weasley', 1, 5),
	('Colin', 'Creevey', 1, 3);


INSERT INTO Relation(TeacherID, PupilID)
VALUES
		(1,1),
		(1,2),
		(1,4),
		(1,5),
		(1,9),
		(2,1),
		(2,2),
		(2,5),
		(2,7),
		(3,3),
		(3,6),
		(3,9),
		(4,8),
		(4,9);

		
		SELECT  DISTINCT Teacher.FirstName, Teacher.LastName, Teacher.[Subject]
		FROM Teacher
		JOIN Relation ON Teacher.ID=Relation.TeacherID
		JOIN Pupil ON Relation.PupilID=Pupil.ID
		WHERE Pupil.FirstName='Giorgi';
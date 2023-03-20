CREATE TABLE Trainees(
	TraineeID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(255),
	Course VARCHAR(255),
	Location VARCHAR(255)
	);

INSERT INTO Trainees (Name, Course, Location)
VALUES ('Ricardo Goncalves', 'Tech 205', 'Birmingham'),
		('Byron Esson', 'Tech 205', 'Wolverhampton');

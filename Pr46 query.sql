USE [DB_2024_13];
GO

CREATE TABLE Subject (
SubjectID INT IDENTITY,
Name NVarChar(50),

CONSTRAINT PK_Subject PRIMARY KEY (SubjectID)
);


CREATE TABLE Substitute (
SubstituteID INT IDENTITY,
Name NVarChar(104),
Phone NVarChar(52),
CPR NVarChar(15),
CertificateDate DateTime2,
Status BIT

CONSTRAINT PK_Substitute PRIMARY KEY (SubstituteID)
);


CREATE TABLE Subject_Substitute (
SubstituteID INT,
SubjectID INT,

CONSTRAINT PK_SubjectSubstitute PRIMARY KEY (SubstituteID, SubjectID),
CONSTRAINT FK_SubjectSubstitute_Subject FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
CONSTRAINT FK_SubjectSubstitute_Substitute FOREIGN KEY (SubstituteID) REFERENCES Substitute(SubstituteID)
);


INSERT INTO Subject(Name)
VALUES
	('Math'),
	('English'),
	('Danish'),
	('Cooking'),
	('PE'),
	('Science'),
	('Defense against the Dark Arts'),
	('Religion'),
	('Woodworking'),
	('Handworking')


INSERT INTO Substitute (Name,Phone,CPR,CertificateDate,Status)
VALUES
	('Gunbritt', '29292392', '9012902023', '20220120', 1),
	('Gustav Groth', '13222339', '32193219321', '20210912', 1),
	('Negromont', '66642069', '321312321213', '20180612', 0)


INSERT INTO Subject_Substitute (SubstituteID, SubjectID)
VALUES
	(1,4),
	(1,10),
	(1,7),
	(2,1),
	(2,2),
	(2,3),
	(2,4),
	(2,5),
	(2,6),
	(2,9),
	(2,10),
	(3,7)


SELECT Subject.Name, Substitute.Name
FROM Subject
JOIN Subject_Substitute
ON Subject.SubjectID = Subject_Substitute.SubjectID
JOIN Substitute
ON Substitute.SubstituteID = Subject_Substitute.SubstituteID



--DROP TABLE Substitute_Competence
--DROP TABLE Subject_Competence
--DROP TABLE Substitute
--DROP TABLE Competence
--DROP TABLE Subject
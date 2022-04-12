INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Minni', 'Collman', '2000-03-05');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Rustie', 'Blethyn', '1996-02-21');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Dotti', 'Riden', '1999-10-12');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Ephrayim', 'Hassard', '1996-12-10');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Corey', 'Alvaro', '1998-11-24');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Jsandye', 'Looks', '1995-11-16');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Merrill', 'Adelsberg', '1999-10-18');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Heather', 'McRoberts', '1999-04-17');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Torrey', 'Pea', '1997-07-22');
INSERT INTO Students (Name, Surname, Birthdate) VALUES ('Dru', 'Waudby', '1999-05-19');

INSERT INTO Subjects (Name, Abbreviation) VALUES ('Communication Technology', 'BPC-KOM');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Mathematics 1', 'BPC-MA1');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Mathematics 2', 'BPC-MA2');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Computers and Programming 1', 'BPC-PC1');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Computers and Programming 2', 'BPC-PC2');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Security of Database Systems', 'BPC-BDS');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Applied Cryptography', 'BPC-AKR');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Data Communication', 'BPC-DAK');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Network Operating Systems', 'BPC-SOS');
INSERT INTO Subjects (Name, Abbreviation) VALUES ('Security Systems', 'BPC-ZSY');

INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (3, 3);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (2, 3);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (4, 3);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (6, 3);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (4, 7);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (1, 7);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (8, 2);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (7, 2);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (8, 2);
INSERT INTO StudentsSubjects (StudentId, SubjectId) VALUES (4, 2);

INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (6, 5, 5, '2021-08-31');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (8, 5, 3, '2022-03-29');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (5, 5, 5, '2021-05-20');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (9, 5, 2, '2021-09-05');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (1, 5, 5, '2021-04-12');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (7, 5, 4, '2022-03-31');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (10, 10, 3, '2021-11-10');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (3, 10, 4, '2021-09-23');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (4, 10, 4, '2022-01-26');
INSERT INTO SubjectsReviews (StudentId, SubjectId, Rating, CreatedAt) VALUES (2, 10, 1, '2022-03-09');
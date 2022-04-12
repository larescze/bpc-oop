CREATE TABLE [dbo].[Students]
(
	[StudentId] INT NOT NULL IDENTITY(1,1),
	[Name] NCHAR(50) NOT NULL,
	[Surname] NCHAR(50) NOT NULL,
	[Birthdate] DATE NOT NULL,
	CONSTRAINT [Pk_Students] PRIMARY KEY ([StudentId])
)

CREATE TABLE [dbo].[Subjects]
(
	[SubjectId] INT NOT NULL IDENTITY(1,1),
	[Abbreviation] NCHAR(5) NOT NULL,
	[Name] NCHAR(50) NOT NULL,
	CONSTRAINT [Pk_Subjects] PRIMARY KEY ([SubjectId])
)

CREATE TABLE [dbo].[StudentsSubjects]
(
	[StudentId] INT NOT NULL,
	[SubjectId] INT NOT NULL,
	CONSTRAINT [Pk_StudentsSubjects] FOREIGN KEY ([StudentId]) REFERENCES Students ([StudentId]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [Pk_StudentsSubjects_Subject] FOREIGN KEY ([SubjectId]) REFERENCES Subjects ([SubjectId]) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE [dbo].[SubjectsReviews]
(
	[SubjectsReviewsId] INT NOT NULL IDENTITY(1,1),
	[StudentId] INT NOT NULL,
	[SubjectId] INT NOT NULL,
	[Rating] INT NOT NULL,
	[CreatedAt] DATETIME NOT NULL,
	CONSTRAINT [Pk_SubjectsReviews] PRIMARY KEY ([SubjectsReviewsId]),
	CONSTRAINT [Fk_SubjectsReviews_Student] FOREIGN KEY ([StudentId]) REFERENCES Students ([StudentId]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [Fk_SubjectsReviews_Subject] FOREIGN KEY ([SubjectId]) REFERENCES Subjects ([SubjectId]) ON DELETE CASCADE ON UPDATE CASCADE
)
		DECLARE @TableCreated INT = 0;

CREATE TABLE Lecturers (
					ID INT PRIMARY KEY IDENTITY,
					Name NVARCHAR(15) NOT NULL UNIQUE,
					Price INT NOT NULL

				);

				INSERT INTO Lecturers (Name, Price)
					VALUES 
					('Alice',100),
					('Bob',200),
					('Charlie',300);
                SET @TableCreated += 1; -- add 1 to indicate that the table was created				
                CREATE TABLE Courses (
					ID INT PRIMARY KEY IDENTITY,
					Name VARCHAR(25) NOT NULL UNIQUE,
					StartDate Date,
					Price INT NOT NULL,
					DaysInWeek VARCHAR(50),
					Hours VARCHAR(50)
				);	
				INSERT INTO Courses (Name, Price, StartDate,DaysInWeek, Hours)
					VALUES 
					('Biology',1000,'2025-01-01', 'Monday, Tuesday,Thursday, Friday', '16:50-20:40'),
					('Chemistry',2000,'2024-12-01','Sunday, Monday, Tuesday, Friday', '13:50-18:40' ),
					('English',3000,'2025-12-01', 'Monday, Tuesday, Wednesday, Thursday', '12:50-16:40' ),
					('Mathematics',1500,'2024-12-01', 'Monday, Friday', '16:50-20:40' ),
					('History',2300,'2022-12-01', 'Tuesday, Wednesday, Thursday, Friday', '11:50-22:40' );
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
                CREATE TABLE Students (
					ID INT PRIMARY KEY IDENTITY,
					Name NVARCHAR(15),
				);
				INSERT INTO Students (Name)
					VALUES 
						('Alice'),
						('Bob'),
						('Charlie'),
						('David'),
						('Emily'),
						('Frank'),
						('Grace'),
						('Hannah'),
						('Zoe');
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
                 CREATE TABLE Subjects (
					ID INT PRIMARY KEY IDENTITY,
					Name VARCHAR(25) ,
					Hours int NOT NULL,
					LecturerID int FOREIGN KEY REFERENCES Lecturers(ID),
					CourseID int FOREIGN KEY REFERENCES Courses(ID),
					CONSTRAINT UC_Lecturer UNIQUE (LecturerID, Name) ,
				);
				INSERT INTO Subjects (Name, Hours,LecturerID,CourseID)
					VALUES 
						('Cell biology',100,1, 1),
						('Genetics',200, 2,1),
						('Evolution',300,3, 1),
						('Ecology',30,1, 1),
						('Atomic structure',43,1, 2),
						('Chemical bonding',67,1, 2),
						('Chemical reactions',100,3, 2),
						('Thermochemistry',100,1, 2),
						('Grammar',100,3, 3),
						('Vocabulary',100,3, 3),
						('Syntax',100,3, 3),
						('Composition',100,1, 3),
						('Algebra',200,1, 4),
						('Calculus',200, 2, 4),
						('Geometry',126,  2,4),
						('Trigonometry',200,2,  4),
						('Ancient history',200,2,  5),
						('Medieval history',150, 3, 5),
						('Modern history',300, 3, 5),
						('United States history',300,3,  5);
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
			CREATE TABLE Registrations (
					ID INT PRIMARY KEY IDENTITY,
					StudentID int FOREIGN KEY REFERENCES Students(ID),
					CourseID int FOREIGN KEY REFERENCES Courses(ID),
					CONSTRAINT UC_Registrations UNIQUE (StudentID, CourseID) ,

				);
				INSERT INTO Registrations (StudentID, CourseID)
					VALUES 
					(1, 1),
					(2, 2),
					(3, 3),
					(4, 4),
					(5, 5),
					(6, 1),
					(7, 2),
					(8, 3),
					(9, 2),
					(2, 3),
					(3, 1),
					(4, 1);
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
				CREATE TABLE Payments (
					ID INT PRIMARY KEY IDENTITY,
					StudentID int FOREIGN KEY REFERENCES Students(ID),
					amount int 
				);
				INSERT INTO Payments (StudentID, amount)
					VALUES 
					(1, 1000),
					(2, 2000),
					(3, 1000),
					(1, 500),
					(2, 500),
					(3, 1000);
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
 select @TableCreated           			
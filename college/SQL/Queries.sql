DECLARE @sum INT = 0;
select Lecturers.*, Subjects.Hours,Subjects.Hours  * Lecturers.Price  from Lecturers
join Subjects on Subjects.LecturerID = Lecturers.ID
where Subjects.CourseID = 1

-- Total expenses for course number 1
DECLARE @CourseID INT = 1;
select Sum(Subjects.Hours  * Lecturers.Price) as 'Expenses'  from Lecturers
join Subjects on Subjects.LecturerID = Lecturers.ID
where Subjects.CourseID = @CourseID



--The amount of revenue for course number 1

select  count (*) * (select Courses.Price from Courses where Courses.ID = @CourseID) as 'income'  from  Courses
join Registrations on Courses.ID = Registrations.CourseID
where Courses.ID = @CourseID


--Calculating how much a student should pay
DECLARE @StudentID INT = 4;
select sum(Courses.price) as 'should pay' from Students
join Registrations on Students.ID = Registrations.StudentID
join Courses on Courses.ID = Registrations.CourseID
where @StudentID = Students.ID

--Calculate how much a student has already paid


select sum(Payments.amount) as 'already paid' from Payments
join Students on Students.ID = Payments.StudentID
where Students.ID = @StudentID


--Current debt amount
select
(select sum(Courses.price) as 'should pay' from Students
join Registrations on Students.ID = Registrations.StudentID
join Courses on Courses.ID = Registrations.CourseID
where @StudentID = Students.ID) - (select sum(Payments.amount) as 'already paid' from Payments
join Students on Students.ID = Payments.StudentID where Students.ID = @StudentID) as 'Current debt amount'

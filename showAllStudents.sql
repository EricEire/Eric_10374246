CREATE PROC uspCreateStudent
AS 
CREATE TABLE Student(
StudentNo int not null primary key,
FirstName VARCHAR(100),
LastName VARCHAR(100),
Email VARCHAR(100) unique,
PhoneNo VARCHAR(20),
AddressLine1 VARCHAR(100),
AddressLine2 VARCHAR(100),
City VARCHAR(50),
County VARCHAR(50),
Course VARCHAR(50),
CourseLevel VARCHAR(20))

exec uspCreateStudent

go
CREATE PROC uspShowAllStudents
as
SELECT * FROM Student
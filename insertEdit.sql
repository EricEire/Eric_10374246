CREATE PROC uspInsetEditStudent
@mode VARCHAR(10),
@StudentNo int,
@FirstName VARCHAR(100),
@LastName VARCHAR(100),
@Email VARCHAR(100),
@PhoneNo VARCHAR(20),
@AddressLine1 VARCHAR(100),
@AddressLine2 VARCHAR(100),
@City VARCHAR(50),
@County VARCHAR(50),
@Course VARCHAR(50),
@CourseLevel VARCHAR(20)
AS
if @mode ="'add'"
INSERT INTO Student(
StudentNo,
FirstName,
LastName,
Email,
PhoneNo,
AddressLine1,
AddressLine2,
City,
County,
Course,
CourseLevel)
VALUES(
@StudentNo,
@FirstName,
@LastName,
@Email,
@PhoneNo,
@AddressLine1,
@AddressLine2,
@City,
@County,
@Course,
@CourseLevel)

ELSE IF @mode= "'edit'"
BEGIN
UPDATE Student
SET
FirstName=@FirstName,
LastName=@LastName,
Email=@Email,
PhoneNo=@PhoneNo,
AddressLine1=@AddressLine1,
AddressLine2=@AddressLine2,
City=@City,
County=@County,
CourseLevel=@CourseLevel
WHERE StudentNo=@StudentNo
END


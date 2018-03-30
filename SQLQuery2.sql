CREATE PROC uspFindStudent
@StudentNo int
AS 
SELECT * FROM Student
WHERE StudentNo LIKE @StudentNo




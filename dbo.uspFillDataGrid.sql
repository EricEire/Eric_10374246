CREATE PROC uspFillDataGrid
@StudentNo int
as
SELECT * 
FROM Student
WHERE StudentNo like @StudentNo

exec uspFillDataGrid
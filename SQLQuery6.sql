CREATE PROC uspUpdateStudent
AS
UPDATE Student
SET 
@PhoneNo=PhoneNo,
@AddressLine1=AddressLine1,
@AddressLine2=AddressLine1,
@City=City,
@County=County 
WHERE @StudentNo=StudentNo

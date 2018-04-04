CREATE TRIGGER trg_Student_Insert
ON Student
FOR insert
AS
BEGIN

	SELECT * FROM inserted
	DECLARE @Id int
	SELECT @Id = StudentNo from inserted

	INSERT into HistoryDB
	VALUES('New Student with StudentNo = '+ cast(@Id as nvarchar(8))+' added at '+ cast(GetDate() as nvarchar(20)))
END
go
CREATE TRIGGER trg_Student_Delete
ON Student
FOR Delete
AS
BEGIN

	SELECT * FROM inserted
	DECLARE @Id int
	SELECT @Id = StudentNo from inserted

	INSERT into HistoryDB
	VALUES('Student with StudentNo = '+ cast(@Id as nvarchar(8))+' deleted at '+ cast(GetDate() as nvarchar(20)))
END
go
CREATE TRIGGER trg_Student_Update
ON Student
FOR Update
AS
BEGIN

	SELECT * FROM inserted
	DECLARE @Id int
	DECLARE @OLDEmail nvarchar(100), @NEWEmail nvarchar(100)
	DECLARE @OLDPhoneNo nvarchar(20), @NEWPhoneNo nvarchar(20)
	DECLARE @OLDAddressLine1 nvarchar(100), @NEWAddressLine1 nvarchar(100)
	DECLARE @OLDAddressLine2 nvarchar(100), @NEWAddressLine2 nvarchar(100)
	DECLARE @OLDCity nvarchar(50), @NEWCity nvarchar(50)
	DECLARE @OLDCounty nvarchar(50), @NEWCounty nvarchar(50)
	DECLARE @OLDCourseLevel nvarchar(20), @NEWCourseLevel nvarchar(20)

	DECLARE @AuditString NVARCHAR(1000)

	SELECT * INTO #TempTable
	FROM inserted

	WHILE(EXISTS(Select Id from #TempTable))
	BEGIN
Set @AuditString=''

SELECT TOP 1 @Id=StudentNo, @NEWAddressLine1=AddressLine1,@NEWAddressLine2=AddressLine2,
@NEWEmail=Email,@NEWPhoneNo=PhoneNo,@NEWCity=City,@NEWCounty=County,@NEWCourseLevel=CourseLevel
FROM #TempTable

SELECT @OLDAddressLine1=AddressLine1,@OLDAddressLine2=AddressLine2,
@OLDEmail=Email,@OLDPhoneNo=PhoneNo,@OLDCity=City,@OLDCounty=County,@OLDCourseLevel=CourseLevel
FROM deleted where StudentNo=@Id

SET @AuditString='Student with StudentNo= '+Cast(@Id as nvarchar(8))+ ' Changed '
if(@OLDAddressLine1<>@NEWAddressLine1)
	set @AuditString =@AuditString + ' Address Line 1 from ' + @OLDAddressLine1 + ' to ' +@NEWAddressLine1
if(@OLDAddressLine2<>@NEWAddressLine2)
	set @AuditString =@AuditString + ' Address Line 2 from ' + @OLDAddressLine2 + ' to ' +@NEWAddressLine2
if(@OLDEmail<>@NEWEmail)
	set @AuditString =@AuditString + ' Email from ' + @OLDEmail + ' to ' +@NEWEmail
if(@OLDPhoneNo<>@NEWPhoneNo)
	set @AuditString =@AuditString + ' PhoneNo from ' + @OLDPhoneNo + ' to ' +@NEWPhoneNo
if(@OLDCounty<>@NEWCounty)
	set @AuditString =@AuditString + ' County from ' + @OLDCounty + ' to ' +@NEWCounty
if(@OLDCourseLevel<>@NEWCourseLevel)
	set @AuditString =@AuditString + ' Course Level from ' + @OLDCourseLevel + ' to ' +@NEWCourseLevel	
if(@OLDCity<>@NEWCity)
	set @AuditString =@AuditString + ' City from ' + @OLDCity + ' to ' +@NEWCity	
	

Insert into HistoryDB VALUES(@AuditString)

DELETE from #TempTable where StudentNo=@Id
end
end
	INSERT into HistoryDB
	VALUES('Student with StudentNo = '+ cast(@Id as nvarchar(8))+' deleted at '+ cast(GetDate() as nvarchar(20)))
END
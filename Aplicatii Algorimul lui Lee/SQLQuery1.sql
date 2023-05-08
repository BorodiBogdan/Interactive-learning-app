CREATE PROC UserAdd
@id int,
@Username varchar(30),
@Password	varchar(30)
AS
	INSERT INTO tblUser(id, Username, Password)
	VALUES(@id, @Username, @Password)

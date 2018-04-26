--thur tuc dương
USE QuanLyQuanCafe
GO
CREATE PROC GetStaff
AS
BEGIN
	SELECT * FROM dbo.Staff
END
GO 

--thủ tục thêm nhân viên
CREATE PROC AddStaff( @birthday DATE,  @name NVARCHAR(100),  @phone VARCHAR(11),  @address NVARCHAR(100),  @sex VARCHAR(11))
AS
BEGIN
	INSERT dbo.Staff
	VALUES  ( @birthday, @name,@phone, @address,@sex )
END
GO 
--thủ tục sử nhân viên
CREATE PROC UpdateStaff(@birthday DATE,  @name NVARCHAR(100),  @phone VARCHAR(11),  @address NVARCHAR(100),  @sex VARCHAR(11))
AS 
BEGIN
	UPDATE dbo.Staff
	SET birthday=@birthday,name=@name,phone=@phone,address=@address
END
GO 
--thur tuc xoa nhaan vien
CREATE PROC DeleteStaff(@id INT )
AS
BEGIN
	DELETE dbo.Staff
	WHERE id=@id
END
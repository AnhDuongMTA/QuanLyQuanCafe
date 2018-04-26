CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO


CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'NoName',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Chalky',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 123,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

Create Table Coupon(
	id VARCHAR(50) PRIMARY KEY, 
	description NVARCHAR(100) NOT NULL , -- mô tả về coupon được áp dụng
	valueCoupon INT DEFAULT 0 -- giá trị khuyến mãi bao nhiêu phần trăm
);
GO

Create table Staff( 
	id int IDENTITY PRIMARY KEY, 
	birthday DATE,
	name NVARCHAR(100) NOT NULL ,
	phone varchar(11) not null,
	address nvarchar(100) not null ,
	sex NVARCHAR(10) not null
	
);
go

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	cashier INT REFERENCES dbo.Staff(id),
	idTable INT NOT NULL REFERENCES dbo.TableFood(id),
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	idCoupon VARCHAR(50) DEFAULT NULL  REFERENCES dbo.Coupon(id)
	
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO


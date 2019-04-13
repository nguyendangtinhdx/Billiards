CREATE TABLE TableFood
(
	IDTable INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Trống', -- trống|| có người
)
GO 

CREATE TABLE PlayTime
(
	IDPlayTime INT IDENTITY PRIMARY KEY,
	MoneyPlayTime FLOAT NOT NULL DEFAULT 1000,
	StatusPlayTime NVARCHAR(100) NOT NULL DEFAULT N'Không máy lạnh'
)
GO

CREATE TABLE Account
(
	Username NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Chưa xác định',
	Password NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1: admin   0: staff
)
GO

CREATE TABLE FoodCategory
(
	IDCategory INT IDENTITY PRIMARY KEY,
	NameCategory NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	IDFood INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	Unit NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
	Price FLOAT NOT NULL DEFAULT 0,
	IDCategory INT NOT NULL

	FOREIGN KEY (IDCategory) REFERENCES dbo.FoodCategory(IDCategory)
)
GO



CREATE TABLE Bill
(
	IDBill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
	Hour INT,
	Minute INT,
	StatusBill INT NOT NULL DEFAULT 0, -- chưa thanh toán và đã thanh toán
	Discount INT,
	TotalPrice FLOAT,
	IDTable INT NOT NULL

	FOREIGN KEY (IDTable) REFERENCES dbo.TableFood(IDTable)
)
GO


CREATE TABLE BillInfo
(
	IDBillInfo INT IDENTITY PRIMARY KEY,
	IDBill INT NOT NULL,
	IDFood INT NOT NULL,
	Count INT NOT NULL DEFAULT 0

	FOREIGN KEY (IDBill) REFERENCES dbo.Bill(IDBill),
	FOREIGN KEY (IDFood) REFERENCES dbo.Food(IDFood)
)
GO

CREATE TABLE Debt
(
	IDDebt INT IDENTITY PRIMARY KEY,
	NameDebt NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người nợ',
	Money FLOAT,
	StatusDebt NVARCHAR(100) NOT NULL DEFAULT N'Đã trả nợ',
	IDBill INT NOT NULL

	FOREIGN KEY (IDBill) REFERENCES dbo.Bill(IDBill)
)
GO
------------------------------------------------------------------------------------

-- thêm account
INSERT INTO dbo.Account
        ( Username ,
          DisplayName ,
          Password ,
          Type
        )
VALUES  ( N'admin' , -- UserName - nvarchar(100)
          N'Nguyễn Đăng Tỉnh' , -- DisplayName - nvarchar(100)
          N'C8qiotBAbGg=' , -- PassWord - nvarchar(1000)   --  mã hóa thành :  33354741122871651676713774147412831195
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( Username ,
          DisplayName ,
          Password ,
          Type
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'ei0nosl3xbs=' , -- PassWord - nvarchar(1000)  -- mã hóa thành :  18833213210117723916811824913021616923162239
          0  -- Type - int  
        )

-- thêm bàn
DECLARE @i INT = 1;  -- 8
WHILE @i <= 6
BEGIN	
	INSERT dbo.TableFood(NameTable) VALUES ( N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END

-- thêm giờ chơi
INSERT dbo.PlayTime( MoneyPlayTime, StatusPlayTime ) VALUES  (20000,N'Không máy lạnh')
INSERT dbo.PlayTime( MoneyPlayTime, StatusPlayTime ) VALUES  (25000,N'Có máy lạnh')

-- thêm category
INSERT dbo.FoodCategory( NameCategory ) VALUES  ( N'Thuốc')
INSERT dbo.FoodCategory( NameCategory ) VALUES  ( N'Nước giải khác')
INSERT dbo.FoodCategory( NameCategory ) VALUES  ( N'Bia')
INSERT dbo.FoodCategory( NameCategory ) VALUES  ( N'Nướng')
INSERT dbo.FoodCategory( NameCategory ) VALUES  ( N'Kẹo')

-- thêm món ăn
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Prince',N'Gói',12000, 1)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Con ngựa',N'Gói',15000, 1)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Mực nướng',N'Con',12000, 4)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Cá bò nướng',N'Con',3000, 4)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Singum',N'Tép',5000, 5)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Cool air',N'Gói',1000, 5)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Pepsi',N'Chai',7000, 2)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Sting',N'Chai',8000, 2)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Larue',N'Chai',9000, 3)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Tiger',N'Lon',11000, 3)
INSERT dbo.Food( NameFood, Unit, Price, IDCategory) VALUES  ( N'Dunhill',N'Gói',20000,1 )

-- thêm bill
INSERT dbo.Bill( DateCheckIn ,DateCheckOut,Hour,Minute,StatusBill,TotalPrice, IDTable )
VALUES  ( GETDATE() , NULL ,2 , 30 ,0 , 0,1)
INSERT dbo.Bill( DateCheckIn ,DateCheckOut,Hour,Minute,StatusBill,TotalPrice, IDTable )
VALUES  ( GETDATE() , NULL ,1 , 10 ,0 , 0,2)
INSERT dbo.Bill( DateCheckIn ,DateCheckOut,Hour,Minute,StatusBill,TotalPrice, IDTable )
VALUES  ( GETDATE() , GETDATE() ,0 , 50 ,1 , 12000,3)
INSERT dbo.Bill( DateCheckIn ,DateCheckOut,Hour,Minute,StatusBill,TotalPrice, IDTable )
VALUES  ( GETDATE() , GETDATE() ,2 , 0 ,1 , 30000,4)

-- thêm bill info
INSERT dbo.BillInfo ( IDBill, IDFood, Count )
VALUES  ( 1, 1, 3 )
INSERT dbo.BillInfo ( IDBill, IDFood, Count )
VALUES  ( 2, 5, 4 )
INSERT dbo.BillInfo ( IDBill, IDFood, Count )
VALUES  ( 3, 4, 2 )
INSERT dbo.BillInfo ( IDBill, IDFood, Count )
VALUES  ( 4, 2, 2 )

-- thêm nợ

INSERT dbo.Debt( NameDebt ,Money ,StatusDebt ,IDBill)
VALUES  (N'Anh Bình' , -- NameDebt - nvarchar(100)
          20000 , -- Money - float
          N'Chưa trả nợ' , -- StatusDebt - nvarchar(100)
          3  -- IDBill - int
        )



CREATE PROC USP_Login -- 7
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username = @userName AND Password = @passWord
END
GO

CREATE PROC USP_CheckPasswordForChangeMoneyPlayTime -- 7
@password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Password = @password
END
GO

CREATE PROC USP_GetAccountByUsername --4
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username = @userName
END
GO


CREATE PROC USP_GetTableList -- 8
AS 
	SELECT * FROM dbo.TableFood
GO

CREATE PROC USP_InsertBill     -- 11
@idTable INT
AS
BEGIN
INSERT dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          Hour ,
          Minute ,
          StatusBill ,
          Discount ,
          TotalPrice ,
          IDTable
        )
VALUES  ( GETDATE() , -- DateCheckIn - datetime
          NULL , -- DateCheckOut - datetime
          0 , -- Hour - int
          0 , -- Minute - int
          0 , -- StatusBill - int
          0 , -- Discount - int
          0.0 , -- TotalPrice - float
          @idTable  -- IDTable - int
        )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @idExitBillInfo INT
	DECLARE @foodCount INT = 1
	SELECT @idExitBillInfo = b.IDBillInfo,@foodCount = b.Count 
	FROM dbo.BillInfo AS b 
	WHERE IDBill = @idBill AND IDFood = @idFood
	
	IF(@idExitBillInfo > 0) -- thức ăn có tồn tại
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE dbo.BillInfo SET Count = @foodCount + @count WHERE IDFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE IDBill = @idBill AND IDFood = @idFood
	END

	ELSE	
	BEGIN
		INSERT dbo.BillInfo
	        ( IDBill, IDFood, Count )
		VALUES  ( @idBill, -- idBill - int
	          @idFood, -- idFood - int
	          @count  -- count - int
	          )
	END
END
GO


-- trigger
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = IDBill FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = IDTable FROM dbo.Bill WHERE IDBill = @idBill AND StatusBill = 0

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE IDBill = @idBill
	IF(@count > 0)
	BEGIN
		PRINT @idTable
		PRINT @idBill
		PRINT @count

		UPDATE dbo.TableFood SET StatusTable = N'Đang đánh' WHERE IDTable = @idTable
	END
	
	ELSE

	BEGIN
		PRINT @idTable
		PRINT @idBill
		PRINT @count

		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IDTable = @idTable	
	END
		
END
GO


CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = IDBill FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = IDTable FROM dbo.Bill WHERE IDBill = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.Bill WHERE IDTable = @idTable AND StatusBill = 0

	IF (@count = 0)  -- không có bill nào hết
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IDTable = @idTable
END
GO



ALTER PROC USP_SwitchTable -- chuyển bàn
@idTable1 INT , @idTable2 INT
AS
BEGIN
	DECLARE @idFirstBill INT
	DECLARE  @idSecondBill INT

	DECLARE @isFirstTableEmty INT = 1
	DECLARE @isSecondTableEmty INT = 1 

	SELECT @idSecondBill = IDBill FROM dbo.Bill WHERE IDTable = @idTable2 AND StatusBill = 0
	SELECT @idFirstBill = IDBill FROM dbo.Bill WHERE IDTable = @idTable1 AND StatusBill = 0

	PRINT @idFirstBill
	PRINT @idSecondBill
	PRINT '-------------'

	IF (@idFirstBill IS NULL)  -- nếu null thì tạo ra thằng mới
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn,
		          DateCheckOut ,
		          Hour,
				  Minute,
				  StatusBill ,
		          Discount,
				  TotalPrice,
				  IDTable 
		        )
		VALUES  ( (SELECT DateCheckIn FROM dbo.Bill WHERE IDTable = @idTable2 AND StatusBill = 0) , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
					0,
					0,
					0 , -- status - int
					0,  -- discount - int
					0,
					@idTable1  -- idTable - int
		        )
		
		SELECT @idFirstBill =  MAX(IDBill) FROM dbo.Bill WHERE IDTable = @idTable1 AND StatusBill = 0
	END

	SELECT @isFirstTableEmty = COUNT(*) FROM dbo.BillInfo WHERE IDBill = @idFirstBill

	PRINT @idFirstBill
	PRINT @idSecondBill
	PRINT '-------------'

	IF (@idSecondBill IS NULL)  -- nếu null thì tạo ra thằng mới
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn,
		          DateCheckOut ,
				  Hour,
				  Minute,
				  StatusBill ,
		          Discount,
				  TotalPrice,
				  IDTable 
		        )
		VALUES  ( (SELECT DateCheckIn FROM dbo.Bill WHERE IDTable = @idTable1 AND StatusBill = 0) , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
					0,
					0,
					0 , -- status - int
					0,  -- discount - int
					0,
					@idTable2  -- idTable - int
		        )
		SELECT @idSecondBill =  MAX(IDBill) FROM dbo.Bill WHERE IDTable = @idTable2 AND StatusBill = 0
		
		
	END

	SELECT @isSecondTableEmty = COUNT(*) FROM dbo.BillInfo WHERE IDBill = @idSecondBill
	
	PRINT @idFirstBill
	PRINT @idSecondBill
	PRINT '-------------'

	SELECT IDBillInfo INTO IDBillInfoTable FROM dbo.BillInfo WHERE IDBill = @idSecondBill

	UPDATE dbo.BillInfo SET IDBill = @idSecondBill WHERE IDBill = @idFirstBill -- chuyển tất cả billInfo của thằng đầu tiên qua thằng thứ 2

	UPDATE dbo.BillInfo SET IDBill = @idFirstBill WHERE IDBillInfo IN (SELECT * FROM IDBillInfoTable) -- chuyển tất cả billInfo của thằng thứ 2  
																								-- qua thằng đầu tiền với điều kiện mặc định từ đầu
	DROP TABLE IDBillInfoTable

	IF (@isFirstTableEmty = 0)
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IDTable = @idTable2

	IF (@isSecondTableEmty = 0)
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IDTable = @idTable1
END
GO


CREATE PROC USP_GetListBillByDate
@day INT, @month INT, @year INT
AS
BEGIN
	SELECT t.NameTable  , DateCheckIn , DateCheckOut , b.Hour, b.Minute, Discount  ,b.TotalPrice , b.IDBill
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE b.StatusBill = 1 AND t.IDTable = b.IDTable AND 
	DAY(DateCheckOut) = @day AND MONTH(DateCheckOut) = @month AND YEAR(DateCheckOut) = @year
	ORDER BY b.DateCheckOut DESC
END
GO


CREATE TRIGGER UTP_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = Deleted.IDBillInfo, @idBill = IDBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = IDTable FROM dbo.Bill WHERE IDBill = @idBill
	
	DECLARE @count INT = 0;
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi , dbo.Bill AS b WHERE b.IDBill = bi.idBill AND b.IDBill = @idBill AND b.StatusBill = 0

	IF(@count = 0)
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IDTable = @idTable
END
GO

CREATE FUNCTION [dbo].[fChuyenCoDauThanhKhongDau](@inputVar NVARCHAR(MAX) ) -- chuyển chuỗi thành không dấu
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
GO

CREATE PROC USP_GetListBillByDateAndPage
@day INT, @month INT, @year INT, @page int, @rowOfPage int
AS
BEGIN
	DECLARE @pageRows INT = @rowOfPage
	DECLARE @selectRows INT = @pageRows 
	DECLARE @exceptRows INT = (@page - 1) * @pageRows

	;WITH BillShow AS ( SELECT t.NameTable  , DateCheckIn , DateCheckOut , b.Hour, b.Minute, Discount  ,b.TotalPrice , b.IDBill
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE b.StatusBill = 1 AND t.IDTable = b.IDTable AND 
	DAY(DateCheckOut) = @day AND MONTH(DateCheckOut) = @month AND YEAR(DateCheckOut) = @year )  

	SELECT TOP (@selectRows) * FROM BillShow WHERE IDBill NOT IN (SELECT TOP (@exceptRows) IDBill FROM BillShow ORDER BY DateCheckOut DESC ) ORDER BY DateCheckOut DESC
END
GO


CREATE PROC USP_GetNumBillByDate
@day INT, @month INT, @year INT
AS
BEGIN
	SELECT  COUNT(*) 
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DAY(DateCheckOut) = @day AND MONTH(DateCheckOut) = @month AND YEAR(DateCheckOut) = @year AND b.StatusBill = 1
	AND t.IDTable = b.IDTable
END
GO

CREATE PROC USP_UpdateAccountProfile
@userName NVARCHAR(100), @passwordNew NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Account SET Password = @passwordNew WHERE Username = @userName
END
GO

CREATE PROC USP_InsertFood
@nameFood NVARCHAR(100),@unit NVARCHAR(100),
@price FLOAT,@idCategory INT
AS
BEGIN
	INSERT dbo.Food( NameFood, Unit, Price, IDCategory )VALUES  ( @nameFood,@unit,@price,@idCategory)
END
GO

CREATE PROC USP_UpdateFood
@idFood INT, @nameFood NVARCHAR(100),@unit NVARCHAR(100),
@price FLOAT,@idCategory INT
AS
BEGIN
	UPDATE dbo.Food SET NameFood = @nameFood, Unit = @unit, Price = @price, IDCategory = @idCategory WHERE IDFood = @idFood
END
GO

ALTER PROC USP_SearchFoodByNameOrPrice
@nameFood NVARCHAR(100), @price FLOAT
AS
BEGIN
	SELECT * FROM dbo.Food WHERE dbo.fChuyenCoDauThanhKhongDau(NameFood) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@nameFood) + '%' OR Price = @price
END
GO

CREATE PROC USP_SearchFoodByName
@nameFood NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Food WHERE dbo.fChuyenCoDauThanhKhongDau(NameFood) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@nameFood) + '%' 
END
GO

CREATE PROC USP_InsertCategory
@nameCategory NVARCHAR(100)
AS
BEGIN
	INSERT dbo.FoodCategory( NameCategory ) VALUES  (@nameCategory)
END
GO

CREATE PROC USP_UpdateCategory
@idCategory INT, @nameCategory NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.FoodCategory SET NameCategory = @nameCategory WHERE IDCategory = @idCategory
END
GO

CREATE PROC USP_SearchCategory
@nameCategory NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.FoodCategory WHERE dbo.fChuyenCoDauThanhKhongDau(NameCategory) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@nameCategory) + '%' 
END
GO

CREATE PROC USP_InsertTable
@nameTable NVARCHAR(100)
AS
BEGIN
	INSERT dbo.TableFood( NameTable, StatusTable ) VALUES  ( @nameTable,N'Trống')
END
GO

CREATE PROC USP_UpdateTable
@idTable INT, @nameTable NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.TableFood SET NameTable = @nameTable WHERE IDTable = @idTable
END
GO

CREATE PROC USP_CheckAccount
@username NVARCHAR(100)
AS
BEGIN
	SELECT Username FROM dbo.Account WHERE Username = @username
END
GO

CREATE PROC USP_InsertAccount
@username NVARCHAR(100), @displayName NVARCHAR(100),
@password NVARCHAR(100), @type INT
AS
BEGIN
	INSERT dbo.Account( Username ,DisplayName ,Password ,Type) VALUES( @username ,@displayName , @password ,@type)
END
GO

ALTER PROC USP_CheckPasswordForUpdateAccount 
@password NVARCHAR(100)
AS
BEGIN
	SELECT Username FROM dbo.Account WHERE Password = @password AND Type = 1
END
GO

CREATE PROC USP_UpdateAccount
@username NVARCHAR(100), @displayName NVARCHAR(100), @type INT
AS
BEGIN
	UPDATE dbo.Account SET DisplayName = @displayName, Type = @type WHERE Username = @username
END
GO

CREATE PROC USP_DeleteAccount
@username NVARCHAR(100)
AS
BEGIN
	DELETE FROM dbo.Account WHERE Username = @username
END
GO

CREATE PROC USP_ResetPassword
@username NVARCHAR(100),@password NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Account SET Password = @password WHERE Username = @username
END
GO

CREATE PROC USP_SearchAccount
@displayName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE dbo.fChuyenCoDauThanhKhongDau(DisplayName) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@displayName) + '%' 
END
GO

CREATE PROC USP_SearchAccountByDisplayNameOrAdmin
@displayName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE dbo.fChuyenCoDauThanhKhongDau(DisplayName) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@displayName) + '%' OR Type = 1
END
GO

CREATE PROC USP_SearchAccountByDisplayNameOrStaff
@displayName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE dbo.fChuyenCoDauThanhKhongDau(DisplayName) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@displayName) + '%' OR Type = 0
END
GO

CREATE PROC USP_InsertDebt
@nameDebt NVARCHAR(100), @money FLOAT, @idBill INT
AS
BEGIN
	INSERT dbo.Debt( NameDebt, Money, StatusDebt, IDBill )VALUES  ( @nameDebt,@money,N'Chưa trả nợ',@idBill)
END
GO

CREATE PROC USP_UpdateDebt
@idDebt INT, @nameDebt NVARCHAR(100), @money FLOAT, @idBill INT
AS
BEGIN
	UPDATE dbo.Debt SET NameDebt = @nameDebt, Money = @money,IDBill = @idBill WHERE IDDebt = @idDebt
END
GO

CREATE PROC USP_DeleteDebt
@idDebt INT
AS
BEGIN
	DELETE FROM dbo.Debt WHERE IDDebt = @idDebt
END
GO


CREATE PROC USP_SearchDebt
@nameDebt NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Debt WHERE dbo.fChuyenCoDauThanhKhongDau(NameDebt) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@nameDebt) + '%' 
END
GO

CREATE PROC USP_SearchDebtByNameDebtOrMoney
@nameDebt NVARCHAR(100), @money FLOAT
AS
BEGIN
	SELECT * FROM dbo.Debt WHERE dbo.fChuyenCoDauThanhKhongDau(NameDebt) LIKE N'%' + dbo.fChuyenCoDauThanhKhongDau(@nameDebt) + '%' OR Money = @money
END
GO

CREATE PROC USP_InsertPlayTime
@moneyPlayTime FLOAT , @statusPlayTime NVARCHAR(100)
AS
BEGIN
	INSERT dbo.PlayTime( MoneyPlayTime, StatusPlayTime )VALUES  ( @moneyPlayTime,@statusPlayTime)
END
GO

CREATE PROC USP_UpdatePlayTime
@idPlayTime INT, @moneyPlayTime FLOAT , @statusPlayTime NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.PlayTime SET MoneyPlayTime = @moneyPlayTime, StatusPlayTime = @statusPlayTime WHERE IDPlayTime = @idPlayTime
END
GO

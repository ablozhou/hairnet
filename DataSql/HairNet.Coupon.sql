IF NOT EXISTS(SELECT TOP 1 * FROM sys.objects WHERE object_id = OBJECT_ID('Coupon') AND TYPE IN ('U'))
BEGIN
CREATE TABLE [dbo].[Coupon](
	[ID] [int] identity(1,1)  NOT NULL,
	[Name] [nvarchar](256) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
	[HairShopID] [int] NOT NULL,
	[Discount] [nvarchar](256) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
	[ExpiredDate] [nvarchar](32) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
	[PhoneNumber] [nvarchar](32) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
	[CouponTag] [nvarchar](1024) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
	[Description] [nvarchar](1024) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
	CONSTRAINT [PK_Coupon] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)
) ON [PRIMARY]

END
GO

IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('InsertCoupon') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE InsertCoupon
END
GO

CREATE PROCEDURE InsertCoupon
@ID int,
@Name nvarchar (256),
@HairShopID int,
@Discount nvarchar (256),
@ExpiredDate nvarchar (64),
@PhoneNumber nvarchar (32),
@CouponTag nvarchar (1024),
@Description nvarchar (1024)
AS
BEGIN
	INSERT INTO Coupon VALUES (
	@ID,
	@Name,
	@HairShopID,
	@Discount,
	@ExpiredDate,
	@PhoneNumber,
	@CouponTag,
	@Description )
END
GO

IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('UpdateCoupon') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE UpdateCoupon
END
GO

CREATE PROCEDURE UpdateCoupon
@ID int,
@Name nvarchar (256),
@HairShopID int,
@Discount nvarchar (256),
@ExpiredDate nvarchar (64),
@PhoneNumber nvarchar (32),
@CouponTag nvarchar (1024),
@Description nvarchar (1024)
AS
BEGIN
	UPDATE Coupon
	SET [Name] = @Name,
	HairShopID = @HairShopID,
	Discount = @Discount,
	ExpiredDate = @ExpiredDate,
	PhoneNumber = @PhoneNumber,
	CouponTag = @CouponTag,
	Description = @Description
	WHERE ID = @ID
END
GO

IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('DeleteCoupon') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE DeleteCoupon
END
GO

CREATE PROCEDURE DeleteCoupon
@ID int
AS
BEGIN
	DELETE FROM Coupon WHERE ID = @ID
END
GO

IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('QueryCoupon') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE QueryCoupon
END
GO

CREATE PROCEDURE QueryCoupon
@ID int
AS
BEGIN
	SELECT ID, [Name], HairShopID, Discount, ExpiredDate, PhoneNumber, CouponTag,Description
	FROM Coupon WHERE ID = @ID
END
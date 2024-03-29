--创建插入存储过程
IF EXISTS(SELECT TOP 1 * FROM sys.objects WHERE object_id = OBJECT_ID('InsertHairStyle') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE InsertHairStyle
END
GO

CREATE PROCEDURE InsertHairStyle
@ID int,
@HairName varchar (1024),
@HairStyle tinyint,
@FaceStyle tinyint,
@Temperament tinyint,
@Occasion tinyint,
@Sex tinyint,
@BigPic varchar (1024),
@SmallPic_F varchar (1024),
@SmallPic_B varchar (1024),
@SmallPic_S varchar (1024),
@Pic1 text,
@Pic2 text,
@Pic3 text,
@HairShopID int,
@HairEngineerID int,
@HairQuantity tinyint,
@HairNature tinyint,
@Color tinyint,
@CreateTime datetime,
@BBSURL varchar (1024),
@Good int,
@Nomarl int,
@Bad int,
@Tag varchar (1024) 
AS
BEGIN
	INSERT INTO HairStyle VALUES (
		@HairName,
		@HairStyle,
		@FaceStyle,
		@Temperament,
		@Occasion,
		@Sex,
		@BigPic,
		@SmallPic_F,
		@SmallPic_B,
		@SmallPic_S,
		@Pic1,
		@Pic2,
		@Pic3,
		@HairShopID ,
		@HairEngineerID ,
		@HairQuantity,
		@HairNature,
		@Color,
		@CreateTime,
		@BBSURL,
		@Good ,
		@Nomarl ,
		@Bad ,
		@Tag )
END
GO

--创建删除存储过程
IF EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('DeleteHairStyle') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE DeleteHairStyle
END
GO

CREATE PROCEDURE DeleteHairStyle
@ID int
AS
BEGIN
	DELETE FROM HairStyle WHERE ID = @ID
END
GO

--创建更新存储过程
IF EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('UpdateHairStyle') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE UpdateHairStyle
END
GO

CREATE PROCEDURE UpdateHairStyle
@ID int,
@HairName varchar (1024),
@HairStyle tinyint,
@FaceStyle tinyint,
@Temperament tinyint,
@Occasion tinyint,
@Sex tinyint,
@BigPic varchar (1024),
@SmallPic_F varchar (1024),
@SmallPic_B varchar (1024),
@SmallPic_S varchar (1024),
@Pic1 text,
@Pic2 text,
@Pic3 text,
@HairShopID int,
@HairEngineerID int,
@HairQuantity tinyint,
@HairNature tinyint,
@Color tinyint,
@CreateTime datetime,
@BBSURL varchar (1024),
@Good int,
@Nomarl int,
@Bad int,
@Tag varchar (1024) 
AS
BEGIN
	UPDATE HairStyle 
	SET 
		HairName = @HairName,
		HairStyle = @HairStyle,
		FaceStyle = @FaceStyle,
		Temperament = @Temperament,
		Occasion = @Occasion,
		Sex = @Sex,
		BigPic = @BigPic,
		SmallPic_F = @SmallPic_F,
		SmallPic_B = @SmallPic_B,
		SmallPic_S = @SmallPic_S,
		Pic1 = @Pic1,
		Pic2 = @Pic2,
		Pic3 = @Pic3,
		HairShopID = @HairShopID ,
		HairEngineerID = @HairEngineerID ,
		HairQuantity = @HairQuantity,
		HairNature = @HairNature,
		Color = @Color,
		CreateTime = @CreateTime,
		BBSURL = @BBSURL,
		Good = @Good ,
		Nomarl = @Nomarl ,
		Bad = @Bad ,
		Tag = @Tag 
	WHERE ID = @ID
END
GO

--创建获取数据存储过程
IF EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('QueryHairStyle') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE QueryHairStyle
END
GO

CREATE PROCEDURE QueryHairStyle
@ID int
AS
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,BigPic,SmallPic_F,SmallPic_B,SmallPic_S,Pic1,Pic2,Pic3,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Nomarl ,Bad ,Tag 
	FROM HairStyle
	WHERE ID = @ID
	ORDER BY ID DESC

END
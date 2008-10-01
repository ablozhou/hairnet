--创建EngineerOpus表
IF NOT EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('EngineerOpus') AND TYPE IN ('U'))
BEGIN

	CREATE TABLE [dbo].[EngineerOpus](
		[ID] [int] IDENTITY(1,1) NOT NULL,
		[EngineerID] [int] NOT NULL,
		[OpusName] [nvarchar](64) COLLATE Chinese_PRC_90_CI_AS NOT NULL,
		[FrontSidePic] [nvarchar](64) COLLATE Chinese_PRC_90_CI_AS NULL,
		[FlankSidePic] [nvarchar](64) COLLATE Chinese_PRC_90_CI_AS NULL,
		[BackSidePic] [nvarchar](64) COLLATE Chinese_PRC_90_CI_AS NULL,
		[AssistancePic] [nvarchar](64) COLLATE Chinese_PRC_90_CI_AS NULL,
		[HairStyle] [int] NOT NULL,
		[FaceStyle] [int] NOT NULL,
		[HairType] [int] NOT NULL,
		[HairItem] [int] NOT NULL,
		[Description] [nvarchar](2048) COLLATE Chinese_PRC_90_CI_AS NULL
	) ON [PRIMARY]

END
GO

--创建插入存储过程
IF EXISTS(SELECT TOP 1 * FROM sys.objects WHERE object_id = OBJECT_ID('InsertEngineerOpus') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE InsertEngineerOpus
END
GO

CREATE PROCEDURE InsertEngineerOpus
@EngineerID int,
@OpusName nvarchar(64),
@FrontSidePic nvarchar(64),
@FlankSidePic nvarchar(64),
@BackSidePic nvarchar(64),
@AssistancePic nvarchar(64),
@HairStyle int,
@FaceStyle int,
@HairType int,
@HairItem int,
@Description nvarchar(2048)
AS
BEGIN
	INSERT INTO EngineerOpus VALUES (
	@EngineerID,
	@OpusName,
	@FrontSidePic,
	@FlankSidePic,
	@BackSidePic,
	@AssistancePic,
	@HairStyle,
	@FaceStyle,
	@HairType,
	@HairItem,
	@Description )
END
GO

--创建删除存储过程
IF EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('DeleteEngineerOpus') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE DeleteEngineerOpus
END
GO

CREATE PROCEDURE DeleteEngineerOpus
@ID int
AS
BEGIN
	DELETE FROM EngineerOpus WHERE ID = @ID
END
GO

--创建更新存储过程
IF EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('UpdateEngineerOpus') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE UpdateEngineerOpus
END
GO

CREATE PROCEDURE UpdateEngineerOpus
@ID int,
@EngineerID int,
@OpusName nvarchar(64),
@FrontSidePic nvarchar(64),
@FlankSidePic nvarchar(64),
@BackSidePic nvarchar(64),
@AssistancePic nvarchar(64),
@HairStyle int,
@FaceStyle int,
@HairType int,
@HairItem int,
@Description nvarchar(2048)
AS
BEGIN
	UPDATE EngineerOpus 
	SET 
	EngineerID = @EngineerID,
	OpusName = @OpusName,
	FrontSidePic = @FrontSidePic,
	FlankSidePic = @FlankSidePic,
	BackSidePic = @BackSidePic,
	AssistancePic = @AssistancePic,
	HairStyle = @HairStyle,
	FaceStyle = @FaceStyle,
	HairType = @HairType,
	HairItem = @HairItem,
	Description = @Description
	WHERE ID = @ID
END
GO

--创建获取数据存储过程
IF EXISTS(SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID('QueryEngineerOpus') AND TYPE IN ('P'))
BEGIN
	DROP PROCEDURE QueryEngineerOpus
END
GO

CREATE PROCEDURE QueryEngineerOpus
@EngineerID int
AS
BEGIN
	SELECT 	ID, EngineerID, OpusName, FrontSidePic, FlankSidePic, BackSidePic, AssistancePic, 
			HairStyle, FaceStyle, HairType, HairItem, Description
	FROM EngineerOpus
	WHERE EngineerID = @EngineerID

END
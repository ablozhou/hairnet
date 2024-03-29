SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Coupon]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Coupon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[HairShopID] [int] NOT NULL,
	[Discount] [nvarchar](256) NULL,
	[ExpiredDate] [nvarchar](32) NULL,
	[PhoneNumber] [nvarchar](32) NULL,
	[CouponTag] [nvarchar](1024) NULL,
	[Description] [nvarchar](1024) NULL,
	[ImageUrl] [varchar](1024) NULL,
	[CreateDate] [datetime] NULL,
	[HitNum] [int] NULL CONSTRAINT [DF_Coupon_HitNum]  DEFAULT (0),
	[postid] [int] NULL CONSTRAINT [DF_Coupon_postid]  DEFAULT (0),
	[ImageSmallUrl] [varchar](1024) NULL,
 CONSTRAINT [PK_Coupon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStoreGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStoreGroup](
	[PictureStoreGroupID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreGroupName] [varchar](100) NOT NULL,
	[PictureStoreGroupParentID] [int] NULL,
	[PictureStoreIDs] [varchar](8000) NULL,
	[AddTime] [datetime] NULL CONSTRAINT [DF_PictureStoreGroup_AddTime]  DEFAULT (getdate()),
	[postid] [int] NULL CONSTRAINT [DF_PictureStoreGroup_postid]  DEFAULT (0),
 CONSTRAINT [PK_PictureStoreGroup] PRIMARY KEY CLUSTERED 
(
	[PictureStoreGroupID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairEngineer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairEngineer](
	[HairEngineerID] [int] IDENTITY(1,1) NOT NULL,
	[HairEngineerAge] [varchar](100) NULL,
	[HairEngineerName] [varchar](100) NOT NULL,
	[HairEngineerSex] [tinyint] NULL,
	[HairShopID] [int] NOT NULL,
	[HairEngineerYear] [varchar](100) NULL,
	[HairEngineerSkill] [varchar](100) NULL,
	[HairEngineerTagIDs] [varchar](1024) NULL,
	[HairEngineerPictureStoreIDs] [varchar](1024) NULL CONSTRAINT [DF_HairEngineer_HairEngineerPictureStoreIDs]  DEFAULT (''),
	[HairEngineerHits] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerHits]  DEFAULT (0),
	[HairEngineerDescription] [text] NULL,
	[HairEngineerRawPrice] [varchar](100) NULL,
	[HairEngineerTel] [varchar](100) NULL,
	[HairEngineerGood] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerGood]  DEFAULT (0),
	[HairEngineerBad] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerBad]  DEFAULT (0),
	[HairEngineerClassID] [varchar](1024) NULL,
	[HairEngineerConstellation] [varchar](64) NULL,
	[IsImportant] [bit] NULL,
	[HairEngineerPhotoIDs] [varchar](1024) NULL CONSTRAINT [DF_HairEngineer_HairEngineerPhotoIDs]  DEFAULT (''),
	[HairEngineerNormal] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerNormal]  DEFAULT (0),
	[postid] [int] NULL CONSTRAINT [DF_HairEngineer_postid]  DEFAULT (0),
 CONSTRAINT [PK_HairEngineer] PRIMARY KEY CLUSTERED 
(
	[HairEngineerID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'领军人物' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'HairEngineer', @level2type=N'COLUMN', @level2name=N'IsImportant'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairEngineerRecommand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairEngineerRecommand](
	[HairEngineerRecommandID] [int] IDENTITY(1,1) NOT NULL,
	[HairEngineerRawID] [int] NOT NULL,
	[HairEngineerName] [varchar](100) NOT NULL,
	[HairEngineerAge] [varchar](100) NOT NULL,
	[HairEngineerSex] [tinyint] NOT NULL,
	[HairEngineerPhoto] [varchar](1024) NOT NULL,
	[HairShopID] [int] NOT NULL,
	[HairEngineerYear] [varchar](100) NULL,
	[HairEngineerSkill] [varchar](100) NULL,
	[HairEngineerTagIDs] [varchar](1024) NULL,
	[HairEngineerPictureStoreIDs] [varchar](1024) NULL,
	[HairEngineerDescription] [text] NULL,
	[HairEngineerRawPrice] [varchar](100) NULL,
	[HairEngineerPrice] [varchar](100) NULL,
	[HairEngineerClassID] [varchar](1024) NULL,
	[HairEngineerRecommandEx] [text] NULL,
	[HairEngineerRecommandInfo] [text] NULL,
 CONSTRAINT [PK_HairEngineerRecommand] PRIMARY KEY CLUSTERED 
(
	[HairEngineerRecommandID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hairstyle]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hairstyle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hairname] [varchar](100) NOT NULL,
	[hairstyle] [tinyint] NULL,
	[facestyle] [tinyint] NULL,
	[temperament] [tinyint] NULL,
	[occasion] [tinyint] NULL,
	[sex] [tinyint] NULL,
	[hairshopid] [int] NULL,
	[hairengineerid] [int] NULL,
	[hairquantity] [tinyint] NULL,
	[hairnature] [tinyint] NULL,
	[color] [tinyint] NULL,
	[createtime] [datetime] NULL,
	[bbsurl] [varchar](1024) NULL,
	[good] [int] NULL,
	[normal] [int] NULL,
	[bad] [int] NULL,
	[tag] [varchar](1024) NULL,
	[savenum] [int] NULL,
	[hitnum] [int] NULL,
	[descr] [varchar](1024) NULL,
	[picturestoreid] [int] NULL,
	[psgids] [varchar](1024) NULL,
	[IsHairStyle] [bit] NULL,
	[postid] [int] NULL
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'长短中直卷' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'hairstyle', @level2type=N'COLUMN', @level2name=N'hairstyle'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发量' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'hairstyle', @level2type=N'COLUMN', @level2name=N'hairquantity'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发质' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'hairstyle', @level2type=N'COLUMN', @level2name=N'hairnature'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[temperament]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[temperament](
	[id] [int] NOT NULL,
	[temperament] [varchar](100) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](100) NOT NULL,
	[CityVisible] [bit] NOT NULL CONSTRAINT [DF_City_CityVisible]  DEFAULT (1),
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairShopTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairShopTag](
	[HairShopTagID] [int] IDENTITY(1,1) NOT NULL,
	[HairShopTagName] [varchar](100) NOT NULL,
	[HairShopIDs] [varchar](1024) NULL,
	[TagCount] [int] NULL CONSTRAINT [DF_HairShopTag_TagCount]  DEFAULT (0),
 CONSTRAINT [PK_HairShopTag] PRIMARY KEY CLUSTERED 
(
	[HairShopTagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairEngineerTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairEngineerTag](
	[HairEngineerTagID] [int] IDENTITY(1,1) NOT NULL,
	[HairEngineerTagName] [varchar](100) NOT NULL,
	[HairEngineerIDs] [varchar](1024) NULL,
	[TagCount] [int] NULL CONSTRAINT [DF_HairEngineerTag_TagCount]  DEFAULT (0),
 CONSTRAINT [PK_HairEngineerTag] PRIMARY KEY CLUSTERED 
(
	[HairEngineerTagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairShop]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairShop](
	[HairShopID] [int] IDENTITY(1,1) NOT NULL,
	[HairShopName] [varchar](100) NOT NULL,
	[HairShopCityID] [int] NOT NULL,
	[HairShopMapZoneID] [int] NOT NULL,
	[HairShopHotZoneID] [int] NOT NULL,
	[HairShopAddress] [varchar](100) NOT NULL,
	[HairShopPhoneNum] [varchar](100) NOT NULL,
	[HairShopEngineerNum] [int] NULL,
	[HairShopOpenTime] [varchar](1024) NULL,
	[HairShopVisitNum] [int] NULL CONSTRAINT [DF_HairShop_HairShopVisitNum]  DEFAULT (0),
	[HairShopWebSite] [varchar](1024) NULL,
	[HairShopEmail] [varchar](1024) NULL,
	[HairshopDiscount] [varchar](100) NULL,
	[HairShopLogo] [varchar](1024) NULL,
	[HairShopCreateTime] [varchar](100) NULL,
	[HairShopDescription] [text] NULL,
	[ProductIDs] [varchar](1024) NULL,
	[HairShopTagIDs] [varchar](1024) NULL,
	[HairShopShortName] [varchar](100) NULL,
	[IsJoin] [bit] NULL,
	[TypeID] [int] NULL,
	[IsPostStation] [bit] NULL,
	[IsPostMachine] [bit] NULL,
	[HairShopGood] [int] NULL CONSTRAINT [DF_HairShop_HairShopGood]  DEFAULT (0),
	[HairShopBad] [int] NULL CONSTRAINT [DF_HairShop_HairShopBad]  DEFAULT (0),
	[HairCutPrice] [int] NULL,
	[HairMarcelPrice] [int] NULL,
	[HairDyePrice] [int] NULL,
	[HairShapePrice] [int] NULL,
	[HairConservationPrice] [int] NULL,
	[HairCutDiscount] [int] NULL,
	[HairMarcelDiscount] [int] NULL,
	[HairDyeDiscount] [int] NULL,
	[HairShapeDiscount] [int] NULL,
	[HairConservationDiscount] [int] NULL,
	[LocationMapURL] [varchar](1024) NULL,
	[Square] [int] NULL,
	[IsServeMarcel] [bit] NULL,
	[IsServeDye] [bit] NULL,
	[IsServeHairCut] [bit] NULL,
	[MemberInfo] [varchar](200) NULL,
	[OutLogs] [varchar](200) NULL CONSTRAINT [DF_HairShop_OutLogs]  DEFAULT (''),
	[InnerLogs] [varchar](200) NULL CONSTRAINT [DF_HairShop_InnerLogs]  DEFAULT (''),
	[CouponNum] [int] NULL CONSTRAINT [DF_HairShop_CouponNum]  DEFAULT (0),
	[postid] [int] NULL,
	[HairShopNormal] [int] NULL CONSTRAINT [DF_HairShop_HairShopNormal]  DEFAULT (0),
	[TravelInfo] [varchar](1024) NULL CONSTRAINT [DF_HairShop_TravelInfo]  DEFAULT (''),
	[HairConservationPriceMin] [int] NULL CONSTRAINT [DF_HairShop_HairConservationPriceMin]  DEFAULT (0),
	[HairCutPriceMin] [int] NULL CONSTRAINT [DF_HairShop_HairCutPriceMin]  DEFAULT (0),
	[HairDyePriceMin] [int] NULL CONSTRAINT [DF_HairShop_HairDyePriceMin]  DEFAULT (0),
	[HairMarcelPriceMin] [int] NULL CONSTRAINT [DF_HairShop_HairMarcelPriceMin]  DEFAULT (0),
	[HairShapePriceMin] [int] NULL CONSTRAINT [DF_HairShop_HairShapePriceMin]  DEFAULT (0),
 CONSTRAINT [PK_HairShop] PRIMARY KEY CLUSTERED 
(
	[HairShopID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairShopRecommand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairShopRecommand](
	[HairShopRecommandID] [int] IDENTITY(1,1) NOT NULL,
	[HairShopRawID] [int] NOT NULL,
	[HairShopName] [varchar](100) NOT NULL,
	[HairShopCityID] [int] NOT NULL,
	[HairShopMapZoneID] [int] NOT NULL,
	[HairShopHotZoneID] [int] NOT NULL,
	[HairShopAddress] [varchar](100) NOT NULL,
	[HairShopPhoneNum] [varchar](100) NOT NULL,
	[HairShopPictureStoreIDs] [varchar](1024) NOT NULL,
	[HairShopMainIDs] [varchar](1024) NULL,
	[HairShopPartialIDs] [varchar](1024) NULL,
	[HairShopEngineerNum] [int] NULL,
	[HairShopOpenTime] [varchar](1024) NULL,
	[WorkRangeIDs] [varchar](1024) NULL,
	[HairShopWebSite] [varchar](1024) NULL,
	[HairShopEmail] [varchar](1024) NULL,
	[HairShopDiscount] [varchar](100) NULL,
	[HairShopLogo] [varchar](1024) NULL,
	[HairShopCreateTime] [varchar](100) NULL,
	[HairShopDescription] [text] NULL,
	[ProductIDs] [varchar](1024) NULL,
	[HairShopTagIDs] [varchar](1024) NULL,
	[HairShopShortName] [varchar](100) NULL,
	[IsBest] [bit] NULL CONSTRAINT [DF_HairShopRecommand_IsBest]  DEFAULT (0),
	[IsJoin] [bit] NULL CONSTRAINT [DF_HairShopRecommand_IsJoin]  DEFAULT (0),
	[TypeID] [int] NULL,
	[IsPostStation] [bit] NULL CONSTRAINT [DF_HairShopRecommand_IsPostStation]  DEFAULT (0),
	[IsPostMachine] [bit] NULL CONSTRAINT [DF_HairShopRecommand_IsPostMachine]  DEFAULT (0),
	[HairShopRecommandEx] [text] NULL,
	[HairShopRecommandInfo] [text] NULL,
 CONSTRAINT [PK_HairShopRecommand] PRIMARY KEY CLUSTERED 
(
	[HairShopRecommandID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[History]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[History](
	[HistoryID] [int] IDENTITY(1,1) NOT NULL,
	[ChannelID] [int] NOT NULL,
	[HistoryCreateTime] [datetime] NOT NULL CONSTRAINT [DF_History_HistoryCreateTime]  DEFAULT (getdate()),
	[HistoryUrl] [varchar](1024) NOT NULL,
	[ProductName] [varchar](100) NOT NULL,
	[HistoryAction] [varchar](100) NOT NULL,
	[UserID] [int] NOT NULL,
	[HistorySummary] [varchar](1024) NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[HistoryID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MapZone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MapZone](
	[MapZoneID] [int] IDENTITY(1,1) NOT NULL,
	[MapZoneName] [varchar](100) NOT NULL,
	[MapZoneVisible] [bit] NOT NULL CONSTRAINT [DF_MapZone_MapZoneVisible]  DEFAULT (1),
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_MapZone] PRIMARY KEY CLUSTERED 
(
	[MapZoneID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[subsemail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[subsemail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[shopid] [int] NULL,
	[classid] [int] NULL,
	[descr] [varchar](200) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStoreRecommand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStoreRecommand](
	[PictureStoreRecommandID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreRawID] [int] NULL,
	[PictureStoreName] [varchar](100) NULL,
	[PictureStoreRawUrl] [varchar](1024) NULL,
	[PictureStoreLittleUrl] [varchar](1024) NULL,
	[PictureStoreTagIDs] [varchar](1024) NULL,
	[PictureStoreDescription] [text] NULL,
	[HairEngineerIDs] [varchar](1024) NULL,
	[HairShopIDs] [varchar](1024) NULL,
	[PictureStoreCreateTime] [datetime] NULL,
	[PictureStoreGroupIDs] [varchar](1024) NULL,
	[PictureStoreRecommandEx] [text] NULL,
	[PictureStoreRecommandInfo] [text] NULL,
 CONSTRAINT [PK_PictureStoreRecommand] PRIMARY KEY CLUSTERED 
(
	[PictureStoreRecommandID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStoreTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStoreTag](
	[PictureStoreTagID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreTagName] [varchar](100) NOT NULL,
	[PictureStoreIDs] [varchar](1024) NULL,
	[TagCount] [int] NULL CONSTRAINT [DF_PictureStoreTag_TagCount]  DEFAULT (0),
 CONSTRAINT [PK_PictureStoreTag] PRIMARY KEY CLUSTERED 
(
	[PictureStoreTagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NULL,
	[ProductCompany] [varchar](100) NULL,
	[ProductCompanyDescription] [text] NULL,
	[ProductPictureStoreIDs] [varchar](1024) NULL,
	[ProductHits] [int] NULL CONSTRAINT [DF_Product_ProductHits]  DEFAULT (0),
	[ProductDescription] [text] NULL,
	[HairShopIDs] [varchar](1024) NULL,
	[ProductRawPrice] [varchar](100) NULL,
	[ProductPrice] [varchar](100) NULL,
	[ProductDiscount] [varchar](100) NULL,
	[ProductTagIDs] [varchar](1024) NULL,
	[postid] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[enginpics]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[enginpics](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[picurl] [varchar](1024) NULL,
	[ownerid] [int] NULL,
	[classid] [int] NULL,
	[picsmallurl] [varchar](1024) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[shoppics]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[shoppics](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[picurl] [varchar](1024) NULL,
	[hairshopID] [int] NULL,
	[classid] [int] NULL,
	[picsmallurl] [varchar](1024) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HotZone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HotZone](
	[HotZoneID] [int] IDENTITY(1,1) NOT NULL,
	[HotZoneName] [varchar](100) NOT NULL,
	[HotZoneVisible] [bit] NOT NULL CONSTRAINT [DF_HotZone_HotZoneVisible]  DEFAULT (1),
	[MapZoneID] [int] NULL CONSTRAINT [DF_HotZone_MapZoneID]  DEFAULT (1),
 CONSTRAINT [PK_HotZone] PRIMARY KEY CLUSTERED 
(
	[HotZoneID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[occasion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[occasion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[occasion] [varchar](100) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[facestyle]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[facestyle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[facestylename] [varchar](100) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hairstyleclassname]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hairstyleclassname](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hairstyleclassname] [varchar](100) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hairquantity]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hairquantity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hairquantity] [varchar](50) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hairnature]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hairnature](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hairnature] [varchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserBasicInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserBasicInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[FindPassQus] [varchar](100) NULL,
	[FindPassAsw] [varchar](100) NULL,
	[ActivatedIDS] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Integral] [int] NULL,
	[UserRoleID] [int] NOT NULL,
	[IsActive] [bit] NULL CONSTRAINT [DF_UserBasicInfo_IsActive]  DEFAULT (1),
 CONSTRAINT [PK_UserBasicInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[comment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[comment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[good] [int] NULL,
	[normal] [int] NULL,
	[bad] [int] NULL,
	[other] [int] NULL,
	[ownerid] [int] NULL,
	[classname] [varchar](50) NULL,
	[commentobject] [varchar](200) NULL,
	[description] [varchar](200) NULL
) ON [PRIMARY]
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'评论类别，如形象，服务' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'comment', @level2type=N'COLUMN', @level2name=N'classname'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'评价对象，如美发厅，美发师，发型' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'comment', @level2type=N'COLUMN', @level2name=N'commentobject'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModelList]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ModelList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sex] [varchar](6) NULL CONSTRAINT [DF_ModelList_sex]  DEFAULT ('female'),
	[facestyle] [int] NULL CONSTRAINT [DF_ModelList_facestyle]  DEFAULT (1),
	[bigurl] [varchar](200) NULL CONSTRAINT [DF_ModelList_bigurl]  DEFAULT (''),
	[thumburl] [varchar](200) NULL CONSTRAINT [DF_ModelList_thumburl]  DEFAULT (''),
	[flag] [tinyint] NULL CONSTRAINT [DF_ModelList_flag]  DEFAULT (1),
	[createtime] [smalldatetime] NULL CONSTRAINT [DF_ModelList_createtime]  DEFAULT (getdate()),
	[ModelName] [varchar](50) NULL CONSTRAINT [DF_ModelList_ModelName]  DEFAULT ('')
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductRecommand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProductRecommand](
	[ProductRecommandID] [int] IDENTITY(1,1) NOT NULL,
	[ProductRawID] [int] NOT NULL,
	[ProductName] [varchar](100) NULL,
	[ProductCompany] [varchar](100) NULL,
	[ProductCompanyDescription] [text] NULL,
	[ProductPictureStoreIDs] [varchar](1024) NULL,
	[ProductDescription] [text] NULL,
	[HairShopIDs] [varchar](1024) NULL,
	[ProductRawPrice] [varchar](100) NULL,
	[ProductPrice] [varchar](100) NULL,
	[ProductDiscount] [varchar](100) NULL,
	[ProductTagIDs] [varchar](1024) NULL,
	[ProductRecommandEx] [text] NULL,
	[ProductRecommandInfo] [text] NULL,
 CONSTRAINT [PK_ProductRecommand] PRIMARY KEY CLUSTERED 
(
	[ProductRecommandID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProductTag](
	[ProductTagID] [int] IDENTITY(1,1) NOT NULL,
	[ProductTagName] [varchar](100) NOT NULL,
	[ProductIDs] [varchar](1024) NULL,
	[TagCount] [int] NULL CONSTRAINT [DF_ProductTag_TagCount]  DEFAULT (0),
 CONSTRAINT [PK_ProductTag] PRIMARY KEY CLUSTERED 
(
	[ProductTagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Table1]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Table1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[asdf] [char](10) NULL CONSTRAINT [DF_Table1_asdf]  DEFAULT ('asdf'),
	[sd] [int] NULL CONSTRAINT [DF_Table1_sd]  DEFAULT ((-1))
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeTable]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TypeTable](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](100) NOT NULL,
	[TypeVisible] [bit] NOT NULL CONSTRAINT [DF_TypeTable_TypeVisible]  DEFAULT (1),
 CONSTRAINT [PK_TypeTable] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStore]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStore](
	[PictureStoreID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreName] [varchar](100) NOT NULL,
	[PictureStoreTagIDs] [varchar](1024) NULL,
	[PictureStoreDescription] [text] NULL,
	[PictureStoreCreateTime] [datetime] NOT NULL CONSTRAINT [DF_PictureStore_PictureStoreCreateTime]  DEFAULT (getdate()),
	[PictureStoreGroupIDs] [varchar](1024) NULL,
 CONSTRAINT [PK_PictureStore] PRIMARY KEY CLUSTERED 
(
	[PictureStoreID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserRole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserRole](
	[UserRoleID] [int] IDENTITY(1,1) NOT NULL,
	[UserRoleName] [varchar](100) NOT NULL,
	[UserRoleIsVisible] [bit] NOT NULL CONSTRAINT [DF_UserRole_UserRoleIsVisible]  DEFAULT (1),
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStoreSet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStoreSet](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreId] [int] NOT NULL,
	[PictureStoreURL] [varchar](1024) NULL,
	[IsHairStyle] [bit] NULL,
	[HairStylePos] [int] NULL,
	[SmallPictureUrl] [varchar](1024) NULL,
 CONSTRAINT [PK_PictureStoreSet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteCoupon]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[DeleteCoupon]
@ID int
AS
BEGIN
	DELETE FROM Coupon WHERE ID = @ID
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QueryCoupon]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[QueryCoupon]
@ID int
AS
BEGIN
	SELECT ID, [Name], HairShopID, Discount, ExpiredDate, PhoneNumber, CouponTag,Description,ImageUrl,PostID,ImageSmallUrl,HitNum,CreateDate
	FROM Coupon WHERE ID = @ID
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertCoupon]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[InsertCoupon]
@ID int,
@Name nvarchar (256),
@HairShopID int,
@Discount nvarchar (256),
@ExpiredDate nvarchar (64),
@PhoneNumber nvarchar (32),
@CouponTag nvarchar (1024),
@Description nvarchar (1024),
@ImageUrl varchar (1024),
@PostID int,
@ImageSmallUrl varchar(1024)
AS
BEGIN
	INSERT INTO Coupon VALUES (
	
	@Name,
	@HairShopID,
	@Discount,
	@ExpiredDate,
	@PhoneNumber,
	@CouponTag,
	@Description ,@ImageUrl,getDate(),0,@PostID,@ImageSmallUrl)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCoupon]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[UpdateCoupon]
@ID int,
@Name nvarchar (256),
@HairShopID int,
@Discount nvarchar (256),
@ExpiredDate nvarchar (64),
@PhoneNumber nvarchar (32),
@CouponTag nvarchar (1024),
@Description nvarchar (1024),
@ImageUrl varchar (1024),
@ImageSmallUrl varchar(1024)
AS
BEGIN
	UPDATE Coupon
	SET [Name] = @Name,
	HairShopID = @HairShopID,
	Discount = @Discount,
	ExpiredDate = @ExpiredDate,
	PhoneNumber = @PhoneNumber,
	CouponTag = @CouponTag,
	Description = @Description,
	ImageUrl = @ImageUrl,
	ImageSmallUrl = @ImageSmallUrl
	WHERE ID = @ID
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateHairStyle]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[UpdateHairStyle]
@ID int,
@HairName varchar (1024),
@HairStyle tinyint,
@FaceStyle tinyint,
@Temperament tinyint,
@Occasion tinyint,
@Sex tinyint,
@HairShopID int,
@HairEngineerID int,
@HairQuantity tinyint,
@HairNature tinyint,
@Color tinyint,
@CreateTime datetime,
@BBSURL varchar (1024),
@Good int,
@Normal int,
@Bad int,
@Tag varchar (1024),
@Description varchar(1024),
@Picturestoreid int,
@psgids varchar(1024),
@IsHairStyle bit,
@PostID int
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
		HairShopID = @HairShopID ,
		HairEngineerID = @HairEngineerID ,
		HairQuantity = @HairQuantity,
		HairNature = @HairNature,
		Color = @Color,
		CreateTime = @CreateTime,
		BBSURL = @BBSURL,
		Good = @Good ,
		Normal = @Normal ,
		Bad = @Bad ,
		Tag = @Tag ,
		Descr = @Description,
		PicturestoreID= @PicturestoreID,
		psgids = @psgids,
		IsHairStyle = @IsHairStyle,
		PostID = @PostID
		
	WHERE ID = @ID
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteHairStyle]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[DeleteHairStyle]
@ID int
AS
BEGIN
	DELETE FROM HairStyle WHERE ID = @ID
END
' 
END
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QueryHairStyle1]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[QueryHairStyle1]


AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag,postID,psgids,ishairstyle,picturestoreid,descr 
	FROM HairStyle
	ORDER BY ID DESC

END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertHairStyle]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[InsertHairStyle]
@ID int,
@HairName varchar (1024),
@HairStyle tinyint,
@FaceStyle tinyint,
@Temperament tinyint,
@Occasion tinyint,
@Sex tinyint,
@HairShopID int,
@HairEngineerID int,
@HairQuantity tinyint,
@HairNature tinyint,
@Color tinyint,
@CreateTime datetime,
@BBSURL varchar (1024),
@Good int,
@Normal int,
@Bad int,
@Tag varchar (1024) ,
@Description varchar(1024),
@Picturestoreid int,
@psgids varchar(1024),
@IsHairStyle bit,
@PostID int
AS
BEGIN
	INSERT INTO HairStyle VALUES (
		@HairName,
		@HairStyle,
		@FaceStyle,
		@Temperament,
		@Occasion,
		@Sex,
		@HairShopID ,
		@HairEngineerID ,
		@HairQuantity,
		@HairNature,
		@Color,
		@CreateTime,
		@BBSURL,
		@Good ,
		@Normal ,
		@Bad ,
		@Tag ,0,0,@Description,@PictureStoreID,@psgids,@IsHairStyle,@PostID)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QueryHairStyleByEngineerID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[QueryHairStyleByEngineerID]
@HairEngineerID int

AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag 
	FROM HairStyle
	WHERE HairEngineerID = @HairEngineerID
	ORDER BY ID DESC

END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QueryHairStyleByName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[QueryHairStyleByName]
@HairName varchar

AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag 
	FROM HairStyle
	WHERE HairName = @HairName
	ORDER BY ID DESC

END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QueryHairStyleByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[QueryHairStyleByID]
@ID int
AS
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag 
	FROM HairStyle
	WHERE ID = @ID
	ORDER BY ID DESC

END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QueryHairStyle]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[QueryHairStyle]


AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag,postID,psgids,ishairstyle,picturestoreid,descr 
	FROM HairStyle
	where picturestoreid =0
	ORDER BY ID DESC

END' 
END

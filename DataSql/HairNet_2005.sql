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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Channel]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Channel](
	[ChannelID] [int] IDENTITY(1,1) NOT NULL,
	[ChannelName] [varchar](100) NULL,
	[ChannelUrl] [varchar](1024) NULL CONSTRAINT [DF_Channel_ChannelIsVisible]  DEFAULT (1),
	[ChannelCreateTime] [varchar](100) NULL,
	[ChannelAdmin] [varchar](100) NULL,
	[ChannelUserNum] [int] NULL,
	[ChannelAdminUrl] [varchar](1024) NULL,
	[ChannelSummary] [varchar](1024) NULL,
 CONSTRAINT [PK_Channel] PRIMARY KEY CLUSTERED 
(
	[ChannelID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Channel2]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Channel2](
	[ChannelID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[ChannelIsVisible] [bit] NOT NULL,
	[ChannelDisplayNum] [int] NOT NULL,
	[ChannelSubmitTime] [datetime] NOT NULL CONSTRAINT [DF_Channel2_ChannelSubmitTime]  DEFAULT (getdate()),
	[ChannelCustomName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Channel2] PRIMARY KEY CLUSTERED 
(
	[ChannelID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArticleRecommand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ArticleRecommand](
	[ArticleRecommandID] [int] IDENTITY(1,1) NOT NULL,
	[ChannelID] [int] NOT NULL,
	[ChannelName] [varchar](100) NULL,
	[ArticleTitle] [varchar](100) NULL,
	[ArticleAuthor] [varchar](100) NULL,
	[ArticleUrl] [varchar](1024) NULL,
	[ProductName] [varchar](100) NULL,
	[ProductEx] [text] NULL,
	[UserID] [int] NULL,
	[ChannelSummary] [varchar](1024) NULL,
	[RecommandTime] [datetime] NULL CONSTRAINT [DF_ArticleRecommand_RecommandTime]  DEFAULT (getdate()),
	[Hits] [int] NULL,
 CONSTRAINT [PK_ArticleRecommand] PRIMARY KEY CLUSTERED 
(
	[ArticleRecommandID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Friendship]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Friendship](
	[FriendshipID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[UserFriendID] [int] NOT NULL,
	[UserFriendSex] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL CONSTRAINT [DF_Friendship_CreateTime]  DEFAULT (getdate()),
	[Summary] [varchar](1024) NULL,
 CONSTRAINT [PK_Friendship] PRIMARY KEY CLUSTERED 
(
	[FriendshipID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderCreateTime] [datetime] NOT NULL CONSTRAINT [DF_Order_OrderCreateTime]  DEFAULT (getdate()),
	[UserID] [int] NOT NULL,
	[UserName] [varchar](100) NULL,
	[UserPhoneNum] [varchar](1024) NULL,
	[OrderStatus] [tinyint] NULL,
	[ChannelID] [int] NULL,
	[ProductID1] [int] NULL,
	[ProductID2] [int] NULL,
	[ProductID3] [int] NULL,
	[ReferenceUserID] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserPersonalInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserPersonalInfo](
	[UserID] [int] NOT NULL,
	[Sex] [tinyint] NULL,
	[Birthday] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Name] [varchar](100) NULL,
	[Country] [varchar](100) NULL,
	[City] [varchar](100) NULL,
	[PostalCode] [varchar](100) NULL,
	[Vocational] [varchar](100) NULL,
	[Location] [varchar](100) NULL,
	[Interest] [varchar](100) NULL,
 CONSTRAINT [PK_UserPersonalInfo] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserBasicInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserBasicInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[FindPassQus] [varchar](100) NOT NULL,
	[FindPassAsw] [varchar](100) NOT NULL,
	[ActivatedIDS] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TempEmail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TempEmail](
	[TempEmailID] [int] IDENTITY(1,1) NOT NULL,
	[TempEmailName] [varchar](1024) NOT NULL,
	[TempEmailIsSend] [bit] NOT NULL CONSTRAINT [DF_TempEmail_TempEmailIsSend]  DEFAULT (0),
	[TempEmailCreateTime] [datetime] NOT NULL CONSTRAINT [DF_TempEmail_TempEmailCreateTime]  DEFAULT (getdate()),
 CONSTRAINT [PK_TempEmail] PRIMARY KEY CLUSTERED 
(
	[TempEmailID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HotZone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HotZone](
	[HotZoneID] [int] IDENTITY(1,1) NOT NULL,
	[HotZoneName] [varchar](100) NOT NULL,
	[HotZoneVisible] [bit] NOT NULL CONSTRAINT [DF_HotZone_HotZoneVisible]  DEFAULT (1),
	[MapZoneID] [int] NOT NULL,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceRange]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PriceRange](
	[PriceRangeID] [int] IDENTITY(1,1) NOT NULL,
	[PriceRangeName] [varchar](100) NOT NULL,
	[PriceRangeVisible] [bit] NOT NULL CONSTRAINT [DF_PriceRange_PriceRangeVisible]  DEFAULT (1),
 CONSTRAINT [PK_PriceRange] PRIMARY KEY CLUSTERED 
(
	[PriceRangeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderWay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrderWay](
	[OrderWayID] [int] IDENTITY(1,1) NOT NULL,
	[OrderWayName] [varchar](100) NOT NULL,
	[OrderWayVisible] [bit] NOT NULL CONSTRAINT [DF_OrderWay_OrderWayVisible]  DEFAULT (1),
	[OrderWayKey] [varchar](100) NOT NULL,
 CONSTRAINT [PK_OrderWay] PRIMARY KEY CLUSTERED 
(
	[OrderWayID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairNetTagGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairNetTagGroup](
	[HairNetTagGroupID] [int] IDENTITY(1,1) NOT NULL,
	[HairNetTagGroupName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_HairNetTagGroup] PRIMARY KEY CLUSTERED 
(
	[HairNetTagGroupID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairNetTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairNetTag](
	[HairNetTagID] [int] IDENTITY(1,1) NOT NULL,
	[HairNetTagName] [varchar](100) NOT NULL,
	[HairNetTagGroupID] [int] NOT NULL,
 CONSTRAINT [PK_HairNetTag] PRIMARY KEY CLUSTERED 
(
	[HairNetTagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Specializes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Specializes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SpecializesTitle] [varchar](10) NOT NULL,
	[SpecializesDescription] [varchar](1024) NOT NULL,
	[BuildDate] [datetime] NOT NULL CONSTRAINT [DF_Specializes_BuildDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Specializes] PRIMARY KEY CLUSTERED 
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
	[HairShopPictureStoreIDs] [varchar](1024) NOT NULL,
	[HairShopMainIDs] [varchar](1024) NULL,
	[HairShopPartialIDs] [varchar](1024) NULL,
	[HairShopEngineerNum] [int] NULL,
	[HairShopOpenTime] [varchar](1024) NULL,
	[HairShopOrderNum] [int] NULL CONSTRAINT [DF_HairShop_HairShopOrderNum]  DEFAULT (0),
	[HairShopVisitNum] [int] NULL CONSTRAINT [DF_HairShop_HairShopVisitNum]  DEFAULT (0),
	[WorkRangeIDs] [varchar](1024) NULL,
	[HairShopWebSite] [varchar](1024) NULL,
	[HairShopEmail] [varchar](1024) NULL,
	[HairshopDiscount] [varchar](100) NULL,
	[HairShopLogo] [varchar](1024) NULL,
	[HairShopRecommandNum] [int] NULL CONSTRAINT [DF_HairShop_HairShopRecommandNum]  DEFAULT (0),
	[HairShopCreateTime] [varchar](100) NULL,
	[HairShopDescription] [text] NULL,
	[ProductIDs] [varchar](1024) NULL,
	[HairShopTagIDs] [varchar](1024) NULL,
	[HairShopShortName] [varchar](100) NULL,
	[IsBest] [bit] NULL,
	[IsJoin] [bit] NULL,
	[TypeID] [int] NULL,
	[IsPostStation] [bit] NULL,
	[IsPostMachine] [bit] NULL,
	[HairShopGood] [int] NULL CONSTRAINT [DF_HairShop_HairShopGood]  DEFAULT (0),
	[HairShopBad] [int] NULL CONSTRAINT [DF_HairShop_HairShopBad]  DEFAULT (0),
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairShopComment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairShopComment](
	[HairShopCommentID] [int] IDENTITY(1,1) NOT NULL,
	[HairShopCommentText] [text] NOT NULL,
	[UserID] [int] NULL,
	[UserName] [varchar](100) NULL,
	[UserAddress] [varchar](1024) NULL,
	[IsGood] [bit] NOT NULL,
	[HairShopCommentCreateTime] [datetime] NOT NULL CONSTRAINT [DF_HairShopComment_HairShopCommentCreateTime]  DEFAULT (getdate()),
	[HairShopID] [int] NOT NULL,
 CONSTRAINT [PK_HairShopComment] PRIMARY KEY CLUSTERED 
(
	[HairShopCommentID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkRange]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[WorkRange](
	[WorkRangeID] [int] IDENTITY(1,1) NOT NULL,
	[WorkRangeName] [varchar](100) NOT NULL,
	[WorkRangeVisible] [bit] NOT NULL CONSTRAINT [DF_WorkRange_WorkRangeVisible]  DEFAULT (1),
 CONSTRAINT [PK_WorkRange] PRIMARY KEY CLUSTERED 
(
	[WorkRangeID] ASC
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
	[HairShopIDs] [varchar](1024) NOT NULL,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShopRelations]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ShopRelations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HairShopID] [int] NOT NULL,
	[StyleID] [int] NOT NULL,
	[Relations] [int] NOT NULL,
	[ShowInfo] [int] NOT NULL,
 CONSTRAINT [PK_ShopRelations] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairEngineer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairEngineer](
	[HairEngineerID] [int] IDENTITY(1,1) NOT NULL,
	[HairEngineerAge] [varchar](100) NOT NULL,
	[HairEngineerName] [varchar](100) NOT NULL,
	[HairEngineerSex] [tinyint] NOT NULL,
	[HairEngineerPhoto] [varchar](1024) NOT NULL,
	[HairShopID] [int] NOT NULL,
	[HairEngineerYear] [varchar](100) NULL,
	[HairEngineerSkill] [varchar](100) NULL,
	[HairEngineerTagIDs] [varchar](1024) NULL,
	[HairEngineerPictureStoreIDs] [varchar](1024) NULL,
	[HairEngineerHits] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerHits]  DEFAULT (0),
	[HairEngineerDescription] [text] NULL,
	[HairEngineerOrderNum] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerOrderNum]  DEFAULT (0),
	[HairEngineerRecommandNum] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerRecommndNum]  DEFAULT (0),
	[HairEngineerRawPrice] [varchar](100) NULL,
	[HairEngineerPrice] [varchar](100) NULL,
	[HairEngineerGood] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerGood]  DEFAULT (0),
	[HairEngineerBad] [int] NULL CONSTRAINT [DF_HairEngineer_HairEngineerBad]  DEFAULT (0),
	[HairEngineerClassID] [int] NULL,
 CONSTRAINT [PK_HairEngineer] PRIMARY KEY CLUSTERED 
(
	[HairEngineerID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairEngineerComment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairEngineerComment](
	[HairEngineerCommentID] [int] IDENTITY(1,1) NOT NULL,
	[HairEngineerCommentText] [text] NOT NULL,
	[UserID] [int] NULL,
	[UserName] [varchar](100) NULL,
	[UserAddress] [varchar](1024) NULL,
	[IsGood] [bit] NULL,
	[HairEngineerCommentCreateTime] [datetime] NULL CONSTRAINT [DF_HairEngineerComment_HairEngineerCommentCreateTime]  DEFAULT (getdate()),
	[HairEngineerID] [int] NOT NULL,
 CONSTRAINT [PK_HairEngineerComment] PRIMARY KEY CLUSTERED 
(
	[HairEngineerCommentID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HairEngineerClass]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HairEngineerClass](
	[HairEngineerClassID] [int] IDENTITY(1,1) NOT NULL,
	[HairEngineerClassName] [varchar](100) NOT NULL,
	[HairEngineerClassVisible] [bit] NOT NULL CONSTRAINT [DF_HairEngineerClass_HairEngineerClassVisible]  DEFAULT (1),
 CONSTRAINT [PK_HairEngineerClass] PRIMARY KEY CLUSTERED 
(
	[HairEngineerClassID] ASC
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStore]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStore](
	[PictureStoreID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreName] [varchar](100) NOT NULL,
	[PictureStoreRawUrl] [varchar](1024) NOT NULL,
	[PictureStoreLittleUrl] [varchar](1024) NOT NULL,
	[PictureStoreTagIDs] [varchar](1024) NULL,
	[PictureStoreHits] [int] NULL CONSTRAINT [DF_PictureStore_PictureStoreHits]  DEFAULT (0),
	[PictureStoreDescription] [text] NULL,
	[HairEngineerIDs] [varchar](1024) NULL,
	[HairShopIDs] [varchar](1024) NULL,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStoreComment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStoreComment](
	[PictureStoreCommentID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreCommentText] [text] NOT NULL,
	[PictureStoreCommentCreateTime] [datetime] NOT NULL CONSTRAINT [DF_PictureStoreComment_PictureStoreCommentCreateTime]  DEFAULT (getdate()),
	[UserID] [int] NULL,
	[UserName] [varchar](100) NULL,
	[UserAddress] [varchar](1024) NULL,
	[PictureStoreID] [int] NOT NULL,
 CONSTRAINT [PK_PictureStoreComment] PRIMARY KEY CLUSTERED 
(
	[PictureStoreCommentID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
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
	[PictureStoreIDs] [varchar](1024) NULL,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PictureStoreTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PictureStoreTag](
	[PictureStoreTagID] [int] IDENTITY(1,1) NOT NULL,
	[PictureStoreTagName] [varchar](100) NOT NULL,
	[PictureStoreIDs] [varchar](1024) NULL,
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductComment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProductComment](
	[ProductCommentID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCommentText] [text] NULL,
	[UserID] [int] NULL,
	[UserName] [varchar](100) NULL,
	[UserAddress] [varchar](1024) NULL,
	[ProductCommentCreateTime] [datetime] NULL CONSTRAINT [DF_ProductComment_ProductCommentCreateTime]  DEFAULT (getdate()),
	[ProductID] [int] NULL,
 CONSTRAINT [PK_ProductComment] PRIMARY KEY CLUSTERED 
(
	[ProductCommentID] ASC
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Article]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Article](
	[ArticleID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleTitle] [varchar](1024) NULL,
	[ArticleAuthor] [varchar](100) NULL,
	[ArticleContent] [text] NULL,
	[ArticleTagIDs] [varchar](1024) NULL,
	[ArticleDigNum] [int] NULL CONSTRAINT [DF_Article_ArticleDigNum]  DEFAULT (0),
	[ArticleOutLink] [varchar](1024) NULL,
	[ArticleSource] [varchar](1024) NULL,
	[ArticlePublishDate] [datetime] NULL,
	[ArticleGroupID] [int] NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArticleTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ArticleTag](
	[ArticleTagID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleTagName] [varchar](100) NOT NULL,
	[ArticleIDs] [varchar](1024) NULL,
 CONSTRAINT [PK_ArticleTag] PRIMARY KEY CLUSTERED 
(
	[ArticleTagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArticleComment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ArticleComment](
	[ArticleCommentID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleCommentText] [text] NULL,
	[UserID] [int] NULL,
	[UserName] [varchar](100) NULL,
	[UserAddress] [varchar](1024) NULL,
	[ArticleCommentCreateTime] [datetime] NULL CONSTRAINT [DF_ArticleComment_ArticleCommentCreateTime]  DEFAULT (getdate()),
	[ArticleID] [int] NOT NULL,
 CONSTRAINT [PK_ArticleComment] PRIMARY KEY CLUSTERED 
(
	[ArticleCommentID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArticleGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ArticleGroup](
	[ArticleGroupID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleGroupName] [varchar](100) NOT NULL,
	[ArticleGroupParentID] [int] NULL,
	[ArticleIDs] [varchar](1024) NULL,
 CONSTRAINT [PK_ArticleGroup] PRIMARY KEY CLUSTERED 
(
	[ArticleGroupID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserContactInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserContactInfo](
	[UserID] [int] NOT NULL,
	[LiveCity] [varchar](100) NULL,
	[HomeAddr] [varchar](1024) NULL,
	[HomeTel1] [varchar](100) NULL,
	[HomeTel2] [varchar](100) NULL,
	[Mobile] [varchar](100) NULL,
	[LiveFax] [varchar](100) NULL,
	[PersonalEmail] [varchar](100) NULL,
	[PersonalMessgeAddr] [varchar](1024) NULL,
	[MSN] [varchar](100) NULL,
	[QQ] [varchar](100) NULL,
 CONSTRAINT [PK_UserContactInfo] PRIMARY KEY CLUSTERED 
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserBusinessInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserBusinessInfo](
	[UserID] [int] NOT NULL,
	[Duty] [varchar](100) NULL,
	[Company] [varchar](100) NULL,
	[CompanyCountry] [varchar](100) NULL,
	[CompanyCity] [varchar](100) NULL,
	[OfficeCity] [varchar](100) NULL,
	[OfficeAddr] [varchar](100) NULL,
	[OfficeTel1] [varchar](100) NULL,
	[OfficeTel2] [varchar](100) NULL,
	[OfficeFax] [varchar](100) NULL,
	[WorkEmail] [varchar](100) NULL,
	[WorkMessageAddr] [varchar](1024) NULL,
	[BeginWork] [varchar](100) NULL,
	[MonthlyIncome] [varchar](100) NULL,
 CONSTRAINT [PK_UserBusinessInfo] PRIMARY KEY CLUSTERED 
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
	[HairEngineerClassID] [int] NULL,
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

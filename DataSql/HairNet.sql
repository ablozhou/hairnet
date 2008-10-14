if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DeleteCoupon]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DeleteCoupon]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DeleteHairStyle]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DeleteHairStyle]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InsertCoupon]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[InsertCoupon]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InsertHairStyle]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[InsertHairStyle]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[QueryCoupon]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[QueryCoupon]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[QueryHairStyle]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[QueryHairStyle]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[QueryHairStyle1]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[QueryHairStyle1]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[QueryHairStyleByEngineerID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[QueryHairStyleByEngineerID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[QueryHairStyleByID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[QueryHairStyleByID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[QueryHairStyleByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[QueryHairStyleByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UpdateCoupon]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[UpdateCoupon]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UpdateHairStyle]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[UpdateHairStyle]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Article]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Article]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleComment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ArticleComment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleGroup]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ArticleGroup]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleRecommand]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ArticleRecommand]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ArticleTag]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ArticleTag]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Channel]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Channel]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Channel2]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Channel2]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[City]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[City]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Coupon]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Coupon]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Friendship]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Friendship]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairEngineer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairEngineer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairEngineerClass]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairEngineerClass]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairEngineerComment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairEngineerComment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairEngineerRecommand]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairEngineerRecommand]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairEngineerTag]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairEngineerTag]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairNetTag]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairNetTag]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairNetTagGroup]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairNetTagGroup]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairShop]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairShop]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairShopComment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairShopComment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairShopRecommand]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairShopRecommand]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HairShopTag]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HairShopTag]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[History]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[History]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HotZone]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HotZone]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MapZone]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[MapZone]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ModelList]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ModelList]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Order]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Order]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[OrderWay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[OrderWay]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PictureStore]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PictureStore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PictureStoreComment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PictureStoreComment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PictureStoreGroup]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PictureStoreGroup]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PictureStoreRecommand]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PictureStoreRecommand]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PictureStoreSet]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PictureStoreSet]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PictureStoreTag]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PictureStoreTag]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PriceRange]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PriceRange]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Product]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Product]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductComment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductComment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductRecommand]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductRecommand]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductTag]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductTag]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ShopRelations]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ShopRelations]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Specializes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Specializes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TempEmail]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TempEmail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TypeTable]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TypeTable]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserBasicInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserBasicInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserBusinessInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserBusinessInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserContactInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserContactInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserPersonalInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserPersonalInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserRole]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserRole]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[WorkRange]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[WorkRange]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[comment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[comment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[enginpics]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[enginpics]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[facestyle]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[facestyle]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[hairnature]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[hairnature]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[hairquantity]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[hairquantity]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[hairstyle]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[hairstyle]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[hairstyleclassname]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[hairstyleclassname]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[occasion]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[occasion]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[shoppics]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[shoppics]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[subsemail]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[subsemail]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[temperament]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[temperament]
GO

CREATE TABLE [dbo].[Article] (
	[ArticleID] [int] IDENTITY (1, 1) NOT NULL ,
	[ArticleTitle] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleAuthor] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleContent] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleDigNum] [int] NULL ,
	[ArticleOutLink] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleSource] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticlePublishDate] [datetime] NULL ,
	[ArticleGroupID] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArticleComment] (
	[ArticleCommentID] [int] IDENTITY (1, 1) NOT NULL ,
	[ArticleCommentText] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserAddress] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleCommentCreateTime] [datetime] NULL ,
	[ArticleID] [int] NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArticleGroup] (
	[ArticleGroupID] [int] IDENTITY (1, 1) NOT NULL ,
	[ArticleGroupName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ArticleGroupParentID] [int] NULL ,
	[ArticleIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArticleRecommand] (
	[ArticleRecommandID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannelID] [int] NOT NULL ,
	[ChannelName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleTitle] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleAuthor] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ArticleUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductEx] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[ChannelSummary] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[RecommandTime] [datetime] NULL ,
	[Hits] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ArticleTag] (
	[ArticleTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[ArticleTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ArticleIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[TagCount] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Channel] (
	[ChannelID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannelName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelCreateTime] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelAdmin] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelUserNum] [int] NULL ,
	[ChannelAdminUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ChannelSummary] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Channel2] (
	[ChannelID] [int] NOT NULL ,
	[UserID] [int] NOT NULL ,
	[ChannelIsVisible] [bit] NOT NULL ,
	[ChannelDisplayNum] [int] NOT NULL ,
	[ChannelSubmitTime] [datetime] NOT NULL ,
	[ChannelCustomName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[City] (
	[CityID] [int] IDENTITY (1, 1) NOT NULL ,
	[CityName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[CityVisible] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Coupon] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (256) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopID] [int] NOT NULL ,
	[Discount] [nvarchar] (256) COLLATE Chinese_PRC_CI_AS NULL ,
	[ExpiredDate] [nvarchar] (32) COLLATE Chinese_PRC_CI_AS NULL ,
	[PhoneNumber] [nvarchar] (32) COLLATE Chinese_PRC_CI_AS NULL ,
	[CouponTag] [nvarchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[Description] [nvarchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ImageUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[CreateDate] [datetime] NULL ,
	[HitNum] [int] NULL ,
	[postid] [int] NULL ,
	[ImageSmallUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Friendship] (
	[FriendshipID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserID] [int] NOT NULL ,
	[UserFriendID] [int] NOT NULL ,
	[UserFriendSex] [int] NOT NULL ,
	[CreateTime] [datetime] NOT NULL ,
	[Summary] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairEngineer] (
	[HairEngineerID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairEngineerAge] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerSex] [tinyint] NULL ,
	[HairEngineerPhoto] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopID] [int] NOT NULL ,
	[HairEngineerYear] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerSkill] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerPictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerHits] [int] NULL ,
	[HairEngineerDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerOrderNum] [int] NULL ,
	[HairEngineerRecommandNum] [int] NULL ,
	[HairEngineerRawPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerTel] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerGood] [int] NULL ,
	[HairEngineerBad] [int] NULL ,
	[HairEngineerClassID] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerConstellation] [varchar] (64) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsImportant] [bit] NULL ,
	[HairEngineerPhotoIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerNormal] [int] NULL ,
	[postid] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairEngineerClass] (
	[HairEngineerClassID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairEngineerClassName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerClassVisible] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairEngineerComment] (
	[HairEngineerCommentID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairEngineerCommentText] [text] COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[UserID] [int] NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserAddress] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsGood] [bit] NULL ,
	[HairEngineerCommentCreateTime] [datetime] NULL ,
	[HairEngineerID] [int] NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairEngineerRecommand] (
	[HairEngineerRecommandID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairEngineerRawID] [int] NOT NULL ,
	[HairEngineerName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerAge] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerSex] [tinyint] NOT NULL ,
	[HairEngineerPhoto] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopID] [int] NOT NULL ,
	[HairEngineerYear] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerSkill] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerPictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerRawPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerClassID] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerRecommandEx] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerRecommandInfo] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairEngineerTag] (
	[HairEngineerTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairEngineerTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[TagCount] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairNetTag] (
	[HairNetTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairNetTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairNetTagGroupID] [int] NOT NULL ,
	[TagCount] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairNetTagGroup] (
	[HairNetTagGroupID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairNetTagGroupName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairShop] (
	[HairShopID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairShopName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopCityID] [int] NOT NULL ,
	[HairShopMapZoneID] [int] NOT NULL ,
	[HairShopHotZoneID] [int] NOT NULL ,
	[HairShopAddress] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopPhoneNum] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopPictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopMainIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopPartialIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopEngineerNum] [int] NULL ,
	[HairShopOpenTime] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopOrderNum] [int] NULL ,
	[HairShopVisitNum] [int] NULL ,
	[WorkRangeIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopWebSite] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopEmail] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairshopDiscount] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopLogo] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopRecommandNum] [int] NULL ,
	[HairShopCreateTime] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopShortName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsBest] [bit] NULL ,
	[IsJoin] [bit] NULL ,
	[TypeID] [int] NULL ,
	[IsPostStation] [bit] NULL ,
	[IsPostMachine] [bit] NULL ,
	[HairShopGood] [int] NULL ,
	[HairShopBad] [int] NULL ,
	[HairCutPrice] [int] NULL ,
	[HairMarcelPrice] [int] NULL ,
	[HairDyePrice] [int] NULL ,
	[HairShapePrice] [int] NULL ,
	[HairConservationPrice] [int] NULL ,
	[HairCutDiscount] [int] NULL ,
	[HairMarcelDiscount] [int] NULL ,
	[HairDyeDiscount] [int] NULL ,
	[HairShapeDiscount] [int] NULL ,
	[HairConservationDiscount] [int] NULL ,
	[LocationMapURL] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[Square] [int] NULL ,
	[IsServeMarcel] [bit] NULL ,
	[IsServeDye] [bit] NULL ,
	[IsServeHairCut] [bit] NULL ,
	[IsChainStore] [bit] NULL ,
	[MemberInfo] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[OutLogs] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[InnerLogs] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[CouponNum] [int] NULL ,
	[postid] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairShopComment] (
	[HairShopCommentID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairShopCommentText] [text] COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[UserID] [int] NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserAddress] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsGood] [bit] NOT NULL ,
	[HairShopCommentCreateTime] [datetime] NOT NULL ,
	[HairShopID] [int] NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairShopRecommand] (
	[HairShopRecommandID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairShopRawID] [int] NOT NULL ,
	[HairShopName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopCityID] [int] NOT NULL ,
	[HairShopMapZoneID] [int] NOT NULL ,
	[HairShopHotZoneID] [int] NOT NULL ,
	[HairShopAddress] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopPhoneNum] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopPictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopMainIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopPartialIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopEngineerNum] [int] NULL ,
	[HairShopOpenTime] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkRangeIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopWebSite] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopEmail] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopDiscount] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopLogo] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopCreateTime] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopShortName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsBest] [bit] NULL ,
	[IsJoin] [bit] NULL ,
	[TypeID] [int] NULL ,
	[IsPostStation] [bit] NULL ,
	[IsPostMachine] [bit] NULL ,
	[HairShopRecommandEx] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopRecommandInfo] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairShopTag] (
	[HairShopTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairShopTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairShopIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[TagCount] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[History] (
	[HistoryID] [int] IDENTITY (1, 1) NOT NULL ,
	[ChannelID] [int] NOT NULL ,
	[HistoryCreateTime] [datetime] NOT NULL ,
	[HistoryUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ProductName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HistoryAction] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[UserID] [int] NOT NULL ,
	[HistorySummary] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HotZone] (
	[HotZoneID] [int] IDENTITY (1, 1) NOT NULL ,
	[HotZoneName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HotZoneVisible] [bit] NOT NULL ,
	[MapZoneID] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MapZone] (
	[MapZoneID] [int] IDENTITY (1, 1) NOT NULL ,
	[MapZoneName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[MapZoneVisible] [bit] NOT NULL ,
	[CityID] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ModelList] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[sex] [varchar] (6) COLLATE Chinese_PRC_CI_AS NULL ,
	[facestyle] [int] NULL ,
	[bigurl] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[thumburl] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[flag] [tinyint] NULL ,
	[createtime] [smalldatetime] NULL ,
	[ModelName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Order] (
	[OrderID] [int] IDENTITY (1, 1) NOT NULL ,
	[OrderCreateTime] [datetime] NOT NULL ,
	[UserID] [int] NOT NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserPhoneNum] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[OrderStatus] [tinyint] NULL ,
	[ChannelID] [int] NULL ,
	[ProductID1] [int] NULL ,
	[ProductID2] [int] NULL ,
	[ProductID3] [int] NULL ,
	[ReferenceUserID] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[OrderWay] (
	[OrderWayID] [int] IDENTITY (1, 1) NOT NULL ,
	[OrderWayName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[OrderWayVisible] [bit] NOT NULL ,
	[OrderWayKey] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStore] (
	[PictureStoreID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreRawUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreLittleUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreHits] [int] NULL ,
	[PictureStoreDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreCreateTime] [datetime] NOT NULL ,
	[PictureStoreGroupIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStoreComment] (
	[PictureStoreCommentID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreCommentText] [text] COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreCommentCreateTime] [datetime] NOT NULL ,
	[UserID] [int] NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserAddress] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreID] [int] NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStoreGroup] (
	[PictureStoreGroupID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreGroupName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreGroupParentID] [int] NULL ,
	[PictureStoreIDs] [varchar] (8000) COLLATE Chinese_PRC_CI_AS NULL ,
	[AddTime] [datetime] NULL ,
	[postid] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStoreRecommand] (
	[PictureStoreRecommandID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreRawID] [int] NULL ,
	[PictureStoreName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreRawUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreLittleUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreCreateTime] [datetime] NULL ,
	[PictureStoreGroupIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreRecommandEx] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[PictureStoreRecommandInfo] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStoreSet] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreId] [int] NOT NULL ,
	[PictureStoreURL] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsHairStyle] [bit] NULL ,
	[HairStylePos] [int] NULL ,
	[SmallPictureUrl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStoreTag] (
	[PictureStoreTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[TagCount] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PriceRange] (
	[PriceRangeID] [int] IDENTITY (1, 1) NOT NULL ,
	[PriceRangeName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PriceRangeVisible] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Product] (
	[ProductID] [int] IDENTITY (1, 1) NOT NULL ,
	[ProductName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductCompany] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductCompanyDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductPictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductHits] [int] NULL ,
	[ProductDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductRawPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductDiscount] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[postid] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductComment] (
	[ProductCommentID] [int] IDENTITY (1, 1) NOT NULL ,
	[ProductCommentText] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[UserID] [int] NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[UserAddress] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductCommentCreateTime] [datetime] NULL ,
	[ProductID] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductRecommand] (
	[ProductRecommandID] [int] IDENTITY (1, 1) NOT NULL ,
	[ProductRawID] [int] NOT NULL ,
	[ProductName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductCompany] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductCompanyDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductPictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductDescription] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairShopIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductRawPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductDiscount] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductRecommandEx] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[ProductRecommandInfo] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductTag] (
	[ProductTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[ProductTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ProductIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[TagCount] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ShopRelations] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairShopID] [int] NOT NULL ,
	[StyleID] [int] NOT NULL ,
	[Relations] [int] NOT NULL ,
	[ShowInfo] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Specializes] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[SpecializesTitle] [varchar] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[SpecializesDescription] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[BuildDate] [datetime] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TempEmail] (
	[TempEmailID] [int] IDENTITY (1, 1) NOT NULL ,
	[TempEmailName] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[TempEmailIsSend] [bit] NOT NULL ,
	[TempEmailCreateTime] [datetime] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TypeTable] (
	[TypeID] [int] IDENTITY (1, 1) NOT NULL ,
	[TypeName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[TypeVisible] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserBasicInfo] (
	[UserID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Password] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[FindPassQus] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[FindPassAsw] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[ActivatedIDS] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Email] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Integral] [int] NULL ,
	[UserRoleID] [int] NOT NULL ,
	[IsActive] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserBusinessInfo] (
	[UserID] [int] NOT NULL ,
	[Duty] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Company] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[CompanyCountry] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[CompanyCity] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[OfficeCity] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[OfficeAddr] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[OfficeTel1] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[OfficeTel2] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[OfficeFax] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkEmail] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkMessageAddr] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[BeginWork] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[MonthlyIncome] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserContactInfo] (
	[UserID] [int] NOT NULL ,
	[LiveCity] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HomeAddr] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[HomeTel1] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HomeTel2] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Mobile] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[LiveFax] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[PersonalEmail] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[PersonalMessgeAddr] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[MSN] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[QQ] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserPersonalInfo] (
	[UserID] [int] NOT NULL ,
	[Sex] [tinyint] NULL ,
	[Birthday] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[FirstName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[LastName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Country] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[City] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[PostalCode] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Vocational] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Location] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[Interest] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserRole] (
	[UserRoleID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserRoleName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[UserRoleIsVisible] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[WorkRange] (
	[WorkRangeID] [int] IDENTITY (1, 1) NOT NULL ,
	[WorkRangeName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[WorkRangeVisible] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[comment] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[good] [int] NULL ,
	[normal] [int] NULL ,
	[bad] [int] NULL ,
	[other] [int] NULL ,
	[ownerid] [int] NULL ,
	[classname] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[commentobject] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL ,
	[description] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[enginpics] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[picurl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[ownerid] [int] NULL ,
	[classid] [int] NULL ,
	[picsmallurl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[facestyle] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[facestylename] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[hairnature] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[hairnature] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[hairquantity] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[hairquantity] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[hairstyle] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[hairname] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[hairstyle] [tinyint] NULL ,
	[facestyle] [tinyint] NULL ,
	[temperament] [tinyint] NULL ,
	[occasion] [tinyint] NULL ,
	[sex] [tinyint] NULL ,
	[bigpic] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[smallpic_f] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[smallpic_b] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[smallpic_s] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[pic1] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[pic2] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[pic3] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[hairshopid] [int] NULL ,
	[hairengineerid] [int] NULL ,
	[hairquantity] [tinyint] NULL ,
	[hairnature] [tinyint] NULL ,
	[color] [tinyint] NULL ,
	[createtime] [datetime] NULL ,
	[bbsurl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[good] [int] NULL ,
	[normal] [int] NULL ,
	[bad] [int] NULL ,
	[tag] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[savenum] [int] NULL ,
	[hitnum] [int] NULL ,
	[descr] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[picturestoreid] [int] NULL ,
	[psgids] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[IsHairStyle] [bit] NULL ,
	[postid] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[hairstyleclassname] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[hairstyleclassname] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[occasion] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[occasion] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[shoppics] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[picurl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL ,
	[hairshopID] [int] NULL ,
	[classid] [int] NULL ,
	[picsmallurl] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[subsemail] (
	[id] [int] IDENTITY (1, 1) NOT NULL ,
	[email] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[shopid] [int] NULL ,
	[classid] [int] NULL ,
	[descr] [varchar] (200) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[temperament] (
	[id] [int] NOT NULL ,
	[temperament] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL 
) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE DeleteCoupon
@ID int
AS
BEGIN
	DELETE FROM Coupon WHERE ID = @ID
END

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE DeleteHairStyle
@ID int
AS
BEGIN
	DELETE FROM HairStyle WHERE ID = @ID
END

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE InsertCoupon
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
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
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
		@Normal ,
		@Bad ,
		@Tag ,0,0,@Description,@PictureStoreID,@psgids,@IsHairStyle,@PostID)
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE QueryCoupon
@ID int
AS
BEGIN
	SELECT ID, [Name], HairShopID, Discount, ExpiredDate, PhoneNumber, CouponTag,Description,ImageUrl,PostID,ImageSmallUrl,HitNum,CreateDate
	FROM Coupon WHERE ID = @ID
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.QueryHairStyle


AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,BigPic,SmallPic_F,SmallPic_B,SmallPic_S,Pic1,Pic2,Pic3,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag,postID,psgids,ishairstyle,picturestoreid,descr 
	FROM HairStyle
	where picturestoreid =0
	ORDER BY ID DESC

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE dbo.QueryHairStyle1


AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,BigPic,SmallPic_F,SmallPic_B,SmallPic_S,Pic1,Pic2,Pic3,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag,postID,psgids,ishairstyle,picturestoreid,descr 
	FROM HairStyle
	ORDER BY ID DESC

END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.QueryHairStyleByEngineerID
@HairEngineerID int

AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,BigPic,SmallPic_F,SmallPic_B,SmallPic_S,Pic1,Pic2,Pic3,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag 
	FROM HairStyle
	WHERE HairEngineerID = @HairEngineerID
	ORDER BY ID DESC

END

	

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


create PROCEDURE QueryHairStyleByID
@ID int
AS
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,BigPic,SmallPic_F,SmallPic_B,SmallPic_S,Pic1,Pic2,Pic3,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag 
	FROM HairStyle
	WHERE ID = @ID
	ORDER BY ID DESC

END


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

Create PROCEDURE dbo.QueryHairStyleByName
@HairName varchar

AS
	
BEGIN
	SELECT 	ID,HairName,HairStyle,FaceStyle,Temperament,Occasion,Sex,BigPic,SmallPic_F,SmallPic_B,SmallPic_S,Pic1,Pic2,Pic3,
			HairShopID ,HairEngineerID ,HairQuantity,HairNature,Color,CreateTime,BBSURL,Good ,Normal ,Bad ,Tag 
	FROM HairStyle
	WHERE HairName = @HairName
	ORDER BY ID DESC

END

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE UpdateCoupon
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
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
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
		Normal = @Normal ,
		Bad = @Bad ,
		Tag = @Tag ,
		Descr = @Description,
		PicturestoreID= @PicturestoreID,
		psgids = @psgids,
		IsHairStyle = @IsHairStyle,
		PostID = @PostID
		
	WHERE ID = @ID
END
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO


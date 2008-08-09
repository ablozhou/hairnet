IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'HairNetDB')
	DROP DATABASE [HairNetDB]
GO

CREATE DATABASE [HairNetDB]  ON (NAME = N'HairNetDB_Data', FILENAME = N'D:\Root\Data\HairNetDB_Data.MDF' , SIZE = 2, FILEGROWTH = 10%) LOG ON (NAME = N'HairNetDB_Log', FILENAME = N'D:\Root\Data\HairNetDB_Log.LDF' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE Chinese_PRC_CI_AS
GO

exec sp_dboption N'HairNetDB', N'autoclose', N'false'
GO

exec sp_dboption N'HairNetDB', N'bulkcopy', N'false'
GO

exec sp_dboption N'HairNetDB', N'trunc. log', N'false'
GO

exec sp_dboption N'HairNetDB', N'torn page detection', N'false'
GO

exec sp_dboption N'HairNetDB', N'read only', N'false'
GO

exec sp_dboption N'HairNetDB', N'dbo use', N'false'
GO

exec sp_dboption N'HairNetDB', N'single', N'false'
GO

exec sp_dboption N'HairNetDB', N'autoshrink', N'false'
GO

exec sp_dboption N'HairNetDB', N'ANSI null default', N'false'
GO

exec sp_dboption N'HairNetDB', N'recursive triggers', N'false'
GO

exec sp_dboption N'HairNetDB', N'ANSI nulls', N'false'
GO

exec sp_dboption N'HairNetDB', N'concat null yields null', N'false'
GO

exec sp_dboption N'HairNetDB', N'cursor close on commit', N'false'
GO

exec sp_dboption N'HairNetDB', N'default to local cursor', N'false'
GO

exec sp_dboption N'HairNetDB', N'quoted identifier', N'false'
GO

exec sp_dboption N'HairNetDB', N'ANSI warnings', N'false'
GO

exec sp_dboption N'HairNetDB', N'auto create statistics', N'true'
GO

exec sp_dboption N'HairNetDB', N'auto update statistics', N'true'
GO

if( (@@microsoftversion / power(2, 24) = 8) and (@@microsoftversion & 0xffff >= 724) )
	exec sp_dboption N'HairNetDB', N'db chaining', N'false'
GO

use [HairNetDB]
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
	[ArticleIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
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
	[HairEngineerAge] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerSex] [tinyint] NOT NULL ,
	[HairEngineerPhoto] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL ,
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
	[HairEngineerPrice] [varchar] (100) COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerGood] [int] NULL ,
	[HairEngineerBad] [int] NULL ,
	[HairEngineerClassID] [int] NULL 
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
	[HairEngineerClassID] [int] NULL ,
	[HairEngineerRecommandEx] [text] COLLATE Chinese_PRC_CI_AS NULL ,
	[HairEngineerRecommandInfo] [text] COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairEngineerTag] (
	[HairEngineerTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairEngineerTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairEngineerIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HairNetTag] (
	[HairNetTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[HairNetTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[HairNetTagGroupID] [int] NOT NULL 
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
	[HairShopBad] [int] NULL 
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
	[HairShopIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NOT NULL 
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
	[MapZoneID] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[MapZone] (
	[MapZoneID] [int] IDENTITY (1, 1) NOT NULL ,
	[MapZoneName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[MapZoneVisible] [bit] NOT NULL ,
	[CityID] [int] NOT NULL 
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
	[PictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PictureStoreTag] (
	[PictureStoreTagID] [int] IDENTITY (1, 1) NOT NULL ,
	[PictureStoreTagName] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[PictureStoreIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
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
	[ProductTagIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
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
	[ProductIDs] [varchar] (1024) COLLATE Chinese_PRC_CI_AS NULL 
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
	[FindPassQus] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[FindPassAsw] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ActivatedIDS] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Email] [varchar] (100) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Integral] [int] NULL ,
	[UserRoleID] [int] NOT NULL 
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

ALTER TABLE [dbo].[Article] WITH NOCHECK ADD 
	CONSTRAINT [PK_Article] PRIMARY KEY  CLUSTERED 
	(
		[ArticleID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ArticleComment] WITH NOCHECK ADD 
	CONSTRAINT [PK_ArticleComment] PRIMARY KEY  CLUSTERED 
	(
		[ArticleCommentID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ArticleGroup] WITH NOCHECK ADD 
	CONSTRAINT [PK_ArticleGroup] PRIMARY KEY  CLUSTERED 
	(
		[ArticleGroupID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ArticleRecommand] WITH NOCHECK ADD 
	CONSTRAINT [PK_ArticleRecommand] PRIMARY KEY  CLUSTERED 
	(
		[ArticleRecommandID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ArticleTag] WITH NOCHECK ADD 
	CONSTRAINT [PK_ArticleTag] PRIMARY KEY  CLUSTERED 
	(
		[ArticleTagID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Channel] WITH NOCHECK ADD 
	CONSTRAINT [PK_Channel] PRIMARY KEY  CLUSTERED 
	(
		[ChannelID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Channel2] WITH NOCHECK ADD 
	CONSTRAINT [PK_Channel2] PRIMARY KEY  CLUSTERED 
	(
		[ChannelID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[City] WITH NOCHECK ADD 
	CONSTRAINT [PK_City] PRIMARY KEY  CLUSTERED 
	(
		[CityID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Friendship] WITH NOCHECK ADD 
	CONSTRAINT [PK_Friendship] PRIMARY KEY  CLUSTERED 
	(
		[FriendshipID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairEngineer] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairEngineer] PRIMARY KEY  CLUSTERED 
	(
		[HairEngineerID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairEngineerClass] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairEngineerClass] PRIMARY KEY  CLUSTERED 
	(
		[HairEngineerClassID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairEngineerComment] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairEngineerComment] PRIMARY KEY  CLUSTERED 
	(
		[HairEngineerCommentID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairEngineerRecommand] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairEngineerRecommand] PRIMARY KEY  CLUSTERED 
	(
		[HairEngineerRecommandID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairEngineerTag] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairEngineerTag] PRIMARY KEY  CLUSTERED 
	(
		[HairEngineerTagID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairNetTag] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairNetTag] PRIMARY KEY  CLUSTERED 
	(
		[HairNetTagID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairNetTagGroup] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairNetTagGroup] PRIMARY KEY  CLUSTERED 
	(
		[HairNetTagGroupID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairShop] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairShop] PRIMARY KEY  CLUSTERED 
	(
		[HairShopID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairShopComment] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairShopComment] PRIMARY KEY  CLUSTERED 
	(
		[HairShopCommentID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairShopRecommand] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairShopRecommand] PRIMARY KEY  CLUSTERED 
	(
		[HairShopRecommandID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HairShopTag] WITH NOCHECK ADD 
	CONSTRAINT [PK_HairShopTag] PRIMARY KEY  CLUSTERED 
	(
		[HairShopTagID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[History] WITH NOCHECK ADD 
	CONSTRAINT [PK_History] PRIMARY KEY  CLUSTERED 
	(
		[HistoryID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[HotZone] WITH NOCHECK ADD 
	CONSTRAINT [PK_HotZone] PRIMARY KEY  CLUSTERED 
	(
		[HotZoneID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[MapZone] WITH NOCHECK ADD 
	CONSTRAINT [PK_MapZone] PRIMARY KEY  CLUSTERED 
	(
		[MapZoneID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Order] WITH NOCHECK ADD 
	CONSTRAINT [PK_Order] PRIMARY KEY  CLUSTERED 
	(
		[OrderID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[OrderWay] WITH NOCHECK ADD 
	CONSTRAINT [PK_OrderWay] PRIMARY KEY  CLUSTERED 
	(
		[OrderWayID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PictureStore] WITH NOCHECK ADD 
	CONSTRAINT [PK_PictureStore] PRIMARY KEY  CLUSTERED 
	(
		[PictureStoreID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PictureStoreComment] WITH NOCHECK ADD 
	CONSTRAINT [PK_PictureStoreComment] PRIMARY KEY  CLUSTERED 
	(
		[PictureStoreCommentID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PictureStoreGroup] WITH NOCHECK ADD 
	CONSTRAINT [PK_PictureStoreGroup] PRIMARY KEY  CLUSTERED 
	(
		[PictureStoreGroupID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PictureStoreTag] WITH NOCHECK ADD 
	CONSTRAINT [PK_PictureStoreTag] PRIMARY KEY  CLUSTERED 
	(
		[PictureStoreTagID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PriceRange] WITH NOCHECK ADD 
	CONSTRAINT [PK_PriceRange] PRIMARY KEY  CLUSTERED 
	(
		[PriceRangeID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Product] WITH NOCHECK ADD 
	CONSTRAINT [PK_Product] PRIMARY KEY  CLUSTERED 
	(
		[ProductID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductComment] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductComment] PRIMARY KEY  CLUSTERED 
	(
		[ProductCommentID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductRecommand] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductRecommand] PRIMARY KEY  CLUSTERED 
	(
		[ProductRecommandID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductTag] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductTag] PRIMARY KEY  CLUSTERED 
	(
		[ProductTagID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ShopRelations] WITH NOCHECK ADD 
	CONSTRAINT [PK_ShopRelations] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Specializes] WITH NOCHECK ADD 
	CONSTRAINT [PK_Specializes] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TypeTable] WITH NOCHECK ADD 
	CONSTRAINT [PK_TypeTable] PRIMARY KEY  CLUSTERED 
	(
		[TypeID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[UserBasicInfo] WITH NOCHECK ADD 
	CONSTRAINT [PK_UserBasicInfo] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[UserBusinessInfo] WITH NOCHECK ADD 
	CONSTRAINT [PK_UserBusinessInfo] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[UserContactInfo] WITH NOCHECK ADD 
	CONSTRAINT [PK_UserContactInfo] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[UserPersonalInfo] WITH NOCHECK ADD 
	CONSTRAINT [PK_UserPersonalInfo] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[UserRole] WITH NOCHECK ADD 
	CONSTRAINT [PK_UserRole] PRIMARY KEY  CLUSTERED 
	(
		[UserRoleID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[WorkRange] WITH NOCHECK ADD 
	CONSTRAINT [PK_WorkRange] PRIMARY KEY  CLUSTERED 
	(
		[WorkRangeID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Article] ADD 
	CONSTRAINT [DF_Article_ArticleDigNum] DEFAULT (0) FOR [ArticleDigNum]
GO

ALTER TABLE [dbo].[ArticleComment] ADD 
	CONSTRAINT [DF_ArticleComment_ArticleCommentCreateTime] DEFAULT (getdate()) FOR [ArticleCommentCreateTime]
GO

ALTER TABLE [dbo].[ArticleRecommand] ADD 
	CONSTRAINT [DF_ArticleRecommand_RecommandTime] DEFAULT (getdate()) FOR [RecommandTime]
GO

ALTER TABLE [dbo].[Channel] ADD 
	CONSTRAINT [DF_Channel_ChannelIsVisible] DEFAULT (1) FOR [ChannelUrl]
GO

ALTER TABLE [dbo].[Channel2] ADD 
	CONSTRAINT [DF_Channel2_ChannelSubmitTime] DEFAULT (getdate()) FOR [ChannelSubmitTime]
GO

ALTER TABLE [dbo].[City] ADD 
	CONSTRAINT [DF_City_CityVisible] DEFAULT (1) FOR [CityVisible]
GO

ALTER TABLE [dbo].[Friendship] ADD 
	CONSTRAINT [DF_Friendship_CreateTime] DEFAULT (getdate()) FOR [CreateTime]
GO

ALTER TABLE [dbo].[HairEngineer] ADD 
	CONSTRAINT [DF_HairEngineer_HairEngineerHits] DEFAULT (0) FOR [HairEngineerHits],
	CONSTRAINT [DF_HairEngineer_HairEngineerOrderNum] DEFAULT (0) FOR [HairEngineerOrderNum],
	CONSTRAINT [DF_HairEngineer_HairEngineerRecommndNum] DEFAULT (0) FOR [HairEngineerRecommandNum],
	CONSTRAINT [DF_HairEngineer_HairEngineerGood] DEFAULT (0) FOR [HairEngineerGood],
	CONSTRAINT [DF_HairEngineer_HairEngineerBad] DEFAULT (0) FOR [HairEngineerBad]
GO

ALTER TABLE [dbo].[HairEngineerClass] ADD 
	CONSTRAINT [DF_HairEngineerClass_HairEngineerClassVisible] DEFAULT (1) FOR [HairEngineerClassVisible]
GO

ALTER TABLE [dbo].[HairEngineerComment] ADD 
	CONSTRAINT [DF_HairEngineerComment_HairEngineerCommentCreateTime] DEFAULT (getdate()) FOR [HairEngineerCommentCreateTime]
GO

ALTER TABLE [dbo].[HairShop] ADD 
	CONSTRAINT [DF_HairShop_HairShopOrderNum] DEFAULT (0) FOR [HairShopOrderNum],
	CONSTRAINT [DF_HairShop_HairShopVisitNum] DEFAULT (0) FOR [HairShopVisitNum],
	CONSTRAINT [DF_HairShop_HairShopRecommandNum] DEFAULT (0) FOR [HairShopRecommandNum],
	CONSTRAINT [DF_HairShop_HairShopGood] DEFAULT (0) FOR [HairShopGood],
	CONSTRAINT [DF_HairShop_HairShopBad] DEFAULT (0) FOR [HairShopBad]
GO

ALTER TABLE [dbo].[HairShopComment] ADD 
	CONSTRAINT [DF_HairShopComment_HairShopCommentCreateTime] DEFAULT (getdate()) FOR [HairShopCommentCreateTime]
GO

ALTER TABLE [dbo].[HairShopRecommand] ADD 
	CONSTRAINT [DF_HairShopRecommand_IsBest] DEFAULT (0) FOR [IsBest],
	CONSTRAINT [DF_HairShopRecommand_IsJoin] DEFAULT (0) FOR [IsJoin],
	CONSTRAINT [DF_HairShopRecommand_IsPostStation] DEFAULT (0) FOR [IsPostStation],
	CONSTRAINT [DF_HairShopRecommand_IsPostMachine] DEFAULT (0) FOR [IsPostMachine]
GO

ALTER TABLE [dbo].[History] ADD 
	CONSTRAINT [DF_History_HistoryCreateTime] DEFAULT (getdate()) FOR [HistoryCreateTime]
GO

ALTER TABLE [dbo].[HotZone] ADD 
	CONSTRAINT [DF_HotZone_HotZoneVisible] DEFAULT (1) FOR [HotZoneVisible]
GO

ALTER TABLE [dbo].[MapZone] ADD 
	CONSTRAINT [DF_MapZone_MapZoneVisible] DEFAULT (1) FOR [MapZoneVisible]
GO

ALTER TABLE [dbo].[Order] ADD 
	CONSTRAINT [DF_Order_OrderCreateTime] DEFAULT (getdate()) FOR [OrderCreateTime]
GO

ALTER TABLE [dbo].[OrderWay] ADD 
	CONSTRAINT [DF_OrderWay_OrderWayVisible] DEFAULT (1) FOR [OrderWayVisible]
GO

ALTER TABLE [dbo].[PictureStore] ADD 
	CONSTRAINT [DF_PictureStore_PictureStoreHits] DEFAULT (0) FOR [PictureStoreHits],
	CONSTRAINT [DF_PictureStore_PictureStoreCreateTime] DEFAULT (getdate()) FOR [PictureStoreCreateTime]
GO

ALTER TABLE [dbo].[PictureStoreComment] ADD 
	CONSTRAINT [DF_PictureStoreComment_PictureStoreCommentCreateTime] DEFAULT (getdate()) FOR [PictureStoreCommentCreateTime]
GO

ALTER TABLE [dbo].[PriceRange] ADD 
	CONSTRAINT [DF_PriceRange_PriceRangeVisible] DEFAULT (1) FOR [PriceRangeVisible]
GO

ALTER TABLE [dbo].[Product] ADD 
	CONSTRAINT [DF_Product_ProductHits] DEFAULT (0) FOR [ProductHits]
GO

ALTER TABLE [dbo].[ProductComment] ADD 
	CONSTRAINT [DF_ProductComment_ProductCommentCreateTime] DEFAULT (getdate()) FOR [ProductCommentCreateTime]
GO

ALTER TABLE [dbo].[Specializes] ADD 
	CONSTRAINT [DF_Specializes_BuildDate] DEFAULT (getdate()) FOR [BuildDate]
GO

ALTER TABLE [dbo].[TypeTable] ADD 
	CONSTRAINT [DF_TypeTable_TypeVisible] DEFAULT (1) FOR [TypeVisible]
GO

ALTER TABLE [dbo].[UserRole] ADD 
	CONSTRAINT [DF_UserRole_UserRoleIsVisible] DEFAULT (1) FOR [UserRoleIsVisible]
GO

ALTER TABLE [dbo].[WorkRange] ADD 
	CONSTRAINT [DF_WorkRange_WorkRangeVisible] DEFAULT (1) FOR [WorkRangeVisible]
GO


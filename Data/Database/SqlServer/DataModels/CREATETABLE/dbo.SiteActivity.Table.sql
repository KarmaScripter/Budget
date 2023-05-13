USE [Data]
GO
/****** Object:  Table [dbo].[SiteActivity]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteActivity](
	[SiteActivityId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[City] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[ProjectType] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[LastActivity] [datetime] NULL,
	[Requested] [float] NULL,
	[Accepted] [float] NULL,
	[Closed] [float] NULL,
	[Outstanding] [float] NULL,
	[Refunded] [float] NULL,
	[Reversal] [float] NULL
) ON [PRIMARY]
GO

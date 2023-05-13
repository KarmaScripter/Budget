USE [Data]
GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizations](
	[OrganizationsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[Usage] [nvarchar](80) NULL,
	[UseAsCostOrg] [nvarchar](80) NULL,
	[SubCodeRequired] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
 CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED 
(
	[OrganizationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

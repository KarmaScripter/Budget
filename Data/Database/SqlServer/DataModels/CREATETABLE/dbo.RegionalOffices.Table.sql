USE [Data]
GO
/****** Object:  Table [dbo].[RegionalOffices]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegionalOffices](
	[RegionalOfficesId] [int] NOT NULL,
	[ResourcePlanningOfficesId] [int] NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_RegionalOffices] PRIMARY KEY CLUSTERED 
(
	[RegionalOfficesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

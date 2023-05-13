USE [Data]
GO
/****** Object:  Table [dbo].[PayrollRequests]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollRequests](
	[PayrollRequestsId] [int] NOT NULL,
	[ControlTeamAnalyst] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[DocumentTitle] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[FundCode] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[OriginalRequestDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[BFS] [nvarchar](80) NULL,
	[Comments] [nvarchar](max) NULL,
	[RequestDocument] [nvarchar](max) NULL,
	[Duration] [float] NULL,
 CONSTRAINT [PK_PayrollRequests] PRIMARY KEY CLUSTERED 
(
	[PayrollRequestsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

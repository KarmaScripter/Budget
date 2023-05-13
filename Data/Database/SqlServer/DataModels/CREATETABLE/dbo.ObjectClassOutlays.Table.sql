USE [Data]
GO
/****** Object:  Table [dbo].[ObjectClassOutlays]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectClassOutlays](
	[ObjectClassOutlaysId] [int] NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[BudgetAgencyCode] [nvarchar](80) NULL,
	[BudgetAgencyName] [nvarchar](80) NULL,
	[BudgetBureauCode] [nvarchar](80) NULL,
	[BudgetBureauName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[ObligationType] [nvarchar](80) NULL,
	[DirectReimbursableTitle] [nvarchar](80) NULL,
	[ObjectClassGroupNumber] [nvarchar](80) NULL,
	[ObjectClassGroupName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FinanceObjectClass] [nvarchar](80) NULL,
	[PriorYear] [float] NULL,
	[CurrentYear] [float] NULL,
	[BudgetYear] [float] NULL,
 CONSTRAINT [PK_ObjectClassOutlays] PRIMARY KEY CLUSTERED 
(
	[ObjectClassOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

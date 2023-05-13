USE [Data]
GO
/****** Object:  Table [dbo].[AppropriationAvailableBalances]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationAvailableBalances](
	[AppropriationAvailableBalancesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[OriginalAmount] [float] NULL,
	[Authority] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[CarryoverIn] [float] NULL,
	[CarryoverOut] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
 CONSTRAINT [PK_AppropriationAvailableBalances] PRIMARY KEY CLUSTERED 
(
	[AppropriationAvailableBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

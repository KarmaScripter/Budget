USE [Data]
GO
/****** Object:  Table [dbo].[ApportionmentData]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApportionmentData](
	[ApportionmentDataId] [int] NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[ApportionmentAccountName] [nvarchar](80) NULL,
	[AvailabilityType] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[ApprovalDate] [datetime] NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ApportionmentData] PRIMARY KEY CLUSTERED 
(
	[ApportionmentDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

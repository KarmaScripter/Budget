USE [Data]
GO
/****** Object:  Table [dbo].[TreasurySymbols]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreasurySymbols](
	[TreasurySymbolsId] [int] NOT NULL,
	[ShortKey] [nvarchar](80) NULL,
	[AllocationTransferAgency] [nvarchar](80) NULL,
	[AgencyIdentifier] [nvarchar](80) NULL,
	[BeginningPeriodOfAvailability] [nvarchar](80) NULL,
	[EndingPeriodOfAvailability] [nvarchar](80) NULL,
	[AvailabilityType] [nvarchar](80) NULL,
	[MainAccount] [nvarchar](80) NULL,
	[SubAccount] [nvarchar](80) NULL,
	[Lapsed] [nvarchar](80) NULL,
	[UseCancelledYearSpendingAccounts] [nvarchar](80) NULL,
	[AgencyTreasurySymbol] [nvarchar](80) NULL,
	[InUse] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
 CONSTRAINT [PK_TreasurySymbols] PRIMARY KEY CLUSTERED 
(
	[TreasurySymbolsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE
[Data]
GO
/****** Object:  Table [dbo].[UnobligatedBalances]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnobligatedBalances]
(
    [
    UnobligatedBalancesId ] [
    int ]
    NOT
    NULL, [
    BudgetYear ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [BudgetAccount] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [AccountNumber] [nvarchar]
(
    80
) NULL,
    [AccountName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_UnobligatedBalances] PRIMARY KEY CLUSTERED
(
[
    UnobligatedBalancesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

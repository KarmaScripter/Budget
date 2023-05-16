USE
[Data]
GO
/****** Object:  Table [dbo].[StatusOfInflationReductionActFunds]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfInflationReductionActFunds]
(
    [
    StatusOfSupplementalFundingId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [OpenCommitments] [float] NULL,
    [ULO] [float] NULL,
    [Expenditures] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [Available] [float] NULL,
    [Balance] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    CONSTRAINT [PK_StatusOfInflationReductionActFunds] PRIMARY KEY CLUSTERED
(
[
    StatusOfSupplementalFundingId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

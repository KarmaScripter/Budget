USE
[Data]
GO
/****** Object:  Table [dbo].[RegionalAuthority]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegionalAuthority]
(
    [
    RegionalAuthorityId ] [
    int ]
    NOT
    NULL, [
    AllocationsId ] [
    int ]
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    255
) NULL,
    [BFY] [nvarchar]
(
    255
) NULL,
    [EFY] [nvarchar]
(
    255
) NULL,
    [FundCode] [nvarchar]
(
    255
) NULL,
    [FundName] [nvarchar]
(
    255
) NULL,
    [RpioCode] [nvarchar]
(
    255
) NULL,
    [RpioName] [nvarchar]
(
    255
) NULL,
    [AhCode] [nvarchar]
(
    255
) NULL,
    [AhName] [nvarchar]
(
    255
) NULL,
    [OrgCode] [nvarchar]
(
    255
) NULL,
    [OrgName] [nvarchar]
(
    255
) NULL,
    [AccountCode] [nvarchar]
(
    255
) NULL,
    [RcCode] [nvarchar]
(
    255
) NULL,
    [RcName] [nvarchar]
(
    255
) NULL,
    [BocCode] [nvarchar]
(
    255
) NULL,
    [BocName] [nvarchar]
(
    255
) NULL,
    [Amount] [float] NULL,
    [ProgramProjectCode] [nvarchar]
(
    255
) NULL,
    [ProgramProjectName] [nvarchar]
(
    255
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    255
) NULL,
    [ProgramAreaName] [nvarchar]
(
    255
) NULL,
    [NpmCode] [nvarchar]
(
    255
) NULL,
    [NpmName] [nvarchar]
(
    255
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    255
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    255
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    255
) NULL,
    [BudgetAccountName] [nvarchar]
(
    255
) NULL
    ) ON [PRIMARY]
    GO

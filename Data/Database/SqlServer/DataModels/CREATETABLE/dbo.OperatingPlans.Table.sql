USE
[Data]
GO
/****** Object:  Table [dbo].[OperatingPlans]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperatingPlans]
(
    [
    OperatingPlansId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
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
    [OrgCode] [nvarchar]
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
    [Amount] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [ActivityName] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [GoalName] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveName] [nvarchar]
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
    [Version] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_OperatingPlans] PRIMARY KEY CLUSTERED
(
[
    OperatingPlansId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

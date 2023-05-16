USE
[Data]
GO
/****** Object:  Table [dbo].[CongressionalProjects]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongressionalProjects]
(
    [
    CongressionalEarmarksId ] [
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
    [AhName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    [StateCode] [nvarchar]
(
    80
) NULL,
    [StateName] [nvarchar]
(
    80
) NULL,
    [Project] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
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
    CONSTRAINT [PK_CongressionalProjects] PRIMARY KEY CLUSTERED
(
[
    CongressionalEarmarksId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

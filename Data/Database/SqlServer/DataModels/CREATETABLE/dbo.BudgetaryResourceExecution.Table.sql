USE
[Data]
GO
/****** Object:  Table [dbo].[BudgetaryResourceExecution]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetaryResourceExecution]
(
    [
    BudgetaryResourceExecutionId ] [
    int ]
    NOT
    NULL, [
    FiscalYear ] [
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
    [LastUpdate] [datetime] NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [STAT] [nvarchar]
(
    80
) NULL,
    [CreditIndicator] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineDescription] [nvarchar]
(
    80
) NULL,
    [SectionName] [nvarchar]
(
    80
) NULL,
    [SectionNumber] [nvarchar]
(
    80
) NULL,
    [LineType] [nvarchar]
(
    80
) NULL,
    [FinancingAccounts] [nvarchar]
(
    80
) NULL,
    [November] [float] NULL,
    [January] [float] NULL,
    [Feburary] [float] NULL,
    [April] [float] NULL,
    [May] [float] NULL,
    [June] [float] NULL,
    [August] [float] NULL,
    [October] [float] NULL,
    [Amount1] [float] NULL,
    [Amount2] [float] NULL,
    [Amount3] [float] NULL,
    [Amount4] [float] NULL,
    CONSTRAINT [PK_BudgetaryResourceExecution] PRIMARY KEY CLUSTERED
(
[
    BudgetaryResourceExecutionId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

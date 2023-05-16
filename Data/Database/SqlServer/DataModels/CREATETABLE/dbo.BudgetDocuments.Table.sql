USE
[Data]
GO
/****** Object:  Table [dbo].[BudgetDocuments]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetDocuments]
(
    [
    BudgetDocumentsId ] [
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
    [BudgetLevel] [nvarchar]
(
    80
) NULL,
    [DocumentDate] [datetime] NULL,
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
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
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [CarryoverOut] [float] NULL,
    [CarryoverIn] [float] NULL,
    [Recoveries] [float] NULL,
    [Reimbursements] [float] NULL,
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
    CONSTRAINT [PK_BudgetDocuments] PRIMARY KEY CLUSTERED
(
[
    BudgetDocumentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

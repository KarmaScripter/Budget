CREATE TABLE [AppropriationLevelAuthority]
(
   [AppropriationLevelAuthorityId] INT NOT NULL IDENTITY (939,1),
   [BudgetAccountCode] NVARCHAR(80),
   [BudgetAccountName] NVARCHAR(80),
   [FiscalYear] NVARCHAR(80),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [Budgeted] DECIMAL(18,0),
   [Posted] DECIMAL(18,0),
   [CarryOut] DECIMAL(18,0),
   [CarryIn] DECIMAL(18,0),
   [EstimatedReimbursements] DECIMAL(18,0),
   [EstimatedRecoveries] DECIMAL(18,0)
);

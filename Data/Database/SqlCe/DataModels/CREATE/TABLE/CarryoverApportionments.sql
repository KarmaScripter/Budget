CREATE TABLE [CarryoverApportionments]
(
   [CarryoverApportionmentsId] INT NOT NULL IDENTITY (99,1),
   [BudgetAccount] NVARCHAR(80),
   [TreasuryAccount] NVARCHAR(80),
   [BFY] NVARCHAR(80),
   [EFY] NVARCHAR(80),
   [Group] NVARCHAR(80),
   [Description] NVARCHAR(80),
   [LineName] NVARCHAR(80),
   [AuthorityType] NVARCHAR(80),
   [Request] DECIMAL(18,0),
   [Balance] DECIMAL(18,0),
   [Deobligations] DECIMAL(18,0),
   [Amount] DECIMAL(18,0),
   [LineNumber] NVARCHAR(80),
   [LineSplit] NVARCHAR(80),
   [ApportionmentAccountCode] NVARCHAR(80),
   [TreasuryAccountCode] NVARCHAR(80),
   [TreasuryAccountName] NVARCHAR(80),
   [BudgetAccountCode] NVARCHAR(80),
   [BudgetAccountName] NVARCHAR(80)
);

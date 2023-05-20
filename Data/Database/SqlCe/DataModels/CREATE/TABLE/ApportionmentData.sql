CREATE TABLE [ApportionmentData]
(
   [ApportionmentDataId] INT NOT NULL IDENTITY (2080,1),
   [FiscalYear] NVARCHAR(80),
   [BFY] NVARCHAR(80),
   [EFY] NVARCHAR(80),
   [TreasuryAppropriationFundSymbol] NVARCHAR(80),
   [TreasuryAppropriationFundSymbolName] NVARCHAR(80),
   [ApportionmentAccountCode] NVARCHAR(80),
   [ApportionmentAccountName] NVARCHAR(80),
   [AvailabilityType] NVARCHAR(80),
   [BudgetAccountCode] NVARCHAR(80),
   [BudgetAccountName] NVARCHAR(80),
   [ApprovalDate] DATETIME,
   [LineNumber] NVARCHAR(80),
   [LineName] NVARCHAR(80),
   [Amount] DECIMAL(18,0)
);

CREATE TABLE [AppropriationAvailableBalances]
(
   [AppropriationAvailableBalancesId] INT NOT NULL IDENTITY (1299,1),
   [BFY] NVARCHAR(80),
   [EFY] NVARCHAR(80),
   [AppropriationFundCode] NVARCHAR(80),
   [AppropriationFundName] NVARCHAR(80),
   [TreasurySymbol] NVARCHAR(80),
   [OmbAccountCode] NVARCHAR(80),
   [Availability] NVARCHAR(80),
   [TotalAuthority] DECIMAL(18,0),
   [TotalUsed] DECIMAL(18,0),
   [Available] DECIMAL(18,0)
);

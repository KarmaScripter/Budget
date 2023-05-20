CREATE TABLE [CompassOutlays]
(
   [CompassOutlaysId] INT NOT NULL IDENTITY (3204,1),
   [BFY] NVARCHAR(80),
   [EFY] NVARCHAR(80),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [AppropriationCode] NVARCHAR(80),
   [AppropriationName] NVARCHAR(80),
   [TreasurySymbol] NVARCHAR(80),
   [ProgramAreaCode] NVARCHAR(80),
   [ProgramAreaName] NVARCHAR(80),
   [ProgramProjectCode] NVARCHAR(80),
   [ProgramProjectName] NVARCHAR(80),
   [BocCode] NVARCHAR(80),
   [BocName] NVARCHAR(80),
   [TotalObligations] DECIMAL(18,0),
   [UnliquidatedObligations] DECIMAL(18,0),
   [ObligationsPaid] DECIMAL(18,0)
);

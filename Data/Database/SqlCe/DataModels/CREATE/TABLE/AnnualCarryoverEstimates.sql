CREATE TABLE [AnnualCarryoverEstimates]
(
   [AnnualCarryoverEstimatesId] INT NOT NULL IDENTITY (6758,1),
   [BFY] NVARCHAR(80),
   [EFY] NVARCHAR(80),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [TreasuryAccountCode] NVARCHAR(80),
   [RpioCode] NVARCHAR(80),
   [RpioName] NVARCHAR(80),
   [Amount] DECIMAL(18,0),
   [OpenCommitments] DECIMAL(18,0),
   [Obligations] DECIMAL(18,0),
   [Available] DECIMAL(18,0),
   [Estimate] DECIMAL(18,0)
);

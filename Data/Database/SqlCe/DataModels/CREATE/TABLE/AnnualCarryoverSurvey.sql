CREATE TABLE [AnnualCarryoverSurvey]
(
   [AnnualCarryoverSurveyId] INT NOT NULL IDENTITY (300,1),
   [BFY] NVARCHAR(80),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [TreasuryAccountCode] NVARCHAR(80),
   [Amount] DECIMAL(18,0)
);

CREATE TABLE [AnnualReimbursableSurvey]
(
   [AnnualReimbursableSurveyId] INT NOT NULL IDENTITY (2,1),
   [BFY] NVARCHAR(80),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [Amount] DECIMAL(18,0)
);

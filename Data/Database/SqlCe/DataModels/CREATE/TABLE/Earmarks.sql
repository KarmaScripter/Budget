CREATE TABLE [Earmarks]
(
   [EarmarksId] INT NOT NULL IDENTITY (492,1),
   [RpioCode] NVARCHAR(80),
   [RpioName] NVARCHAR(80),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [StateCode] NVARCHAR(80),
   [Description] NVARCHAR(80),
   [Amount] DECIMAL(18,0),
   [ProjectOfficerLastName] NVARCHAR(80),
   [ProjectOfficerFirstName] NVARCHAR(80),
   [ProjectOfficerPhoneNumber] NVARCHAR(80),
   [ProjectOfficerMailCode] NVARCHAR(80),
   [CommitmentDate] DATETIME,
   [ObligationDate] DATETIME,
   [ProjectStatus] NVARCHAR(80),
   [ProjectOfficerComments] NVARCHAR(80)
);

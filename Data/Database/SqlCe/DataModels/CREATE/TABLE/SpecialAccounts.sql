﻿CREATE TABLE [SpecialAccounts]
(
   [SpecialAccountsId] INT NOT NULL IDENTITY (957754,1),
   [BFY] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [SpecialAccountFund] NVARCHAR(80) NULL,
   [SpecialAccountNumber] NVARCHAR(80) NULL,
   [SpecialAccountName] NVARCHAR(80) NULL,
   [AccountStatus] NVARCHAR(80) NULL,
   [NplStatusCode] NVARCHAR(80) NULL,
   [NplStatusName] NVARCHAR(80) NULL,
   [SiteId] NVARCHAR(80) NULL,
   [CerclisId] NVARCHAR(80) NULL,
   [SiteCode] NVARCHAR(80) NULL,
   [SiteName] NVARCHAR(80) NULL,
   [OperableUnit] NVARCHAR(80) NULL,
   [PipelineCode] NVARCHAR(80) NULL,
   [PipelineDescription] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [TransactionType] NVARCHAR(80) NULL,
   [TransactionTypeName] NVARCHAR(80) NULL,
   [FocCode] NVARCHAR(80) NULL,
   [FocName] NVARCHAR(80) NULL,
   [TransactionDate] DATETIME,
   [AvailableBalance] DECIMAL(18,0),
   [OpenCommitments] DECIMAL(18,0),
   [Obligations] DECIMAL(18,0),
   [ULO] DECIMAL(18,0),
   [Disbursements] DECIMAL(18,0),
   [UnpaidBalances] DECIMAL(18,0),
   [Collections] DECIMAL(18,0),
   [CumulativeReceipts] DECIMAL(18,0)
);

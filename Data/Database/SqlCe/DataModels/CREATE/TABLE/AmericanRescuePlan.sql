﻿CREATE TABLE [AmericanRescuePlan]
(
   [AmericanRescuePlanId] INT NOT NULL,
   [StatusOfFundsId] INT NOT NULL,
   [BudgetLevel] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [AhCode] NVARCHAR(80) NULL,
   [AhName] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [OrgName] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [ProgramAreaCode] NVARCHAR(80) NULL,
   [ProgramAreaName] NVARCHAR(80) NULL,
   [RcCode] NVARCHAR(80) NULL,
   [RcName] NVARCHAR(80) NULL,
   [LowerName] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [Budgeted] DECIMAL(18,0),
   [Posted] DECIMAL(18,0),
   [OpenCommitments] DECIMAL(18,0),
   [ULO] DECIMAL(18,0),
   [Expenditures] DECIMAL(18,0),
   [Obligations] DECIMAL(18,0),
   [Used] DECIMAL(18,0),
   [Available] DECIMAL(18,0),
   [NpmCode] NVARCHAR(80) NULL,
   [NpmName] NVARCHAR(80)
);

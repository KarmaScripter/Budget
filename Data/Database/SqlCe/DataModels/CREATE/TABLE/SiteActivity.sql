﻿CREATE TABLE [SiteActivity]
(
   [SiteActivityId] INT NOT NULL IDENTITY (266266,1),
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [RpioName] NVARCHAR(80) NULL,
   [AhCode] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [OrgName] NVARCHAR(80) NULL,
   [FocCode] NVARCHAR(80) NULL,
   [FocName] NVARCHAR(80) NULL,
   [EpaSiteId] NVARCHAR(80) NULL,
   [SiteProjectCode] NVARCHAR(80) NULL,
   [SSID] NVARCHAR(80) NULL,
   [ActionCode] NVARCHAR(80) NULL,
   [OperableUnit] NVARCHAR(80) NULL,
   [SiteProjectName] NVARCHAR(80) NULL,
   [State] NVARCHAR(80) NULL,
   [City] NVARCHAR(80) NULL,
   [CongressionalDistrict] NVARCHAR(80) NULL,
   [ProjectType] NVARCHAR(80) NULL,
   [StartDate] DATETIME,
   [EndDate] DATETIME,
   [LastActivity] DATETIME,
   [Requested] DECIMAL(18,0),
   [Accepted] DECIMAL(18,0),
   [Closed] DECIMAL(18,0),
   [Outstanding] DECIMAL(18,0),
   [Refunded] DECIMAL(18,0),
   [Reversal] DECIMAL(18,0)
);

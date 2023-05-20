﻿CREATE TABLE [CongressionalReprogrammings]
(
   [CongressionalReprogrammingsId] INT NOT NULL IDENTITY (2,1),
   [ReprogrammingNumber] NVARCHAR(80) NULL,
   [BFY] NVARCHAR(80) NULL,
   [EFY] NVARCHAR(80) NULL,
   [RpioCode] NVARCHAR(80) NULL,
   [AhCode] NVARCHAR(80) NULL,
   [AhName] NVARCHAR(80) NULL,
   [FundCode] NVARCHAR(80) NULL,
   [FundName] NVARCHAR(80) NULL,
   [AccountCode] NVARCHAR(80) NULL,
   [ProgramProjectCode] NVARCHAR(80) NULL,
   [ProgramProjectName] NVARCHAR(80) NULL,
   [ProgramAreaCode] NVARCHAR(80) NULL,
   [ProgramAreaName] NVARCHAR(80) NULL,
   [OrgCode] NVARCHAR(80) NULL,
   [OrgName] NVARCHAR(80) NULL,
   [BocCode] NVARCHAR(80) NULL,
   [BocName] NVARCHAR(80) NULL,
   [ActivityCode] NVARCHAR(80) NULL,
   [Amount] DECIMAL(18,0),
   [Description] NVARCHAR(155),
   [ExtendedDescription] NTEXT,
   [FromTo] NVARCHAR(80) NULL,
   [Cycle] NVARCHAR(80)
);

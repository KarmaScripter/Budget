﻿CREATE TABLE [Transfers]
(
    [
    TransfersId ]
    INT
    NOT
    NULL
    IDENTITY
(
    1,
    1
),
    [BudgetLevel] NVARCHAR
(
    255
),
    [DocType] NVARCHAR
(
    255
),
    [BFY] NVARCHAR
(
    255
),
    [RPIO] NVARCHAR
(
    255
),
    [FundCode] NVARCHAR
(
    255
),
    [FundName] NVARCHAR
(
    255
),
    [DocumentNumber] NVARCHAR
(
    255
),
    [ProcessedDate] DATETIME,
    [AhCode] NVARCHAR
(
    255
),
    [AhName] NVARCHAR
(
    255
),
    [OrgCode] NVARCHAR
(
    255
),
    [OrgName] NVARCHAR
(
    255
),
    [RcCode] NVARCHAR
(
    255
),
    [DivisionName] NVARCHAR
(
    255
),
    [Code] NVARCHAR
(
    255
) NOT NULL,
    [ProgramAreaCode] NVARCHAR
(
    255
),
    [ProgramAreaName] NVARCHAR
(
    255
),
    [ProgramProjectCode] NVARCHAR
(
    255
),
    [ResourceType] NVARCHAR
(
    255
),
    [Line] FLOAT,
    [Subline] FLOAT,
    [FromTo] NVARCHAR
(
    255
),
    [BocCode] NVARCHAR
(
    255
),
    [BocName] NVARCHAR
(
    255
),
    [Amount] FLOAT NOT NULL,
    [Purpose] NTEXT,
    CONSTRAINT PK_Transfers
    PRIMARY KEY
(
    TransfersId
)
    );

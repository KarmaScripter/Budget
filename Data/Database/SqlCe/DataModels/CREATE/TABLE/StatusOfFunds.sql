﻿CREATE TABLE [StatusOfFunds]
(
    [
    StatusOfFundsId ]
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
    [BFY] NVARCHAR
(
    255
),
    [EFY] NVARCHAR
(
    255
),
    [RpioCode] NVARCHAR
(
    255
),
    [RpioName] NVARCHAR
(
    255
),
    [AhCode] NVARCHAR
(
    255
),
    [AhName] NVARCHAR
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
    [ProgramProjectName] NVARCHAR
(
    255
),
    [AccountCode] NVARCHAR
(
    255
),
    [LowerName] NVARCHAR
(
    255
),
    [RcCode] NVARCHAR
(
    255
),
    [RcName] NVARCHAR
(
    255
),
    [DivisionName] NVARCHAR
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
    [BocCode] NVARCHAR
(
    255
),
    [BocName] NVARCHAR
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
    [Amount] FLOAT,
    [OpenCommitments] FLOAT,
    [ULO] FLOAT,
    [ExpenseAccruals] FLOAT,
    [Expenditures] FLOAT,
    [Obligations] FLOAT,
    [Used] FLOAT,
    [Available] FLOAT,
    [NpmCode] NVARCHAR
(
    255
),
    [NpmName] NVARCHAR
(
    255
),
    [NpmTitle] NVARCHAR
(
    255
),
    [ProgramAreaCode] NVARCHAR
(
    255
),
    CONSTRAINT PK_StatusOfFunds
    PRIMARY KEY
(
    StatusOfFundsId
)
    );
CREATE TABLE PayrollCostCodes
(
    PayrollCostCodesId AUTOINCREMENT NOT NULL UNIQUE,
    RpioCode           TEXT(80) NULL DEFAULT NS,
    RpioName           TEXT(80) NULL DEFAULT NS,
    AhCode             TEXT(80) NULL DEFAULT NS,
    AhName             TEXT(80) NULL DEFAULT NS,
    RcCode             TEXT(80) NULL DEFAULT NS,
    RcName             TEXT(80) NULL DEFAULT NS,
    SubRcCode          TEXT(80) NULL DEFAULT NS,
    SubRcName          TEXT(80) NULL DEFAULT NS,
    HrOrgCode          TEXT(80) NULL DEFAULT NS,
    HrOrgName          TEXT(80) NULL DEFAULT NS,
    WorkCode           TEXT(80) NULL DEFAULT NS,
    WorkCodeName       TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY ( PayrollCostCodesId )
);
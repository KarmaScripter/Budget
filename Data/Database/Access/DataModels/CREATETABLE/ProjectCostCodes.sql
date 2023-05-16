CREATE TABLE ProjectCostCodes
(
    ProjectCostCodeId  INTEGER,
    BFY                INTEGER,
    RpioCode           INTEGER,
    RpioName           TEXT(80) NULL DEFAULT NS,
    AhCode             INTEGER,
    AhName             TEXT(80) NULL DEFAULT NS,
    FundCode           TEXT(80) NULL DEFAULT NS,
    FundName           TEXT(80) NULL DEFAULT NS,
    AccountCode        TEXT(80) NULL DEFAULT NS,
    ProgramProjectName TEXT(80) NULL DEFAULT NS,
    BocCode            INTEGER,
    BocName            TEXT(80) NULL DEFAULT NS,
    OrgCode            TEXT(80) NULL DEFAULT NS,
    OrgName            TEXT(80) NULL DEFAULT NS,
    VendorCode         TEXT(80) NULL DEFAULT NS,
    VendorName         TEXT
)
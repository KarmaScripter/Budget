CREATE TABLE GrossUtilization
(
    GrossUtilizationId AUTOINCREMENT NOT NULL UNIQUE,
    BFY                TEXT(80) NULL DEFAULT NS,
    EFY                TEXT(80) NULL DEFAULT NS,
    FundCode           TEXT(80) NULL DEFAULT NS,
    FundName           TEXT(80) NULL DEFAULT NS,
    RpioCode           TEXT(80) NULL DEFAULT NS,
    RpioName           TEXT(80) NULL DEFAULT NS,
    AhCode             TEXT(80) NULL DEFAULT NS,
    AhName             TEXT(80) NULL DEFAULT NS,
    OrgCode            TEXT(80) NULL DEFAULT NS,
    OrgName            TEXT(80) NULL DEFAULT NS,
    AccountCode        TEXT(80) NULL DEFAULT NS,
    ProgramProjectName TEXT(80) NULL DEFAULT NS,
    BocCode            TEXT(80) NULL DEFAULT NS,
    BocName            TEXT(80) NULL DEFAULT NS,
    Committed          DECIMAL NULL DEFAULT 0.0,
    Obligated          DECIMAL NULL DEFAULT 0.0,
    Unliquidated       DECIMAL NULL DEFAULT 0.0,
    Utilization        DECIMAL NULL DEFAULT 0.0,
    Availability       DECIMAL NULL DEFAULT 0.0,
    Outlaid            DECIMAL NULL DEFAULT 0.0,
    PRIMARY KEY ( GrossUtilizationId )
);
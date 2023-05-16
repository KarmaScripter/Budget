CREATE TABLE Defactos
(
    DefactosId         INTEGER NOT NULL UNIQUE AUTONUMBER,
    StatusOfFundsId    INT     NOT NULL,
    BudgetLevel        TEXT(80) NULL DEFAULT 'NS',
    BFY                TEXT(80) NULL DEFAULT 'NS',
    EFY                TEXT(80) NULL DEFAULT 'NS',
    RpioCode           TEXT(80) NULL DEFAULT 'NS',
    RpioName           TEXT(80) NULL DEFAULT 'NS',
    AhCode             TEXT(80) NULL DEFAULT 'NS',
    AhName             TEXT(80) NULL DEFAULT 'NS',
    FundCode           TEXT(80) NULL DEFAULT 'NS',
    FundName           TEXT(80) NULL DEFAULT 'NS',
    OrgCode            TEXT(80) NULL DEFAULT 'NS',
    OrgName            TEXT(80) NULL DEFAULT 'NS',
    AccountCode        TEXT(80) NULL DEFAULT 'NS',
    BocCode            TEXT(80) NULL DEFAULT 'NS',
    BocName            TEXT(80) NULL DEFAULT 'NS',
    ProgramProjectCode TEXT(80) NULL DEFAULT 'NS',
    ProgramProjectName TEXT(80) NULL DEFAULT 'NS',
    ProgramAreaCode    TEXT(80) NULL DEFAULT 'NS',
    ProgramAreaName    TEXT(80) NULL DEFAULT 'NS',
    RcCode             TEXT(80) NULL DEFAULT 'NS',
    RcName             TEXT(80) NULL DEFAULT 'NS',
    LowerName          TEXT(80) NULL DEFAULT 'NS',
    Amount             FLOAT DEFAULT 0.0,
    Budgeted           FLOAT DEFAULT 0.0,
    Posted             FLOAT DEFAULT 0.0,
    OpenCommitments    FLOAT DEFAULT 0.0,
    ULO                FLOAT DEFAULT 0.0,
    Expenditures       FLOAT DEFAULT 0.0,
    Obligations        FLOAT DEFAULT 0.0,
    Used               FLOAT DEFAULT 0.0,
    Available          FLOAT DEFAULT 0.0,
    NpmCode            TEXT(80) NULL DEFAULT 'NS',
    NpmName            TEXT(80) NULL DEFAULT 'NS',
    PRIMARY KEY ( DefactosId AUTOINCREMENT )
);
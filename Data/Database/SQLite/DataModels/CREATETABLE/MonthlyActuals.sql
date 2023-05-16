CREATE TABLE IF NOT EXISTS MonthlyActuals
(
    MonthlyActualsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BFY
    TEXT
(
    80
) NULL DEFAULT NS,
    EFY TEXT
(
    80
) NULL DEFAULT NS,
    FundCode TEXT
(
    80
) NULL DEFAULT NS,
    FundName TEXT
(
    80
) NULL DEFAULT NS,
    AppropriationCode TEXT
(
    80
) NULL DEFAULT NS,
    AppropriationName TEXT
(
    80
) NULL DEFAULT NS,
    SubAppropriationCode TEXT
(
    80
) NULL DEFAULT NS,
    SubAppropriationName TEXT
(
    80
) NULL DEFAULT NS,
    RpioCode TEXT
(
    80
) NULL DEFAULT NS,
    RpioName TEXT
(
    80
) NULL DEFAULT NS,
    AhCode TEXT
(
    80
) NULL DEFAULT NS,
    AhName TEXT
(
    80
) NULL DEFAULT NS,
    OrgCode TEXT
(
    80
) NULL DEFAULT NS,
    OrgName TEXT
(
    80
) NULL DEFAULT NS,
    RpioActivityCode TEXT
(
    80
) NULL DEFAULT NS,
    AccountCode TEXT
(
    80
) NULL DEFAULT NS,
    ProgramProjectCode TEXT
(
    80
) NULL DEFAULT NS,
    ProgramProjectName TEXT
(
    80
) NULL DEFAULT NS,
    BocCode TEXT
(
    80
) NULL DEFAULT NS,
    BocName TEXT
(
    80
) NULL DEFAULT NS,
    NetOutlays DOUBLE NULL DEFAULT 0.0,
    GrossOutlays DOUBLE NULL DEFAULT 0.0,
    Obligations DOUBLE NULL DEFAULT 0.0,
    TreasuryAccountCode TEXT
(
    80
) NULL DEFAULT NS,
    TreasuryAccountName TEXT
(
    80
) NULL DEFAULT NS,
    BudgetAccountCode TEXT
(
    80
) NULL DEFAULT NS,
    BudgetAccountName TEXT
(
    80
) NULL DEFAULT NS,
    PRIMARY KEY
(
    MonthlyActualsId AUTOINCREMENT
)
    );
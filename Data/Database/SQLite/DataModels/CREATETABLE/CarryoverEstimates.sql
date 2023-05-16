CREATE TABLE IF NOT EXISTS CarryoverEstimates
(
    CarryoverEstimatesId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BudgetLevel
    TEXT
(
    80
) NULL DEFAULT 'NS',
    BFY TEXT
(
    80
) NULL DEFAULT 'NS',
    EFY TEXT
(
    80
) NULL DEFAULT 'NS',
    RpioCode TEXT
(
    80
) NULL DEFAULT 'NS',
    RpioName TEXT
(
    80
) NULL DEFAULT 'NS',
    AhCode TEXT
(
    80
) NULL DEFAULT 'NS',
    AhName TEXT
(
    80
) NULL DEFAULT 'NS',
    FundCode TEXT
(
    80
) NULL DEFAULT 'NS',
    FundName TEXT
(
    80
) NULL DEFAULT 'NS',
    OrgCode TEXT
(
    80
) NULL DEFAULT 'NS',
    AccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramProjectCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramProjectName TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramAreaCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramAreaName TEXT
(
    80
) NULL DEFAULT 'NS',
    BocCode TEXT
(
    80
) NULL DEFAULT 'NS',
    BocName TEXT
(
    80
) NULL DEFAULT 'NS',
    AvailableBalance NUMERIC NULL DEFAULT 0.0,
    OpenCommitments NUMERIC NULL DEFAULT 0.0,
    UnobligatedAuthority NUMERIC NULL DEFAULT 0.0,
    PRIMARY KEY
(
    CarryoverEstimatesId
)
    );
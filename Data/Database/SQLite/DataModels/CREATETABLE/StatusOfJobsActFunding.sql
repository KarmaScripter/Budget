CREATE TABLE IF NOT EXISTS StatusOfJobsActFunding
(
    StatusOfJobsActFundingId
    INTEGER
    NOT
    NULL
    UNIQUE,
    StatusOfFundsId
    INTEGER
    NOT
    NULL,
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
    OrgName TEXT
(
    80
) NULL DEFAULT 'NS',
    AccountCode TEXT
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
    NpmCode TEXT
(
    80
) NULL DEFAULT 'NS',
    NpmName TEXT
(
    80
) NULL DEFAULT 'NS',
    RcCode TEXT
(
    80
) NULL DEFAULT 'NS',
    RcName TEXT
(
    80
) NULL DEFAULT 'NS',
    LowerName TEXT
(
    80
) NULL DEFAULT 'NS',
    Amount DOUBLE NULL DEFAULT 0.0,
    Budgeted DOUBLE NULL DEFAULT 0.0,
    Posted DOUBLE NULL DEFAULT 0.0,
    OpenCommitments DOUBLE NULL DEFAULT 0.0,
    ULO DOUBLE NULL DEFAULT 0.0,
    Expenditures DOUBLE NULL DEFAULT 0.0,
    Obligations DOUBLE NULL DEFAULT 0.0,
    Used DOUBLE NULL DEFAULT 0.0,
    Available DOUBLE NULL DEFAULT 0.0,
    TreasuryAccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAccountName TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetAccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetAccountName TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    StatusOfJobsActFundingId AUTOINCREMENT
)
    );
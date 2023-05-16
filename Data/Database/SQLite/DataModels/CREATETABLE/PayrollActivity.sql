CREATE TABLE IF NOT EXISTS PayrollActivity
(
    PayrollActivityId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BFY
    TEXT
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
    FundCode TEXT
(
    80
) NULL DEFAULT 'NS',
    FundName TEXT
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
    RcCode TEXT
(
    80
) NULL DEFAULT 'NS',
    RcName TEXT
(
    80
) NULL DEFAULT 'NS',
    SubRcCode TEXT
(
    80
) NULL DEFAULT 'NS',
    SubRcName TEXT
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
    NpmCode TEXT
(
    80
) NULL DEFAULT 'NS',
    NpmName TEXT
(
    80
) NULL DEFAULT 'NS',
    FocCode TEXT
(
    80
) NULL DEFAULT 'NS',
    FocName TEXT
(
    80
) NULL DEFAULT 'NS',
    HrOrgCode TEXT
(
    80
) NULL DEFAULT 'NS',
    HrOrgName TEXT
(
    80
) NULL DEFAULT 'NS',
    WorkCode TEXT
(
    80
) NULL DEFAULT 'NS',
    WorkCodeName TEXT
(
    80
) NULL DEFAULT 'NS',
    PayPeriod TEXT
(
    80
) NULL DEFAULT 'NS',
    StartDate TEXT
(
    80
) NULL DEFAULT 'NS',
    EndDate TEXT
(
    80
) NULL DEFAULT 'NS',
    CheckDate TEXT
(
    80
) NULL DEFAULT 'NS',
    Amount DOUBLE NULL DEFAULT 0.0,
    Hours DOUBLE NULL DEFAULT 0.0,
    BasePaid DOUBLE NULL DEFAULT 0.0,
    BaseHours DOUBLE NULL DEFAULT 0.0,
    Benefits DOUBLE NULL DEFAULT 0.0,
    OvertimePaid DOUBLE NULL DEFAULT 0.0,
    OvertimeHours DOUBLE NULL DEFAULT 0.0,
    PRIMARY KEY
(
    PayrollActivityId AUTOINCREMENT
)
    );
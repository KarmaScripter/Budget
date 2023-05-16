CREATE TABLE IF NOT EXISTS OperatingPlans
(
    OperatingPlansId
    INTEGER
    NOT
    NULL
    UNIQUE,
    RpioCode
    TEXT
(
    80
) NULL DEFAULT 'NS',
    RpioName TEXT
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
    AhCode TEXT
(
    80
) NULL DEFAULT 'NS',
    FundCode TEXT
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
    RcCode TEXT
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
    Amount DOUBLE NULL DEFAULT 0.0,
    ITProjectCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProjectCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProjectName TEXT
(
    80
) NULL DEFAULT 'NS',
    NpmCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProjectTypeName TEXT
(
    80
) NULL DEFAULT 'NS',
    ProjectTypeCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramProjectCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramAreaCode TEXT
(
    80
) NULL DEFAULT 'NS',
    NpmName TEXT
(
    80
) NULL DEFAULT 'NS',
    AhName TEXT
(
    80
) NULL DEFAULT 'NS',
    FundName TEXT
(
    80
) NULL DEFAULT 'NS',
    OrgName TEXT
(
    80
) NULL DEFAULT 'NS',
    RcName TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramProjectName TEXT
(
    80
) NULL DEFAULT 'NS',
    ActivityCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ActivityName TEXT
(
    80
) NULL DEFAULT 'NS',
    LocalCode TEXT
(
    80
) NULL DEFAULT 'NS',
    LocalCodeName TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramAreaName TEXT
(
    80
) NULL DEFAULT 'NS',
    CostAreaCode TEXT
(
    80
) NULL DEFAULT 'NS',
    CostAreaName TEXT
(
    80
) NULL DEFAULT 'NS',
    GoalCode TEXT
(
    80
) NULL DEFAULT 'NS',
    GoalName TEXT
(
    80
) NULL DEFAULT 'NS',
    ObjectiveCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ObjectiveName TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    OperatingPlansId AUTOINCREMENT
)
    );
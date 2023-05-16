CREATE TABLE IF NOT EXISTS Deobligations
(
    DeobligationsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BFY
    TEXT
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
    AccountCode TEXT
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
    ProgramProjectCode TEXT
(
    80
) NULL DEFAULT 'NS',
    ProgramProjectName TEXT
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
    BocCode TEXT
(
    80
) NULL DEFAULT 'NS',
    BocName TEXT
(
    80
) NULL DEFAULT 'NS',
    DocumentNumber TEXT
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
    ProcessedDate TEXT
(
    80
) NULL DEFAULT 'NS',
    Amount REAL DEFAULT 0.0,
    PRIMARY KEY
(
    DeobligationsId AUTOINCREMENT
)
    );
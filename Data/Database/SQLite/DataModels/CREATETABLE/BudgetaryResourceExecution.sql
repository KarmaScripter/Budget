CREATE TABLE IF NOT EXISTS BudgetaryResourceExecution
(
    BudgetaryResourceExecutionId
    INTEGER
    NOT
    NULL
    UNIQUE,
    FiscalYear
    TEXT
(
    80
) NULL DEFAULT 'NS',
    Agency TEXT
(
    80
) NULL DEFAULT 'NS',
    Bureau TEXT
(
    80
) NULL DEFAULT 'NS',
    OmbAccount TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAgencyCode TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAccountCode TEXT
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
    STAT TEXT
(
    80
) NULL DEFAULT 'NS',
    CreditIndicator TEXT
(
    80
) NULL DEFAULT 'NS',
    LineNumber TEXT
(
    80
) NULL DEFAULT 'NS',
    LineDescription TEXT
(
    80
) NULL DEFAULT 'NS',
    TAFS TEXT
(
    80
) NULL DEFAULT 'NS',
    AgencyTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    LastUpdate TEXT
(
    80
) NULL DEFAULT 'NS',
    SectionName TEXT
(
    80
) NULL DEFAULT 'NS',
    SectionNumber TEXT
(
    80
) NULL DEFAULT 'NS',
    LineType TEXT
(
    80
) NULL DEFAULT 'NS',
    TafsAccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    BureauTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    OmbAccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    FinancingAccounts TEXT
(
    80
) NULL DEFAULT 'NS',
    November DOUBLE NULL DEFAULT 0.0,
    January DOUBLE NULL DEFAULT 0.0,
    Feburary DOUBLE NULL DEFAULT 0.0,
    April DOUBLE NULL DEFAULT 0.0,
    May DOUBLE NULL DEFAULT 0.0,
    June DOUBLE NULL DEFAULT 0.0,
    August DOUBLE NULL DEFAULT 0.0,
    October DOUBLE NULL DEFAULT 0.0,
    Amount1 DOUBLE NULL DEFAULT 0.0,
    Amount2 DOUBLE NULL DEFAULT 0.0,
    Amount3 DOUBLE NULL DEFAULT 0.0,
    Amount4 DOUBLE NULL DEFAULT 0.0,
    PRIMARY KEY
(
    BudgetaryResourceExecutionId,
    AUTOINCREMENT
)
    );
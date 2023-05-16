CREATE TABLE IF NOT EXISTS MonthlyOutlays
(
    MonthlyOutlaysId
    INTEGER
    NOT
    NULL
    UNIQUE,
    FiscalYear
    TEXT
(
    80
) NULL DEFAULT 'NS',
    LineNumber TEXT
(
    80
) NULL DEFAULT 'NS',
    LineTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    TaxationCode TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAgency TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAccount TEXT
(
    80
) NULL DEFAULT 'NS',
    SubAccount TEXT
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
    OmbAgency TEXT
(
    80
) NULL DEFAULT 'NS',
    OmbBureau TEXT
(
    80
) NULL DEFAULT 'NS',
    OmbAccount TEXT
(
    80
) NULL DEFAULT 'NS',
    AgencySequence TEXT
(
    80
) NULL DEFAULT 'NS',
    BureauSequence TEXT
(
    80
) NULL DEFAULT 'NS',
    AccountSequence TEXT
(
    80
) NULL DEFAULT 'NS',
    AgencyTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    BureauTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    OmbAccountTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAccountTitle TEXT
(
    80
) NULL DEFAULT 'NS',
    October DOUBLE NULL DEFAULT 0.0,
    November DOUBLE NULL DEFAULT 0.0,
    December DOUBLE NULL DEFAULT 0.0,
    January DOUBLE NULL DEFAULT 0.0,
    Feburary DOUBLE NULL DEFAULT 0.0,
    March DOUBLE NULL DEFAULT 0.0,
    April DOUBLE NULL DEFAULT 0.0,
    May DOUBLE NULL DEFAULT 0.0,
    June DOUBLE NULL DEFAULT 0.0,
    July DOUBLE NULL DEFAULT 0.0,
    August DOUBLE NULL DEFAULT 0.0,
    September DOUBLE NULL DEFAULT 0.0,
    PRIMARY KEY
(
    MonthlyOutlaysId AUTOINCREMENT
)
    );
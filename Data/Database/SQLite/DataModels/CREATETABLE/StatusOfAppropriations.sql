CREATE TABLE IF NOT EXISTS StatusOfAppropriations
(
    StatusOfAppropriationsId
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
    BudgetLevel TEXT
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
    Availability TEXT
(
    80
) NULL DEFAULT 'NS',
    TransType TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasurySymbol TEXT
(
    80
) NULL DEFAULT 'NS',
    OriginalAmount DOUBLE NULL DEFAULT 0.0,
    Authority DOUBLE NULL DEFAULT 0.0,
    Budgeted DOUBLE NULL DEFAULT 0.0,
    Posted DOUBLE DEFAULT 0.0,
    CarryoverIn DOUBLE NULL DEFAULT 0.0,
    CarryoverOut DOUBLE NULL DEFAULT 0.0,
    TransferIn DOUBLE NULL DEFAULT 0.0,
    TransferOut DOUBLE NULL DEFAULT 0.0,
    OpenCommitments DOUBLE NULL DEFAULT 0.0,
    Obligations DOUBLE NULL DEFAULT 0.0,
    Used DOUBLE NULL DEFAULT 0.0,
    Expenditures DOUBLE NULL DEFAULT 0.0,
    UnliquidatedObligations DOUBLE NULL DEFAULT 0.0,
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
    StatusOfAppropriationsId AUTOINCREMENT
)
    );
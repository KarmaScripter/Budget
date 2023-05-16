CREATE TABLE IF NOT EXISTS AppropriationLevelAuthority
(
    AppropriationLevelAuthorityId
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
    BUdgetLevel TEXT
(
    80
) NULL DEFAULT NS,
    TreasuryAccountCode TEXT
(
    80
) NULL DEFAULT NS,
    Budgeted DOUBLE NULL DEFAULT 0.0,
    Posted DOUBLE NULL DEFAULT 0.0,
    CarryoverOut DOUBLE NULL DEFAULT 0.0,
    CarryoverIn DOUBLE NULL DEFAULT 0.0,
    Reimbursements DOUBLE NULL DEFAULT 0.0,
    Recoveries DOUBLE NULL DEFAULT 0.0,
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
    AppropriationLevelAuthorityId AUTOINCREMENT
)
    );
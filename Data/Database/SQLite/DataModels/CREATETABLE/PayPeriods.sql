CREATE TABLE IF NOT EXISTS PayPeriods
(
    PayPeriodsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BFY
    TEXT
(
    80
) NULL DEFAULT NS,
    Number TEXT
(
    80
) NULL DEFAULT NS,
    Period TEXT
(
    80
) NULL DEFAULT NS,
    Type TEXT
(
    80
) NULL DEFAULT NS,
    SecurityOrg TEXT
(
    80
) NULL DEFAULT NS,
    StartDate TEXT
(
    80
) NULL DEFAULT NS,
    EndDate TEXT
(
    80
) NULL DEFAULT NS,
    SplitPayPeriod TEXT
(
    80
) NULL DEFAULT NS,
    PRIMARY KEY
(
    PayPeriodsId AUTOINCREMENT
)
    );
CREATE TABLE IF NOT EXISTS AmericanRescuePlanCarryoverEstimates
(
    AmericanRescuePlanCarryoverEstimatesId
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
    TreasuryAccountCode TEXT
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
    RpioCode TEXT
(
    80
) NULL DEFAULT NS,
    RpioName TEXT
(
    80
) NULL DEFAULT NS,
    Amount DOUBLE DEFAULT 0.0,
    OpenCommitments DOUBLE DEFAULT 0.0,
    Obligations DOUBLE DEFAULT 0.0,
    Available DOUBLE DEFAULT 0.0,
    Estimate DOUBLE DEFAULT 0.0,
    PRIMARY KEY
(
    AmericanRescuePlanCarryoverEstimatesId AUTOINCREMENT
)
    );
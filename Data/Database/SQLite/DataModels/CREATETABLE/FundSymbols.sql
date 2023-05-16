CREATE TABLE IF NOT EXISTS FundSymbols
(
    FundSymbolsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    TreasuryAccount
    TEXT,
    OmbAccount
    TEXT,
    PRIMARY
    KEY
(
    FundSymbolsId
    AUTOINCREMENT
)
    );
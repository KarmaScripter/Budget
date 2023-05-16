CREATE TABLE Obligations
(
    ObligationsId           AUTOINCREMENT NOT NULL UNIQUE,
    BFY                     TEXT(80) NULL DEFAULT NS,
    EFY                     TEXT(80) NULL DEFAULT NS,
    TreasurySymbol          TEXT(80) NULL DEFAULT NS,
    RpioCode                TEXT(80) NULL DEFAULT NS,
    RpioName                TEXT(80) NULL DEFAULT NS,
    AhCode                  TEXT(80) NULL DEFAULT NS,
    AhName                  TEXT(80) NULL DEFAULT NS,
    FundCode                TEXT(80) NULL DEFAULT NS,
    FundName                TEXT(80) NULL DEFAULT NS,
    OrgCode                 TEXT(80) NULL DEFAULT NS,
    OrgName                 TEXT(80) NULL DEFAULT NS,
    AccountCode             TEXT(80) NULL DEFAULT NS,
    ProgramProjectCode      TEXT(80) NULL DEFAULT NS,
    ProgramProjectName      TEXT(80) NULL DEFAULT NS,
    RcCode                  TEXT(80) NULL DEFAULT NS,
    RcName                  TEXT(80) NULL DEFAULT NS,
    DocumentType            TEXT(80) NULL DEFAULT NS,
    DocumentNumber          TEXT(80) NULL DEFAULT NS,
    DocumentControlNumber   TEXT(80) NULL DEFAULT NS,
    ReferenceDocumentNumber TEXT(80) NULL DEFAULT NS,
    ProcessedDate           TEXT(80) NULL DEFAULT NS,
    LastActivityDate        TEXT(80) NULL DEFAULT NS,
    Age                     TEXT(80) NULL DEFAULT NS,
    BocCode                 TEXT(80) NULL DEFAULT NS,
    BocName                 TEXT(80) NULL DEFAULT NS,
    FocCode                 TEXT(80) NULL DEFAULT NS,
    FocName                 TEXT(80) NULL DEFAULT NS,
    NpmCode                 TEXT(80) NULL DEFAULT NS,
    NpmName                 TEXT(80) NULL DEFAULT NS,
    VendorCode              TEXT(80) NULL DEFAULT NS,
    VendorName              TEXT(80) NULL DEFAULT NS,
    OpenCommitments         DECIMAL NULL DEFAULT 0,
    Obligations             DECIMAL NULL DEFAULT 0,
    ULO                     DECIMAL NULL DEFAULT 0,
    Expenditures            DECIMAL NULL DEFAULT 0,
    TreasuryAccountCode     TEXT(80) NULL DEFAULT NS,
    TreasuryAccountName     TEXT(80) NULL DEFAULT NS,
    BudgetAccountCode       TEXT(80) NULL DEFAULT NS,
    BudgetAccountName       TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY ( ObligationsId AUTOINCREMENT )
);
CREATE TABLE GrossBudgetAuthorityOutlays 
(
    GrossBudgetAuthorityOutlaysId AUTOINCREMENT NOT NULL UNIQUE,
    ReportYear TEXT(80) NULL DEFAULT NS,
    AgencyName TEXT(80) NULL DEFAULT NS,
    OmbAccount TEXT(80) NULL DEFAULT NS,
    Line TEXT(80) NULL DEFAULT NS,
    LineNumber TEXT(80) NULL DEFAULT NS,
    LineSection TEXT(80) NULL DEFAULT NS,
    LineName TEXT(80) NULL DEFAULT NS,
    BeaCategory TEXT(80) NULL DEFAULT NS,
    BeaCategoryName TEXT(80) NULL DEFAULT NS,
    LineCategory TEXT(80) NULL DEFAULT NS,
    PriorYear DOUBLE NULL DEFAULT 0.0,
    CurrentYear DOUBLE NULL DEFAULT 0.0,
    BudgetYear DOUBLE NULL DEFAULT 0.0,
    OutYear1 DOUBLE NULL DEFAULT 0.0,
    OutYear2 DOUBLE NULL DEFAULT 0.0,
    OutYear3 DOUBLE NULL DEFAULT 0.0,
    OutYear4 DOUBLE NULL DEFAULT 0.0,
    OutYear5 DOUBLE NULL DEFAULT 0.0,
    OutYear6 DOUBLE NULL DEFAULT 0.0,
    OutYear7 DOUBLE NULL DEFAULT 0.0,
    OutYear8 DOUBLE NULL DEFAULT 0.0,
    OutYear9 DOUBLE NULL DEFAULT 0.0,
    PRIMARY KEY(GrossBudgetAuthorityOutlaysId)
);
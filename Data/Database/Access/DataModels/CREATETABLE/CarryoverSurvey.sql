CREATE TABLE CarryoverSurvey
(
    CarryoverSurveyId AUTOINCREMENT NOT NULL UNIQUE,
    BFY               TEXT(80) NULL DEFAULT NS,
    FundCode          TEXT(80) NULL DEFAULT NS,
    FundName          TEXT(80) NULL DEFAULT NS,
    Amount            DOUBLE NULL DEFAULT 0.0,
    PRIMARY KEY ( CarryoverSurveyId )
);
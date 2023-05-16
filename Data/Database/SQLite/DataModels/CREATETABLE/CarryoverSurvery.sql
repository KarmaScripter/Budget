CREATE TABLE IF NOT EXISTS CarryoverSurvey
(
    CarryoverSurveyId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BFY
    TEXT
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
    Amount NUMERIC NULL DEFAULT 0.0,
    PRIMARY KEY
(
    CarryoverSurveyId AUTOINCREMENT
)
    );
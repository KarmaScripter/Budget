CREATE TABLE IF NOT EXISTS Objectives
(
    ObjectivesId
    INTEGER
    NOT
    NULL
    UNIQUE
    CONSTRAINT
    PrimaryKeyObjectives
    PRIMARY
    KEY
    AUTOINCREMENT,
    Code
    TEXT
(
    80
) NULL,
    Name TEXT
(
    80
) NULL,
    Title TEXT
(
    80
) NULL
    );


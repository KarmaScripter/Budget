CREATE TABLE Objectives
(
    ObjectivesId INTEGER NOT NULL UNIQUE
        CONSTRAINT PrimaryKeyObjectives PRIMARY KEY AUTOINCREMENT,
    Code         TEXT(80) NULL DEFAULT NS,
    Name         TEXT(80) NULL DEFAULT NS,
    Title        TEXT(80) NULL DEFAULT NS
);


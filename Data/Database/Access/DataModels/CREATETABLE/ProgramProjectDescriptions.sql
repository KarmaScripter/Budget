CREATE TABLE ProgramProjectDescriptions 
(
    ProgramProjectDescriptionsId AUTOINCREMENT NOT NULL UNIQUE,
    Code TEXT(80) NULL DEFAULT NS,
    Name TEXT(80) NULL DEFAULT NS,
    ProgramTitle TEXT(80) NULL DEFAULT NS,
    Laws TEXT(255) NULL DEFAULT NS,
    Description TEXT(MAX) NULL DEFAULT NS,
    ProgramAreaCode TEXT(80) NULL DEFAULT NS,
    ProgramAreaName TEXT(80) NULL DEFAULT NS,
    CONSTRAINT ProgramProjectDescriptionsPrimaryKey
        PRIMARY KEY(ProgramProjectDescriptionsId)
);
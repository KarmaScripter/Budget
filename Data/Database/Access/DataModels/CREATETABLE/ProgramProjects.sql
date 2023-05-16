CREATE TABLE ProgramProjects
(
    ProgramProjectId INTEGER NOT NULL UNIQUE
        CONSTRAINT PrimaryKeyProgramProjects PRIMARY KEY AUTOINCREMENT,
    Code             TEXT(80) NULL DEFAULT NS,
    Name             TEXT(80) NULL DEFAULT NS,
    Title            TEXT(80) NULL DEFAULT NS,
    Laws             TEXT(80) NULL DEFAULT NS,
    Narrative        TEXT(80) NULL DEFAULT NS,
    Definition       TEXT(80) NULL DEFAULT NS,
    ProgramAreaCode  TEXT(80) NULL DEFAULT NS,
    ProgramAreaName  TEXT(80) NULL DEFAULT NS
);


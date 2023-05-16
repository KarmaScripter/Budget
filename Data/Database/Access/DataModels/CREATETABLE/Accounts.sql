CREATE TABLE Accounts
(
    AccountsId         AUTOINCREMENT NOT NULL UNIQUE,
    Code               TEXT(80) NULL DEFAULT NS,
    ProgramAreaCode    TEXT(80) NULL DEFAULT NS,
    GoalCode           TEXT(80) NULL DEFAULT NS,
    ObjectiveCode      TEXT(80) NULL DEFAULT NS,
    NpmCode            TEXT(80) NULL DEFAULT NS,
    NpmName            TEXT(80) NULL DEFAULT NS,
    ProgramProjectCode TEXT(80) NULL DEFAULT NS,
    ProgramProjectName TEXT(80) NULL DEFAULT NS,
    ActivityCode       TEXT(80) NULL DEFAULT NS,
    ActivityName       TEXT(80) NULL DEFAULT NS,
    AgencyActivity     TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY ( AccountsId )
);
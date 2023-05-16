CREATE TABLE FinanceObjectClasses
(
    FinanceObjectClassId INTEGER NOT NULL UNIQUE
        CONSTRAINT PK_FinanceObjectClasses PRIMARY KEY AUTOINCREMENT,
    Code                 TEXT(255) NOT NULL,
    Name                 TEXT(255) NULL
);


CREATE TABLE BudgetObjectClasses
(
    BudgetObjectClassId INTEGER NOT NULL UNIQUE
        CONSTRAINT PK_BudgetObjectClasses PRIMARY KEY AUTOINCREMENT,
    Code                TEXT(255) NOT NULL,
    Name                TEXT(255) NULL
);


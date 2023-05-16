CREATE TABLE Appropriations
(
    AppropriationId INTEGER NOT NULL UNIQUE
        CONSTRAINT PK_Appropriations PRIMARY KEY AUTOINCREMENT,
    BFY             TEXT(255) NOT NULL,
    Title           TEXT(255) NULL,
    PublicLaw       TEXT(255) NULL,
    EnactedDate     DATETIME NULL
);


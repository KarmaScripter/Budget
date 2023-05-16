CREATE TABLE ProgramAreas
(
    ProgramAreasId INTEGER NOT NULL UNIQUE
        CONSTRAINT PK_ProgramAreas PRIMARY KEY AUTOINCREMENT,
    Code           TEXT(255) NOT NULL,
    Name           TEXT(255) NULL
);


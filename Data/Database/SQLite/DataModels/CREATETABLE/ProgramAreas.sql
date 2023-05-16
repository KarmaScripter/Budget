CREATE TABLE IF NOT EXISTS ProgramAreas
(
    ProgramAreasId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    255
) NOT NULL,
    Name TEXT
(
    255
),
    CONSTRAINT PrimaryKeyProgramAreas PRIMARY KEY
(
    ProgramAreasId AUTOINCREMENT
)
    );
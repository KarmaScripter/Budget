CREATE TABLE IF NOT EXISTS Appropriations
(
    AppropriationsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    80
) NULL DEFAULT NS,
    Name TEXT
(
    80
) NULL DEFAULT NS,
    PRIMARY KEY
(
    AppropriationsId AUTOINCREMENT
)
    );
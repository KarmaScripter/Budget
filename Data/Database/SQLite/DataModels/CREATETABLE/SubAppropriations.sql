CREATE TABLE IF NOT EXISTS SubAppropriations
(
    SubAppropriationsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    80
) NULL DEFAULT 'NS',
    Name TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    SubAppropriationsId AUTOINCREMENT
)
    );
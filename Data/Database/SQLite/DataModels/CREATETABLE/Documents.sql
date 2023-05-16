CREATE TABLE IF NOT EXISTS Documents
(
    DocumentsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    255
),
    Category TEXT
(
    255
),
    Name TEXT
(
    255
),
    System TEXT
(
    255
),
    PRIMARY KEY
(
    DocumentsId AUTOINCREMENT
)
    );
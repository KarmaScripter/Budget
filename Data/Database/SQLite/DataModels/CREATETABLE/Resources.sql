CREATE TABLE IF NOT EXISTS Resources
(
    ResourcesId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Identifier
    TEXT
(
    80
) NULL DEFAULT NS,
    Type TEXT
(
    80
) NULL DEFAULT NS,
    Location TEXT
(
    255
) NULL DEFAULT NS,
    Extension TEXT
(
    80
) NULL DEFAULT NS,
    Caption TEXT
(
    80
) NULL DEFAULT NS,
    PRIMARY KEY
(
    ResourcesId AUTOINCREMENT
)
    );
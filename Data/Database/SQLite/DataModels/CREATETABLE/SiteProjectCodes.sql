CREATE TABLE IF NOT EXISTS SiteProjectCodes
(
    SiteProjectCodeId
    INTEGER
    NOT
    NULL
    UNIQUE
    CONSTRAINT
    PrimaryKeySiteProjectCodes
    PRIMARY
    KEY
    AUTOINCREMENT,
    RcCode
    TEXT
(
    255
) NULL,
    DivisionName TEXT
(
    255
) NULL,
    SiteProjectCode TEXT
(
    255
) NULL
    );
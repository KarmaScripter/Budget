CREATE TABLE SiteProjectCodes
(
    SiteProjectCodeId     AUTOINCREMENT NOT NULL UNIQUE,
    RpioCode              TEXT(80) NULL DEFAULT NS,
    RpioName              TEXT(80) NULL DEFAULT NS,
    State                 TEXT(80) NULL DEFAULT NS,
    CongressionalDistrict TEXT(80) NULL DEFAULT NS,
    EpaSiteId             TEXT(80) NULL DEFAULT NS,
    SiteProjectCode       TEXT(80) NULL DEFAULT NS,
    SiteProjectName       TEXT(80) NULL DEFAULT NS,
    SSID                  TEXT(80) NULL DEFAULT NS,
    ActionCode            TEXT(80) NULL DEFAULT NS,
    CONSTRAINT SiteProjectCodesPrimaryKey
        PRIMARY KEY ( SiteProjectCodesId )
);
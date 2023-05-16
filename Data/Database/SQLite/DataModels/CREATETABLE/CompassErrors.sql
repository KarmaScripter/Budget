CREATE TABLE CompassErrors2
(
    CompassErrorsId INTEGER NOT NULL UNIQUE,
    Code            TEXT(80) NULL DEFAULT 'NS',
    Message         TEXT(80) NULL DEFAULT 'NS',
    Severity        TEXT(80) NULL DEFAULT 'NS',
    PRIMARY KEY ( CompassErrorsId AUTOINCREMENT )
);
CREATE TABLE Resources
(
    ResourcesId AUTOINCREMENT NOT NULL UNIQUE,
    Identifier  TEXT(80) NULL DEFAULT NS,
    Type        TEXT(80) NULL DEFAULT NS,
    Location    TEXT(80) NULL DEFAULT NS,
    FileExtension NULL DEFAULT NS,
    Caption     TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY ( ResourcesId )
);
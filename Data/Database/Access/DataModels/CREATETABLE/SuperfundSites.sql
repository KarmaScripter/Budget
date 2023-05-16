CREATE TABLE SuperfundSites
(
    SuperfundSitesId AUTOINCREMENT NOT NULL UNIQUE,
    RpioCode         TEXT(80) NULL DEFAULT NS,
    RpioName         TEXT(80) NULL DEFAULT NS,
    City             TEXT(80) NULL DEFAULT NS,
    State            TEXT(80) NULL DEFAULT NS,
    SSID             TEXT(80) NULL DEFAULT NS,
    SiteProjectName  TEXT(80) NULL DEFAULT NS,
    EpaSiteId        TEXT(80) NULL DEFAULT NS,
    CONSTRAINT SuperfundSitesPrimaryKey
        PRIMARY KEY ( SuperfundSitesId )
);
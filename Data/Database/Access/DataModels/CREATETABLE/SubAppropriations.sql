CREATE TABLE SubAppropriations
(
    SubAppropriationsId AUTOINCREMENT NOT NULL UNIQUE,
    Code                TEXT(80) NULL DEFAULT NS,
    Name                TEXT(80) NULL DEFAULT NS,
    PRIMARY KEY ( SubAppropriationsId )
);
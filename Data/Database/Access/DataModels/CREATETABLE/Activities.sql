CREATE TABLE Activities
(
    ActivityId INTEGER NOT NULL UNIQUE
        CONSTRAINT PrimaryKeyActivity PRIMARY KEY,
    Code       TEXT(80) NULL DEFAULT NS,
    Name       TEXT(80) NULL DEFAULT NS,
    Title      TEXT(80) NULL DEFAULT NS
);


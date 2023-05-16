CREATE TABLE Activity
(
    ActivityId INTEGER NOT NULL UNIQUE
        CONSTRAINT PK_Activity PRIMARY KEY AUTOINCREMENT,
    Code       TEXT(255) NOT NULL,
    Name       TEXT(255) NULL,
    Title      TEXT(255) NULL
);


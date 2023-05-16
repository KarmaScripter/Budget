CREATE TABLE Holidays
(
    HolidayId           INTEGER NOT NULL UNIQUE
        CONSTRAINT PrimaryKeyHoldiays PRIMARY KEY AUTOINCREMENT,
    ColumbusDay         DATETIME NULL,
    ThanksgivingDay     DATETIME NULL,
    ChristmasDay        DATETIME NULL,
    NewYearsDay         DATETIME NULL,
    MartinLutherKingDay DATETIME NULL,
    PresidentsDay       DATETIME NULL,
    MemorialDay         DATETIME NULL,
    VeteransDay         DATETIME NULL,
    LaborDay            DATETIME NULL
);


CREATE TABLE PayPeriods
(
    PayPeriodsId INTEGER NOT NULL IDENTITY(1,1),
    Period NVARCHAR(255) NOT NULL,
    PayPeriod    NVARCHAR(255) NULL,
    StartDate    DATETIME NULL,
    EndDate      DATETIME NULL,
    CONSTRAINT PK_PayPeriods
        PRIMARY KEY ( PayPeriodsId )
);


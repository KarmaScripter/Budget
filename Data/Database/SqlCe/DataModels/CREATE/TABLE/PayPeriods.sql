CREATE TABLE PayPeriods
(
    PayPeriodsId INTEGER NOT NULL IDENTITY(1,1),
    Period NVARCHAR(80) NOT NULL,
    PayPeriod  NVARCHAR(80) NULL,
    StartDate DATETIME NULL,
    EndDate DATETIME NULL
);


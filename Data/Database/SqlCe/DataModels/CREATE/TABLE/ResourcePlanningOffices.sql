CREATE TABLE ResourcePlanningImplentationOffices
(
    RpioId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code   NVARCHAR(255) NULL,
    Name   NVARCHAR(255) NULL
);


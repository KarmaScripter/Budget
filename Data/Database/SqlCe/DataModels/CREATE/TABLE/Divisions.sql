CREATE TABLE Divisions
(
    DivisionId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code       NVARCHAR(255) NOT NULL,
    Name       NVARCHAR(255) NULL,
    Caption    NVARCHAR(255) NULL,
    Title      NVARCHAR(255) NULL,
    FCO        NVARCHAR(255) NULL,
    Icon       NVARCHAR(255) NULL,
    Logo       NVARCHAR(255) NULL
);


CREATE TABLE NationalPrograms
(
    NationalProgramsId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code               NVARCHAR(255) NOT NULL,
    Name               NVARCHAR(255) NULL,
    RpioCode           NVARCHAR(255) NULL,
    Title              NVARCHAR(255) NULL
);


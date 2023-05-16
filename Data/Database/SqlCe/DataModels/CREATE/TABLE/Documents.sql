CREATE TABLE Documents
(
    DocumentId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code       NVARCHAR(255) NULL,
    Category   NVARCHAR(255) NULL,
    Name       NVARCHAR(255) NULL,
    System     NVARCHAR(255) NULL
);


CREATE TABLE Organizations
(
    OrganizationsId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code            NVARCHAR(255) NOT NULL,
    Name            NVARCHAR(255) NULL
);


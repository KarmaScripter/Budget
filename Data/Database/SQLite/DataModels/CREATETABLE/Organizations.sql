CREATE TABLE IF NOT EXISTS Organizations
(
    OrganizationsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    255
) NOT NULL,
    Name TEXT
(
    255
),
    CONSTRAINT PrimaryKeyOrganizations PRIMARY KEY
(
    OrganizationsId AUTOINCREMENT
)
    );
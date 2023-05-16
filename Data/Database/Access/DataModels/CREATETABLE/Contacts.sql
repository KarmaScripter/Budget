CREATE TABLE Contacts
(
    ContactsId AUTOINCREMENT NOT NULL UNIQUE,
    FirstName  TEXT(80) NULL DEFAULT NS,
    LastName   TEXT(80) NULL DEFAULT NS,
    FullName   TEXT(80) NULL DEFAULT NS,
    Email      TEXT(80) NULL DEFAULT NS,
    RPIO       TEXT(80) NULL DEFAULT NS,
    Section    TEXT(80) NULL DEFAULT NS,
    CONSTAINT  ContactsPrimaryKey
        PRIMARY KEY(ContactsId)
);
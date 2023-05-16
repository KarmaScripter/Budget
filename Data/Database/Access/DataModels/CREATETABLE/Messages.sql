CREATE TABLE Messages
(
    MessagesId AUTOINCREMENT NOT NULL UNIQUE,
    Message    TEXT(80) NULL DEFAULT NS,
    Type       TEXT(80) NULL DEFAULT NS,
    Form       TEXT(80) NULL DEFAULT NS,
    CONSTRAINT MessagesPrimaryKey
        PRIMARY KEY ( MessagesId )
);
CREATE TABLE WorkCodes
(
    WorkCodesId AUTOINCREMENT NOT NULL UNIQUE,
    Code        TEXT(80) NULL DCONSTRAINT EFAULT NS,
    Name        TEXT(80) NULL DEFAULT NS,
    WorkCodesPrimaryKey
        PRIMARY KEY (WorkCodesId)
);
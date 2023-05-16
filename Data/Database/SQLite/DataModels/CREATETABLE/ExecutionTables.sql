CREATE TABLE IF NOT EXISTS ExecutionTables
(
    ExecutionTablesId
    INTEGER
    NOT
    NULL
    UNIQUE
    CONSTRAINT
    PrimaryKeyExecutionTables
    PRIMARY
    KEY,
    TableName
    TEXT
(
    80
) NULL DEFAULT NS,
    TableType TEXT
(
    80
) NULL DEFAULT NS
    );

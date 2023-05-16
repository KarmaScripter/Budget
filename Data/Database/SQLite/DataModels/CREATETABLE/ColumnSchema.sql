CREATE TABLE IF NOT EXISTS ColumnSchema
(
    ColumnSchemaId
    INTEGER
    NOT
    NULL
    UNIQUE,
    DataType
    TEXT
(
    80
) NULL DEFAULT 'NS',
    ColumnName TEXT
(
    80
) NULL DEFAULT 'NS',
    TableName TEXT
(
    80
) NULL DEFAULT 'NS',
    ColumnCaption TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    ColumnSchemaId AUTOINCREMENT
)
    );
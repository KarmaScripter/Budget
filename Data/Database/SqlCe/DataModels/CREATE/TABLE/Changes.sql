CREATE TABLE [Changes]
(
    [
    ChangesId ]
    INT
    NOT
    NULL
    IDENTITY
(
    1,
    1
),
    [TableName] NVARCHAR
(
    255
) NULL,
    [FieldName] NVARCHAR
(
    255
) NULL,
    [Action] NVARCHAR
(
    255
) NULL,
    [OldValue] NVARCHAR
(
    255
) NULL,
    [NewValue] NVARCHAR
(
    255
) NULL,
    [TimeStamp] DATETIME NULL,
    [Message] NVARCHAR
(
    255
) NULL,
    CONSTRAINT PK_Changes
    PRIMARY KEY
(
    ChangesId
)
    );


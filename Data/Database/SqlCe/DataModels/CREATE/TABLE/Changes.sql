CREATE TABLE [Changes]
(
   [ChangesId] INT NOT NULL IDENTITY (4194,1),
   [TableName] NVARCHAR(80),
   [FieldName] NVARCHAR(80),
   [Action] NVARCHAR(80),
   [OldValue] NVARCHAR(80),
   [NewValue] NVARCHAR(80),
   [TimeStamp] DATETIME,
   [Message] NVARCHAR(80)
);

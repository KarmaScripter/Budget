CREATE TABLE [dbo].[ReferenceTables]
(
	[ReferenceTableId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](255) NULL,
	[Type] [nvarchar](max) NULL
);

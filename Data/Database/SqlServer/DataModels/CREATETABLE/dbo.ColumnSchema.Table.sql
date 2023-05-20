USE [Data]
GO
/****** Object:  Table [dbo].[ColumnSchema]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColumnSchema](
	[ColumnSchemaId] [int] NOT NULL,
	[DataType] [nvarchar](80) NULL,
	[ColumnName] [nvarchar](80) NULL,
	[TableName] [nvarchar](80) NULL,
	[ColumnCaption] [nvarchar](80) NULL,
 CONSTRAINT [PK_ColumnSchema] PRIMARY KEY CLUSTERED 
(
	[ColumnSchemaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

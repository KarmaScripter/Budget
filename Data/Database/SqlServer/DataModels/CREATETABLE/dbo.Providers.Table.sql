USE [Data]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[ProvidersId] [int] NOT NULL,
	[ProviderName] [nvarchar](80) NULL,
	[FileExtension] [nvarchar](80) NULL,
	[Connection] [nvarchar](80) NULL,
	[Properties] [nvarchar](80) NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[ProvidersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

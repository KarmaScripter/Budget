USE
[Data]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images]
(
    [
    ImagesId ] [
    int ]
    NOT
    NULL, [
    FileName ] [
    nvarchar ]
(
    80
) NULL,
    [FilePath] [nvarchar]
(
    80
) NULL,
    [FileExtension] [nvarchar]
(
    80
) NULL,
    [ImageFile] [image] NULL,
    [Attachments] [nvarchar]
(
    max
) NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED
(
[
    ImagesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO

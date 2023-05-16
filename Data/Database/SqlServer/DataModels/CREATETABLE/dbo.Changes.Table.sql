USE
[Data]
GO
/****** Object:  Table [dbo].[Changes]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Changes]
(
    [
    ChangesId ] [
    int ]
    NOT
    NULL, [
    TableName ] [
    nvarchar ]
(
    80
) NULL,
    [FieldName] [nvarchar]
(
    80
) NULL,
    [Action] [nvarchar]
(
    80
) NULL,
    [OldValue] [nvarchar]
(
    80
) NULL,
    [NewValue] [nvarchar]
(
    80
) NULL,
    [TimeStamp] [datetime] NULL,
    [Message] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Changes] PRIMARY KEY CLUSTERED
(
[
    ChangesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

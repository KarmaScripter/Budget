USE
[Data]
GO
/****** Object:  Table [dbo].[ActivityCodes]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityCodes]
(
    [
    ActivityId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NOT NULL,
    [Name] [nvarchar]
(
    50
) NULL,
    [Description] [nvarchar]
(
    50
) NULL,
    CONSTRAINT [PK_ActivityCodes] PRIMARY KEY CLUSTERED
(
[
    ActivityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

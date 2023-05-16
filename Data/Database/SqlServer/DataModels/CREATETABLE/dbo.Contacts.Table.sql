USE
[Data]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts]
(
    [
    ContactsId ] [
    int ]
    NOT
    NULL, [
    FirstName ] [
    nvarchar ]
(
    80
) NULL,
    [LastName] [nvarchar]
(
    80
) NULL,
    [FullName] [nvarchar]
(
    80
) NULL,
    [Email] [nvarchar]
(
    80
) NULL,
    [RPIO] [nvarchar]
(
    80
) NULL,
    [Section] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED
(
[
    ContactsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

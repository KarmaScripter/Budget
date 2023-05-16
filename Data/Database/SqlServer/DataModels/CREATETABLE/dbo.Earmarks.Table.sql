USE
[Data]
GO
/****** Object:  Table [dbo].[Earmarks]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Earmarks]
(
    [
    EarmarksId ] [
    int ]
    NOT
    NULL, [
    RpioCode ] [
    nvarchar ]
(
    80
) NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [StateCode] [nvarchar]
(
    80
) NULL,
    [Description] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [ProjectOfficerLastName] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerFirstName] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerPhoneNumber] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerMailCode] [nvarchar]
(
    80
) NULL,
    [CommitmentDate] [datetime] NULL,
    [ObligationDate] [datetime] NULL,
    [ProjectStatus] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerComments] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Earmarks] PRIMARY KEY CLUSTERED
(
[
    EarmarksId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

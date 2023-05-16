USE
[Data]
GO
/****** Object:  Table [dbo].[AnnualCarryoverSurvey]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualCarryoverSurvey]
(
    [
    AnnualCarryoverSurveyId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
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
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_AnnualCarryoverSurvey] PRIMARY KEY CLUSTERED
(
[
    AnnualCarryoverSurveyId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

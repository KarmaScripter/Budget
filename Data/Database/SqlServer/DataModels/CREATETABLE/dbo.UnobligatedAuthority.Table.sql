USE
[Data]
GO
/****** Object:  Table [dbo].[UnobligatedAuthority]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnobligatedAuthority]
(
    [
    UnobligatedAuthorityId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [BudgetAgencyCode] [nvarchar]
(
    80
) NULL,
    [BudgetBureauCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountTitle] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [BudgetYear] [float] NULL,
    [PriorYear] [float] NULL,
    [CurrentYear] [float] NULL,
    [AgencyName] [nvarchar]
(
    80
) NULL,
    [BureauName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_UnobligatedAuthority] PRIMARY KEY CLUSTERED
(
[
    UnobligatedAuthorityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

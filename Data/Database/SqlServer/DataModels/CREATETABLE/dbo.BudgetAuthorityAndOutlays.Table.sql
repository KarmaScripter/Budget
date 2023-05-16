USE
[Data]
GO
/****** Object:  Table [dbo].[BudgetAuthorityAndOutlays]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetAuthorityAndOutlays]
(
    [
    BudgetAuthorityAndOutlaysId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [Category] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
    [AccountType] [nvarchar]
(
    80
) NULL,
    [AuthorityType] [nvarchar]
(
    80
) NULL,
    [PriorYear] [float] NULL,
    [CurrentYear] [float] NULL,
    [BudgetYear] [float] NULL,
    [OutYear1] [float] NULL,
    [OutYear2] [float] NULL,
    [OutYear3] [float] NULL,
    [OutYear4] [float] NULL,
    [OutYear5] [float] NULL,
    [OutYear6] [float] NULL,
    [OutYear7] [float] NULL,
    [OutYear8] [float] NULL,
    [OutYear9] [float] NULL,
    CONSTRAINT [PK_BudgetAuthorityAndOutlays] PRIMARY KEY CLUSTERED
(
[
    BudgetAuthorityAndOutlaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

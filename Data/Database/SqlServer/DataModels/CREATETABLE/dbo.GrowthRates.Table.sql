USE
[Data]
GO
/****** Object:  Table [dbo].[GrowthRates]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrowthRates]
(
    [
    GrowthRatesId ] [
    int ]
    NOT
    NULL, [
    RateId ] [
    nvarchar ]
(
    80
) NULL,
    [DESCRIPTION] [nvarchar]
(
    80
) NULL,
    [BudgetYearRate] [float] NULL,
    [OutYear1] [float] NULL,
    [OutYear2] [float] NULL,
    [OutYear3] [float] NULL,
    [OutYear4] [float] NULL,
    [OutYear5] [float] NULL,
    [OutYear6] [float] NULL,
    [OutYear7] [float] NULL,
    [OutYear8] [float] NULL,
    [OutYear9] [float] NULL,
    [Sort] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_GrowthRates] PRIMARY KEY CLUSTERED
(
[
    GrowthRatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

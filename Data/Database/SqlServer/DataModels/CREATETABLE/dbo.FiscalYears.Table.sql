USE
[Data]
GO
/****** Object:  Table [dbo].[FiscalYears]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalYears]
(
    [
    FiscalYearsId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NOT NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [StartDate] [nvarchar]
(
    80
) NULL,
    [Columbus] [datetime] NULL,
    [Veterans] [datetime] NULL,
    [Thanksgiving] [datetime] NULL,
    [Christmas] [datetime] NULL,
    [NewYears] [datetime] NULL,
    [MartinLutherKing] [datetime] NULL,
    [Washingtons] [datetime] NULL,
    [Memorial] [datetime] NULL,
    [Juneteenth] [datetime] NULL,
    [Independence] [datetime] NULL,
    [Labor] [datetime] NULL,
    [ExpiringYear] [nvarchar]
(
    80
) NULL,
    [ExpirationDate] [nvarchar]
(
    80
) NULL,
    [WorkDays] [float] NULL,
    [WeekDays] [float] NULL,
    [WeekEnds] [float] NULL,
    [EndDate] [nvarchar]
(
    80
) NULL,
    [Availability] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_FiscalYears] PRIMARY KEY CLUSTERED
(
[
    FiscalYearsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

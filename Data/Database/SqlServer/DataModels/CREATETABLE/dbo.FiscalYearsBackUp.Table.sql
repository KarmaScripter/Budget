USE
[Data]
GO
/****** Object:  Table [dbo].[FiscalYearsBackUp]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalYearsBackUp]
(
    [
    FiscalYearsBackUpId ] [
    int ]
    NOT
    NULL, [
    FiscalYearsId ] [
    int ]
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [FirstYear] [nvarchar]
(
    80
) NULL,
    [LastYear] [nvarchar]
(
    80
) NULL,
    [ExpiringYear] [nvarchar]
(
    80
) NULL,
    [CalendarYearStartDate] [datetime] NULL,
    [FiscalYearStartDate] [datetime] NULL,
    [CalendarYearEndDate] [datetime] NULL,
    [FiscalYearEndDate] [datetime] NULL,
    [ExpirationDate] [datetime] NULL,
    [Availability] [nvarchar]
(
    80
) NULL,
    [NewYears] [datetime] NULL,
    [MartinLutherKing] [datetime] NULL,
    [Presidents] [datetime] NULL,
    [Memorial] [datetime] NULL,
    [Juneteeth] [datetime] NULL,
    [Independence] [datetime] NULL,
    [Labor] [datetime] NULL,
    [Columbus] [datetime] NULL,
    [Veterans] [datetime] NULL,
    [Thanksgiving] [datetime] NULL,
    [Christmas] [datetime] NULL,
    [WorkDays] [float] NULL,
    [WeekDays] [float] NULL,
    [WeekEnds] [float] NULL,
    CONSTRAINT [PK_FiscalYearsBackUp] PRIMARY KEY CLUSTERED
(
[
    FiscalYearsBackUpId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

USE
[Data]
GO
/****** Object:  Table [dbo].[PayPeriods]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayPeriods]
(
    [
    PayPeriodsId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [Number] [nvarchar]
(
    80
) NULL,
    [Period] [nvarchar]
(
    80
) NULL,
    [Type] [nvarchar]
(
    80
) NULL,
    [SecurityOrg] [nvarchar]
(
    80
) NULL,
    [StartDate] [datetime] NULL,
    [EndDate] [datetime] NULL,
    [SplitPayPeriod] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_PayPeriods] PRIMARY KEY CLUSTERED
(
[
    PayPeriodsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

USE
[Data]
GO
/****** Object:  Table [dbo].[PayrollCostCodes]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollCostCodes]
(
    [
    PayrollCostCodesId ] [
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [SubRcCode] [nvarchar]
(
    80
) NULL,
    [SubRcName] [nvarchar]
(
    80
) NULL,
    [HrOrgCode] [nvarchar]
(
    80
) NULL,
    [HrOrgName] [nvarchar]
(
    80
) NULL,
    [WorkCode] [nvarchar]
(
    80
) NULL,
    [WorkCodeName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_PayrollCostCodes] PRIMARY KEY CLUSTERED
(
[
    PayrollCostCodesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

USE
[Data]
GO
/****** Object:  Table [dbo].[ReimbursableFunds]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReimbursableFunds]
(
    [
    ReimbursableFundsId ] [
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
    [AgreeementNumber] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [Amount] [money] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [UnliquidatedObligations] [float] NULL,
    [Available] [float] NULL,
    CONSTRAINT [PK_ReimbursableFunds] PRIMARY KEY CLUSTERED
(
[
    ReimbursableFundsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

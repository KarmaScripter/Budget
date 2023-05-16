USE
[Data]
GO
/****** Object:  Table [dbo].[ReimbursableAgreements]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReimbursableAgreements]
(
    [
    ReimbursableAgreementsId ] [
    int ]
    NOT
    NULL, [
    RPIO ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [AgreementNumber] [nvarchar]
(
    80
) NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [StartDate] [datetime] NULL,
    [EndDate] [datetime] NULL,
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [SiteProjectCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [VendorCode] [nvarchar]
(
    80
) NULL,
    [VendorName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [ULO] [float] NULL,
    [Available] [float] NULL,
    CONSTRAINT [PK_ReimbursableAgreements] PRIMARY KEY CLUSTERED
(
[
    ReimbursableAgreementsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

USE
[Data]
GO
/****** Object:  Table [dbo].[SpendingDocuments]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpendingDocuments]
(
    [
    SpendingDocumentsId ] [
    int ]
    NOT
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
    [TreasurySymbol] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [RpioName] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [RpioActivityCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [PurchaseRequestNumber] [nvarchar]
(
    80
) NULL,
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentControlNumber] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [OriginalActionDate] [datetime] NULL,
    [LastActionDate] [datetime] NULL,
    [Commitments] [float] NULL,
    [Obligations] [float] NULL,
    [Deobligations] [float] NULL,
    [UnliqudatedObligations] [float] NULL,
    CONSTRAINT [PK_SpendingDocuments] PRIMARY KEY CLUSTERED
(
[
    SpendingDocumentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

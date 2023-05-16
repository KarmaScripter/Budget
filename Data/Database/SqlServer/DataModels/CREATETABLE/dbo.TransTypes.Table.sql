USE
[Data]
GO
/****** Object:  Table [dbo].[TransTypes]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransTypes]
(
    [
    TransTypesId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [DocType] [nvarchar]
(
    80
) NULL,
    [AppropriationBill] [nvarchar]
(
    80
) NULL,
    [ContinuingResolution] [nvarchar]
(
    80
) NULL,
    [RescissionCurrentYear] [nvarchar]
(
    80
) NULL,
    [RescissionPriorYear] [nvarchar]
(
    80
) NULL,
    [SequesterReduction] [nvarchar]
(
    80
) NULL,
    [SequesterReturn] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_TransTypes] PRIMARY KEY CLUSTERED
(
[
    TransTypesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

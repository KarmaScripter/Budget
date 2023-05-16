USE
[Data]
GO
/****** Object:  Table [dbo].[JobsActCarryoverEstimates]    Script Date: 5/13/2023 1:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobsActCarryoverEstimates]
(
    [
    JobsActCarryoverEstimatesId ] [
    int ]
    IDENTITY
(
    1,
    1
) NOT NULL,
    [BFY] [nvarchar]
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
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [Available] [float] NULL,
    [Estimate] [float] NULL,
    CONSTRAINT [PK_JobsActCarryoverEstimates] PRIMARY KEY CLUSTERED
(
[
    JobsActCarryoverEstimatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO

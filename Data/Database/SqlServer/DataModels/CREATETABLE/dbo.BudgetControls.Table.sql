USE [Data]
GO
/****** Object:  Table [dbo].[BudgetControls]    Script Date: 5/13/2023 1:48:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetControls](
	[BudgetControlsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[BudgetedTransType] [nvarchar](80) NULL,
	[PostedTransType] [nvarchar](80) NULL,
	[EstimatedReimbursementsTransType] [nvarchar](80) NULL,
	[SpendingAdjustmentTransType] [nvarchar](80) NULL,
	[EstimatedRecoveriesTransType] [nvarchar](80) NULL,
	[ActualRecoveriesTransType] [nvarchar](80) NULL,
	[StatusReserveTransType] [nvarchar](80) NULL,
	[ProfitLossTransType] [nvarchar](80) NULL,
	[EstimatedReimbursementsSpendingOption] [nvarchar](80) NULL,
	[EstimatedReimursementsBudgetingOption] [nvarchar](80) NULL,
	[TrackAgreementLowerLevel] [nvarchar](80) NULL,
	[BudgetEstimatedLowerLevel] [nvarchar](80) NULL,
	[EstimatedRecoveriesSpendingOption] [nvarchar](80) NULL,
	[EstimatedRecoveriesBudgetingOption] [nvarchar](80) NULL,
	[RecoveryNextLevel] [nvarchar](80) NULL,
	[RecoveryBudgetMismatch] [nvarchar](80) NULL,
	[ProfitLossSpendingOption] [nvarchar](80) NULL,
	[ProfitLossBudgetOption] [nvarchar](80) NULL,
	[RecoveriesCarryInLowerLevel] [nvarchar](80) NULL,
	[RecoveriesCarryInLowerLevelControl] [nvarchar](80) NULL,
	[RecoveriesCarryInAmountControl] [nvarchar](80) NULL,
	[BudgetedControl] [nvarchar](80) NULL,
	[PostedControl] [nvarchar](80) NULL,
	[PreCommitmentSpendingControl] [nvarchar](80) NULL,
	[CommitmentSpendingControl] [nvarchar](80) NULL,
	[ObligationSpendingControl] [nvarchar](80) NULL,
	[AccrualSpendingControl] [nvarchar](80) NULL,
	[ExpenditureSpendingControl] [nvarchar](80) NULL,
	[ExpenseSpendingControl] [nvarchar](80) NULL,
	[ReimbursableSpendingControl] [nvarchar](80) NULL,
	[ReimbursableAgreementSpendingControl] [nvarchar](80) NULL,
	[FteBudgetingControl] [nvarchar](80) NULL,
	[FteSpendingControl] [nvarchar](80) NULL,
	[TransactionTypeControl] [nvarchar](80) NULL,
	[AuthorityDistributionControl] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetControls] PRIMARY KEY CLUSTERED 
(
	[BudgetControlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

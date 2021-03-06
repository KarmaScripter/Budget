USE [Data]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](100) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](100) NULL,
	[AgencyActivity] [nvarchar](80) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActivityCodes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityCodes](
	[ActivityCodesId] [smallint] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_ActivityCodes] PRIMARY KEY CLUSTERED 
(
	[ActivityCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Allocations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allocations](
	[PrcId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](50) NULL,
	[RPIO] [nvarchar](50) NULL,
	[BFY] [nvarchar](50) NULL,
	[FundCode] [nvarchar](50) NULL,
	[AhCode] [nvarchar](50) NULL,
	[OrgCode] [nvarchar](50) NULL,
	[RcCode] [nvarchar](50) NULL,
	[AccountCode] [nvarchar](50) NULL,
	[BocCode] [nvarchar](50) NULL,
	[Amount] [float] NULL,
	[ActivityCode] [nvarchar](50) NULL,
	[ActivityName] [nvarchar](50) NULL,
	[FundName] [nvarchar](50) NULL,
	[BocName] [nvarchar](50) NULL,
	[NpmName] [nvarchar](50) NULL,
	[Division] [nvarchar](50) NULL,
	[DivisionName] [nvarchar](50) NULL,
	[ProgramProjectCode] [nvarchar](50) NULL,
	[ProgramProjectName] [nvarchar](100) NOT NULL,
	[ProgramAreaName] [nvarchar](50) NULL,
	[AhName] [nvarchar](50) NULL,
	[OrgName] [nvarchar](50) NULL,
	[GoalName] [nvarchar](50) NULL,
	[ObjectiveName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AmericanRescuePlan]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmericanRescuePlan](
	[AmericanRescuePlanId] [int] NOT NULL,
	[StatusOfFundsId] [int] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](50) NULL,
	[AhCode] [nvarchar](50) NULL,
	[AhName] [nvarchar](50) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](50) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](50) NULL,
	[AccountCode] [nvarchar](50) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](50) NULL,
	[ProgramProjectCode] [nvarchar](50) NULL,
	[ProgramProjectName] [nvarchar](100) NULL,
	[ProgramAreaCode] [nvarchar](50) NULL,
	[ProgramAreaName] [nvarchar](50) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[LowerName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
	[NpmCode] [nvarchar](50) NULL,
	[NpmName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AmericanRescuePlan] PRIMARY KEY CLUSTERED 
(
	[AmericanRescuePlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualCarryoverEstimates]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualCarryoverEstimates](
	[AnnualCarryoverEstimatesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](100) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](100) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[Available] [float] NULL,
	[Estimate] [float] NULL,
 CONSTRAINT [PK_AnnualCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[AnnualCarryoverEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualCarryoverSurvey]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualCarryoverSurvey](
	[CarryoverSurveyId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](100) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[Amount] [float] NULL,
 CONSTRAINT [PK_AnnualCarryoverSurvey] PRIMARY KEY CLUSTERED 
(
	[CarryoverSurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualReimbursableEstimates]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualReimbursableEstimates](
	[ReimbursableEstimatesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](50) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](50) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[Available] [float] NULL,
	[Estimate] [float] NULL,
 CONSTRAINT [PK_AnnualReimbursableEstimates] PRIMARY KEY CLUSTERED 
(
	[ReimbursableEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationTables]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationTables](
	[ApplicationTableId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Model] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApportionmentData]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApportionmentData](
	[ApportionmentDataId] [int] NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasuryAppropriationFundSymbol] [nvarchar](50) NULL,
	[TreasuryAppropriationFundSymbolName] [nvarchar](100) NULL,
	[ApportionmentAccountCode] [nvarchar](50) NULL,
	[ApportionmentAccountName] [nvarchar](100) NULL,
	[AvailabilityType] [nvarchar](50) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](100) NULL,
	[ApprovalDate] [date] NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineName] [nvarchar](100) NULL,
	[Amount] [float] NULL,
 CONSTRAINT [PK_ApportionmentData] PRIMARY KEY CLUSTERED 
(
	[ApportionmentDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppropriationAvailableBalances]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationAvailableBalances](
	[AppropriationAvailableBalancesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AppropriationFundCode] [nvarchar](80) NULL,
	[AppropriationFundName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
	[TotalAuthority] [float] NULL,
	[TotalUsed] [float] NULL,
	[Available] [float] NULL,
 CONSTRAINT [PK_AppropriationAvailableBalances] PRIMARY KEY CLUSTERED 
(
	[AppropriationAvailableBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppropriationDocuments]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationDocuments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](50) NULL,
	[EFY] [nvarchar](50) NULL,
	[Fund] [nvarchar](50) NULL,
	[FundCode] [nvarchar](50) NULL,
	[DocumentType] [nvarchar](50) NULL,
	[DocumentNumber] [nvarchar](50) NULL,
	[DocumentDate] [datetime] NOT NULL,
	[LastDocumentDate] [datetime] NOT NULL,
	[BudgetLevel] [nvarchar](50) NULL,
	[BudgetingControls] [nvarchar](50) NULL,
	[PostingControls] [nvarchar](50) NULL,
	[PreCommitmentControls] [nvarchar](50) NULL,
	[CommitmentControls] [nvarchar](50) NULL,
	[ObligationControls] [nvarchar](50) NULL,
	[AccrualControls] [nvarchar](50) NULL,
	[ExpenditureControls] [nvarchar](50) NULL,
	[ExpenseControls] [nvarchar](50) NULL,
	[ReimbursementControls] [nvarchar](50) NULL,
	[ReimbursableAgreementControls] [nvarchar](50) NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[CarryOut] [float] NULL,
	[CarryIn] [float] NULL,
	[EstimatedReimbursements] [float] NULL,
	[EstimatedRecoveries] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppropriationLevelAuthority]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationLevelAuthority](
	[AppropriationBalancesId] [int] NOT NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[CarryOut] [float] NULL,
	[CarryIn] [float] NULL,
	[EstimatedReimbursements] [float] NULL,
	[EstimatedRecoveries] [time](7) NULL,
 CONSTRAINT [PK_AppropriationLevelAuthority] PRIMARY KEY CLUSTERED 
(
	[AppropriationBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appropriations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appropriations](
	[AppropriationsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[column4] [nvarchar](1) NULL,
	[column5] [nvarchar](1) NULL,
 CONSTRAINT [PK_Appropriations] PRIMARY KEY CLUSTERED 
(
	[AppropriationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BackUp]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackUp](
	[BackupAllocationId] [int] IDENTITY(1,1) NOT NULL,
	[PrcId] [float] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[AllocationRatio] [float] NULL,
	[FundName] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Division] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
	[ChangeDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetaryResourceExecution]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetaryResourceExecution](
	[BudgetaryResourceExecutionId] [int] NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[LastUpdate] [date] NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[STAT] [nvarchar](80) NULL,
	[CreditIndicator] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineDescription] [nvarchar](80) NULL,
	[SectionName] [nvarchar](80) NULL,
	[SectionNumber] [nvarchar](80) NULL,
	[LineType] [nvarchar](80) NULL,
	[FinancingAccounts] [nvarchar](80) NULL,
	[November] [float] NULL,
	[January] [float] NULL,
	[Feburary] [float] NULL,
	[April] [float] NULL,
	[May] [float] NULL,
	[June] [float] NULL,
	[August] [float] NULL,
	[October] [time](7) NULL,
	[Amount1] [float] NULL,
	[Amount2] [float] NULL,
	[Amount3] [float] NULL,
	[Amount4] [float] NULL,
	[Agency] [nvarchar](80) NULL,
	[Bureau] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetaryResourceExecution] PRIMARY KEY CLUSTERED 
(
	[BudgetaryResourceExecutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetControlValues]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetControlValues](
	[ControlValueId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[SecOrg] [nvarchar](50) NULL,
	[BdgtTransType] [nvarchar](50) NULL,
	[PstdTransType] [nvarchar](50) NULL,
	[EstReimTransType] [nvarchar](50) NULL,
	[SpngAdjTransType] [nvarchar](50) NULL,
	[EstRecTransType] [nvarchar](50) NULL,
	[ActlRecTransType] [nvarchar](50) NULL,
	[StatRsrvTransType] [nvarchar](50) NULL,
	[ProfLossTransType] [nvarchar](50) NULL,
	[EstReimSpngOpt] [nvarchar](50) NULL,
	[EstReimBdgtOpt] [nvarchar](50) NULL,
	[TrckAgreLowerLevel] [nvarchar](50) NULL,
	[BdgtEstLowerLevel] [nvarchar](50) NULL,
	[EstRecSpngOpt] [nvarchar](50) NULL,
	[EstRecBdgtOpt] [nvarchar](50) NULL,
	[RecNextLevel] [nvarchar](50) NULL,
	[RecBdgtMismatch] [nvarchar](50) NULL,
	[ProfitLossSpngOpt] [nvarchar](50) NULL,
	[ProfitLossBdgtOpt] [nvarchar](50) NULL,
	[RecCrryInLowerLevel] [nvarchar](50) NULL,
	[RecCrryInLowerLevelCtrl] [nvarchar](50) NULL,
	[RecCrryInAMCtrl] [nvarchar](50) NULL,
	[BdgtCtrl] [nvarchar](50) NULL,
	[PstdCtrl] [nvarchar](50) NULL,
	[PreCommSpngCtrl] [nvarchar](50) NULL,
	[CommSpngCtrl] [nvarchar](50) NULL,
	[ObligSpngCtrl] [nvarchar](50) NULL,
	[AccrSpngCtrl] [nvarchar](50) NULL,
	[ExpndSpngCtrl] [nvarchar](50) NULL,
	[ExpnsSpngCtrl] [nvarchar](50) NULL,
	[ReimSpngCtrl] [nvarchar](50) NULL,
	[ReimAgreSpngCtrl] [nvarchar](50) NULL,
	[FteBdgtCtrl] [nvarchar](50) NULL,
	[FteSpngCtrl] [nvarchar](50) NULL,
	[TransactionTypeCtrl] [nvarchar](50) NULL,
	[AuthorityDistributionCtrl] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetDocuments]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetDocuments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[DocumentDate] [datetime] NULL,
	[LastDocumentDate] [datetime] NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ReimbursableAgreementControls] [nvarchar](80) NULL,
	[BudgetingControls] [nvarchar](80) NULL,
	[PostingControls] [nvarchar](80) NULL,
	[PreCommitmentControls] [nvarchar](80) NULL,
	[CommitmentControls] [nvarchar](80) NULL,
	[ObligationControls] [nvarchar](80) NULL,
	[ExpenditureControls] [nvarchar](80) NULL,
	[ExpenseControls] [nvarchar](80) NULL,
	[AccrualControls] [nvarchar](80) NULL,
	[ReimbursementControls] [nvarchar](80) NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[CarryOut] [float] NULL,
	[CarryIn] [float] NULL,
	[EstimatedRecoveries] [float] NULL,
	[EstimatedReimbursements] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetOutlays]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetOutlays](
	[BudgetOutlaysId] [int] NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[AgencyName] [nvarchar](50) NULL,
	[OmbAccount] [nvarchar](100) NULL,
	[Line] [nvarchar](50) NULL,
	[LineNumber] [nvarchar](50) NULL,
	[LineSection] [nvarchar](80) NULL,
	[LineName] [nvarchar](100) NULL,
	[BeaCategory] [nvarchar](50) NULL,
	[BeaCategoryName] [nvarchar](100) NULL,
	[LineCategory] [nvarchar](50) NULL,
	[PriorYear] [float] NULL,
	[CurrentYear] [float] NULL,
	[BudgetYear] [float] NULL,
	[OutYear1] [float] NULL,
	[OutYear2] [float] NULL,
	[OutYear3] [float] NULL,
	[OutYear4] [float] NULL,
	[OutYear5] [float] NULL,
	[OutYear6] [float] NULL,
	[OutYear7] [float] NULL,
	[OutYear8] [float] NULL,
	[OutYear9] [float] NULL,
 CONSTRAINT [PK_BudgetOutlays] PRIMARY KEY CLUSTERED 
(
	[BudgetOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CapitalPlanningInvestmentCodes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapitalPlanningInvestmentCodes](
	[CapitalPlanningInvestmentCodesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[CostAreaCode] [nvarchar](80) NULL,
	[CostAreaName] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarryoverApportionments]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverApportionments](
	[CarryoverApportionmentsId] [int] NOT NULL,
	[BudgetAccount] [nvarchar](80) NULL,
	[TreasuryAccount] [nvarchar](50) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[Group] [nvarchar](100) NULL,
	[Description] [nvarchar](100) NULL,
	[LineName] [nvarchar](100) NULL,
	[AuthorityType] [nvarchar](100) NULL,
	[Request] [float] NULL,
	[Balance] [float] NULL,
	[Deobligations] [float] NULL,
	[Amount] [float] NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineSplit] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](50) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[TreasuryAccountName] [nvarchar](100) NULL,
	[BudgetAccountCode] [nvarchar](50) NULL,
	[BudgetAccountName] [nvarchar](100) NULL,
 CONSTRAINT [PK_CarryoverApportionments] PRIMARY KEY CLUSTERED 
(
	[CarryoverApportionmentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarryoverEstimates]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverEstimates](
	[CarryoverEstimateId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Balance] [real] NULL,
	[OpenCommitment] [real] NULL,
	[Estimate] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarryoverOutlays]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverOutlays](
	[CarryoverOutlaysId] [int] NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[AgencyName] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[LINE] [nvarchar](80) NULL,
	[Carryover] [float] NULL,
	[CarryoverOutlays] [float] NULL,
	[Delta] [float] NULL,
	[AvailableBalance] [float] NULL,
	[UnliquidatedObligations] [float] NULL,
	[CurrentYearAdjustment] [float] NULL,
	[BudgetYearAdjustment] [float] NULL,
	[CurrentYear] [float] NULL,
	[BudgetYear] [float] NULL,
	[OutYear1] [float] NULL,
	[OutYear2] [float] NULL,
	[OutYear3] [float] NULL,
	[OutYear4] [float] NULL,
	[OutYear5] [float] NULL,
	[OutYear6] [float] NULL,
	[OutYear7] [float] NULL,
	[OutYear8] [float] NULL,
	[OutYear9] [time](7) NULL,
 CONSTRAINT [PK_CarryoverOutlays] PRIMARY KEY CLUSTERED 
(
	[CarryoverOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarryoverRequests]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverRequests](
	[CarryoverRequestsId] [int] NOT NULL,
	[ControlTeamAnalyst] [nvarchar](50) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[DocumentTitle] [nvarchar](100) NULL,
	[Amount] [float] NULL,
	[FundCode] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[OriginalRequestDate] [date] NULL,
	[LastActivityDate] [date] NULL,
	[BFS] [nvarchar](50) NULL,
	[Comments] [nvarchar](80) NULL,
	[RequestDocument] [nvarchar](100) NULL,
	[Duration] [int] NULL,
 CONSTRAINT [PK_CarryoverRequests] PRIMARY KEY CLUSTERED 
(
	[CarryoverRequestsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Changes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Changes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[FieldName] [nvarchar](80) NULL,
	[Action] [nvarchar](80) NULL,
	[OldValue] [nvarchar](80) NULL,
	[NewValue] [nvarchar](80) NULL,
	[TimeStamp] [datetime] NULL,
	[Message] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongressionalControls]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongressionalControls](
	[CongressionalControlsId] [int] NOT NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](50) NULL,
	[ProgramAreaCode] [nvarchar](50) NULL,
	[ProgramAreaName] [nvarchar](50) NULL,
	[ProgramProjectCode] [nvarchar](50) NULL,
	[ProgramProjectName] [nvarchar](100) NULL,
	[SubProjectCode] [nvarchar](80) NULL,
	[SubProjectName] [nvarchar](50) NULL,
	[ReprogrammingRestriction] [nvarchar](80) NULL,
	[IncreaseRestriction] [nvarchar](80) NULL,
	[DecreaseRestriction] [nvarchar](80) NULL,
	[MemoRequirement] [nvarchar](80) NULL,
 CONSTRAINT [PK_CongressionalControls] PRIMARY KEY CLUSTERED 
(
	[CongressionalControlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CostAreas]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CostAreas](
	[CostAreasId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Defactos]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defactos](
	[DefactoId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](50) NULL,
	[RcCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[LowerName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeobligationActivity]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeobligationActivity](
	[DeobligationActivityId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[BudgetAccountCode] [nvarchar](50) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](100) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](100) NULL,
	[AhCode] [nvarchar](50) NULL,
	[AhName] [nvarchar](100) NULL,
	[OrgCode] [nvarchar](50) NULL,
	[OrgName] [nvarchar](100) NULL,
	[AccountCode] [nvarchar](50) NULL,
	[ProgramProjectName] [nvarchar](100) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](50) NULL,
	[DocumentNumber] [nvarchar](50) NULL,
	[ProcessedDate] [date] NULL,
	[Amount] [float] NULL,
 CONSTRAINT [PK_DeobligationActivity] PRIMARY KEY CLUSTERED 
(
	[DeobligationActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deobligations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deobligations](
	[DeobligationId] [int] IDENTITY(1,1) NOT NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[CalendarYear] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[Date] [datetime] NULL,
	[Amount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentControlNumbers]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentControlNumbers](
	[DocumentControlNumbersId] [int] NOT NULL,
	[RpioCode] [nvarchar](50) NULL,
	[RpioName] [nvarchar](50) NULL,
	[DocumentType] [nvarchar](50) NULL,
	[DocumentNumber] [nvarchar](50) NULL,
	[DocumentPrefix] [nvarchar](50) NULL,
	[DocumentControlNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_DocumentControlNumbers] PRIMARY KEY CLUSTERED 
(
	[DocumentControlNumbersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[DocumentsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[System] [nvarchar](50) NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[DocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExecutionTables]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExecutionTables](
	[ExecutionTableId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Type] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FederalHolidays]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FederalHolidays](
	[FederalHolidaysId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Columbus] [date] NULL,
	[Veterans] [date] NULL,
	[Thanksgiving] [date] NULL,
	[Christmas] [date] NULL,
	[NewYears] [date] NULL,
	[MartinLutherKing] [date] NULL,
	[Washingtons] [date] NULL,
	[Memorial] [date] NULL,
	[Juneteenth] [date] NULL,
	[Independence] [date] NULL,
	[Labor] [date] NULL,
 CONSTRAINT [PK_FederalHolidays] PRIMARY KEY CLUSTERED 
(
	[FederalHolidaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FullTimeEquivalents]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FullTimeEquivalents](
	[FullTimeEquivalentId] [int] IDENTITY(1,1) NOT NULL,
	[PrcId] [int] NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[FundName] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Division] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
	[AllocationRatio] [float] NULL,
	[ChangeDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundCategories]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundCategories](
	[FundCategoriesId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[ShortName] [nvarchar](50) NULL,
 CONSTRAINT [PK_FundCategories] PRIMARY KEY CLUSTERED 
(
	[FundCategoriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funds]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funds](
	[FundsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[ShortName] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[SubLevelPrefix] [nvarchar](80) NULL,
	[ATA] [nvarchar](80) NULL,
	[AID] [nvarchar](80) NULL,
	[BeginningPeriodOfAvailability] [nvarchar](80) NULL,
	[EndingPeriodOfAvailability] [nvarchar](80) NULL,
	[A] [nvarchar](80) NULL,
	[MAIN] [nvarchar](80) NULL,
	[SUB] [nvarchar](80) NULL,
	[FundCategory] [nvarchar](50) NULL,
	[AppropriationCode] [nvarchar](50) NULL,
	[SubAppropriationCode] [nvarchar](50) NULL,
	[FundGroup] [nvarchar](50) NULL,
	[NoYear] [nvarchar](80) NULL,
	[Carryover] [nvarchar](80) NULL,
	[CanceledYearSpendingAccount] [nvarchar](50) NULL,
	[ApplyAtAllLevels] [nvarchar](80) NULL,
	[BatsFund] [nvarchar](50) NULL,
	[BatsEndDate] [nvarchar](80) NULL,
	[BatsOptionId] [nvarchar](80) NULL,
	[SecurityOrg] [nvarchar](50) NULL,
	[BudgetAccountCode] [nvarchar](50) NULL,
	[BudgetAccountName] [nvarchar](100) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[TreasuryAccountName] [nvarchar](100) NULL,
	[ApportionmentAccountCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Funds] PRIMARY KEY CLUSTERED 
(
	[FundsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundSymbols]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundSymbols](
	[FundSymbolsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](100) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[TreasuryAccountName] [nvarchar](100) NULL,
	[BudgetAccountCode] [nvarchar](50) NULL,
	[BudgetAccountName] [nvarchar](100) NULL,
	[ApportionmentAccountCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_FundSymbols] PRIMARY KEY CLUSTERED 
(
	[FundSymbolsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goals]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goals](
	[GoalsId] [int] NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Goals] PRIMARY KEY CLUSTERED 
(
	[GoalsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrossAuthority]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrossAuthority](
	[GrossAuthorityId] [float] NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[Authority] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[ULO] [float] NULL,
	[Used] [float] NULL,
	[Outlays] [float] NULL,
	[Available] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrossUtilization]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrossUtilization](
	[GrossUtilizationId] [float] NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[Committed] [nvarchar](255) NULL,
	[Obligated] [nvarchar](255) NULL,
	[Unliquidated] [nvarchar](255) NULL,
	[Utilization] [nvarchar](255) NULL,
	[Availability] [nvarchar](255) NULL,
	[Outlaid] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrowthRates]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrowthRates](
	[GrowthRatesId] [int] NOT NULL,
	[RateId] [nvarchar](80) NULL,
	[Description] [nvarchar](100) NULL,
	[BudgetYearRate] [float] NULL,
	[OutYear1] [float] NULL,
	[OutYear2] [float] NULL,
	[OutYear3] [float] NULL,
	[OutYear4] [float] NULL,
	[OutYear5] [float] NULL,
	[OutYear6] [float] NULL,
	[OutYear7] [float] NULL,
	[OutYear8] [float] NULL,
	[OutYear9] [float] NULL,
	[Sort] [nvarchar](50) NULL,
 CONSTRAINT [PK_GrowthRates] PRIMARY KEY CLUSTERED 
(
	[GrowthRatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeadquartersAuthority]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeadquartersAuthority](
	[HeadquartersAuthorityId] [float] NULL,
	[AllocationsId] [float] NULL,
	[StatusOfFundsId] [float] NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[Amount] [float] NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeadquartersOffices]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeadquartersOffices](
	[HeadquartersOfficesId] [int] NOT NULL,
	[ResourcePlanningOfficesId] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_HeadquartersOffices] PRIMARY KEY CLUSTERED 
(
	[HeadquartersOfficesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HumanResourceOrganizations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HumanResourceOrganizations](
	[HumanResourceOrganizationsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_HumanResourceOrganizations] PRIMARY KEY CLUSTERED 
(
	[HumanResourceOrganizationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobsActCarryoverEstimates]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobsActCarryoverEstimates](
	[JobsActCarryoverEstimatesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](100) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](100) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[Available] [float] NULL,
	[Estimate] [float] NULL,
 CONSTRAINT [PK_JobsActCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[JobsActCarryoverEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonthlyLedgerAccountBalances]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlyLedgerAccountBalances](
	[MonthlyLedgerAccountBalancesId] [float] NULL,
	[FiscalYear] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[LedgerAccount] [nvarchar](255) NULL,
	[LedgerName] [nvarchar](255) NULL,
	[ApportionmentAccountCode] [nvarchar](255) NULL,
	[TreasurySymbol] [nvarchar](255) NULL,
	[TreasurySymbolName] [nvarchar](255) NULL,
	[BudgetAccountCode] [nvarchar](255) NULL,
	[BudgetAccountName] [nvarchar](255) NULL,
	[FiscalMonth] [nvarchar](255) NULL,
	[CreditBalance] [float] NULL,
	[DebitBalance] [float] NULL,
	[YearToDateAmount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonthlyOutlays]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlyOutlays](
	[MonthlyOutlaysId] [float] NULL,
	[FiscalYear] [nvarchar](255) NULL,
	[LineNumber] [nvarchar](255) NULL,
	[LineTitle] [nvarchar](255) NULL,
	[TaxationCode] [nvarchar](255) NULL,
	[TreasuryAgency] [nvarchar](255) NULL,
	[TreasuryAccount] [nvarchar](255) NULL,
	[SubAccount] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[OmbAgency] [nvarchar](255) NULL,
	[OmbBureau] [nvarchar](255) NULL,
	[OmbAccount] [nvarchar](255) NULL,
	[AgencySequence] [nvarchar](255) NULL,
	[BureauSequence] [nvarchar](255) NULL,
	[AccountSequence] [nvarchar](255) NULL,
	[AgencyTitle] [nvarchar](255) NULL,
	[BureauTitle] [nvarchar](255) NULL,
	[OmbAccountTitle] [nvarchar](255) NULL,
	[TreasuryAccountTitle] [nvarchar](255) NULL,
	[October] [float] NULL,
	[November] [float] NULL,
	[December] [float] NULL,
	[January] [float] NULL,
	[Feburary] [float] NULL,
	[March] [float] NULL,
	[April] [float] NULL,
	[May] [float] NULL,
	[June] [float] NULL,
	[July] [float] NULL,
	[August] [float] NULL,
	[September] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NationalPrograms]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NationalPrograms](
	[NationalProgramsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[Title] [nvarchar](100) NULL,
 CONSTRAINT [PK_NationalPrograms] PRIMARY KEY CLUSTERED 
(
	[NationalProgramsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjectClassOutlays]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectClassOutlays](
	[ObjectClassOutlaysId] [int] NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbAgencyName] [nvarchar](50) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbBureauName] [nvarchar](50) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](100) NULL,
	[ObligationType] [nvarchar](50) NULL,
	[DirectReimbursableTitle] [nvarchar](50) NULL,
	[ObjectClassGroupNumber] [nvarchar](80) NULL,
	[ObjectClassGroupName] [nvarchar](50) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](50) NULL,
	[FinanceObjectClass] [nvarchar](100) NULL,
	[PriorYear] [float] NULL,
	[CurrentYear] [float] NULL,
	[BudgetYear] [float] NULL,
 CONSTRAINT [PK_ObjectClassOutlays] PRIMARY KEY CLUSTERED 
(
	[ObjectClassOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Objectives]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Objectives](
	[ObjectivesId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Objectives] PRIMARY KEY CLUSTERED 
(
	[ObjectivesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obligations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obligations](
	[ObligationId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[ReferenceDocumentNumber] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperatingPlans]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperatingPlans](
	[OperatingPlanId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[ITProjectCode] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProjectTypeName] [nvarchar](80) NULL,
	[ProjectTypeCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[LocalCode] [nvarchar](80) NULL,
	[LocalCodeName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[CostAreaCode] [nvarchar](80) NULL,
	[CostAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayPeriods]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayPeriods](
	[PayPeriodId] [int] IDENTITY(1,1) NOT NULL,
	[Period] [nvarchar](255) NOT NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollActivity]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollActivity](
	[PayrollActivityId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[SubRcName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [text] NOT NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[HrOrgCode] [nvarchar](80) NULL,
	[HrOrgName] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[CheckDate] [datetime] NULL,
	[Amount] [float] NULL,
	[Hours] [float] NULL,
	[BasePaid] [float] NULL,
	[BaseHours] [float] NULL,
	[Benefits] [float] NULL,
	[OvertimePaid] [float] NULL,
	[OvertimeHours] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollAuthority]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollAuthority](
	[PayrollId] [int] IDENTITY(1,1) NOT NULL,
	[AllocationsId] [int] NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [tinyint] NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollCostCodes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollCostCodes](
	[PayrollCostCodeId] [int] IDENTITY(1,1) NOT NULL,
	[RPIO] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[HrOrgCode] [nvarchar](80) NULL,
	[HrOrgName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramAreas]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramAreas](
	[ProgramAreasId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProgramAreas] PRIMARY KEY CLUSTERED 
(
	[ProgramAreasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramFinancingSchedule]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramFinancingSchedule](
	[ID] [int] NOT NULL,
	[ReportFiscalYear] [nvarchar](80) NULL,
	[ReportFiscalMonth] [nvarchar](80) NULL,
	[ReportFiscalQuarter] [nvarchar](80) NULL,
	[FY1] [nvarchar](80) NULL,
	[FY2] [nvarchar](80) NULL,
	[TRACCT] [nvarchar](80) NULL,
	[SGL_ACCT] [nvarchar](80) NULL,
	[LINENO] [nvarchar](80) NULL,
	[AMT] [float] NULL,
	[AMT_ORIG] [float] NULL,
	[BUD_AMT] [float] NULL,
	[AGY_AMT] [float] NULL,
	[SECTION_NO] [nvarchar](80) NULL,
	[SECTION_NAME] [nvarchar](80) NULL,
	[LINE_DESC_SHORT] [nvarchar](80) NULL,
	[BUDGET_ACCT_ID] [nvarchar](80) NULL,
	[ACCT] [nvarchar](80) NULL,
	[AGESEQ] [nvarchar](80) NULL,
	[ACCTSEQ] [nvarchar](80) NULL,
	[AGETL] [nvarchar](80) NULL,
	[BURTL] [nvarchar](80) NULL,
	[ACCTTL] [nvarchar](80) NULL,
	[TRACCTTL] [nvarchar](80) NULL,
	[TRAG_ALLO_TRAC] [nvarchar](80) NULL,
	[Year2Year1] [nvarchar](80) NULL,
	[FLTR_AGETL] [nvarchar](80) NULL,
	[FLTR_BUDGET_ACCT_ID] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramFinancingSchedule] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramProjectDescriptions]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramProjectDescriptions](
	[ProgramProjectDescriptionsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[ProgramTitle] [nvarchar](100) NULL,
	[Laws] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ProgramAreaCode] [nvarchar](50) NULL,
	[ProgramAreaName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProgramProjectDescriptions] PRIMARY KEY CLUSTERED 
(
	[ProgramProjectDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramProjects]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramProjects](
	[ProgramProjectsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[ProgramAreaCode] [nvarchar](50) NULL,
	[ProgramAreaName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectCostCodes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectCostCodes](
	[ProjectCostCodesId] [float] NULL,
	[BFY] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[VendorCode] [nvarchar](255) NULL,
	[VendorName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicLaws]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicLaws](
	[PublicLawsId] [int] NOT NULL,
	[LawNumber] [nvarchar](50) NULL,
	[BillTitle] [nvarchar](300) NULL,
	[EnactedDate] [date] NULL,
	[Congress] [nvarchar](50) NULL,
	[BFY] [nvarchar](80) NULL,
 CONSTRAINT [PK_PublicLaws] PRIMARY KEY CLUSTERED 
(
	[PublicLawsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegionalAuthority]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegionalAuthority](
	[RescissionId] [int] IDENTITY(1,1) NOT NULL,
	[PrcId] [int] NULL,
	[RPIO] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[Allocation] [float] NULL,
	[Reduction] [float] NULL,
	[Amount] [float] NULL,
	[FundName] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Division] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReimbursableAgreements]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReimbursableAgreements](
	[ReimbursableAgreementId] [int] IDENTITY(1,1) NOT NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AgreementNumber] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[RcCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[ULO] [float] NULL,
	[Available] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReimbursableFunds]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReimbursableFunds](
	[ReimbursableFundId] [int] IDENTITY(1,1) NOT NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[AgreeementNumber] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[ULO] [float] NULL,
	[Available] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reprogrammings]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reprogrammings](
	[ReprogrammingId] [int] IDENTITY(1,1) NOT NULL,
	[ReprogrammingNumber] [nvarchar](80) NULL,
	[ProcessedDate] [nvarchar](80) NULL,
	[RPIO] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[Amount] [numeric](18, 0) NULL,
	[SPIO] [nvarchar](80) NULL,
	[Purpose] [nvarchar](80) NULL,
	[ExtendedPurpose] [nvarchar](80) NULL,
	[FromTo] [nvarchar](80) NULL,
	[DocType] [nvarchar](80) NULL,
	[DocPrefix] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[Line] [nvarchar](80) NULL,
	[Subline] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourcePlanningOffices]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourcePlanningOffices](
	[ResourcePlanningOfficesId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_ResourcePlanningOffices] PRIMARY KEY CLUSTERED 
(
	[ResourcePlanningOfficesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponsibilityCenters]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponsibilityCenters](
	[ResponsibilityCentersId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[Title] [nvarchar](100) NULL,
 CONSTRAINT [PK_ResponsibilityCenters] PRIMARY KEY CLUSTERED 
(
	[ResponsibilityCentersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SchemaTypes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchemaTypes](
	[SchemaTypesId] [int] NOT NULL,
	[TypeName] [nvarchar](50) NULL,
	[Database] [nvarchar](50) NULL,
 CONSTRAINT [PK_SchemaTypes] PRIMARY KEY CLUSTERED 
(
	[SchemaTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteActivity]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteActivity](
	[SiteActivityId] [float] NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[FocCode] [nvarchar](255) NULL,
	[FocName] [nvarchar](255) NULL,
	[EpaSiteId] [nvarchar](255) NULL,
	[SiteProjectCode] [nvarchar](255) NULL,
	[SSID] [nvarchar](255) NULL,
	[ActionCode] [nvarchar](255) NULL,
	[OperableUnit] [nvarchar](255) NULL,
	[SiteProjectName] [nvarchar](255) NULL,
	[State] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[CongressionalDistrict] [nvarchar](255) NULL,
	[ProjectType] [nvarchar](255) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[LastActivity] [datetime] NULL,
	[Requested] [float] NULL,
	[Accepted] [float] NULL,
	[Closed] [float] NULL,
	[Outstanding] [float] NULL,
	[Refunded] [float] NULL,
	[Reversal] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteProjectCodes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteProjectCodes](
	[SiteProjectCodeId] [int] IDENTITY(713,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpecialAccounts]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialAccounts](
	[SpecialAccountsId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[SpecialAccountFund] [nvarchar](50) NULL,
	[SpecialAccountNumber] [nvarchar](50) NULL,
	[SpecialAccountName] [nvarchar](100) NULL,
	[AccountStatus] [nvarchar](50) NULL,
	[NplStatusCode] [nvarchar](50) NULL,
	[NplStatusName] [nvarchar](50) NULL,
	[SiteId] [nvarchar](50) NULL,
	[CerclisId] [nvarchar](80) NULL,
	[SiteCode] [nvarchar](50) NULL,
	[SiteName] [nvarchar](100) NULL,
	[OperableUnit] [nvarchar](80) NULL,
	[PipelineCode] [nvarchar](80) NULL,
	[PipelineDescription] [nvarchar](50) NULL,
	[AccountCode] [nvarchar](50) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](50) NULL,
	[TransactionType] [nvarchar](50) NULL,
	[TransactionTypeName] [nvarchar](50) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](50) NULL,
	[TransactionDate] [date] NULL,
	[AvailableBalance] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[ULO] [float] NULL,
	[Disbursements] [float] NULL,
	[UnpaidBalances] [float] NULL,
	[Collections] [float] NULL,
	[CumulativeReceipts] [float] NULL,
 CONSTRAINT [PK_SpecialAccounts] PRIMARY KEY CLUSTERED 
(
	[SpecialAccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateGrantObligations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateGrantObligations](
	[StateGrantObligationId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[StateCode] [nvarchar](80) NULL,
	[StateName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfAppropriations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfAppropriations](
	[StatusOfAppropriationsId] [float] NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[AppropriationFundCode] [nvarchar](255) NULL,
	[AppropriationFundName] [nvarchar](255) NULL,
	[Availability] [nvarchar](255) NULL,
	[TreasurySymbol] [nvarchar](255) NULL,
	[OmbAccountCode] [nvarchar](255) NULL,
	[AppropriationCreationDate] [datetime] NULL,
	[AppropriationCode] [nvarchar](255) NULL,
	[SubAppropriationCode] [nvarchar](255) NULL,
	[AppropriationDescription] [nvarchar](255) NULL,
	[FundGroup] [nvarchar](255) NULL,
	[FundGroupName] [nvarchar](255) NULL,
	[DocumentType] [nvarchar](255) NULL,
	[TransType] [nvarchar](255) NULL,
	[ActualRecoveryTransType] [nvarchar](255) NULL,
	[CommitmentSpendingControlFlag] [nvarchar](255) NULL,
	[AgreementLimit] [nvarchar](255) NULL,
	[EstimatedRecoveriesTransType] [nvarchar](255) NULL,
	[EstimatedReimbursmentsTransType] [nvarchar](255) NULL,
	[ExpenseSpendingControlFlag] [nvarchar](255) NULL,
	[ObligationSpendingControlFlag] [nvarchar](255) NULL,
	[PreCommitmentSpendingControlFlag] [nvarchar](255) NULL,
	[PostedControlFlag] [nvarchar](255) NULL,
	[PostedFlag] [nvarchar](255) NULL,
	[RecordCarryoverAtLowerLevel] [nvarchar](255) NULL,
	[ReimbursableSpendingOption] [nvarchar](255) NULL,
	[RecoveriesOption] [nvarchar](255) NULL,
	[RecoveriesSpendingOption] [nvarchar](255) NULL,
	[OriginalBudgetedAmount] [float] NULL,
	[ApportionmentsPosted] [float] NULL,
	[TotalAuthority] [float] NULL,
	[TotalBudgeted] [float] NULL,
	[TotalPostedAmount] [float] NULL,
	[FundsWithdrawnPriorYearsAmount] [float] NULL,
	[FundingInAmount] [float] NULL,
	[FundingOutAmount] [float] NULL,
	[TotalAccrualRecoveries] [float] NULL,
	[TotalActualReimbursements] [float] NULL,
	[TotalAgreementReimbursables] [float] NULL,
	[TotalCarriedForwardIn] [float] NULL,
	[TotalCarriedForwardOut] [float] NULL,
	[TotalCommitted] [float] NULL,
	[TotalEstimatedRecoveries] [float] NULL,
	[TotalEstimatedReimbursements] [float] NULL,
	[TotalExpenses] [float] NULL,
	[TotalExpenditureExpenses] [float] NULL,
	[TotalExpenseAccruals] [float] NULL,
	[TotalPreCommitments] [float] NULL,
	[UnliquidatedPreCommitments] [float] NULL,
	[TotalObligations] [float] NULL,
	[ULO] [float] NULL,
	[VoidedAmount] [float] NULL,
	[TotalUsedAmount] [float] NULL,
	[AvailableAmount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfEarmarks]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfEarmarks](
	[StatusOfEarmarksId] [float] NULL,
	[StatusOfFundsId] [float] NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[LowerName] [nvarchar](255) NULL,
	[Amount] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfFunds]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfFunds](
	[StatusOfFundsId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[LowerName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Total Expense Accruals] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[NpmTitle] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfJobsActFunding]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfJobsActFunding](
	[StatusOfJobsActFundingId] [float] NULL,
	[StatusOfFundsId] [float] NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[LowerName] [nvarchar](255) NULL,
	[Amount] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
	[Balance] [float] NULL,
	[TreasuryAccountCode] [nvarchar](255) NULL,
	[TreasuryAccountName] [nvarchar](255) NULL,
	[BudgetAccountCode] [nvarchar](255) NULL,
	[BudgetAccountName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfSupplementalFunding]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfSupplementalFunding](
	[SupplementalAuthorityId] [float] NULL,
	[StatusOfFundsId] [float] NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[LowerName] [nvarchar](255) NULL,
	[Amount] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL,
	[Balance] [float] NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubAppropriations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubAppropriations](
	[SubAppropriationsId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuperfundSites]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuperfundSites](
	[SiteId] [int] NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[City] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
 CONSTRAINT [PK_SuperfundSites] PRIMARY KEY CLUSTERED 
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplementalCarryoverEstimates]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplementalCarryoverEstimates](
	[SupplementalCarryoverEstimatesID] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](100) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](100) NULL,
	[Amount] [float] NULL,
	[OpenCommitments] [float] NULL,
	[Obligations] [float] NULL,
	[Available] [float] NULL,
	[Estimate] [float] NULL,
 CONSTRAINT [PK_SupplementalCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[SupplementalCarryoverEstimatesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfers]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfers](
	[TransferId] [int] IDENTITY(713,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[DocType] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[RPIO] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[Code] [nvarchar](255) NOT NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ResourceType] [nvarchar](80) NULL,
	[Line] [float] NULL,
	[Subline] [float] NULL,
	[FromTo] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [float] NULL,
	[Purpose] [nvarchar](80) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransTypes]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransTypes](
	[TransTypesId] [int] NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](50) NULL,
	[FundName] [nvarchar](150) NULL,
	[TreasuryAccountCode] [nvarchar](50) NULL,
	[DocType] [nvarchar](50) NULL,
	[AppropriationBill] [nvarchar](50) NULL,
	[ContinuingResolution] [nvarchar](50) NULL,
	[RescissionCurrentYear] [nvarchar](50) NULL,
	[RescissionPriorYear] [nvarchar](80) NULL,
	[SequesterReduction] [nvarchar](50) NULL,
	[SequesterReturn] [nvarchar](50) NULL,
 CONSTRAINT [PK_TransTypes] PRIMARY KEY CLUSTERED 
(
	[TransTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TravelActivity]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TravelActivity](
	[TravelActivityId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[FirstName] [nvarchar](80) NULL,
	[LastName] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Duration] [float] NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[Obligations] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Extra] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnliquidatedObligations]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnliquidatedObligations](
	[UnliquidatedObligationsId] [float] NULL,
	[ObligationsId] [float] NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[DocumentType] [nvarchar](255) NULL,
	[DocumentNumber] [nvarchar](255) NULL,
	[DocumentControlNumber] [nvarchar](255) NULL,
	[TreasurySymbol] [nvarchar](255) NULL,
	[BudgetAccountCode] [nvarchar](255) NULL,
	[BudgetAccountName] [nvarchar](255) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [float] NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[FocCode] [nvarchar](255) NULL,
	[FocName] [nvarchar](255) NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL,
	[VendorCode] [nvarchar](255) NULL,
	[VendorName] [nvarchar](255) NULL,
	[Amount] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnobligatedBalances]    Script Date: 1/5/2023 4:58:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnobligatedBalances](
	[UnobligatedBalancesId] [float] NULL,
	[BudgetYear] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[BudgetAccount] [nvarchar](255) NULL,
	[TreasuryAccountCode] [nvarchar](255) NULL,
	[TreasuryAccountName] [nvarchar](255) NULL,
	[BudgetAccountCode] [nvarchar](255) NULL,
	[BudgetAccountName] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[AccountNumber] [nvarchar](255) NULL,
	[AccountName] [nvarchar](255) NULL,
	[Amount] [float] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [ActivityCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [ActivityName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [Division]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[Allocations] ADD  DEFAULT ('NS') FOR [GoalName]
GO
ALTER TABLE [dbo].[ApplicationTables] ADD  DEFAULT ('NS') FOR [TableName]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [Fund]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [DocumentType]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [DocumentNumber]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [BudgetingControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [PostingControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [PreCommitmentControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [CommitmentControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [ObligationControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [AccrualControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [ExpenditureControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [ExpenseControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [ReimbursementControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ('NS') FOR [ReimbursableAgreementControls]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ((0.0)) FOR [Budgeted]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ((0.0)) FOR [Posted]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ((0.0)) FOR [CarryOut]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ((0.0)) FOR [CarryIn]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  DEFAULT ((0.0)) FOR [EstimatedReimbursements]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ((0.0)) FOR [PrcId]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ((0.0)) FOR [AllocationRatio]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [Division]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ActivityCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [GoalCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [GoalName]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ObjectiveCode]
GO
ALTER TABLE [dbo].[BackUp] ADD  DEFAULT ('NS') FOR [ObjectiveName]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [Code]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [Name]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [SecOrg]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [BdgtTransType]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [PstdTransType]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [EstReimTransType]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [EstRecTransType]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [StatRsrvTransType]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ProfLossTransType]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [EstReimSpngOpt]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [EstReimBdgtOpt]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [TrckAgreLowerLevel]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [BdgtEstLowerLevel]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [EstRecSpngOpt]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [EstRecBdgtOpt]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [RecNextLevel]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [RecBdgtMismatch]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ProfitLossSpngOpt]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ProfitLossBdgtOpt]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [RecCrryInLowerLevel]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [RecCrryInLowerLevelCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [RecCrryInAMCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [BdgtCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [PstdCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [PreCommSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [CommSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ObligSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [AccrSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ExpndSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ExpnsSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ReimSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [ReimAgreSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [FteBdgtCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [FteSpngCtrl]
GO
ALTER TABLE [dbo].[BudgetControlValues] ADD  DEFAULT ('NS') FOR [TransactionTypeCtrl]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [DocumentType]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [DocumentNumber]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ReimbursableAgreementControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [BudgetingControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [PostingControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [PreCommitmentControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [CommitmentControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ObligationControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ExpenditureControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ExpenseControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [AccrualControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ('NS') FOR [ReimbursementControls]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ((0.0)) FOR [Budgeted]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ((0.0)) FOR [Posted]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ((0.0)) FOR [CarryOut]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ((0.0)) FOR [CarryIn]
GO
ALTER TABLE [dbo].[BudgetDocuments] ADD  DEFAULT ((0.0)) FOR [EstimatedRecoveries]
GO
ALTER TABLE [dbo].[CapitalPlanningInvestmentCodes] ADD  DEFAULT ('NS') FOR [CostAreaCode]
GO
ALTER TABLE [dbo].[CapitalPlanningInvestmentCodes] ADD  DEFAULT ('NS') FOR [CostAreaName]
GO
ALTER TABLE [dbo].[CapitalPlanningInvestmentCodes] ADD  DEFAULT ('NS') FOR [ProjectCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[CarryoverEstimates] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[Changes] ADD  DEFAULT ('NS') FOR [TableName]
GO
ALTER TABLE [dbo].[Changes] ADD  DEFAULT ('NS') FOR [FieldName]
GO
ALTER TABLE [dbo].[Changes] ADD  DEFAULT ('NS') FOR [Action]
GO
ALTER TABLE [dbo].[Changes] ADD  DEFAULT ('NS') FOR [OldValue]
GO
ALTER TABLE [dbo].[Changes] ADD  DEFAULT ('NS') FOR [NewValue]
GO
ALTER TABLE [dbo].[Changes] ADD  DEFAULT ('NOT SPECIFIED') FOR [Message]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [LowerName]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Budgeted]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Posted]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [OpenCommitments]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [ULO]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Expenditures]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Obligations]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Used]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ((0.0)) FOR [Available]
GO
ALTER TABLE [dbo].[Defactos] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [DocumentNumber]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [CalendarYear]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[Deobligations] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[ExecutionTables] ADD  DEFAULT ('NS') FOR [TableName]
GO
ALTER TABLE [dbo].[ExecutionTables] ADD  DEFAULT ('NS') FOR [Type]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [Division]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ActivityCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [GoalCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [GoalName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ObjectiveCode]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ('NS') FOR [ObjectiveName]
GO
ALTER TABLE [dbo].[FullTimeEquivalents] ADD  DEFAULT ((0.0)) FOR [AllocationRatio]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [DocumentType]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [DocumentNumber]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [DocumentControlNumber]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [ReferenceDocumentNumber]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [Age]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [FocCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [FocName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [VendorCode]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ('NS') FOR [VendorName]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ((0.0)) FOR [OpenCommitments]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ((0.0)) FOR [Obligations]
GO
ALTER TABLE [dbo].[Obligations] ADD  DEFAULT ((0.0)) FOR [ULO]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ITProjectCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProjectCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProjectName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProjectTypeName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProjectTypeCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ActivityCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ActivityName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [LocalCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [LocalCodeName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [CostAreaCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [CostAreaName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [GoalCode]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [GoalName]
GO
ALTER TABLE [dbo].[OperatingPlans] ADD  DEFAULT ('NS') FOR [ObjectiveCode]
GO
ALTER TABLE [dbo].[PayPeriods] ADD  DEFAULT ('NS') FOR [PayPeriod]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [SubRcCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [SubRcName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [FocCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [FocName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [HrOrgCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [HrOrgName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [WorkCode]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [WorkCodeName]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ('NS') FOR [PayPeriod]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ((0.0)) FOR [Hours]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ((0.0)) FOR [BasePaid]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ((0.0)) FOR [BaseHours]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ((0.0)) FOR [Benefits]
GO
ALTER TABLE [dbo].[PayrollActivity] ADD  DEFAULT ((0.0)) FOR [OvertimePaid]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [EFY]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[PayrollAuthority] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [WorkCode]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [WorkCodeName]
GO
ALTER TABLE [dbo].[PayrollCostCodes] ADD  DEFAULT ('NS') FOR [HrOrgCode]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [ReportFiscalYear]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [ReportFiscalMonth]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [ReportFiscalQuarter]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [FY1]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [FY2]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [TRACCT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [SGL_ACCT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [LINENO]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ((0.0)) FOR [AMT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ((0.0)) FOR [AMT_ORIG]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ((0.0)) FOR [BUD_AMT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ((0.0)) FOR [AGY_AMT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [SECTION_NO]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [SECTION_NAME]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [LINE_DESC_SHORT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [BUDGET_ACCT_ID]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [ACCT]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [AGESEQ]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [ACCTSEQ]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [AGETL]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [BURTL]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [ACCTTL]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [TRACCTTL]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [TRAG_ALLO_TRAC]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [Year2Year1]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [FLTR_AGETL]
GO
ALTER TABLE [dbo].[ProgramFinancingSchedule] ADD  DEFAULT ('NS') FOR [FLTR_BUDGET_ACCT_ID]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [ActivityCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ((0.0)) FOR [Allocation]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ((0.0)) FOR [Reduction]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [Division]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [GoalCode]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [GoalName]
GO
ALTER TABLE [dbo].[RegionalAuthority] ADD  DEFAULT ('NS') FOR [ObjectiveCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [AgreementNumber]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [SiteProjectCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [VendorCode]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ('NS') FOR [VendorName]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ((0.0)) FOR [OpenCommitments]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ((0.0)) FOR [Obligations]
GO
ALTER TABLE [dbo].[ReimbursableAgreements] ADD  DEFAULT ((0.0)) FOR [ULO]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [DocumentControlNumber]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ('NS') FOR [AgreeementNumber]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ((0.0)) FOR [OpenCommitments]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ((0.0)) FOR [Obligations]
GO
ALTER TABLE [dbo].[ReimbursableFunds] ADD  DEFAULT ((0.0)) FOR [ULO]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ReprogrammingNumber]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ProcessedDate]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [SPIO]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [Purpose]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [ExtendedPurpose]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [FromTo]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [DocType]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [DocPrefix]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[Reprogrammings] ADD  DEFAULT ('NS') FOR [Line]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [State]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [CongressionalDistrict]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [EpaSiteId]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [SiteProjectName]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [SiteProjectCode]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [SSID]
GO
ALTER TABLE [dbo].[SiteProjectCodes] ADD  DEFAULT ('NS') FOR [ActionCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [StateCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [StateName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[StateGrantObligations] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [LowerName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [OpenCommitments]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [ULO]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [Total Expense Accruals]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [Expenditures]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [Obligations]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [Used]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ((0.0)) FOR [Available]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [NpmCode]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [NpmName]
GO
ALTER TABLE [dbo].[StatusOfFunds] ADD  DEFAULT ('NS') FOR [NpmTitle]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [City]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [State]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [SSID]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [SiteProjectName]
GO
ALTER TABLE [dbo].[SuperfundSites] ADD  DEFAULT ('NS') FOR [EpaSiteId]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [BudgetLevel]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [DocType]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [RPIO]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [DocumentNumber]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [DivisionName]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [ProgramAreaCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [ProgramAreaName]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [ResourceType]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ((0.0)) FOR [Line]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ((0.0)) FOR [Subline]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [FromTo]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ((0.0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Transfers] ADD  DEFAULT ('NS') FOR [Purpose]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [RpioCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [RpioName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [BFY]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [AhCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [AhName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [FundCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [FundName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [AccountCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [ProgramProjectCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [ProgramProjectName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [OrgCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [OrgName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [BocCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [BocName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [RcCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [RcName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [FocCode]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [FocName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [FirstName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [LastName]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ((0.0)) FOR [Duration]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ('NS') FOR [DocumentControlNumber]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ((0.0)) FOR [Obligations]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ((0.0)) FOR [ULO]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ((0.0)) FOR [Expenditures]
GO
ALTER TABLE [dbo].[TravelActivity] ADD  DEFAULT ((0.0)) FOR [Extra]
GO

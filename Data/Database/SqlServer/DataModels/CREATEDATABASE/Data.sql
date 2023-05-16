USE
[Data]
GO
/****** Object:  Table [dbo].[AccountingEvents]    Script Date: 5/13/2023 1:46:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingEvents]
(
    [
    AccountingEventsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
      ON
    GO
    SET QUOTED_IDENTIFIER
      ON
    GO
CREATE TABLE [dbo].[Accounts]
(
    [
    AccountsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
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
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [ActivityName] [nvarchar]
(
    80
) NULL,
    [AgencyActivity] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED
(
[
    AccountsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ActivityCodes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ActivityCodes]
(
    [
    ActivityId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NOT NULL,
    [Name] [nvarchar]
(
    50
) NULL,
    [Description] [nvarchar]
(
    50
) NULL,
    CONSTRAINT [PK_ActivityCodes] PRIMARY KEY CLUSTERED
(
[
    ActivityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Actuals]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Actuals]
(
    [
    ActualsId ] [
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
    [RpioCode] [nvarchar]
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
    [AppropriationCode] [nvarchar]
(
    80
) NULL,
    [AppropriationName] [nvarchar]
(
    80
) NULL,
    [SubAppropriationCode] [nvarchar]
(
    80
) NULL,
    [SubAppropriationName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [RpioActivityCode] [nvarchar]
(
    80
) NULL,
    [RpioActivityName] [nvarchar]
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
    [ULO] [float] NULL,
    [Obligations] [float] NULL,
    [Balance] [float] NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [GoalName] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AdministrativeRequests]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
      ON
    GO
    SET QUOTED_IDENTIFIER
      ON
    GO
CREATE TABLE [dbo].[AdministrativeRequests]
(
    [
    AdministrativeRequestsId ] [
    int ]
    NOT
    NULL, [
    RequestId ] [
    float ]
    NULL, [
    Analyst ] [
    nvarchar ]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [DocumentTitle] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    [OriginalRequestDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [Duration] [float] NULL,
    [BudgetFormulationSystem] [nvarchar]
(
    80
) NULL,
    [Comments] [nvarchar]
(
    max
) NULL,
    [RequestDocument] [nvarchar]
(
    max
) NULL,
    [RequestType] [nvarchar]
(
    80
) NULL,
    [TypeCode] [nvarchar]
(
    80
) NULL,
    [Decision] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_AdministrativeRequests] PRIMARY KEY CLUSTERED
(
[
    AdministrativeRequestsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Allocations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Allocations]
(
    [
    AllocationsId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NOT
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [AhCode] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    [RcCode] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NOT NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
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
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Allocations] PRIMARY KEY CLUSTERED
(
[
    AllocationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AllowanceHolders]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AllowanceHolders]
(
    [
    AllowanceHoldersId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_AllowanceHolders] PRIMARY KEY CLUSTERED
(
[
    AllowanceHoldersId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AmericanRescuePlanCarryoverEstimates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AmericanRescuePlanCarryoverEstimates]
(
    [
    AmericanRescuePlanCarryoverEstimatesId ] [
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
    [TreasuryAccountCode] [nvarchar]
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
    CONSTRAINT [PK_AmericanRescuePlanCarryoverEstimates] PRIMARY KEY CLUSTERED
(
[
    AmericanRescuePlanCarryoverEstimatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AnnualCarryoverEstimates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AnnualCarryoverEstimates]
(
    [
    AnnualCarryoverEstimatesId ] [
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
    CONSTRAINT [PK_AnnualCarryoverEstimates] PRIMARY KEY CLUSTERED
(
[
    AnnualCarryoverEstimatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AnnualCarryoverSurvey]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AnnualCarryoverSurvey]
(
    [
    AnnualCarryoverSurveyId ] [
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
    [FundName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_AnnualCarryoverSurvey] PRIMARY KEY CLUSTERED
(
[
    AnnualCarryoverSurveyId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AnnualReimbursableEstimates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AnnualReimbursableEstimates]
(
    [
    AnnualReimbursableEstimatesId ] [
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
    CONSTRAINT [PK_AnnualReimbursableEstimates] PRIMARY KEY CLUSTERED
(
[
    AnnualReimbursableEstimatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AnnualReimbursableSurvey]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AnnualReimbursableSurvey]
(
    [
    AnnualReimbursableSurveyId ] [
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
    [FundName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_AnnualReimbursableSurvey] PRIMARY KEY CLUSTERED
(
[
    AnnualReimbursableSurveyId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ApplicationTables]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ApplicationTables]
(
    [
    ApplicationTablesId ] [
    int ]
    NOT
    NULL, [
    TableName ] [
    nvarchar ]
(
    80
) NULL,
    [Model] [nvarchar]
(
    80
) NULL,
    [Title] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ApplicationTables] PRIMARY KEY CLUSTERED
(
[
    ApplicationTablesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ApportionmentData]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ApportionmentData]
(
    [
    ApportionmentDataId ] [
    int ]
    NOT
    NULL, [
    FiscalYear ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountCode] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountName] [nvarchar]
(
    80
) NULL,
    [AvailabilityType] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ApprovalDate] [datetime] NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ApportionmentData] PRIMARY KEY CLUSTERED
(
[
    ApportionmentDataId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AppropriationAvailableBalances]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AppropriationAvailableBalances]
(
    [
    AppropriationAvailableBalancesId ] [
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
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [OriginalAmount] [float] NULL,
    [Authority] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [CarryoverIn] [float] NULL,
    [CarryoverOut] [float] NULL,
    [Used] [float] NULL,
    [Available] [float] NULL,
    CONSTRAINT [PK_AppropriationAvailableBalances] PRIMARY KEY CLUSTERED
(
[
    AppropriationAvailableBalancesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AppropriationDocuments]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AppropriationDocuments]
(
    [
    AppropriationDocumentsId ] [
    int ]
    NOT
    NULL, [
    FiscalYear ] [
    nvarchar ]
(
    80
) NULL,
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
    [AppropriationFund] [nvarchar]
(
    80
) NULL,
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [DocumentDate] [datetime] NULL,
    [BudgetLevel] [nvarchar]
(
    80
) NULL,
    [BudgetingControls] [nvarchar]
(
    80
) NULL,
    [PostingControls] [nvarchar]
(
    80
) NULL,
    [PreCommitmentControls] [nvarchar]
(
    80
) NULL,
    [CommitmentControls] [nvarchar]
(
    80
) NULL,
    [ObligationControls] [nvarchar]
(
    80
) NULL,
    [AccrualControls] [nvarchar]
(
    80
) NULL,
    [ExpenditureControls] [nvarchar]
(
    255
) NULL,
    [ExpenseControls] [nvarchar]
(
    80
) NULL,
    [ReimbursementControls] [nvarchar]
(
    80
) NULL,
    [ReimbursableAgreementControls] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [CarryoverOut] [float] NULL,
    [CarryoverIn] [float] NULL,
    [Reimbursements] [float] NULL,
    [Recoveries] [float] NULL,
    CONSTRAINT [PK_AppropriationDocuments] PRIMARY KEY CLUSTERED
(
[
    AppropriationDocumentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[AppropriationLevelAuthority]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[AppropriationLevelAuthority]
(
    [
    AppropriationLevelAuthority ] [
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
    [TreasuryAccountCode] [nvarchar]
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
    [BudgetLevel] [nvarchar]
(
    80
) NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [CarryoverOut] [float] NULL,
    [CarryoverIn] [float] NULL,
    [Reimbursements] [float] NULL,
    [Recoveries] [float] NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_AppropriationLevelAuthority] PRIMARY KEY CLUSTERED
(
[
    AppropriationLevelAuthority ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Appropriations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Appropriations]
(
    [
    AppropriationsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Appropriations] PRIMARY KEY CLUSTERED
(
[
    AppropriationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[BudgetaryResourceExecution]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[BudgetaryResourceExecution]
(
    [
    BudgetaryResourceExecutionId ] [
    int ]
    NOT
    NULL, [
    FiscalYear ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [LastUpdate] [datetime] NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [STAT] [nvarchar]
(
    80
) NULL,
    [CreditIndicator] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineDescription] [nvarchar]
(
    80
) NULL,
    [SectionName] [nvarchar]
(
    80
) NULL,
    [SectionNumber] [nvarchar]
(
    80
) NULL,
    [LineType] [nvarchar]
(
    80
) NULL,
    [FinancingAccounts] [nvarchar]
(
    80
) NULL,
    [November] [float] NULL,
    [January] [float] NULL,
    [Feburary] [float] NULL,
    [April] [float] NULL,
    [May] [float] NULL,
    [June] [float] NULL,
    [August] [float] NULL,
    [October] [float] NULL,
    [Amount1] [float] NULL,
    [Amount2] [float] NULL,
    [Amount3] [float] NULL,
    [Amount4] [float] NULL,
    CONSTRAINT [PK_BudgetaryResourceExecution] PRIMARY KEY CLUSTERED
(
[
    BudgetaryResourceExecutionId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[BudgetAuthorityAndOutlays]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[BudgetAuthorityAndOutlays]
(
    [
    BudgetAuthorityAndOutlaysId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [Category] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
    [AccountType] [nvarchar]
(
    80
) NULL,
    [AuthorityType] [nvarchar]
(
    80
) NULL,
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
    CONSTRAINT [PK_BudgetAuthorityAndOutlays] PRIMARY KEY CLUSTERED
(
[
    BudgetAuthorityAndOutlaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[BudgetControls]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[BudgetControls]
(
    [
    BudgetControlsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [BudgetedTransType] [nvarchar]
(
    80
) NULL,
    [PostedTransType] [nvarchar]
(
    80
) NULL,
    [EstimatedReimbursementsTransType] [nvarchar]
(
    80
) NULL,
    [SpendingAdjustmentTransType] [nvarchar]
(
    80
) NULL,
    [EstimatedRecoveriesTransType] [nvarchar]
(
    80
) NULL,
    [ActualRecoveriesTransType] [nvarchar]
(
    80
) NULL,
    [StatusReserveTransType] [nvarchar]
(
    80
) NULL,
    [ProfitLossTransType] [nvarchar]
(
    80
) NULL,
    [EstimatedReimbursementsSpendingOption] [nvarchar]
(
    80
) NULL,
    [EstimatedReimursementsBudgetingOption] [nvarchar]
(
    80
) NULL,
    [TrackAgreementLowerLevel] [nvarchar]
(
    80
) NULL,
    [BudgetEstimatedLowerLevel] [nvarchar]
(
    80
) NULL,
    [EstimatedRecoveriesSpendingOption] [nvarchar]
(
    80
) NULL,
    [EstimatedRecoveriesBudgetingOption] [nvarchar]
(
    80
) NULL,
    [RecoveryNextLevel] [nvarchar]
(
    80
) NULL,
    [RecoveryBudgetMismatch] [nvarchar]
(
    80
) NULL,
    [ProfitLossSpendingOption] [nvarchar]
(
    80
) NULL,
    [ProfitLossBudgetOption] [nvarchar]
(
    80
) NULL,
    [RecoveriesCarryInLowerLevel] [nvarchar]
(
    80
) NULL,
    [RecoveriesCarryInLowerLevelControl] [nvarchar]
(
    80
) NULL,
    [RecoveriesCarryInAmountControl] [nvarchar]
(
    80
) NULL,
    [BudgetedControl] [nvarchar]
(
    80
) NULL,
    [PostedControl] [nvarchar]
(
    80
) NULL,
    [PreCommitmentSpendingControl] [nvarchar]
(
    80
) NULL,
    [CommitmentSpendingControl] [nvarchar]
(
    80
) NULL,
    [ObligationSpendingControl] [nvarchar]
(
    80
) NULL,
    [AccrualSpendingControl] [nvarchar]
(
    80
) NULL,
    [ExpenditureSpendingControl] [nvarchar]
(
    80
) NULL,
    [ExpenseSpendingControl] [nvarchar]
(
    80
) NULL,
    [ReimbursableSpendingControl] [nvarchar]
(
    80
) NULL,
    [ReimbursableAgreementSpendingControl] [nvarchar]
(
    80
) NULL,
    [FteBudgetingControl] [nvarchar]
(
    80
) NULL,
    [FteSpendingControl] [nvarchar]
(
    80
) NULL,
    [TransactionTypeControl] [nvarchar]
(
    80
) NULL,
    [AuthorityDistributionControl] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_BudgetControls] PRIMARY KEY CLUSTERED
(
[
    BudgetControlsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[BudgetDocuments]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[BudgetDocuments]
(
    [
    BudgetDocumentsId ] [
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
    [BudgetLevel] [nvarchar]
(
    80
) NULL,
    [DocumentDate] [datetime] NULL,
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
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
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [CarryoverOut] [float] NULL,
    [CarryoverIn] [float] NULL,
    [Recoveries] [float] NULL,
    [Reimbursements] [float] NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_BudgetDocuments] PRIMARY KEY CLUSTERED
(
[
    BudgetDocumentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[BudgetObjectClasses]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[BudgetObjectClasses]
(
    [
    BudgetObjectClassesId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_BudgetObjectClasses] PRIMARY KEY CLUSTERED
(
[
    BudgetObjectClassesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CapitalPlanningInvestmentCodes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CapitalPlanningInvestmentCodes]
(
    [
    CapitalPlanningInvestmentCodesId ] [
    int ]
    NOT
    NULL, [
    Type ] [
    nvarchar ]
(
    80
) NULL,
    [Code] [nvarchar]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CapitalPlanningInvestmentCodes] PRIMARY KEY CLUSTERED
(
[
    CapitalPlanningInvestmentCodesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CarryoverApportionments]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CarryoverApportionments]
(
    [
    CarryoverApportionmentsId ] [
    int ]
    NOT
    NULL, [
    BudgetAccount ] [
    nvarchar ]
(
    80
) NULL,
    [TreasuryAccount] [nvarchar]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [Group] [nvarchar]
(
    80
) NULL,
    [Description] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
    [AuthorityType] [nvarchar]
(
    80
) NULL,
    [Request] [float] NULL,
    [Balance] [float] NULL,
    [Deobligations] [float] NULL,
    [Amount] [float] NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineSplit] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CarryoverApportionments] PRIMARY KEY CLUSTERED
(
[
    CarryoverApportionmentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CarryoverOutlays]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CarryoverOutlays]
(
    [
    CarryoverOutlaysId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [AgencyName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [LINE] [nvarchar]
(
    80
) NULL,
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
    [OutYear9] [float] NULL,
    CONSTRAINT [PK_CarryoverOutlays] PRIMARY KEY CLUSTERED
(
[
    CarryoverOutlaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CarryoverRequests]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CarryoverRequests]
(
    [
    CarryoverRequestsId ] [
    int ]
    NOT
    NULL, [
    Analyst ] [
    nvarchar ]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [DocumentTitle] [nvarchar]
(
    255
) NULL,
    [Amount] [float] NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    [OriginalRequestDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [BudgetFormulationSystem] [nvarchar]
(
    80
) NULL,
    [Comments] [nvarchar]
(
    max
) NULL,
    [RequestDocument] [nvarchar]
(
    max
) NULL,
    [Duration] [float] NULL,
    CONSTRAINT [PK_CarryoverRequests] PRIMARY KEY CLUSTERED
(
[
    CarryoverRequestsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Changes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Changes]
(
    [
    ChangesId ] [
    int ]
    NOT
    NULL, [
    TableName ] [
    nvarchar ]
(
    80
) NULL,
    [FieldName] [nvarchar]
(
    80
) NULL,
    [Action] [nvarchar]
(
    80
) NULL,
    [OldValue] [nvarchar]
(
    80
) NULL,
    [NewValue] [nvarchar]
(
    80
) NULL,
    [TimeStamp] [datetime] NULL,
    [Message] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Changes] PRIMARY KEY CLUSTERED
(
[
    ChangesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ColumnSchema]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ColumnSchema]
(
    [
    ColumnSchemaId ] [
    int ]
    NOT
    NULL, [
    DataType ] [
    nvarchar ]
(
    80
) NULL,
    [ColumnName] [nvarchar]
(
    80
) NULL,
    [TableName] [nvarchar]
(
    80
) NULL,
    [ColumnCaption] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ColumnSchema] PRIMARY KEY CLUSTERED
(
[
    ColumnSchemaId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CompassErrors]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CompassErrors]
(
    [
    CompassErrorsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Message] [nvarchar]
(
    80
) NULL,
    [Severity] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CompassErrors] PRIMARY KEY CLUSTERED
(
[
    CompassErrorsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CompassLevels]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CompassLevels]
(
    [
    CompassLevelsId ] [
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
    [TreasurySymbol] [nvarchar]
(
    80
) NULL,
    [BudgetLevel] [nvarchar]
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
    [AccountCode] [nvarchar]
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
    [Authority] [float] NULL,
    [CarryoverIn] [float] NULL,
    [CarryoverOut] [float] NULL,
    [Recoveries] [float] NULL,
    [Reimbursements] [float] NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CompassLevels] PRIMARY KEY CLUSTERED
(
[
    CompassLevelsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CompassOutlays]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CompassOutlays]
(
    [
    CompassOutlaysId ] [
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
    [AppropriationCode] [nvarchar]
(
    80
) NULL,
    [AppropriationName] [nvarchar]
(
    80
) NULL,
    [TreasurySymbol] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [ProcessedDate] [nvarchar]
(
    80
) NULL,
    [LastActivityDate] [nvarchar]
(
    80
) NULL,
    [TotalObligations] [float] NULL,
    [UnliquidatedObligations] [float] NULL,
    [ObligationsPaid] [float] NULL,
    CONSTRAINT [PK_CompassOutlays] PRIMARY KEY CLUSTERED
(
[
    CompassOutlaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CongressionalControls]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CongressionalControls]
(
    [
    CongressionalControlsId ] [
    int ]
    NOT
    NULL, [
    FundCode ] [
    nvarchar ]
(
    80
) NULL,
    [FundName] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [SubProjectCode] [nvarchar]
(
    80
) NULL,
    [SubProjectName] [nvarchar]
(
    80
) NULL,
    [ReprogrammingRestriction] [nvarchar]
(
    80
) NULL,
    [IncreaseRestriction] [nvarchar]
(
    80
) NULL,
    [DecreaseRestriction] [nvarchar]
(
    80
) NULL,
    [MemoRequirement] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CongressionalControls] PRIMARY KEY CLUSTERED
(
[
    CongressionalControlsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CongressionalProjects]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CongressionalProjects]
(
    [
    CongressionalEarmarksId ] [
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
    [RpioCode] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [StateCode] [nvarchar]
(
    80
) NULL,
    [StateName] [nvarchar]
(
    80
) NULL,
    [Project] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CongressionalProjects] PRIMARY KEY CLUSTERED
(
[
    CongressionalEarmarksId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CongressionalReprogrammings]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CongressionalReprogrammings]
(
    [
    CongressionalReprogrammingsId ] [
    int ]
    NOT
    NULL, [
    ReprogrammingNumber ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
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
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [Description] [nvarchar]
(
    max
) NULL,
    [ExtendedDescription] [nvarchar]
(
    max
) NULL,
    [FromTo] [nvarchar]
(
    80
) NULL,
    [Cycle] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CongressionalReprogrammings] PRIMARY KEY CLUSTERED
(
[
    CongressionalReprogrammingsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Contacts]
(
    [
    ContactsId ] [
    int ]
    NOT
    NULL, [
    FirstName ] [
    nvarchar ]
(
    80
) NULL,
    [LastName] [nvarchar]
(
    80
) NULL,
    [FullName] [nvarchar]
(
    80
) NULL,
    [Email] [nvarchar]
(
    80
) NULL,
    [RPIO] [nvarchar]
(
    80
) NULL,
    [Section] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED
(
[
    ContactsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[CostAreas]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[CostAreas]
(
    [
    CostAreasId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_CostAreas] PRIMARY KEY CLUSTERED
(
[
    CostAreasId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[DataRuleDescriptions]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[DataRuleDescriptions]
(
    [
    DataRuleDescriptionsId ] [
    int ]
    NOT
    NULL, [
    Schedule ] [
    nvarchar ]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [RuleNumber] [nvarchar]
(
    80
) NULL,
    [RuleDescription] [nvarchar]
(
    max
) NULL,
    [ScheduleOrder] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_DataRuleDescriptions] PRIMARY KEY CLUSTERED
(
[
    DataRuleDescriptionsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Defactos]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Defactos]
(
    [
    DefactosId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [RcCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    255
) NULL,
    [Amount] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [OpenCommitments] [float] NULL,
    [ULO] [float] NULL,
    [Expenditures] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [Available] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Defactos] PRIMARY KEY CLUSTERED
(
[
    DefactosId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[DeobligationActivity]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[DeobligationActivity]
(
    [
    DeobligationActivityId ] [
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
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    25
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_DeobligationActivity] PRIMARY KEY CLUSTERED
(
[
    DeobligationActivityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Deobligations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Deobligations]
(
    [
    DeobligationsId ] [
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
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
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
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_Deobligations] PRIMARY KEY CLUSTERED
(
[
    DeobligationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[DocumentControlNumbers]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[DocumentControlNumbers]
(
    [
    DocumentControlNumbersId ] [
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
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [DocumentPrefix] [nvarchar]
(
    80
) NULL,
    [DocumentControlNumber] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_DocumentControlNumbers] PRIMARY KEY CLUSTERED
(
[
    DocumentControlNumbersId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Documents]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Documents]
(
    [
    DocumentsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Category] [nvarchar]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [System] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED
(
[
    DocumentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[EarmarkCodes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[EarmarkCodes]
(
    [
    EarmarkCodesId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [RpioCode] [nvarchar]
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
    CONSTRAINT [PK_EarmarkCodes] PRIMARY KEY CLUSTERED
(
[
    EarmarkCodesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Earmarks]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Earmarks]
(
    [
    EarmarksId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [StateCode] [nvarchar]
(
    80
) NULL,
    [Description] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [ProjectOfficerLastName] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerFirstName] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerPhoneNumber] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerMailCode] [nvarchar]
(
    80
) NULL,
    [CommitmentDate] [datetime] NULL,
    [ObligationDate] [datetime] NULL,
    [ProjectStatus] [nvarchar]
(
    80
) NULL,
    [ProjectOfficerComments] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Earmarks] PRIMARY KEY CLUSTERED
(
[
    EarmarksId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ExecutionTables]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ExecutionTables]
(
    [
    ExecutionTablesId ] [
    int ]
    NOT
    NULL, [
    TableName ] [
    nvarchar ]
(
    80
) NULL,
    [Type] [nvarchar]
(
    max
) NULL,
    CONSTRAINT [PK_ExecutionTables] PRIMARY KEY CLUSTERED
(
[
    ExecutionTablesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Expenditures]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Expenditures]
(
    [
    ExpendituresId ] [
    int ]
    NOT
    NULL, [
    ObligationsId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [DocumentControlNumber] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    255
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [Age] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    255
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    CONSTRAINT [PK_Expenditures] PRIMARY KEY CLUSTERED
(
[
    ExpendituresId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[FederalHolidays]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[FederalHolidays]
(
    [
    FederalHolidaysId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [Columbus] [datetime] NULL,
    [Veterans] [datetime] NULL,
    [Thanksgiving] [datetime] NULL,
    [Christmas] [datetime] NULL,
    [NewYears] [datetime] NULL,
    [MartinLutherKing] [datetime] NULL,
    [Washingtons] [datetime] NULL,
    [Memorial] [datetime] NULL,
    [Juneteenth] [datetime] NULL,
    [Independence] [datetime] NULL,
    [Labor] [datetime] NULL,
    CONSTRAINT [PK_FederalHolidays] PRIMARY KEY CLUSTERED
(
[
    FederalHolidaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[FinanceObjectClasses]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[FinanceObjectClasses]
(
    [
    FinanceObjectClassesId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
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
    CONSTRAINT [PK_FinanceObjectClasses] PRIMARY KEY CLUSTERED
(
[
    FinanceObjectClassesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[FiscalYears]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[FiscalYears]
(
    [
    FiscalYearsId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NOT NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [StartDate] [nvarchar]
(
    80
) NULL,
    [Columbus] [datetime] NULL,
    [Veterans] [datetime] NULL,
    [Thanksgiving] [datetime] NULL,
    [Christmas] [datetime] NULL,
    [NewYears] [datetime] NULL,
    [MartinLutherKing] [datetime] NULL,
    [Washingtons] [datetime] NULL,
    [Memorial] [datetime] NULL,
    [Juneteenth] [datetime] NULL,
    [Independence] [datetime] NULL,
    [Labor] [datetime] NULL,
    [ExpiringYear] [nvarchar]
(
    80
) NULL,
    [ExpirationDate] [nvarchar]
(
    80
) NULL,
    [WorkDays] [float] NULL,
    [WeekDays] [float] NULL,
    [WeekEnds] [float] NULL,
    [EndDate] [nvarchar]
(
    80
) NULL,
    [Availability] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_FiscalYears] PRIMARY KEY CLUSTERED
(
[
    FiscalYearsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[FiscalYearsBackUp]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[FullTimeEquivalents]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[FullTimeEquivalents]
(
    [
    FullTimeEquivialentsId ] [
    int ]
    NOT
    NULL, [
    OperatingPlansId ] [
    int ]
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
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [AhCode] [nvarchar]
(
    80
) NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [RcCode] [nvarchar]
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
    [Amount] [float] NULL,
    [ITProjectCode] [nvarchar]
(
    80
) NULL,
    [ProjectCode] [nvarchar]
(
    80
) NULL,
    [ProjectName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [ProjectTypeName] [nvarchar]
(
    80
) NULL,
    [ProjectTypeCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [ActivityName] [nvarchar]
(
    80
) NULL,
    [LocalCode] [nvarchar]
(
    80
) NULL,
    [LocalCodeName] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [CostAreaCode] [nvarchar]
(
    80
) NULL,
    [CostAreaName] [nvarchar]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [GoalName] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_FullTimeEquivalents] PRIMARY KEY CLUSTERED
(
[
    FullTimeEquivialentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[FundCategories]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[FundCategories]
(
    [
    FundCategoriesId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [ShortName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_FundCategories] PRIMARY KEY CLUSTERED
(
[
    FundCategoriesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Funds]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Funds]
(
    [
    FundsId ] [
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
    [Code] [nvarchar]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [ShortName] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    [StartDate] [nvarchar]
(
    80
) NULL,
    [EndDate] [nvarchar]
(
    80
) NULL,
    [SubLevelPrefix] [nvarchar]
(
    80
) NULL,
    [AllocationTransferAgency] [nvarchar]
(
    80
) NULL,
    [AgencyIdentifier] [nvarchar]
(
    80
) NULL,
    [BeginningPeriodOfAvailability] [nvarchar]
(
    80
) NULL,
    [EndingPeriodOfAvailability] [nvarchar]
(
    80
) NULL,
    [MultiyearIndicator] [nvarchar]
(
    80
) NULL,
    [MainAccount] [nvarchar]
(
    80
) NULL,
    [SubAccount] [nvarchar]
(
    80
) NULL,
    [FundCategory] [nvarchar]
(
    80
) NULL,
    [AppropriationCode] [nvarchar]
(
    80
) NULL,
    [SubAppropriationCode] [nvarchar]
(
    80
) NULL,
    [FundGroup] [nvarchar]
(
    80
) NULL,
    [NoYear] [nvarchar]
(
    80
) NULL,
    [Carryover] [nvarchar]
(
    80
) NULL,
    [CanceledYearSpendingAccount] [nvarchar]
(
    80
) NULL,
    [ApplyAtAllLevels] [nvarchar]
(
    80
) NULL,
    [BatsFund] [nvarchar]
(
    80
) NULL,
    [BatsEndDate] [nvarchar]
(
    80
) NULL,
    [BatsOptionId] [nvarchar]
(
    80
) NULL,
    [SecurityOrg] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountCode] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Funds] PRIMARY KEY CLUSTERED
(
[
    FundsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[FundSymbols]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[FundSymbols]
(
    [
    FundSymbolsId ] [
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
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountCode] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_FundSymbols] PRIMARY KEY CLUSTERED
(
[
    FundSymbolsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[GeneralLedgerAccounts]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[GeneralLedgerAccounts]
(
    [
    GeneralLedgerAccountsId ] [
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
    [Name] [nvarchar]
(
    80
) NULL,
    [ShortName] [nvarchar]
(
    80
) NULL,
    [AccountClassification] [nvarchar]
(
    80
) NULL,
    [NormalBalance] [nvarchar]
(
    80
) NULL,
    [RealOrClosingAccount] [nvarchar]
(
    80
) NULL,
    [CashAccount] [nvarchar]
(
    80
) NULL,
    [SummaryAccount] [nvarchar]
(
    80
) NULL,
    [ReportableAccount] [nvarchar]
(
    80
) NULL,
    [CostAllocationIndicator] [nvarchar]
(
    80
) NULL,
    [FederalNonFederal] [nvarchar]
(
    80
) NULL,
    [AttributeValue] [nvarchar]
(
    80
) NULL,
    [Usage] [nvarchar]
(
    80
) NULL,
    [Deposit] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_GeneralLedgerAccounts] PRIMARY KEY CLUSTERED
(
[
    GeneralLedgerAccountsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Goals]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Goals]
(
    [
    GoalsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [Title] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Goals] PRIMARY KEY CLUSTERED
(
[
    GoalsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[GrossAuthority]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[GrossAuthority]
(
    [
    GrossAuthorityId ] [
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [Authority] [float] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [ULO] [float] NULL,
    [Used] [float] NULL,
    [Outlays] [float] NULL,
    [Available] [float] NULL,
    CONSTRAINT [PK_GrossAuthority] PRIMARY KEY CLUSTERED
(
[
    GrossAuthorityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[GrossUtilization]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[GrossUtilization]
(
    [
    GrossUtilizationId ] [
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [Committed] [nvarchar]
(
    80
) NULL,
    [Obligated] [nvarchar]
(
    80
) NULL,
    [Unliquidated] [nvarchar]
(
    80
) NULL,
    [Utilization] [nvarchar]
(
    80
) NULL,
    [Availability] [nvarchar]
(
    80
) NULL,
    [Outlaid] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_GrossUtilization] PRIMARY KEY CLUSTERED
(
[
    GrossUtilizationId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[GrowthRates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[GrowthRates]
(
    [
    GrowthRatesId ] [
    int ]
    NOT
    NULL, [
    RateId ] [
    nvarchar ]
(
    80
) NULL,
    [DESCRIPTION] [nvarchar]
(
    80
) NULL,
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
    [Sort] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_GrowthRates] PRIMARY KEY CLUSTERED
(
[
    GrowthRatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[GsPayScales]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[GsPayScales]
(
    [
    GsPayScalesId ] [
    int ]
    NOT
    NULL, [
    LOCNAME ] [
    nvarchar ]
(
    80
) NULL,
    [GRADE] [float] NULL,
    [ANNUAL1] [float] NULL,
    [HOURLY1] [nvarchar]
(
    80
) NULL,
    [OVERTIME1] [nvarchar]
(
    80
) NULL,
    [ANNUAL2] [float] NULL,
    [HOURLY2] [nvarchar]
(
    80
) NULL,
    [OVERTIME2] [nvarchar]
(
    80
) NULL,
    [ANNUAL3] [float] NULL,
    [HOURLY3] [nvarchar]
(
    80
) NULL,
    [OVERTIME3] [nvarchar]
(
    80
) NULL,
    [ANNUAL4] [float] NULL,
    [HOURLY4] [nvarchar]
(
    80
) NULL,
    [OVERTIME4] [nvarchar]
(
    80
) NULL,
    [ANNUAL5] [float] NULL,
    [HOURLY5] [nvarchar]
(
    80
) NULL,
    [OVERTIME5] [nvarchar]
(
    80
) NULL,
    [ANNUAL6] [float] NULL,
    [HOURLY6] [nvarchar]
(
    80
) NULL,
    [OVERTIME6] [nvarchar]
(
    80
) NULL,
    [ANNUAL7] [float] NULL,
    [HOURLY7] [nvarchar]
(
    80
) NULL,
    [OVERTIME7] [nvarchar]
(
    80
) NULL,
    [ANNUAL8] [float] NULL,
    [HOURLY8] [nvarchar]
(
    80
) NULL,
    [OVERTIME8] [nvarchar]
(
    80
) NULL,
    [ANNUAL9] [float] NULL,
    [HOURLY9] [nvarchar]
(
    80
) NULL,
    [OVERTIME9] [nvarchar]
(
    80
) NULL,
    [ANNUAL10] [float] NULL,
    [HOURLY10] [nvarchar]
(
    80
) NULL,
    [OVERTIME10] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_GsPayScales] PRIMARY KEY CLUSTERED
(
[
    GsPayScalesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[HeadquartersAuthority]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[HeadquartersAuthority]
(
    [
    HeadquartersAuthorityId ] [
    int ]
    NOT
    NULL, [
    AllocationsId ] [
    int ]
    NULL, [
    StatusOfFundsId ] [
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
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [BudgetLevel] [nvarchar]
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [ProgramProjectCode] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_HeadquartersAuthority] PRIMARY KEY CLUSTERED
(
[
    HeadquartersAuthorityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[HeadquartersOffices]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[HeadquartersOffices]
(
    [
    HeadquartersOfficesId ] [
    int ]
    NOT
    NULL, [
    ResourcePlanningOfficesId ] [
    int ]
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_HeadquartersOffices] PRIMARY KEY CLUSTERED
(
[
    HeadquartersOfficesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[HumanResourceOrganizations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[HumanResourceOrganizations]
(
    [
    HumanResourceOrganizationsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_HumanResourceOrganizations] PRIMARY KEY CLUSTERED
(
[
    HumanResourceOrganizationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Images]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Images]
(
    [
    ImagesId ] [
    int ]
    NOT
    NULL, [
    FileName ] [
    nvarchar ]
(
    80
) NULL,
    [FilePath] [nvarchar]
(
    80
) NULL,
    [FileExtension] [nvarchar]
(
    80
) NULL,
    [ImageFile] [image] NULL,
    [Attachments] [nvarchar]
(
    max
) NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED
(
[
    ImagesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[InflationReductionActCarryoverEstimates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[InflationReductionActCarryoverEstimates]
(
    [
    InflationReductionActCarryoverEstimatesId ] [
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
    CONSTRAINT [PK_InflationReductionActCarryoverEstimates] PRIMARY KEY CLUSTERED
(
[
    InflationReductionActCarryoverEstimatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[InfrastructureAccounts]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[InfrastructureAccounts]
(
    [
    InfrastructureAccountsId ] [
    int ]
    NOT
    NULL, [
    StrategicPlan ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [ActivityName] [nvarchar]
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
    [ProgramName] [nvarchar]
(
    80
) NULL,
    [ProgramDescription] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_InfrastructureAccounts] PRIMARY KEY CLUSTERED
(
[
    InfrastructureAccountsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[JobsActCarryoverEstimates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[Messages]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Messages]
(
    [
    MessageId ] [
    int ]
    NOT
    NULL, [
    Message ] [
    nvarchar ]
(
    255
) NULL,
    [Type] [nvarchar]
(
    80
) NULL,
    [Form] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED
(
[
    MessageId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[MonthlyActuals]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[MonthlyActuals]
(
    [
    MonthlyActualsId ] [
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
    [AppropriationCode] [nvarchar]
(
    80
) NULL,
    [AppropriationName] [nvarchar]
(
    80
) NULL,
    [SubAppropriationCode] [nvarchar]
(
    80
) NULL,
    [SubAppropriationName] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [RpioActivityCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [NetOutlays] [float] NULL,
    [GrossOutlays] [float] NULL,
    [Obligations] [float] NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_MonthlyActuals] PRIMARY KEY CLUSTERED
(
[
    MonthlyActualsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[MonthlyLedgerAccountBalances]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[MonthlyLedgerAccountBalances]
(
    [
    MonthlyLedgerAccountBalancesId ] [
    int ]
    NOT
    NULL, [
    FiscalYear ] [
    nvarchar ]
(
    80
) NULL,
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
    [LedgerAccount] [nvarchar]
(
    80
) NULL,
    [LedgerName] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasurySymbol] [nvarchar]
(
    80
) NULL,
    [TreasurySymbolName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [FiscalMonth] [nvarchar]
(
    80
) NULL,
    [CreditBalance] [float] NULL,
    [DebitBalance] [float] NULL,
    [YearToDateAmount] [float] NULL,
    CONSTRAINT [PK_MonthlyLedgerAccountBalances] PRIMARY KEY CLUSTERED
(
[
    MonthlyLedgerAccountBalancesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[MonthlyOutlays]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[MonthlyOutlays]
(
    [
    MonthlyOutlaysId ] [
    int ]
    NOT
    NULL, [
    FiscalYear ] [
    nvarchar ]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineTitle] [nvarchar]
(
    80
) NULL,
    [TaxationCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAgencyCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [SubAccount] [nvarchar]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [BudgetAgencyCode] [nvarchar]
(
    80
) NULL,
    [BudgetBureauCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [AgencySequence] [nvarchar]
(
    80
) NULL,
    [BureauSequence] [nvarchar]
(
    80
) NULL,
    [AccountSequence] [nvarchar]
(
    80
) NULL,
    [AgencyTitle] [nvarchar]
(
    80
) NULL,
    [BureauTitle] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
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
    [September] [float] NULL,
    CONSTRAINT [PK_MonthlyOutlays] PRIMARY KEY CLUSTERED
(
[
    MonthlyOutlaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[NationalPrograms]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[NationalPrograms]
(
    [
    NationalProgramsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NOT NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [Title] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_NationalPrograms] PRIMARY KEY CLUSTERED
(
[
    NationalProgramsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ObjectClassOutlays]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ObjectClassOutlays]
(
    [
    ObjectClassOutlaysId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [BudgetAgencyCode] [nvarchar]
(
    80
) NULL,
    [BudgetAgencyName] [nvarchar]
(
    80
) NULL,
    [BudgetBureauCode] [nvarchar]
(
    80
) NULL,
    [BudgetBureauName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ObligationType] [nvarchar]
(
    80
) NULL,
    [DirectReimbursableTitle] [nvarchar]
(
    80
) NULL,
    [ObjectClassGroupNumber] [nvarchar]
(
    80
) NULL,
    [ObjectClassGroupName] [nvarchar]
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
    [FinanceObjectClass] [nvarchar]
(
    80
) NULL,
    [PriorYear] [float] NULL,
    [CurrentYear] [float] NULL,
    [BudgetYear] [float] NULL,
    CONSTRAINT [PK_ObjectClassOutlays] PRIMARY KEY CLUSTERED
(
[
    ObjectClassOutlaysId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Objectives]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Objectives]
(
    [
    ObjectivesId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [Title] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Objectives] PRIMARY KEY CLUSTERED
(
[
    ObjectivesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ObligationActivity]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ObligationActivity]
(
    [
    ObligationActivityId ] [
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
    [BudgetAccountCode] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [UnliquidatedObligations] [float] NULL,
    [Outlays] [float] NULL
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Obligations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
      ON
    GO
    SET QUOTED_IDENTIFIER
      ON
    GO
CREATE TABLE [dbo].[Obligations]
(
    [
    ObligationsId ] [
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [DocumentControlNumber] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ApportionmentAccountCode] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [Age] [float] NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [UnliquidatedObligations] [float] NULL,
    [Expenditures] [float] NULL,
    CONSTRAINT [PK_Obligations] PRIMARY KEY CLUSTERED
(
[
    ObligationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[OpenCommitments]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[OpenCommitments]
(
    [
    OpenCommitmentsId ] [
    int ]
    NOT
    NULL, [
    ObligationsId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [DocumentControlNumber] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [Age] [float] NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    CONSTRAINT [PK_OpenCommitments] PRIMARY KEY CLUSTERED
(
[
    OpenCommitmentsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[OperatingPlans]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[OperatingPlans]
(
    [
    OperatingPlansId ] [
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [Amount] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [ActivityName] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [GoalName] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [Version] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_OperatingPlans] PRIMARY KEY CLUSTERED
(
[
    OperatingPlansId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[OperatingPlanUpdates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[OperatingPlanUpdates]
(
    [
    OperatingPlanUpdatesId ] [
    int ]
    NOT
    NULL, [
    OperatingPlansId ] [
    int ]
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
    [BudgetLevel] [nvarchar]
(
    80
) NULL,
    [AhCode] [nvarchar]
(
    80
) NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [ActivityName] [nvarchar]
(
    80
) NULL,
    [DivisionName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    [GoalCode] [nvarchar]
(
    80
) NULL,
    [GoalName] [nvarchar]
(
    80
) NULL,
    [ObjectiveCode] [nvarchar]
(
    80
) NULL,
    [ObjectiveName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_OperatingPlanUpdates] PRIMARY KEY CLUSTERED
(
[
    OperatingPlanUpdatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Organizations]
(
    [
    OrganizationsId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [Code] [nvarchar]
(
    80
) NULL,
    [PreventNewUse] [nvarchar]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    [SecurityOrg] [nvarchar]
(
    80
) NULL,
    [Usage] [nvarchar]
(
    80
) NULL,
    [UseAsCostOrg] [nvarchar]
(
    80
) NULL,
    [SubCodeRequired] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [AhCode] [nvarchar]
(
    80
) NULL,
    [RcCode] [nvarchar]
(
    80
) NULL,
    [SubRcCode] [nvarchar]
(
    80
) NULL,
    [Description] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED
(
[
    OrganizationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[PayPeriods]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[PayrollActivity]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[PayrollActivity]
(
    [
    PayrollActivityId ] [
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
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
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
    [PayPeriod] [nvarchar]
(
    80
) NULL,
    [StartDate] [datetime] NULL,
    [EndDate] [datetime] NULL,
    [CheckDate] [datetime] NULL,
    [Amount] [float] NULL,
    [Hours] [float] NULL,
    [BasePaid] [float] NULL,
    [BaseHours] [float] NULL,
    [Benefits] [float] NULL,
    [OvertimePaid] [float] NULL,
    [OvertimeHours] [float] NULL,
    CONSTRAINT [PK_PayrollActivity] PRIMARY KEY CLUSTERED
(
[
    PayrollActivityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[PayrollAuthority]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[PayrollAuthority]
(
    [
    PayrollAuthorityId ] [
    int ]
    NOT
    NULL, [
    AllocationsId ] [
    int ]
    NULL, [
    StatusOfFundsId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
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
    [BudgetLevel] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [ProgramProjectCode] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_PayrollAuthority] PRIMARY KEY CLUSTERED
(
[
    PayrollAuthorityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[PayrollCostCodes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[PayrollRequests]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[PayrollRequests]
(
    [
    PayrollRequestsId ] [
    int ]
    NOT
    NULL, [
    ControlTeamAnalyst ] [
    nvarchar ]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [DocumentTitle] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    [OriginalRequestDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [BFS] [nvarchar]
(
    80
) NULL,
    [Comments] [nvarchar]
(
    max
) NULL,
    [RequestDocument] [nvarchar]
(
    max
) NULL,
    [Duration] [float] NULL,
    CONSTRAINT [PK_PayrollRequests] PRIMARY KEY CLUSTERED
(
[
    PayrollRequestsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[PRC]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[PRC]
(
    [
    PrcId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [AhCode] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_PRC] PRIMARY KEY CLUSTERED
(
[
    PrcId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ProgramAreas]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ProgramAreas]
(
    [
    ProgramAreasId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ProgramAreas] PRIMARY KEY CLUSTERED
(
[
    ProgramAreasId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ProgramFinancingSchedule]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ProgramFinancingSchedule]
(
    [
    ProgramFinancingScheduleId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [TreasuryAgencyCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [LedgerAccountCode] [nvarchar]
(
    80
) NULL,
    [SectionNumber] [nvarchar]
(
    80
) NULL,
    [SectionName] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineDescription] [nvarchar]
(
    80
) NULL,
    [BudgetAgencyCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [AgencySequence] [nvarchar]
(
    80
) NULL,
    [AccountSequence] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [OriginalAmount] [float] NULL,
    [BudgetAmount] [float] NULL,
    [AgencyAmount] [float] NULL,
    [Amount] [float] NULL,
    [AgencyName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ProgramFinancingSchedule] PRIMARY KEY CLUSTERED
(
[
    ProgramFinancingScheduleId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ProgramProjectDescriptions]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ProgramProjectDescriptions]
(
    [
    ProgramProjectDescriptionsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [ProgramTitle] [nvarchar]
(
    80
) NULL,
    [Laws] [nvarchar]
(
    max
) NULL,
    [Description] [nvarchar]
(
    max
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    80
) NULL,
    [ProgramAreaName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ProgramProjectDescriptions] PRIMARY KEY CLUSTERED
(
[
    ProgramProjectDescriptionsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ProgramProjects]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ProgramProjects]
(
    [
    ProgramProjectsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
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
    CONSTRAINT [PK_ProgramProjects] PRIMARY KEY CLUSTERED
(
[
    ProgramProjectsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ProjectCostCodes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ProjectCostCodes]
(
    [
    ProjectCostCodesId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
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
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
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
    CONSTRAINT [PK_ProjectCostCodes] PRIMARY KEY CLUSTERED
(
[
    ProjectCostCodesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Projects]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Projects]
(
    [
    ProjectsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED
(
[
    ProjectsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Providers]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Providers]
(
    [
    ProvidersId ] [
    int ]
    NOT
    NULL, [
    ProviderName ] [
    nvarchar ]
(
    80
) NULL,
    [FileExtension] [nvarchar]
(
    80
) NULL,
    [Connection] [nvarchar]
(
    80
) NULL,
    [Properties] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED
(
[
    ProvidersId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[PublicLaws]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[PublicLaws]
(
    [
    PublicLawsId ] [
    int ]
    NOT
    NULL, [
    LawNumber ] [
    nvarchar ]
(
    80
) NULL,
    [BillTitle] [nvarchar]
(
    80
) NULL,
    [EnactedDate] [datetime] NULL,
    [Congress] [nvarchar]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_PublicLaws] PRIMARY KEY CLUSTERED
(
[
    PublicLawsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[QueryDefinitions]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[QueryDefinitions]
(
    [
    QueryDefinitionsId ] [
    int ]
    NOT
    NULL, [
    Name ] [
    nvarchar ]
(
    80
) NULL,
    [Type] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_QueryDefinitions] PRIMARY KEY CLUSTERED
(
[
    QueryDefinitionsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[RecoveryAct]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[RecoveryAct]
(
    [
    RecoveryActId ] [
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
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [Amount] [float] NULL,
    CONSTRAINT [PK_RecoveryAct] PRIMARY KEY CLUSTERED
(
[
    RecoveryActId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ReferenceTables]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ReferenceTables]
(
    [
    ReferenceTablesId ] [
    int ]
    NOT
    NULL, [
    TableName ] [
    nvarchar ]
(
    80
) NULL,
    [Type] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ReferenceTables] PRIMARY KEY CLUSTERED
(
[
    ReferenceTablesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[RegionalAuthority]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[RegionalAuthority]
(
    [
    RegionalAuthorityId ] [
    int ]
    NOT
    NULL, [
    AllocationsId ] [
    int ]
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    255
) NULL,
    [BFY] [nvarchar]
(
    255
) NULL,
    [EFY] [nvarchar]
(
    255
) NULL,
    [FundCode] [nvarchar]
(
    255
) NULL,
    [FundName] [nvarchar]
(
    255
) NULL,
    [RpioCode] [nvarchar]
(
    255
) NULL,
    [RpioName] [nvarchar]
(
    255
) NULL,
    [AhCode] [nvarchar]
(
    255
) NULL,
    [AhName] [nvarchar]
(
    255
) NULL,
    [OrgCode] [nvarchar]
(
    255
) NULL,
    [OrgName] [nvarchar]
(
    255
) NULL,
    [AccountCode] [nvarchar]
(
    255
) NULL,
    [RcCode] [nvarchar]
(
    255
) NULL,
    [RcName] [nvarchar]
(
    255
) NULL,
    [BocCode] [nvarchar]
(
    255
) NULL,
    [BocName] [nvarchar]
(
    255
) NULL,
    [Amount] [float] NULL,
    [ProgramProjectCode] [nvarchar]
(
    255
) NULL,
    [ProgramProjectName] [nvarchar]
(
    255
) NULL,
    [ProgramAreaCode] [nvarchar]
(
    255
) NULL,
    [ProgramAreaName] [nvarchar]
(
    255
) NULL,
    [NpmCode] [nvarchar]
(
    255
) NULL,
    [NpmName] [nvarchar]
(
    255
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    255
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    255
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    255
) NULL,
    [BudgetAccountName] [nvarchar]
(
    255
) NULL
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[RegionalOffices]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
      ON
    GO
    SET QUOTED_IDENTIFIER
      ON
    GO
CREATE TABLE [dbo].[RegionalOffices]
(
    [
    RegionalOfficesId ] [
    int ]
    NOT
    NULL, [
    ResourcePlanningOfficesId ] [
    int ]
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_RegionalOffices] PRIMARY KEY CLUSTERED
(
[
    RegionalOfficesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ReimbursableAgreements]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[ReimbursableFunds]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[Reports]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Reports]
(
    [
    ReportsId ] [
    int ]
    NOT
    NULL, [
    Name ] [
    nvarchar ]
(
    80
) NULL,
    [Title] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED
(
[
    ReportsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Reprogrammings]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Reprogrammings]
(
    [
    ReprogrammingsId ] [
    int ]
    NOT
    NULL, [
    DocPrefix ] [
    nvarchar ]
(
    80
) NULL,
    [ReprogrammingNumber] [nvarchar]
(
    80
) NULL,
    [BFY] [nvarchar]
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
    [ProcessedDate] [datetime] NULL,
    [DocType] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [FromTo] [nvarchar]
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
    [Purpose] [nvarchar]
(
    max
) NULL,
    [ResourceType] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_Reprogrammings] PRIMARY KEY CLUSTERED
(
[
    ReprogrammingsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ResourcePlanningOffices]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ResourcePlanningOffices]
(
    [
    ResourcePlanningOfficesId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ResourcePlanningOffices] PRIMARY KEY CLUSTERED
(
[
    ResourcePlanningOfficesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Resources]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Resources]
(
    [
    ResourcesId ] [
    int ]
    NOT
    NULL, [
    Identifier ] [
    nvarchar ]
(
    80
) NULL,
    [Type] [nvarchar]
(
    80
) NULL,
    [Location] [nvarchar]
(
    80
) NULL,
    [FileExtension] [nvarchar]
(
    80
) NULL,
    [Caption] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED
(
[
    ResourcesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[ResponsibilityCenters]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[ResponsibilityCenters]
(
    [
    ResponsibilityCentersId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    [Title] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_ResponsibilityCenters] PRIMARY KEY CLUSTERED
(
[
    ResponsibilityCentersId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SchemaTypes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SchemaTypes]
(
    [
    SchemaTypesId ] [
    int ]
    NOT
    NULL, [
    TypeName ] [
    nvarchar ]
(
    80
) NULL,
    [Database] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_SchemaTypes] PRIMARY KEY CLUSTERED
(
[
    SchemaTypesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SiteActivity]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SiteActivity]
(
    [
    SiteActivityId ] [
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
    [RpioCode] [nvarchar]
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [EpaSiteId] [nvarchar]
(
    80
) NULL,
    [SiteProjectCode] [nvarchar]
(
    80
) NULL,
    [SSID] [nvarchar]
(
    80
) NULL,
    [ActionCode] [nvarchar]
(
    80
) NULL,
    [OperableUnit] [nvarchar]
(
    80
) NULL,
    [SiteProjectName] [nvarchar]
(
    80
) NULL,
    [State] [nvarchar]
(
    80
) NULL,
    [City] [nvarchar]
(
    80
) NULL,
    [CongressionalDistrict] [nvarchar]
(
    80
) NULL,
    [ProjectType] [nvarchar]
(
    80
) NULL,
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
/****** Object:  Table [dbo].[SiteProjectCodes]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
      ON
    GO
    SET QUOTED_IDENTIFIER
      ON
    GO
CREATE TABLE [dbo].[SiteProjectCodes]
(
    [
    SiteProjectCodesId ] [
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
    [State] [nvarchar]
(
    80
) NULL,
    [CongressionalDistrict] [nvarchar]
(
    80
) NULL,
    [EpaSiteId] [nvarchar]
(
    80
) NULL,
    [SiteProjectName] [nvarchar]
(
    80
) NULL,
    [SiteProjectCode] [nvarchar]
(
    80
) NULL,
    [SSID] [nvarchar]
(
    80
) NULL,
    [ActionCode] [nvarchar]
(
    80
) NULL,
    [OperableUnit] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_SiteProjectCodes] PRIMARY KEY CLUSTERED
(
[
    SiteProjectCodesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SpecialAccounts]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SpecialAccounts]
(
    [
    SpecialAccountsId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    [FundCode] [nvarchar]
(
    80
) NULL,
    [SpecialAccountFund] [nvarchar]
(
    80
) NULL,
    [SpecialAccountNumber] [nvarchar]
(
    80
) NULL,
    [SpecialAccountName] [nvarchar]
(
    80
) NULL,
    [AccountStatus] [nvarchar]
(
    80
) NULL,
    [NplStatusCode] [nvarchar]
(
    80
) NULL,
    [NplStatusName] [nvarchar]
(
    80
) NULL,
    [SiteId] [nvarchar]
(
    80
) NULL,
    [CerclisId] [nvarchar]
(
    80
) NULL,
    [SiteCode] [nvarchar]
(
    80
) NULL,
    [SiteName] [nvarchar]
(
    80
) NULL,
    [OperableUnit] [nvarchar]
(
    80
) NULL,
    [PipelineCode] [nvarchar]
(
    80
) NULL,
    [PipelineDescription] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [TransactionType] [nvarchar]
(
    80
) NULL,
    [TransactionTypeName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [TransactionDate] [datetime] NULL,
    [AvailableBalance] [float] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [UnliquidatedObligations] [float] NULL,
    [Disbursements] [float] NULL,
    [UnpaidBalances] [float] NULL,
    [Collections] [float] NULL,
    [CumulativeReceipts] [float] NULL,
    CONSTRAINT [PK_SpecialAccounts] PRIMARY KEY CLUSTERED
(
[
    SpecialAccountsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SpendingDocuments]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[SpendingRates]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SpendingRates]
(
    [
    SpendingRatesId ] [
    int ]
    NOT
    NULL, [
    OmbAgencyCode ] [
    nvarchar ]
(
    80
) NULL,
    [OmbAgencyName] [nvarchar]
(
    80
) NULL,
    [OmbBureauCode] [nvarchar]
(
    80
) NULL,
    [OmbBureauName] [nvarchar]
(
    80
) NULL,
    [TreausuryAgencyCode] [nvarchar]
(
    80
) NULL,
    [TreausuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreausuryAccountName] [nvarchar]
(
    80
) NULL,
    [AccountTitle] [nvarchar]
(
    80
) NULL,
    [Subfunction] [nvarchar]
(
    80
) NULL,
    [Line] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [Category] [nvarchar]
(
    80
) NULL,
    [Subcategory] [nvarchar]
(
    80
) NULL,
    [SubcategoryName] [nvarchar]
(
    80
) NULL,
    [MainAccount] [nvarchar]
(
    80
) NULL,
    [Jurisdiction] [nvarchar]
(
    80
) NULL,
    [YearOfAuthority] [nvarchar]
(
    80
) NULL,
    [BudgetAuthority] [float] NULL,
    [OutYear1] [float] NULL,
    [OutYear2] [float] NULL,
    [OutYear3] [float] NULL,
    [OutYear4] [float] NULL,
    [OutYear5] [float] NULL,
    [OutYear6] [float] NULL,
    [OutYear7] [float] NULL,
    [OutYear8] [float] NULL,
    [OutYear9] [float] NULL,
    [OutYear10] [float] NULL,
    [OutYear11] [float] NULL,
    [TotalSpendout] [float] NULL,
    CONSTRAINT [PK_SpendingRates] PRIMARY KEY CLUSTERED
(
[
    SpendingRatesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StateGrantObligations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StateGrantObligations]
(
    [
    StateGrantObligationsId ] [
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
    [RpioCode] [nvarchar]
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
(
    80
) NULL,
    [Approp Code] [nvarchar]
(
    80
) NULL,
    [Approp Code Short TItle] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [StateCode] [nvarchar]
(
    80
) NULL,
    [StateName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [WholeDollars] [float] NULL,
    CONSTRAINT [PK_StateGrantObligations] PRIMARY KEY CLUSTERED
(
[
    StateGrantObligationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StateOrganizations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StateOrganizations]
(
    [
    StateOrganizationsId ] [
    int ]
    NOT
    NULL, [
    Name ] [
    nvarchar ]
(
    80
) NULL,
    [Code] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [RpioName] [nvarchar]
(
    80
) NULL,
    [RpioCode] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StateOrganizations] PRIMARY KEY CLUSTERED
(
[
    StateOrganizationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfAmericanRescuePlanFunding]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfAmericanRescuePlanFunding]
(
    [
    AmericanRescuePlanId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [BocCode] [nvarchar]
(
    255
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [OpenCommitments] [float] NULL,
    [ULO] [float] NULL,
    [Expenditures] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [Available] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfAmericanRescuePlanFunding] PRIMARY KEY CLUSTERED
(
[
    AmericanRescuePlanId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfAppropriations]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfAppropriations]
(
    [
    StatusOfAppropriationsId ] [
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
    [BudgetLevel] [nvarchar]
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
    [Availability] [nvarchar]
(
    80
) NULL,
    [TransType] [nvarchar]
(
    80
) NULL,
    [TreasurySymbol] [nvarchar]
(
    80
) NULL,
    [OriginalAmount] [float] NULL,
    [Authority] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [CarryoverOut] [float] NULL,
    [CarryoverIn] [float] NULL,
    [TransferIn] [float] NULL,
    [TransferOut] [float] NULL,
    [OpenCommitments] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [Expenditures] [float] NULL,
    [UnliquidatedObligations] [float] NULL,
    [Available] [float] NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfAppropriations] PRIMARY KEY CLUSTERED
(
[
    StatusOfAppropriationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfBudgetaryResources]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfBudgetaryResources]
(
    [
    StatusOfBudgetaryResourcesId ] [
    int ]
    NOT
    NULL, [
    BFY ] [
    nvarchar ]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BeginningPeriodOfAvailability] [nvarchar]
(
    80
) NULL,
    [EndingPeriodOfAvailability] [nvarchar]
(
    80
) NULL,
    [SectionNumber] [nvarchar]
(
    80
) NULL,
    [SectionName] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
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
    [September] [float] NULL,
    [October] [float] NULL,
    [LastUpdate] [datetime] NULL,
    CONSTRAINT [PK_StatusOfBudgetaryResources] PRIMARY KEY CLUSTERED
(
[
    StatusOfBudgetaryResourcesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfEarmarks]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfEarmarks]
(
    [
    StatusOfEarmarksId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [OpenCommitments] [float] NULL,
    [ULO] [float] NULL,
    [Expenditures] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [Available] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfEarmarks] PRIMARY KEY CLUSTERED
(
[
    StatusOfEarmarksId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfFunds]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfFunds]
(
    [
    StatusOfFundsId ] [
    int ]
    NOT
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [Budgeted] [float] NULL,
    [Posted] [float] NULL,
    [OpenCommitments] [float] NULL,
    [ULO] [float] NULL,
    [Expenditures] [float] NULL,
    [Obligations] [float] NULL,
    [Used] [float] NULL,
    [Available] [float] NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfFunds] PRIMARY KEY CLUSTERED
(
[
    StatusOfFundsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfInflationReductionActFunds]    Script Date: 5/13/2023 1:46:44 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfInflationReductionActFunds]
(
    [
    StatusOfSupplementalFundingId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    80
) NULL,
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfInflationReductionActFunds] PRIMARY KEY CLUSTERED
(
[
    StatusOfSupplementalFundingId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfJobsActFunding]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfJobsActFunding]
(
    [
    StatusOfJobsActFundingId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    [LowerName] [nvarchar]
(
    80
) NULL,
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
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfJobsActFunding] PRIMARY KEY CLUSTERED
(
[
    StatusOfJobsActFundingId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[StatusOfSupplementalFunding]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[StatusOfSupplementalFunding]
(
    [
    StatusOfSupplementalFundingId ] [
    int ]
    NOT
    NULL, [
    StatusOfFundsId ] [
    int ]
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
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
    [ProgramProjectCode] [nvarchar]
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
    [RcCode] [nvarchar]
(
    80
) NULL,
    [RcName] [nvarchar]
(
    80
) NULL,
    [LowerName] [nvarchar]
(
    80
) NULL,
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_StatusOfSupplementalFunding] PRIMARY KEY CLUSTERED
(
[
    StatusOfSupplementalFundingId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SubAppropriations]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SubAppropriations]
(
    [
    SubAppropriationsId ] [
    int ]
    NOT
    NULL, [
    Code ] [
    nvarchar ]
(
    80
) NULL,
    [Name] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_SubAppropriations] PRIMARY KEY CLUSTERED
(
[
    SubAppropriationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SuperfundSites]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SuperfundSites]
(
    [
    SuperfundSitesId ] [
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
    [City] [nvarchar]
(
    80
) NULL,
    [State] [nvarchar]
(
    80
) NULL,
    [SSID] [nvarchar]
(
    80
) NULL,
    [SiteProjectName] [nvarchar]
(
    80
) NULL,
    [EpaSiteId] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_SuperfundSites] PRIMARY KEY CLUSTERED
(
[
    SuperfundSitesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SupplementalCarryoverEstimates]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SupplementalCarryoverEstimates]
(
    [
    SupplementalCarryoverEstimatesID ] [
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
    CONSTRAINT [PK_SupplementalCarryoverEstimates] PRIMARY KEY CLUSTERED
(
[
    SupplementalCarryoverEstimatesID ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[SupplementalReimburseableEstimates]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[SupplementalReimburseableEstimates]
(
    [
    ReimbursableEstimatesId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
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
    [Estimate] [float] NULL
    ) ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[TransferActivity]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
      ON
    GO
    SET QUOTED_IDENTIFIER
      ON
    GO
CREATE TABLE [dbo].[TransferActivity]
(
    [
    TransferActivityId ] [
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
    [RpioCode] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [FromTo] [nvarchar]
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
    [ProcessedDate] [datetime] NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [Net] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_TransferActivity] PRIMARY KEY CLUSTERED
(
[
    TransferActivityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Transfers]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[Transfers]
(
    [
    TransfersId ] [
    int ]
    NOT
    NULL, [
    BudgetLevel ] [
    nvarchar ]
(
    80
) NULL,
    [DocPrefix] [nvarchar]
(
    80
) NULL,
    [DocType] [nvarchar]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
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
    [ReprogrammingNumber] [nvarchar]
(
    80
) NULL,
    [ControlNumber] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [Quarter] [nvarchar]
(
    80
) NULL,
    [Line] [nvarchar]
(
    80
) NULL,
    [Subline] [nvarchar]
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
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
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
    [AccountCode] [nvarchar]
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
    [ProgramProjectName] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [FromTo] [nvarchar]
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
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    [Purpose] [nvarchar]
(
    max
) NULL,
    [ResourceType] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_Transfers] PRIMARY KEY CLUSTERED
(
[
    TransfersId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[TransTypes]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
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
/****** Object:  Table [dbo].[TreasurySymbols]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[TreasurySymbols]
(
    [
    TreasurySymbolsId ] [
    int ]
    NOT
    NULL, [
    ShortKey ] [
    nvarchar ]
(
    80
) NULL,
    [AllocationTransferAgency] [nvarchar]
(
    80
) NULL,
    [AgencyIdentifier] [nvarchar]
(
    80
) NULL,
    [BeginningPeriodOfAvailability] [nvarchar]
(
    80
) NULL,
    [EndingPeriodOfAvailability] [nvarchar]
(
    80
) NULL,
    [AvailabilityType] [nvarchar]
(
    80
) NULL,
    [MainAccount] [nvarchar]
(
    80
) NULL,
    [SubAccount] [nvarchar]
(
    80
) NULL,
    [Lapsed] [nvarchar]
(
    80
) NULL,
    [UseCancelledYearSpendingAccounts] [nvarchar]
(
    80
) NULL,
    [AgencyTreasurySymbol] [nvarchar]
(
    80
) NULL,
    [InUse] [nvarchar]
(
    80
) NULL,
    [PreventNewUse] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_TreasurySymbols] PRIMARY KEY CLUSTERED
(
[
    TreasurySymbolsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[UnliquidatedObligations]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[UnliquidatedObligations]
(
    [
    UnliquidatedObligationsId ] [
    int ]
    NOT
    NULL, [
    ObligationsId ] [
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
    [FundCode] [nvarchar]
(
    80
) NULL,
    [FundName] [nvarchar]
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
    [AhCode] [nvarchar]
(
    80
) NULL,
    [AhName] [nvarchar]
(
    80
) NULL,
    [OrgCode] [nvarchar]
(
    80
) NULL,
    [OrgName] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    80
) NULL,
    [ProgramProjectName] [nvarchar]
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
    [DocumentType] [nvarchar]
(
    80
) NULL,
    [DocumentNumber] [nvarchar]
(
    80
) NULL,
    [DocumentControlNumber] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [ProcessedDate] [datetime] NULL,
    [LastActivityDate] [datetime] NULL,
    [Age] [float] NULL,
    [BocCode] [nvarchar]
(
    80
) NULL,
    [BocName] [nvarchar]
(
    80
) NULL,
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [NpmCode] [nvarchar]
(
    80
) NULL,
    [NpmName] [nvarchar]
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
    CONSTRAINT [PK_UnliquidatedObligations] PRIMARY KEY CLUSTERED
(
[
    UnliquidatedObligationsId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[UnobligatedAuthority]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[UnobligatedAuthority]
(
    [
    UnobligatedAuthorityId ] [
    int ]
    NOT
    NULL, [
    ReportYear ] [
    nvarchar ]
(
    80
) NULL,
    [BudgetAgencyCode] [nvarchar]
(
    80
) NULL,
    [BudgetBureauCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountTitle] [nvarchar]
(
    80
) NULL,
    [LineName] [nvarchar]
(
    80
) NULL,
    [LineNumber] [nvarchar]
(
    80
) NULL,
    [BudgetYear] [float] NULL,
    [PriorYear] [float] NULL,
    [CurrentYear] [float] NULL,
    [AgencyName] [nvarchar]
(
    80
) NULL,
    [BureauName] [nvarchar]
(
    80
) NULL,
    CONSTRAINT [PK_UnobligatedAuthority] PRIMARY KEY CLUSTERED
(
[
    UnobligatedAuthorityId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[UnobligatedBalances]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[UnobligatedBalances]
(
    [
    UnobligatedBalancesId ] [
    int ]
    NOT
    NULL, [
    BudgetYear ] [
    nvarchar ]
(
    80
) NULL,
    [BFY] [nvarchar]
(
    80
) NULL,
    [EFY] [nvarchar]
(
    80
) NULL,
    [BudgetAccount] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountCode] [nvarchar]
(
    80
) NULL,
    [TreasuryAccountName] [nvarchar]
(
    80
) NULL,
    [BudgetAccountCode] [nvarchar]
(
    80
) NULL,
    [BudgetAccountName] [nvarchar]
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
    [AccountNumber] [nvarchar]
(
    80
) NULL,
    [AccountName] [nvarchar]
(
    80
) NULL,
    [Amount] [float] NULL,
    CONSTRAINT [PK_UnobligatedBalances] PRIMARY KEY CLUSTERED
(
[
    UnobligatedBalancesId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[URL]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[URL]
(
    [
    SourceId ] [
    int ]
    NOT
    NULL, [
    Name ] [
    nvarchar ]
(
    80
) NULL,
    [Location] [nvarchar]
(
    80
) NULL,
    [Address] [nvarchar]
(
    255
) NULL,
    CONSTRAINT [PK_URL] PRIMARY KEY CLUSTERED
(
[
    SourceId ] ASC
)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
    ON [PRIMARY]
    )
    ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[WorkCodes]    Script Date: 5/13/2023 1:46:45 PM ******/
    SET ANSI_NULLS
    ON
    GO
    SET QUOTED_IDENTIFIER
    ON
    GO
CREATE TABLE [dbo].[WorkCodes]
(
    [
    WorkCodesId ] [
    int ]
    NULL, [
    SecurityOrg ] [
    nvarchar ]
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
    [WorkCodeShortName] [nvarchar]
(
    80
) NULL,
    [ChargeType] [nvarchar]
(
    80
) NULL,
    [PreventNewUse] [nvarchar]
(
    80
) NULL,
    [ReOrgCode] [nvarchar]
(
    80
) NULL,
    [Active] [nvarchar]
(
    80
) NULL,
    [Pay Year] [nvarchar]
(
    80
) NULL,
    [PayPeriod] [nvarchar]
(
    80
) NULL,
    [PayType] [nvarchar]
(
    80
) NULL,
    [FiscalYear] [nvarchar]
(
    80
) NULL,
    [ActivityCode] [nvarchar]
(
    80
) NULL,
    [Justification] [nvarchar]
(
    80
) NULL,
    [AllocationReason] [nvarchar]
(
    80
) NULL,
    [Status] [nvarchar]
(
    80
) NULL,
    [ApprovedBy] [nvarchar]
(
    80
) NULL,
    [ApprovalDate] [datetime] NULL,
    [ModifiedBy] [nvarchar]
(
    80
) NULL,
    [ModifiedDate] [datetime] NULL,
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
    [FocCode] [nvarchar]
(
    80
) NULL,
    [FocName] [nvarchar]
(
    80
) NULL,
    [BETC] [nvarchar]
(
    80
) NULL,
    [BetcName] [nvarchar]
(
    80
) NULL,
    [CostOrgCode] [nvarchar]
(
    80
) NULL,
    [CostOrgName] [nvarchar]
(
    80
) NULL,
    [Organization] [nvarchar]
(
    80
) NULL,
    [Organization Name] [nvarchar]
(
    80
) NULL,
    [AccountCode] [nvarchar]
(
    80
) NULL,
    [ProgramName] [nvarchar]
(
    80
) NULL,
    [ProjectCode] [nvarchar]
(
    80
) NULL,
    [ProjectName] [nvarchar]
(
    80
) NULL,
    [BudgetYear] [nvarchar]
(
    80
) NULL,
    [AllocationPercentage] [float] NULL
    ) ON [PRIMARY]
    GO

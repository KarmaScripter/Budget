CREATE TABLE IF NOT EXISTS BudgetControls
(
    BudgetControlsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    80
) NULL DEFAULT 'NS',
    Name TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetedTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    PostedTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    EstimatedReimbursementsTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    SpendingAdjustmentTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    EstimatedRecoveriesTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    ActualRecoveriesTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    StatusReserveTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    ProfitLossTransType TEXT
(
    80
) NULL DEFAULT 'NS',
    EstimatedReimbursementsSpendingOption TEXT
(
    80
) NULL DEFAULT 'NS',
    EstimatedReimursementsBudgetingOption TEXT
(
    80
) NULL DEFAULT 'NS',
    TrackAgreementLowerLevel TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetEstimatedLowerLevel TEXT
(
    80
) NULL DEFAULT 'NS',
    EstimatedRecoveriesSpendingOption TEXT
(
    80
) NULL DEFAULT 'NS',
    EstimatedRecoveriesBudgetingOption TEXT
(
    80
) NULL DEFAULT 'NS',
    RecoveryNextLevel TEXT
(
    80
) NULL DEFAULT 'NS',
    RecoveryBudgetMismatch TEXT
(
    80
) NULL DEFAULT 'NS',
    ProfitLossSpendingOption TEXT
(
    80
) NULL DEFAULT 'NS',
    ProfitLossBudgetOption TEXT
(
    80
) NULL DEFAULT 'NS',
    RecoveriesCarryInLowerLevel TEXT
(
    80
) NULL DEFAULT 'NS',
    RecoveriesCarryInLowerLevelControl TEXT
(
    80
) NULL DEFAULT 'NS',
    RecoveriesCarryInAmountControl TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetedControl TEXT
(
    80
) NULL DEFAULT 'NS',
    PostedControl TEXT
(
    80
) NULL DEFAULT 'NS',
    PreCommitmentSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    CommitmentSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    ObligationSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    AccrualSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    ExpenditureSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    ExpenseSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    ReimbursableSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    ReimbursableAgreementSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    FteBudgetingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    FteSpendingControl TEXT
(
    80
) NULL DEFAULT 'NS',
    TransactionTypeControl TEXT
(
    80
) NULL DEFAULT 'NS',
    AuthorityDistributionControl TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    BudgetControlsId AUTOINCREMENT
)
    );
CREATE TABLE IF NOT EXISTS AppropriationDocuments
(
    AppropriationDocumentsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    FiscalYear
    TEXT
(
    80
) NULL DEFAULT 'NS',
    BFY TEXT
(
    80
) NULL DEFAULT 'NS',
    EFY TEXT
(
    80
) NULL DEFAULT 'NS',
    AppropriationFund TEXT
(
    80
) NULL DEFAULT 'NS',
    FundCode TEXT
(
    80
) NULL DEFAULT 'NS',
    DocumentType TEXT
(
    80
) NULL DEFAULT 'NS',
    DocumentNumber TEXT
(
    80
) NULL DEFAULT 'NS',
    DocumentDate TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetLevel TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetingControls TEXT
(
    80
) NULL DEFAULT 'NS',
    PostingControls TEXT
(
    80
) NULL DEFAULT 'NS',
    PreCommitmentControls TEXT
(
    80
) NULL DEFAULT 'NS',
    CommitmentControls TEXT
(
    80
) NULL DEFAULT 'NS',
    ObligationControls TEXT
(
    80
) NULL DEFAULT 'NS',
    AccrualControls TEXT
(
    80
) NULL DEFAULT 'NS',
    ExpenditureControls TEXT
(
    80
) NULL DEFAULT 'NS',
    ExpenseControls TEXT
(
    80
) NULL DEFAULT 'NS',
    ReimbursementControls TEXT
(
    80
) NULL DEFAULT 'NS',
    ReimbursableAgreementControls TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    TreasuryAccountName TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetAccountCode TEXT
(
    80
) NULL DEFAULT 'NS',
    BudgetAccountName TEXT
(
    80
) NULL DEFAULT 'NS',
    Budgeted DOUBLE DEFAULT 0.0,
    Posted DOUBLE DEFAULT 0.0,
    CarryoverOut DOUBLE DEFAULT 0.0,
    CarryoverIn DOUBLE DEFAULT 0.0,
    Reimbursements DOUBLE DEFAULT 0.0,
    Recoveries DOUBLE DEFAULT 0.0,
    PRIMARY KEY
(
    AppropriationDocumentsId AUTOINCREMENT
)
    );
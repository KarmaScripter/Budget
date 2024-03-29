CREATE TABLE AppropriationDocuments 
(
	AppropriationDocumentsId	INT NOT NULL IDENTITY(1,1),
	FiscalYear	NVARCHAR(80) NULL,
	BFY	NVARCHAR(80) NULL,
	EFY	NVARCHAR(80) NULL,
	AppropriationFund	NVARCHAR(80) NULL,
	FundCode	NVARCHAR(80) NULL,
	DocumentType	NVARCHAR(80) NULL,
	DocumentNumber	NVARCHAR(80) NULL,
	DocumentDate	NVARCHAR(80) NULL,
	BudgetLevel	NVARCHAR(80) NULL,
	BudgetingControls	NVARCHAR(80) NULL,
	PostingControls	NVARCHAR(80) NULL,
	PreCommitmentControls	NVARCHAR(80) NULL,
	CommitmentControls	NVARCHAR(80) NULL,
	ObligationControls	NVARCHAR(80) NULL,
	AccrualControls	NVARCHAR(80) NULL,
	ExpenditureControls	NVARCHAR(80) NULL,
	ExpenseControls	NVARCHAR(80) NULL,
	ReimbursementControls	NVARCHAR(80) NULL,
	ReimbursableAgreementControls	NVARCHAR(80) NULL,
	TreasuryAccountCode	NVARCHAR(80) NULL,
	TreasuryAccountName NVARCHAR(MAX) NULL,
	BudgetAccountCode	NVARCHAR(80) NULL,
	BudgetAccountName NVARCHAR(MAX) NULL,
	Budgeted	FLOAT NULL,
	Posted	FLOAT NULL,
	CarryoverOut	FLOAT NULL,
	CarryoverIn	FLOAT NULL,
	Reimbursements	FLOAT NULL,
	Recoveries	FLOAT NULL
);
CREATE TABLE IF NOT EXISTS StatusOfAppropriations 
(
	StatusOfAppropriationsId	INTEGER NOT NULL UNIQUE,
	BFY	TEXT(80) NULL DEFAULT 'NS',
	EFY	TEXT(80) NULL DEFAULT 'NS',
	BudgetLevel	TEXT(80) NULL DEFAULT 'NS',
	FundCode	TEXT(80) NULL DEFAULT 'NS',
	FundName	TEXT(80) NULL DEFAULT 'NS',
	Availability	TEXT(80) NULL DEFAULT 'NS',
	TransType	TEXT(80) NULL DEFAULT 'NS',
	TreasurySymbol	TEXT(80) NULL DEFAULT 'NS',
	OriginalAmount	DECIMAL NULL DEFAULT 0.0,
	Authority	DECIMAL NULL DEFAULT 0.0,
	Budgeted	DECIMAL NULL DEFAULT 0.0,
	Posted	DECIMAL DEFAULT 0.0,
	CarryoverIn	DECIMAL NULL DEFAULT 0.0,
	CarryoverOut	DECIMAL NULL DEFAULT 0.0,
	TransferIn	DECIMAL NULL DEFAULT 0.0,
	TransferOut	DECIMAL NULL DEFAULT 0.0,
	OpenCommitments	DECIMAL NULL DEFAULT 0.0,
	Obligations DECIMAL NULL DEFAULT 0.0,
	Used DECIMAL NULL DEFAULT 0.0,
	Expenditures	DECIMAL NULL DEFAULT 0.0,
	UnliquidatedObligations DECIMAL NULL DEFAULT 0.0,
	Available	DECIMAL NULL DEFAULT 0.0,
	TreasuryAccountCode	TEXT(80) NULL DEFAULT 'NS',
	TreasuryAccountName	TEXT(80) NULL DEFAULT 'NS',
	BudgetAccountCode	TEXT(80) NULL DEFAULT 'NS',
	BudgetAccountName	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY(StatusOfAppropriationsId AUTOINCREMENT)
);
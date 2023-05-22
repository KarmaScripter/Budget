CREATE TABLE IF NOT EXISTS PayrollAuthority 
(
	PayrollAuthorityId	INTEGER NOT NULL UNIQUE,
	AllocationsId	INTEGER NOT NULL,
	StatusOfFundsId	INTEGER NOT NULL,
	BFY	TEXT(80) NULL DEFAULT NS,
	EFY	TEXT(80) NULL DEFAULT NS,
	RpioCode	TEXT(80) NULL DEFAULT NS,
	RpioName	TEXT(80) NULL DEFAULT NS,
	BudgetLevel	TEXT(80) NULL DEFAULT NS,
	AhCode	TEXT(80) NULL DEFAULT NS,
	AhName	TEXT(80) NULL DEFAULT NS,
	FundCode	TEXT(80) NULL DEFAULT NS,
	FundName	TEXT(80) NULL DEFAULT NS,
	OrgCode	TEXT(80) NULL DEFAULT NS,
	OrgName	TEXT(80) NULL DEFAULT NS,
	AccountCode	TEXT(80) NULL DEFAULT NS,
	RcCode	TEXT(80) NULL DEFAULT NS,
	RcName	TEXT(80) NULL DEFAULT NS,
	BocCode	TEXT(80) NULL DEFAULT NS,
	BocName	TEXT(80) NULL DEFAULT NS,
	Amount	NUMERIC DEFAULT 0.0,
	ProgramProjectCode	TEXT(80) NULL DEFAULT NS,
	ProgramProjectName	TEXT(80) NULL DEFAULT NS,
	ProgramAreaCode	TEXT(80) NULL DEFAULT NS,
	ProgramAreaName	TEXT(80) NULL DEFAULT NS,
	NpmCode	TEXT(80) NULL DEFAULT NS,
	NpmName	TEXT(80) NULL DEFAULT NS,
	TreasuryAccountCode	TEXT(80) NULL DEFAULT NS,
	TreasuryAccountName	TEXT(80) NULL DEFAULT NS,
	BudgetAccountCode	TEXT(80) NULL DEFAULT NS,
	BudgetAccountName	TEXT(80) NULL DEFAULT NS,
	PRIMARY KEY(PayrollAuthorityId AUTOINCREMENT)
);
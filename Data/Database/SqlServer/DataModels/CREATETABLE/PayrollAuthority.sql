CREATE TABLE PayrollAuthority 
(
	PayrollAuthorityId	INT NOT NULL IDENTITY(1,1),
	AllocationsId	INT NOT NULL,
	StatusOfFundsId	INT NOT NULL,
	BFY	NVARCHAR(80) NULL,
	EFY	NVARCHAR(80) NULL,
	RpioCode	NVARCHAR(80) NULL,
	RpioName	NVARCHAR(80) NULL,
	BudgetLevel	NVARCHAR(80) NULL,
	AhCode	NVARCHAR(80) NULL,
	AhName	NVARCHAR(80) NULL,
	FundCode	NVARCHAR(80) NULL,
	FundName	NVARCHAR(80) NULL,
	OrgCode	NVARCHAR(80) NULL,
	OrgName	NVARCHAR(80) NULL,
	AccountCode	NVARCHAR(80) NULL,
	RcCode	NVARCHAR(80) NULL,
	RcName	NVARCHAR(80) NULL,
	BocCode	NVARCHAR(80) NULL,
	BocName	NVARCHAR(80) NULL,
	Amount	FLOAT NULL,
	ProgramProjectCode	NVARCHAR(80) NULL,
	ProgramProjectName	NVARCHAR(80) NULL,
	ProgramAreaCode	NVARCHAR(80) NULL,
	ProgramAreaName	NVARCHAR(80) NULL,
	NpmCode	NVARCHAR(80) NULL,
	NpmName	NVARCHAR(80) NULL,
	TreasuryAccountCode	NVARCHAR(80) NULL,
	TreasuryAccountName NVARCHAR(MAX) NULL,
	BudgetAccountCode	NVARCHAR(80) NULL,
	BudgetAccountName NVARCHAR(MAX) NULL
);
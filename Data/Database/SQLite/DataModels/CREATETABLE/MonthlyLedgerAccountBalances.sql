CREATE TABLE IF NOT EXISTS "MonthlyLedgerAccountBalances" 
(
	"MonthlyLedgerAccountBalancesId"	INTEGER NOT NULL UNIQUE,
	"FiscalYear"	TEXT(80) DEFAULT 'NS',
	"BFY"	TEXT(80) DEFAULT 'NS',
	"EFY"	TEXT(80) DEFAULT 'NS',
	"FundCode"	TEXT(80) DEFAULT 'NS',
	"FundName"	TEXT(80) DEFAULT 'NS',
	"LedgerAccount"	TEXT(80) DEFAULT 'NS',
	"LedgerName"	TEXT(80) DEFAULT 'NS',
	"FiscalMonth"	TEXT(80) DEFAULT 'NS',
	"CreditBalance"	DOUBLE DEFAULT 0.0,
	"DebitBalance"	DOUBLE DEFAULT 0.0,
	"YearToDateAmount"	DOUBLE DEFAULT 0.0,
	"TreasuryAccountCode"	TEXT(80) DEFAULT 'NS',
	"TreasuryAccountName"	TEXT(80) DEFAULT 'NS',
	"BudgetAccountCode"	TEXT(80) DEFAULT 'NS',
	"BudgetAccountName"	TEXT(80) DEFAULT 'NS',
	"ApportionmentAccountCode"	TEXT(80) DEFAULT 'NS',
	PRIMARY KEY("MonthlyLedgerAccountBalancesId" AUTOINCREMENT)
);
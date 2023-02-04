CREATE TABLE IF NOT EXISTS 'HeadquartersAuthority' 
(
	'HeadquartersAuthorityId'	INTEGER NOT NULL,
	'AllocationsId'	INTEGER,
	'StatusOfFundsId'	INTEGER,
	'BudgetLevel'	TEXT,
	'BFY'	TEXT,
	'EFY'	TEXT,
	'RpioCode'	TEXT,
	'RpioName'	TEXT,
	'AhCode'	TEXT,
	'AhName'	TEXT,
	'FundCode'	TEXT,
	'FundName'	TEXT,
	'OrgCode'	TEXT,
	'OrgName'	TEXT,
	'AccountCode'	TEXT,
	'ProgramProjectCode'	TEXT,
	'ProgramProjectName'	TEXT,
	'ProgramAreaCode'	TEXT,
	'ProgramAreaName'	TEXT,
	'RcCode'	TEXT,
	'RcName'	TEXT,
	'BocCode'	TEXT,
	'BocName'	TEXT,
	'Amount'	REAL,
	'NpmCode'	TEXT,
	'NpmName'	TEXT,
	PRIMARY KEY('HeadquartersAuthorityId')
);
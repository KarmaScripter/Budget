CREATE TABLE IF NOT EXISTS "SiteActivity" 
(
	"SiteActivityId"	INTEGER NOT NULL UNIQUE,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"RpioName"	TEXT(80) NULL DEFAULT 'NS',
	"AhCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"FundName"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"ProgramProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"BocCode"	TEXT(80) NULL DEFAULT 'NS',
	"BocName"	TEXT(80) NULL DEFAULT 'NS',
	"OrgCode"	TEXT(80) NULL DEFAULT 'NS',
	"OrgName"	TEXT(80) NULL DEFAULT 'NS',
	"FocCode"	TEXT(80) NULL DEFAULT 'NS',
	"FocName"	TEXT(80) NULL DEFAULT 'NS',
	"EpaSiteId"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectCode"	TEXT(80) NULL DEFAULT 'NS',
	"SSID"	TEXT(80) NULL DEFAULT 'NS',
	"ActionCode"	TEXT(80) NULL DEFAULT 'NS',
	"OperableUnit"	TEXT(80) NULL DEFAULT 'NS',
	"SiteProjectName"	TEXT(80) NULL DEFAULT 'NS',
	"State"	TEXT(80) NULL DEFAULT 'NS',
	"City"	TEXT(80) NULL DEFAULT 'NS',
	"CongressionalDistrict"	TEXT(80) NULL DEFAULT 'NS',
	"ProjectType"	TEXT(80) NULL DEFAULT 'NS',
	"StartDate"	TEXT(80) NULL DEFAULT 'NS',
	"LastActivity"	TEXT(80) NULL DEFAULT 'NS',
	"EndDate"	TEXT(80) NULL DEFAULT 'NS',
	"Requested"	DOUBLE NULL DEFAULT 0.0,
	"Accepted"	DOUBLE NULL DEFAULT 0.0,
	"Closed"	DOUBLE NULL DEFAULT 0.0,
	"Outstanding"	DOUBLE NULL DEFAULT 0.0,
	"Refunded"	DOUBLE NULL DEFAULT 0.0,
	"Reversal"	DOUBLE NULL DEFAULT 0.0,
	PRIMARY KEY("SiteActivityId" AUTOINCREMENT)
);
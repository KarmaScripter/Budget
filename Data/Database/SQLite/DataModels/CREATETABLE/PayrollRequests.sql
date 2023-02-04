CREATE TABLE IF NOT EXISTS "PayrollRequests" 
(
	"PayrollRequestsId"	INTEGER NOT NULL UNIQUE,
	"ControlTeamAnalyst"	TEXT(80) NULL DEFAULT 'NS',
	"RpioCode"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentTitle"	TEXT(80) NULL DEFAULT 'NS',
	"Amount"	NUMERIC DEFAULT 0.0,
	"FundCode"	TEXT(80) NULL DEFAULT 'NS',
	"Status"	TEXT(80) NULL DEFAULT 'NS',
	"OriginalRequestDate"	TEXT(80) NULL DEFAULT 'NS',
	"LastActivityDate"	TEXT(80) NULL DEFAULT 'NS',
	"BFS"	TEXT(80) NULL DEFAULT 'NS',
	"Comments"	TEXT(80) NULL DEFAULT 'NS',
	"RequestDocument"	TEXT(80) NULL DEFAULT 'NS',
	"Duration"	INTEGER DEFAULT 0,
	PRIMARY KEY("PayrollRequestsId" AUTOINCREMENT)
);
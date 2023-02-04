CREATE TABLE IF NOT EXISTS "CarryoverOutlays" 
(
	"CarryoverOutlaysId"	INTEGER NOT NULL UNIQUE,
	"ReportYear"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyName"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountName"	TEXT(80) NULL DEFAULT 'NS',
	"LINE"	TEXT(80) NULL DEFAULT 'NS',
	"Carryover"	DOUBLE NULL DEFAULT 0.0,
	"CarryoverOutlays"	DOUBLE NULL DEFAULT 0.0,
	"Delta"	DOUBLE NULL DEFAULT 0.0,
	"AvailableBalance"	DOUBLE NULL DEFAULT 0.0,
	"ULO"	DOUBLE NULL DEFAULT 0.0,
	"CurrentYearAdjustment"	DOUBLE NULL DEFAULT 0.0,
	"BudgetYearAdjustment"	DOUBLE NULL DEFAULT 0.0,
	"CurrentYear"	DOUBLE NULL DEFAULT 0.0,
	"BudgetYear"	DOUBLE NULL DEFAULT 0.0,
	"OutYear1"	DOUBLE NULL DEFAULT 0.0,
	"OutYear2"	DOUBLE NULL DEFAULT 0.0,
	"OutYear3"	DOUBLE NULL DEFAULT 0.0,
	"OutYear4"	DOUBLE NULL DEFAULT 0.0,
	"OutYear5"	DOUBLE NULL DEFAULT 0.0,
	"OutYear6"	DOUBLE NULL DEFAULT 0.0,
	"OutYear7"	DOUBLE NULL DEFAULT 0.0,
	"OutYear8"	DOUBLE NULL DEFAULT 0.0,
	"OutYear9"	DOUBLE NULL DEFAULT 0.0,
	PRIMARY KEY("CarryoverOutlaysId" AUTOINCREMENT)
);
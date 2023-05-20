CREATE TABLE IF NOT EXISTS CarryoverOutlays 
(
	CarryoverOutlaysId	INTEGER NOT NULL UNIQUE,
	ReportYear	TEXT(80) NULL DEFAULT NS,
	AgencyName	TEXT(80) NULL DEFAULT NS,
	OmbAccountName	TEXT(80) NULL DEFAULT NS,
	LINE	TEXT(80) NULL DEFAULT NS,
	Carryover	DECIMAL NULL DEFAULT 0.0,
	CarryoverOutlays	DECIMAL NULL DEFAULT 0.0,
	Delta	DECIMAL NULL DEFAULT 0.0,
	AvailableBalance	DECIMAL NULL DEFAULT 0.0,
	ULO	DECIMAL NULL DEFAULT 0.0,
	CurrentYearAdjustment	DECIMAL NULL DEFAULT 0.0,
	BudgetYearAdjustment	DECIMAL NULL DEFAULT 0.0,
	CurrentYear	DECIMAL NULL DEFAULT 0.0,
	BudgetYear	DECIMAL NULL DEFAULT 0.0,
	OutYear1	DECIMAL NULL DEFAULT 0.0,
	OutYear2	DECIMAL NULL DEFAULT 0.0,
	OutYear3	DECIMAL NULL DEFAULT 0.0,
	OutYear4	DECIMAL NULL DEFAULT 0.0,
	OutYear5	DECIMAL NULL DEFAULT 0.0,
	OutYear6	DECIMAL NULL DEFAULT 0.0,
	OutYear7	DECIMAL NULL DEFAULT 0.0,
	OutYear8	DECIMAL NULL DEFAULT 0.0,
	OutYear9	DECIMAL NULL DEFAULT 0.0,
	PRIMARY KEY(CarryoverOutlaysId AUTOINCREMENT)
);
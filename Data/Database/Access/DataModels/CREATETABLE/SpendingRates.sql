CREATE TABLE SpendingRates 
(
	SpendingRatesId	INTEGER NOT NULL UNIQUE,
	Account TEXT(80) DEFAULT NS,
	Subfunction TEXT(80) DEFAULT NS,
	LineNumber TEXT(80) DEFAULT NS,
	SerialNumber TEXT(80) DEFAULT NS,
	Category TEXT(80) DEFAULT NS,
	Subcategory TEXT(80) DEFAULT NS,
	Jurisdiction TEXT(80) DEFAULT NS,
	YearOfAuthority TEXT(80) DEFAULT NS,
	BudgetAuthority DOUBLE DEFAULT 0.0,
	OutYear1 DOUBLE DEFAULT 0.0,
	OutYear2 DOUBLE DEFAULT 0.0,
	OutYear3 DOUBLE DEFAULT 0.0,
	OutYear4 DOUBLE DEFAULT 0.0,
	OutYear5 DOUBLE DEFAULT 0.0,
	OutYear6 DOUBLE DEFAULT 0.0,
	OutYear7 DOUBLE DEFAULT 0.0,
	OutYear8 DOUBLE DEFAULT 0.0,
	OutYear9 DOUBLE DEFAULT 0.0,
	OutYear10 DOUBLE DEFAULT 0.0,
	OutYear11 DOUBLE DEFAULT 0.0,
	TotalSpendout DOUBLE DEFAULT 0.0,
	AgencyName TEXT(80) DEFAULT NS,
	BureauName TEXT(80) DEFAULT NS,
	AccountName TEXT(80) DEFAULT NS,
	AgencyCode TEXT(80) DEFAULT NS,
	BureauCode TEXT(80) DEFAULT NS,
	AccountCode TEXT(80) DEFAULT NS,
	AGESEQ TEXT(80) DEFAULT NS,
	SubcategoryName TEXT(80) DEFAULT NS,
	Line TEXT(80) DEFAULT NS,
	Agency TEXT(80) DEFAULT NS,
	AgencyAccount TEXT(80) DEFAULT NS,
	PRIMARY KEY(SpendingRatesId)
);
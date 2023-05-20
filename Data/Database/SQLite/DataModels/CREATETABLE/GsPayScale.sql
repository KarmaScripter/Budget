CREATE TABLE IF NOT EXISTS GsPayScale (
	GsPayScaleId	INTEGER NOT NULL UNIQUE,
	LOCNAME	TEXT(80) NULL DEFAULT NS,
	GRADE	TEXT(80) NULL DEFAULT NS,
	ANNUAL1	REAL,
	HOURLY1	REAL,
	OVERTIME1	REAL,
	ANNUAL2	REAL,
	HOURLY2	REAL,
	OVERTIME2	REAL,
	ANNUAL3	REAL,
	HOURLY3	REAL,
	OVERTIME3	REAL,
	ANNUAL4	REAL,
	HOURLY4	REAL,
	OVERTIME4	REAL,
	ANNUAL5	REAL,
	HOURLY5	REAL,
	OVERTIME5	REAL,
	ANNUAL6	REAL,
	HOURLY6	REAL,
	OVERTIME6	REAL,
	ANNUAL7	REAL,
	HOURLY7	REAL,
	OVERTIME7	REAL,
	ANNUAL8	REAL,
	HOURLY8	REAL,
	OVERTIME8	REAL,
	ANNUAL9	REAL,
	HOURLY9	REAL,
	OVERTIME9	REAL,
	ANNUAL10	REAL,
	HOURLY10	REAL,
	OVERTIME10	REAL,
	PRIMARY KEY(GsPayScaleId AUTOINCREMENT)
);
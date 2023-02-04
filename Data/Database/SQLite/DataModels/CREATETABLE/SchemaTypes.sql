CREATE TABLE IF NOT EXISTS "SchemaTypes" 
(
	"SchemaTypesId"	INTEGER NOT NULL UNIQUE,
	"TypeName"	TEXT(80) NULL DEFAULT 'NS',
	"Database"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("SchemaTypesId" AUTOINCREMENT)
);
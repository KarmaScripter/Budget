CREATE TABLE IF NOT EXISTS Messages
(
	MessagesId INTEGER NOT NULL,
	Content TEXT(255) NULL DEFAULT NS,
	Type TEXT(80) NULL DEFAULT NS,
	Form TEXT(80) NULL DEFAULT NS,
    CONSTRAINT MessagesPrimaryKey 
        PRIMARY KEY(MessagesId AUTOINCREMENT)
);

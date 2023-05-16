CREATE TABLE IF NOT EXISTS AccountingEvents
(
    AccountingEventsId
    INTEGER
    NOT
    NULL,
    Code
    TEXT
(
    80
) NULL DEFAULT 'NS',
    Name TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    AccountingEventsId AUTOINCREMENT
)
    );
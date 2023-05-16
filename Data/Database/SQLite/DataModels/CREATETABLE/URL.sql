CREATE TABLE IF NOT EXISTS URL
(
    UrlsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Name
    TEXT
(
    80
) NULL DEFAULT 'NS',
    Location TEXT
(
    80
) NULL DEFAULT 'NS',
    Address TEXT
(
    255
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    SourceId AUTOINCREMENT
)
    );
CREATE TABLE IF NOT EXISTS FundCategories
(
    FundCategoriesId
    INTEGER
    NOT
    NULL
    UNIQUE,
    Code
    TEXT
(
    80
) NULL DEFAULT NS,
    Name TEXT
(
    80
) NULL DEFAULT NS,
    ShortName TEXT
(
    80
) NULL DEFAULT NS,
    PRIMARY KEY
(
    FundCategoriesId AUTOINCREMENT
)
    );
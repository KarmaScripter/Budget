CREATE TABLE IF NOT EXISTS PublicLaws
(
    PublicLawsId
    INTEGER
    NOT
    NULL
    UNIQUE,
    LawNumber
    TEXT
(
    80
),
    BillTitle TEXT
(
    80
),
    EnactedDate TEXT
(
    80
),
    Congress TEXT
(
    80
),
    BFY TEXT
(
    80
),
    PRIMARY KEY
(
    PublicLawsId AUTOINCREMENT
)
    );
CREATE TABLE IF NOT EXISTS AppropriationBills
(
    AppropriationBillsId
    INTEGER,
    BFY
    TEXT
(
    80
) NULL DEFAULT 'NS',
    Title TEXT
(
    80
) NULL DEFAULT 'NS',
    PublicLaw TEXT
(
    80
) NULL DEFAULT 'NS',
    EnactedDate TEXT
(
    80
) NULL DEFAULT 'NS'
    );

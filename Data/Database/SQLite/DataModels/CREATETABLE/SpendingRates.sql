CREATE TABLE IF NOT EXISTS 'SpendingRates'
(
    'SpendingRatesId'
    INTEGER
    NOT
    NULL
    UNIQUE,
    'Account'
    TEXT
(
    80
) NULL DEFAULT 'NS',
    'Subfunction' TEXT
(
    80
) NULL DEFAULT 'NS',
    'LineNumber' TEXT
(
    80
) NULL DEFAULT 'NS',
    'SerialNumber' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Category' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Subcategory' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Jurisdiction' TEXT
(
    80
) NULL DEFAULT 'NS',
    'YearOfAuthority' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BudgetAuthority' NUMERIC DEFAULT 0.0,
    'OutYear1' NUMERIC DEFAULT 0.0,
    'OutYear2' NUMERIC DEFAULT 0.0,
    'OutYear3' NUMERIC DEFAULT 0.0,
    'OutYear4' NUMERIC DEFAULT 0.0,
    'OutYear5' NUMERIC DEFAULT 0.0,
    'OutYear6' NUMERIC DEFAULT 0.0,
    'OutYear7' NUMERIC DEFAULT 0.0,
    'OutYear8' NUMERIC DEFAULT 0.0,
    'OutYear9' NUMERIC DEFAULT 0.0,
    'OutYear10' NUMERIC DEFAULT 0.0,
    'OutYear11' NUMERIC DEFAULT 0.0,
    'TotalSpendout' NUMERIC DEFAULT 0.0,
    'AgencyName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BureauName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AccountName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AgencyCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BureauCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AccountCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AGESEQ' TEXT
(
    80
) NULL DEFAULT 'NS',
    'SubcategoryName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Line' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Agency' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AgencyAccount' TEXT
(
    80
) NULL DEFAULT 'NS',
    PRIMARY KEY
(
    'SpendingRatesId' AUTOINCREMENT
)
    );
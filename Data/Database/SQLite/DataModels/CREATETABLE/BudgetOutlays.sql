CREATE TABLE IF NOT EXISTS 'BudgetOutlays'
(
    'BudgetOutlaysId'
    INTEGER
    NOT
    NULL
    UNIQUE,
    'ReportYear'
    TEXT
(
    80
) NULL DEFAULT 'NS',
    'Category' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AgencyName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'LineNumber' TEXT
(
    80
) NULL DEFAULT 'NS',
    'LineSection' TEXT
(
    80
) NULL DEFAULT 'NS',
    'OmbAccount' TEXT
(
    80
) NULL DEFAULT 'NS',
    'LineTitle' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AccountType' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AuthorityTypeName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Line' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AuthorityType' TEXT
(
    80
) NULL DEFAULT 'NS',
    'PriorYear' NUMERIC DEFAULT 0.0,
    'CurrentYear' NUMERIC DEFAULT 0.0,
    'BudgetYear' NUMERIC DEFAULT 0.0,
    'BudgetYear1' NUMERIC DEFAULT 0.0,
    'BudgetYear2' NUMERIC DEFAULT 0.0,
    'BudgetYear3' NUMERIC DEFAULT 0.0,
    'BudgetYear4' NUMERIC DEFAULT 0.0,
    'BudgetYear5' NUMERIC DEFAULT 0.0,
    'BudgetYear6' NUMERIC DEFAULT 0.0,
    'BudgetYear7' NUMERIC DEFAULT 0.0,
    'BudgetYear8' NUMERIC DEFAULT 0.0,
    'BudgetYear9' NUMERIC DEFAULT 0.0,
    PRIMARY KEY
(
    'BudgetOutlaysId' AUTOINCREMENT
)
    );
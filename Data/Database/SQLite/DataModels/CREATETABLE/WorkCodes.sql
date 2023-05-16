CREATE TABLE 'WorkCodes'
(
    'WorkCodesId'
    INTEGER
    NOT
    NULL
    UNIQUE
    'SecurityOrg'
    INTEGER
    NOT
    NULL
    UNIQUE,
    'WorkCode'
    TEXT
(
    80
) NULL DEFAULT 'NS',
    'WorkCodeName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'WorkCodeShortName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ChargeType' TEXT
(
    80
) NULL DEFAULT 'NS',
    'PreventNewUse' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ReOrgCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Active' TEXT
(
    80
) NULL DEFAULT 'NS',
    'PayYear' TEXT
(
    80
) NULL DEFAULT 'NS',
    'PayPeriod' TEXT
(
    80
) NULL DEFAULT 'NS',
    'PayType' TEXT
(
    80
) NULL DEFAULT 'NS',
    'FiscalYear' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ActivityCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Justification' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AllocationReason' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Status' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ApprovedBy' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ApprovalDate' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ModifiedBy' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ModifiedDate' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BFY' TEXT
(
    80
) NULL DEFAULT 'NS',
    'EFY' TEXT
(
    80
) NULL DEFAULT 'NS',
    'FundCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'FundName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'FocCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'FocName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BETC' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BetcName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'CostOrgCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'CostOrgName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'Organization' TEXT
(
    80
) NULL DEFAULT 'NS',
    'OrganizationName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AccountCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ProgramName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ProjectCode' TEXT
(
    80
) NULL DEFAULT 'NS',
    'ProjectName' TEXT
(
    80
) NULL DEFAULT 'NS',
    'BudgetYear' TEXT
(
    80
) NULL DEFAULT 'NS',
    'AllocationPercentage' DOUBLE NULL DEFAULT 0.0,
    PRIMARY KEY
(
    'WorkCodesId' AUTOINCREMENT
)
    );
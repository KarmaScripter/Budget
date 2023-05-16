CREATE TABLE IF NOT EXISTS TransferActivity
(
    TransferActivityId
    INTEGER
    NOT
    NULL
    UNIQUE,
    BFY
    TEXT
    NULL
    DEFAULT
    'NS',
    EFY
    TEXT
    NULL
    DEFAULT
    'NS',
    FundCode
    TEXT
    NULL
    DEFAULT
    'NS',
    FundName
    TEXT
    NULL
    DEFAULT
    'NS',
    RpioCode
    TEXT
    NULL
    DEFAULT
    'NS',
    RpioName
    TEXT
    NULL
    DEFAULT
    'NS',
    AhCode
    TEXT
    NULL
    DEFAULT
    'NS',
    AhName
    TEXT
    NULL
    DEFAULT
    'NS',
    OrgCode
    TEXT
    NULL
    DEFAULT
    'NS',
    OrgName
    TEXT
    NULL
    DEFAULT
    'NS',
    AccountCode
    TEXT
    NULL
    DEFAULT
    'NS',
    ProgramProjectName
    TEXT
    NULL
    DEFAULT
    'NS',
    FromTo
    TEXT
    NULL
    DEFAULT
    'NS',
    BocCode
    TEXT
    NULL
    DEFAULT
    'NS',
    BocName
    TEXT
    NULL
    DEFAULT
    'NS',
    ProcessedDate
    TEXT
    NULL
    DEFAULT
    'NS',
    DocumentNumber
    TEXT
    NULL
    DEFAULT
    'NS',
    Net
    TEXT
    NULL
    DEFAULT
    'NS',
    Amount
    NUMERIC
    NULL
    DEFAULT
    0.0,
    PRIMARY
    KEY
(
    TransferActivityId
    AUTOINCREMENT
)
    );
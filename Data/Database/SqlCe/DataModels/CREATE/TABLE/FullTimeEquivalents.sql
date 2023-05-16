CREATE TABLE FullTimeEquivalents
(
    FullTimeEquivalentsId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    AllocationsId         INTEGER NOT NULL UNIQUE,
    BudgetLevel           NVARCHAR(255) NULL,
    RPIO                  NVARCHAR(255) NULL,
    BFY                   NVARCHAR(255) NULL,
    FundCode              NVARCHAR(255) NULL,
    AhCode                NVARCHAR(255) NULL,
    OrgCode               NVARCHAR(255) NULL,
    RcCode                NVARCHAR(255) NULL,
    AccountCode           NVARCHAR(255) NULL,
    BocCode               NVARCHAR(255) NULL,
    Amount                FLOAT NULL,
    FundName              NVARCHAR(255) NULL,
    BocName               NVARCHAR(255) NULL,
    Division              NVARCHAR(255) NULL,
    DivisionName          NVARCHAR(255) NULL,
    ActivityCode          NVARCHAR(255) NULL,
    NpmCode               NVARCHAR(255) NULL,
    NpmName               NVARCHAR(255) NULL,
    ProgramProjectCode    NVARCHAR(255) NULL,
    ProgramProjectName    NVARCHAR(255) NULL,
    ProgramAreaCode       NVARCHAR(255) NULL,
    ProgramAreaName       NVARCHAR(255) NULL,
    GoalCode              NVARCHAR(255) NULL,
    GoalName              NVARCHAR(255) NULL,
    ObjectiveCode         NVARCHAR(255) NULL,
    ObjectiveName         NVARCHAR(255) NULL,
    AllocationRatio       FLOAT NULL,
    ChangeDate            DATETIME NULL,
    CONSTRAINT PK_FullTimeEquivalents
        PRIMARY KEY ( FullTimeEquivalentsId ),
    CONSTRAINT FK_FullTimeEquivalents
        FOREIGN KEY ( AllocationsId )
            REFERENCES Allocations
);

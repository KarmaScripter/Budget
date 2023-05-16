CREATE TABLE EmployeePayroll
(
    EmployeePayrollId INT NOT NULL IDENTITY (1,1),
    RcCode            NVARCHAR(255) NULL,
    DivisionName      NVARCHAR(255) NULL,
    EpaNumber         NVARCHAR(255) NULL,
    LastName          NVARCHAR(255) NULL,
    FirstName         NVARCHAR(255) NULL,
    ReportingCode     NVARCHAR(255) NULL,
    ReportingCodeName NVARCHAR(255) NULL,
    Hours             FLOAT NULL,
    Days              FLOAT NULL
);

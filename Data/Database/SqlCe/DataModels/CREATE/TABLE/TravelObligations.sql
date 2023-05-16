CREATE TABLE [TravelObligations]
(
    [
    TravelObligationId ] [
    int ]
    NOT
    NULL, [
    RpioCode ] [
    nvarchar ]
(
    255
) NULL,
    [BFY] [nvarchar]
(
    255
) NULL,
    [AhCode] [nvarchar]
(
    255
) NULL,
    [AhName] [nvarchar]
(
    255
) NULL,
    [FundCode] [nvarchar]
(
    255
) NULL,
    [FundName] [nvarchar]
(
    255
) NULL,
    [AccountCode] [nvarchar]
(
    255
) NULL,
    [ProgramProjectCode] [nvarchar]
(
    255
) NULL,
    [ProgramProjectName] [nvarchar]
(
    255
) NULL,
    [OrgCode] [nvarchar]
(
    255
) NULL,
    [OrgName] [nvarchar]
(
    255
) NULL,
    [BocCode] [nvarchar]
(
    255
) NULL,
    [BocName] [nvarchar]
(
    255
) NULL,
    [RcCode] [nvarchar]
(
    255
) NULL,
    [RcName] [nvarchar]
(
    255
) NULL,
    [FocCode] [nvarchar]
(
    255
) NULL,
    [FocName] [nvarchar]
(
    255
) NULL,
    [FirstName] [nvarchar]
(
    255
) NULL,
    [LastName] [nvarchar]
(
    255
) NULL,
    [DepartureDate] [datetime] NULL,
    [ReturnDate] [datetime] NULL,
    [DocumentType] [nvarchar]
(
    255
) NULL,
    [DCN] [nvarchar]
(
    255
) NULL,
    [Obligations] [float] NULL,
    [ULO] [float] NULL,
    [Expenditures] [float] NULL,
    [NpmCode] [nvarchar]
(
    255
) NULL
    );


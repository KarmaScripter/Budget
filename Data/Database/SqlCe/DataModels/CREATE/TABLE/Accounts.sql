CREATE TABLE [Accounts]
(
   [AccountsId] INT NOT NULL IDENTITY (64047,1),
   [Code] NVARCHAR(80),
   [alCode] NVARCHAR(80),
   [ObjectiveCode] NVARCHAR(80),
   [NpmCode] NVARCHAR(80),
   [NpmName] NVARCHAR(80),
   [ProgramProjectCode] NVARCHAR(80),
   [ProgramProjectName] NVARCHAR(80),
   [ProgramAreaCode] NVARCHAR(80),
   [ProgramAreaName] NVARCHAR(80),
   [ActivityCode] NVARCHAR(80),
   [ActivityName] NVARCHAR(80),
   [AgencyActivity] NVARCHAR(80)
);

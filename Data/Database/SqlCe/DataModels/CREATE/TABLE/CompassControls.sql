CREATE TABLE [CongressionalControls]
(
   [CongressionalControlsId] INT NOT NULL IDENTITY (187,1),
   [FundCode] NVARCHAR(80),
   [FundName] NVARCHAR(80),
   [ProgramAreaCode] NVARCHAR(80),
   [ProgramAreaName] NVARCHAR(80),
   [ProgramProjectCode] NVARCHAR(80),
   [ProgramProjectName] NVARCHAR(80),
   [SubProjectCode] NVARCHAR(80),
   [SubProjectName] NVARCHAR(80),
   [ReprogrammingRestriction] NVARCHAR(80),
   [IncreaseRestriction] NVARCHAR(80),
   [DecreaseRestriction] NVARCHAR(80),
   [MemoRequirement] NVARCHAR(80)
);

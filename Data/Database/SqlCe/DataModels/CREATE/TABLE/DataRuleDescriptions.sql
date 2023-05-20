CREATE TABLE [DataRuleDescriptions]
(
   [DataRuleDescriptionsId] INT NOT NULL IDENTITY (1177,1),
   [Schedule] NVARCHAR(80),
   [LineNumber] NVARCHAR(80),
   [RuleNumber] NVARCHAR(80),
   [RuleDescription] NTEXT,
   [ScheduleOrder] NVARCHAR(80)
);

CREATE TABLE [CarryoverRequests]
(
   [CarryoverRequestsId] INT NOT NULL IDENTITY (13,1),
   [ControlTeamAnalyst] NVARCHAR(80),
   [RpioCode] NVARCHAR(80),
   [DocumentTitle] NVARCHAR(80),
   [Amount] DECIMAL(18,0),
   [FundCode] NVARCHAR(80),
   [Status] NVARCHAR(80),
   [OriginalRequestDate] DATETIME,
   [LastActivityDate] DATETIME,
   [BFS] NVARCHAR(80),
   [Comments] NTEXT,
   [RequestDocument] NTEXT,
   [Duration] INT
);

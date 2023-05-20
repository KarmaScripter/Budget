CREATE TABLE [AdministrativeRequests]
(
   [AdministrativeRequestsId] INT NOT NULL IDENTITY (28,1),
   [RequestId] INT,
   [ControlTeamAnalyst] NVARCHAR(255),
   [RpioCode] NVARCHAR(255),
   [DocumentTitle] NVARCHAR(255),
   [Amount] DECIMAL(18,0),
   [FundCode] NVARCHAR(255),
   [BFY] NVARCHAR(255),
   [Status] NVARCHAR(255),
   [OriginalRequestDate] DATETIME,
   [LastActivityDate] DATETIME,
   [Duration] FLOAT,
   [BFS] NVARCHAR(255),
   [Comments] NTEXT,
   [RequestDocument] NTEXT,
   [RequestType] NVARCHAR(255),
   [TypeCode] NVARCHAR(255),
   [Decision] NVARCHAR(255)
);

CREATE TABLE [dbo].[FinanceObjectClasses]
(
	[FinanceObjectClassId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL
);

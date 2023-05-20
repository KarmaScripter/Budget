CREATE TABLE [DocumentControlNumbers]
(
   [DocumentControlNumbersId] INT NOT NULL IDENTITY (481758,1),
   [RpioCode] NVARCHAR(80),
   [RpioName] NVARCHAR(80),
   [DocumentType] NVARCHAR(80),
   [DocumentNumber] NVARCHAR(80),
   [DocumentPrefix] NVARCHAR(80),
   [DocumentControlNumber] NVARCHAR(80)
);

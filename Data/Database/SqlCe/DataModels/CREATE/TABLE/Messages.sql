CREATE TABLE Messages
(
    MessageId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Message   NVARCHAR(255) NULL,
    Type      NVARCHAR(255) NULL,
    Form      NVARCHAR(255) NULL
);


CREATE TABLE Funds
(
    FundsId        INTEGER NOT NULL UNIQUE IDENTITY(1,1),
    Code           NVARCHAR(255) NOT NULL,
    Name           NVARCHAR(255) NULL,
    TreasurySymbol NVARCHAR(255) NULL,
    Title          NVARCHAR(255) NULL
);


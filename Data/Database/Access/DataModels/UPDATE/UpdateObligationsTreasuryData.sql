UPDATE Obligations 
INNER JOIN Funds 
ON (Obligations.BFY = Funds.BFY) 
AND (Obligations.EFY = Funds.EFY) 
AND (Obligations.FundCode = Funds.FundCode) 
SET Obligations.TreasurySymbol = Funds.TreasuryAccountCode, 
Obligations.BudgetAccountCode = Funds.BudgetAccountCode, 
Obligations.BudgetAccountName = Funds.BudgetAccountName, 
Obligations.ApportionmentAccountCode = Funds.ApportionmentAccountCode;
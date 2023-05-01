UPDATE AppropriationAvailableBalances 
INNER JOIN Funds 
ON (AppropriationAvailableBalances.FundCode = Funds.Code) 
AND (AppropriationAvailableBalances.EFY = Funds.EFY) 
AND (AppropriationAvailableBalances.BFY = Funds.BFY) 
SET AppropriationAvailableBalances.FundName = Funds.Name, 
AppropriationAvailableBalances.BudgetAccountCode = Funds.BudgetAccountCode, A
ppropriationAvailableBalances.BudgetAccountName = Funds.BudgetAccountName, 
AppropriationAvailableBalances.TreasuryAccountCode = Funds.TreasuryAccountCode, 
AppropriationAvailableBalances.TreasuryAccountName = Funds.TreasuryAccountName;
UPDATE AppropriationLevelAuthority
    INNER JOIN Funds
ON (AppropriationLevelAuthority.BFY = Funds.BFY)
    AND (AppropriationLevelAuthority.EFY = Funds.EFY)
    AND (AppropriationLevelAuthority.FundCode = Funds.Code)
    SET AppropriationLevelAuthority.FundName = Funds.Name, AppropriationLevelAuthority.BudgetAccountCode = Funds.BudgetAccountCode, AppropriationLevelAuthority.BudgetAccountName = Funds.BudgetAccountName, AppropriationLevelAuthority.TreasuryAccountCode = Funds.TreasuryAccountCode, AppropriationLevelAuthority.TreasuryAccountName = Funds.TreasuryAccountName;
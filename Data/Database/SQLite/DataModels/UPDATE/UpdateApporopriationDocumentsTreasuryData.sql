UPDATE AppropriationDocuments
    INNER JOIN Funds
ON (AppropriationDocuments.FundCode = Funds.Code)
    AND (AppropriationDocuments.BFY = Funds.BFY)
    AND (AppropriationDocuments.EFY = Funds.EFY)
    SET AppropriationDocuments.TreasuryAccountCode = Funds.TreasuryAccountCode, AppropriationDocuments.TreasuryAccountName = Funds.TreasuryAccountName, AppropriationDocuments.BudgetAccountCode = Funds.BudgetAccountCode, AppropriationDocuments.BudgetAccountName = Funds.BudgetAccountName;
UPDATE AppropriationLevelAuthority 
INNER JOIN Funds 
ON (AppropriationLevelAuthority.FundCode = Funds.Code) 
AND (AppropriationLevelAuthority.BFY = Funds.BFY) 
AND (AppropriationLevelAuthority.EFY = Funds.EFY) 
SET AppropriationLevelAuthority.FundName = Funds.Name;
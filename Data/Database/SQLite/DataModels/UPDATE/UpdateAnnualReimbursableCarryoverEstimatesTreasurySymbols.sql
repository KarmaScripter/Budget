UPDATE AnnualReimbursableCarryoverEstimates 
INNER JOIN Funds 
ON (AnnualReimbursableCarryoverEstimates.FundCode = Funds.Code) 
AND (AnnualReimbursableCarryoverEstimates.EFY = Funds.EFY) 
AND (AnnualReimbursableCarryoverEstimates.BFY = Funds.BFY) 
SET AnnualReimbursableCarryoverEstimates.TreasuryAccountCode = Funds.TreasuryAccountCode;

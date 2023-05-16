UPDATE AnnualCarryoverEstimates
    INNER JOIN Funds
ON (AnnualCarryoverEstimates.BFY = Funds.BFY)
    AND (AnnualCarryoverEstimates.EFY = Funds.EFY)
    AND (AnnualCarryoverEstimates.FundCode = Funds.Code)
    SET AnnualCarryoverEstimates.TreasuryAccountCode = Funds.TreasuryAccountCode;

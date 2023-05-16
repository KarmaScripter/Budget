UPDATE AmericanRescuePlanCarryoverEstimates
    INNER JOIN Funds
ON (AmericanRescuePlanCarryoverEstimates.BFY = Funds.BFY)
    AND (AmericanRescuePlanCarryoverEstimates.EFY = Funds.EFY)
    AND (AmericanRescuePlanCarryoverEstimates.FundCode = Funds.Code)
    SET AmericanRescuePlanCarryoverEstimates.TreasuryAccountCode = Funds.TreasuryAccountCode;
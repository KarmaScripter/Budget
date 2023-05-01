INSERT INTO RegionalAuthority
SELECT *
FROM StatusOfFunds
WHERE StatusOfFunds.RpioCode IN ("01", "02", "03", "04", "05", "06", "07", "08", "09", "10");

INSERT INTO HeadquartersAuthority
SELECT *
FROM StatusOfFunds
WHERE StatusOfFunds.RpioCode NOT IN ( "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" );

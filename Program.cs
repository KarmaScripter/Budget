namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [ STAThread ]
        public static void Main( )
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSn9Rd0BiUX1Xc3NWTg==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdURhWHpfeHZcRWhaWQ==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZiW35bcXxXT2NVWEw=;MTMwNjk5NEAzMjMwMmUzNDJlMzBLaXJLbGgrTXNVZEZhUUtZcXdFYnRjNjZqY0NhQVZOcDBuVUtXa1g0K1FzPQ==;MTMwNjk5NUAzMjMwMmUzNDJlMzBWdk5tcENaeVJiYWhUVnlSdGZ4K2dJZ2lvdnNSZGNyekRuY0t5WER3YnJBPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVgWH1fdXVdRGlYVEx+;MTMwNjk5N0AzMjMwMmUzNDJlMzBHSExMUE96LyszQStaQjFleHI0d3lRNWRnbWNMM2tEL2kveVdGQUFKNk5JPQ==;MTMwNjk5OEAzMjMwMmUzNDJlMzBsSWFNUGFNZ0RoNFBORWduZml6NTJYWUM1Wk10cFRpcXZIYXhHZWo2bVZVPQ==;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZiW35bcXxXT2VeU0w=;MTMwNzAwMEAzMjMwMmUzNDJlMzBKOEEzdUdpcmlWQ3V5WkN5NGV3aTV3STNUZEVEdEZESEsxVnlWOHAwc2RnPQ==;MTMwNzAwMUAzMjMwMmUzNDJlMzBKUkNDODVhL1VaRHlNWkdBLzJlcWJpSVpadm1ONDJuN0hCSTl2ZU9RQTRVPQ==;MTMwNzAwMkAzMjMwMmUzNDJlMzBHSExMUE96LyszQStaQjFleHI0d3lRNWRnbWNMM2tEL2kveVdGQUFKNk5JPQ==" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

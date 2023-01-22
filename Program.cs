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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxRd0ZhWH5edn1XQw==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0dhWHxccXVVQWFeVA==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhW35dcnVURmdYUEE=;OTg0NDIxQDMyMzAyZTM0MmUzMFlqMDNnUEV6N0E4bG5rT2NRdnlJMm8yS1JhU1pRTytCdlRzbnNyUm5YWDQ9;OTg0NDIyQDMyMzAyZTM0MmUzMGRJZ3l6U1poTHlMYTE1bzZDbzFFcXpPUWZLTDJxK05teTFRMDlnWFpYVWM9;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW31fc3ZUR2BUUkBz;OTg0NDI0QDMyMzAyZTM0MmUzMGs5R1hBVFNHbE1KOUpSNW1RMmlzOWsyaGFBRHR4SkNVdFMyN2lvTWI5SUE9;OTg0NDI1QDMyMzAyZTM0MmUzMGV0MDBPVzBmaEo2ZTViOFlYZmxWUmN5djRBR2ZQbCtiZENmVDFEblVyQVU9;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhW35dcnVURmleUUE=;OTg0NDI3QDMyMzAyZTM0MmUzMEtpeHp2SzN1NmNpdkdUakVxOXAxWXcvOXFzMEtvN3RBS0NOWXV2dGRHWDQ9;OTg0NDI4QDMyMzAyZTM0MmUzMEdsSUdkeWkzSkdrWEpNdnE1b0pwcGVJa1dJUDMxQ2JNd3ZXRjRYTk5FT1k9;OTg0NDI5QDMyMzAyZTM0MmUzMGs5R1hBVFNHbE1KOUpSNW1RMmlzOWsyaGFBRHR4SkNVdFMyN2lvTWI5SUE9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

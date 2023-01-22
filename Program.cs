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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxRd01hXHxbdXVdQA==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0dhWHdcdXdQQ2NdVw==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhW35WcnFWQ2VYV0U=;OTg1MjY0QDMyMzAyZTM0MmUzMFlqMDNnUEV6N0E4bG5rT2NRdnlJMm8yS1JhU1pRTytCdlRzbnNyUm5YWDQ9;OTg1MjY1QDMyMzAyZTM0MmUzMGRJZ3l6U1poTHlMYTE1bzZDbzFFcXpPUWZLTDJxK05teTFRMDlnWFpYVWM9;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW31feHZQRWVaUEBw;OTg1MjY3QDMyMzAyZTM0MmUzMGs5R1hBVFNHbE1KOUpSNW1RMmlzOWsyaGFBRHR4SkNVdFMyN2lvTWI5SUE9;OTg1MjY4QDMyMzAyZTM0MmUzMGV0MDBPVzBmaEo2ZTViOFlYZmxWUmN5djRBR2ZQbCtiZENmVDFEblVyQVU9;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhW35WcnFWQ2ZbVkM=;OTg1MjcwQDMyMzAyZTM0MmUzMEtpeHp2SzN1NmNpdkdUakVxOXAxWXcvOXFzMEtvN3RBS0NOWXV2dGRHWDQ9;OTg1MjcxQDMyMzAyZTM0MmUzMEdsSUdkeWkzSkdrWEpNdnE1b0pwcGVJa1dJUDMxQ2JNd3ZXRjRYTk5FT1k9;OTg1MjcyQDMyMzAyZTM0MmUzMGs5R1hBVFNHbE1KOUpSNW1RMmlzOWsyaGFBRHR4SkNVdFMyN2lvTWI5SUE9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

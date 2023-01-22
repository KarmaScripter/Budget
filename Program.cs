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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhkWFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxRd0dhWnpfdnxXQg==;Mgo+DSMBPh8sVXJ0S0J+XE9AclRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0dhWH1cc3FUQGlZVQ==;ORg4AjUWIQA/Gnt2VVhkQlFacltJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhW35ccndQR2dcWUA=;OTgzOTc2QDMyMzAyZTM0MmUzMFlqMDNnUEV6N0E4bG5rT2NRdnlJMm8yS1JhU1pRTytCdlRzbnNyUm5YWDQ9;OTgzOTc3QDMyMzAyZTM0MmUzMGRJZ3l6U1poTHlMYTE1bzZDbzFFcXpPUWZLTDJxK05teTFRMDlnWFpYVWM9;NRAiBiAaIQQuGjN/V0Z+WE9EaFtGVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW31fcnZWQ2FbVkB2;OTgzOTc5QDMyMzAyZTM0MmUzMGs5R1hBVFNHbE1KOUpSNW1RMmlzOWsyaGFBRHR4SkNVdFMyN2lvTWI5SUE9;OTgzOTgwQDMyMzAyZTM0MmUzMGV0MDBPVzBmaEo2ZTViOFlYZmxWUmN5djRBR2ZQbCtiZENmVDFEblVyQVU9;Mgo+DSMBMAY9C3t2VVhkQlFacltJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhW35ccndQR2hYU0Q=;OTgzOTgyQDMyMzAyZTM0MmUzMEtpeHp2SzN1NmNpdkdUakVxOXAxWXcvOXFzMEtvN3RBS0NOWXV2dGRHWDQ9;OTgzOTgzQDMyMzAyZTM0MmUzMEdsSUdkeWkzSkdrWEpNdnE1b0pwcGVJa1dJUDMxQ2JNd3ZXRjRYTk5FT1k9;OTgzOTg0QDMyMzAyZTM0MmUzMGs5R1hBVFNHbE1KOUpSNW1RMmlzOWsyaGFBRHR4SkNVdFMyN2lvTWI5SUE9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

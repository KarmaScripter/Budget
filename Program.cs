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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxXdEVjWH1Wd3FVQA==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0dnW39ecXZdQWdaVg==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhXX1ecHVXTmheVkM=;OTk5NTE2QDMyMzAyZTM0MmUzMGMrSU41cVhhWi91b00zNXBtQUZZWEZNWHVmNHpHSXc5TGxnRFY1MFA4c0k9;OTk5NTE3QDMyMzAyZTM0MmUzMEVyUUthbGhIRGhFcHFUcEpFUnVlaXdWUjJ6aWNBdGRWY2hNcUllZUhCSU09;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW3tccHRURGhVUE1x;OTk5NTE5QDMyMzAyZTM0MmUzMFBZTzZvTGtReU1WaTFjTVBjWks4ZnFGLzJnQlFhakRPV3ZRalVVSG94RDg9;OTk5NTIwQDMyMzAyZTM0MmUzME5RNkt2aFJZQlh0UDFmY1MzZGNkYlNQY003a1J1SWhYd1dTYTZZNWx2ZUE9;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhXX1ecHVXTmlUWUA=;OTk5NTIyQDMyMzAyZTM0MmUzMGRMU0xjUDJpOUhla0hZaVlBMm9vOEpwTDlRN0M2SUZJdmwyVEdrRnNXZHM9;OTk5NTIzQDMyMzAyZTM0MmUzMGFqMVk3Q2FPcUFPWCtBOVpNNWE4NkVtMzZyL0E2OGpTbGlNQjlMUmIyUms9;OTk5NTI0QDMyMzAyZTM0MmUzMFBZTzZvTGtReU1WaTFjTVBjWks4ZnFGLzJnQlFhakRPV3ZRalVVSG94RDg9" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

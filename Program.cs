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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jS3xXdEVgXnxfd3dSTg==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdEdnW39dd3dUTmhfVw==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdhXX1ec3NWR2ldUkI=;MTIwMjQ2OEAzMjMwMmUzNDJlMzBLcEt0OGlPZlBzcU1PU3krcU00SGRtRk95Mjl0WldqVkxLWDVSR05BaU5zPQ==;MTIwMjQ2OUAzMjMwMmUzNDJlMzBYand1QTZJTU9XUHl2Vjg5U0p2QnVzVUdjMmE0bFYreTk0Uk1SY1laUzRZPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVhW3tccHdSRWJZVkdz;MTIwMjQ3MUAzMjMwMmUzNDJlMzBvRnVXRHppckVqakR5SVB6U1E0eW1DL1ZFZURWaXJ5Qk9XenBvY2dnUkNBPQ==;MTIwMjQ3MkAzMjMwMmUzNDJlMzBFUmFyaGlsRzFLRXJidnBTNGszT2plaDhkbEU4RmNmL2JUQTdGRTJNVWNBPQ==;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkdhXX1ec3NWRWBYUEE=;MTIwMjQ3NEAzMjMwMmUzNDJlMzBCRGNhMTRIM1kreno3dlg4Q05VQjFWV2RoZDVucitmQWlmQ0FKQzk0aTQwPQ==;MTIwMjQ3NUAzMjMwMmUzNDJlMzBmNzBuaGdCL281RWJRYjA1M2ZDdVhGNklhd2t2TWwxQmVRZkVYckFFRmZVPQ==;MTIwMjQ3NkAzMjMwMmUzNDJlMzBvRnVXRHppckVqakR5SVB6U1E0eW1DL1ZFZURWaXJ5Qk9XenBvY2dnUkNBPQ==" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

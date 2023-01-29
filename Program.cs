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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxad0VnX3pWc3ZRTg==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0dqWH9adnFdRWNUWQ==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhUH5edHJQTmNZUUw=;MTAyNDU2MkAzMjMwMmUzNDJlMzBubnhoQW4yNElxS3BZNjZWWUpLSTYwL3VvVDcwSEgxZC90YnhOa3BRTlVnPQ==;MTAyNDU2M0AzMjMwMmUzNDJlMzBKbUVoQWs1YUZXdGQ3WFBGWjZJUjFPU28rL2J2aWUrdlpvejdpTnZ4cGd3PQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW3ZfcHBTQ2hYUEJz;MTAyNDU2NUAzMjMwMmUzNDJlMzBUcUxVMHI2ZWYycHd3VCtFdTdubmUvREJLRW1uMk5JR2NkSnJxQmZ3c1RRPQ==;MTAyNDU2NkAzMjMwMmUzNDJlMzBMQWQ2M3E3N20wUFhnRnBYVjhWaytPV3NWMTRkUXZWSG1wWFpxck5wSWxZPQ==;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhUH5edHJQTmRUUEE=;MTAyNDU2OEAzMjMwMmUzNDJlMzBGTXVrRXg4Nzd0Nnh2R3MvSktoWGJCZlBqTTJseW1iaHhka0toR2hqTVRBPQ==;MTAyNDU2OUAzMjMwMmUzNDJlMzBLZGNkYzMvV0tmUjVLbnd2NUJLUkNJOUtlK011RWJSZkxpY3p5KzZSMGJZPQ==;MTAyNDU3MEAzMjMwMmUzNDJlMzBUcUxVMHI2ZWYycHd3VCtFdTdubmUvREJLRW1uMk5JR2NkSnJxQmZ3c1RRPQ==" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

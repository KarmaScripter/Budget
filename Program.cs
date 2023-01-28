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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense( "Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxbd0BnUX1ZdHJQQg==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0drWHpaeHZSQmdUVQ==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhUX5bdHxXQWRVUEA=;MTAyMjE0MEAzMjMwMmUzNDJlMzBObFRtQ2FHcmxhR1FCL1FBQk1Ta01pb2hMcUhOZlM5VVpZVW5JaUk3dWZRPQ==;MTAyMjE0MUAzMjMwMmUzNDJlMzBMWUUxbkdES0M1U29HRUtIZW5xQ2h1YTBrQlZhUnM3OHA5U1VzUWEweWVvPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW3dfdXBdRGdZV01/;MTAyMjE0M0AzMjMwMmUzNDJlMzBnZHlDeS9janNwdGU3NWlYN0s4NjdYdjB6WlpSQ0RhQjhsbzduRDc1MmZjPQ==;MTAyMjE0NEAzMjMwMmUzNDJlMzBXTFAzT2pKUWJkNjVoR1ArNUg5ZjZ5eEdWYkw1cXRGRFBsS05rK2c0WkpVPQ==;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhUX5bdHxXQWZYWEA=;MTAyMjE0NkAzMjMwMmUzNDJlMzBrZytnYTJHT3hZYjlNd3ZRcmZ6bU5BYzJyendWWUhwaTNtbk5mUDBmYlMwPQ==;MTAyMjE0N0AzMjMwMmUzNDJlMzBHczlvQWU1REZKQTdnMmVrWDI2VVRZTUNaU2xqamdUUFA5Vm9ZVU92YlV3PQ==;MTAyMjE0OEAzMjMwMmUzNDJlMzBnZHlDeS9janNwdGU3NWlYN0s4NjdYdjB6WlpSQ0RhQjhsbzduRDc1MmZjPQ==" );
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm( ) );
        }
    }
}

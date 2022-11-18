// <copyright file = "ActivityCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ActivityCode
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ActivityCode( )
        {
        }
        
        public ActivityCode( IQuery query )
        {
        }

        public ActivityCode( IDataModel builder )
        {
        }

        public ActivityCode( DataRow dataRow )
        {
        }
    }
}

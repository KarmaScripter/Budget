// <copyright file = "Report.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Report
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Report( )
        {
        }
        
        public Report( IQuery query )
        {
        }

        public Report( IDataModel builder )
        {
        }

        public Report( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "WorkCode.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class WorkCode
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public WorkCode( )
        {
        }
        
        public WorkCode( IQuery query )
        {
        }

        public WorkCode( IDataModel builder )
        {
        }

        public WorkCode( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "ApplicationTable.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ApplicationTable
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ApplicationTable( )
        {
        }
        
        public ApplicationTable( IQuery query )
        {
        }

        public ApplicationTable( IDataModel builder )
        {
        }

        public ApplicationTable( DataRow dataRow )
        {
        }
    }
}

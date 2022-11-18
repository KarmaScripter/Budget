// <copyright file = "QueryDefinition.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class QueryDefinition
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public QueryDefinition( )
        {
        }
        
        public QueryDefinition( IQuery query )
        {
        }

        public QueryDefinition( IDataModel builder )
        {
        }

        public QueryDefinition( DataRow dataRow )
        {
        }
    
    }
}

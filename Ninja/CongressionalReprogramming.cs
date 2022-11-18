// <copyright file = "CongressionalReprogramming.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CongressionalReprogramming
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CongressionalReprogramming( )
        {
        }
        
        public CongressionalReprogramming( IQuery query )
        {
        }

        public CongressionalReprogramming( IDataModel builder )
        {
        }

        public CongressionalReprogramming( DataRow dataRow )
        {
        }
    }
}

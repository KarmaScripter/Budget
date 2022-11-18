// <copyright file = "Providers.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Providers
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Providers( )
        {
        }
        
        public Providers( IQuery query )
        {
        }

        public Providers( IDataModel builder )
        {
        }

        public Providers( DataRow dataRow )
        {
        }
    }
}

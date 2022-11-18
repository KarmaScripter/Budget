// <copyright file = "URL.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class URL
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public URL( )
        {
        }
        
        public URL( IQuery query )
        {
        }

        public URL( IDataModel builder )
        {
        }

        public URL( DataRow dataRow )
        {
        }
    }
}

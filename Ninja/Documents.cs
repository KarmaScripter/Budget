// <copyright file = "Document.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Documents
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Documents( )
        {
        }
        
        public Documents( IQuery query )
        {
        }

        public Documents( IDataModel builder )
        {
        }

        public Documents( DataRow dataRow )
        {
        }
    }
}

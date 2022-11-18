// <copyright file = "Changes.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Changes
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Changes( )
        {
        }
        
        public Changes( IQuery query )
        {
        }

        public Changes( IDataModel builder )
        {
        }

        public Changes( DataRow dataRow )
        {
        }
    }
}

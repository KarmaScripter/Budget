// <copyright file = "GrossAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class GrossAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public GrossAuthority( )
        {
        }

        public GrossAuthority( IQuery query )
        {
        }

        public GrossAuthority( IDataModel builder )
        {
        }

        public GrossAuthority( DataRow dataRow )
        {
        }
    }
}

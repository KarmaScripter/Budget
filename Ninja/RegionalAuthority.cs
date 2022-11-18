// <copyright file = "RegionalAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class RegionalAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public RegionalAuthority( )
        {
        }
        
        public RegionalAuthority( IQuery query )
        {
        }

        public RegionalAuthority( IDataModel builder )
        {
        }

        public RegionalAuthority( DataRow dataRow )
        {
        }
    }
}

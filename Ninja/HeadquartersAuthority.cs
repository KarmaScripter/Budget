// <copyright file = "HeadquartersAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class HeadquartersAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public HeadquartersAuthority( )
        {
        }
        
        public HeadquartersAuthority( IQuery query )
        {
        }

        public HeadquartersAuthority( IDataModel builder )
        {
        }

        public HeadquartersAuthority( DataRow dataRow )
        {
        }
    }
}

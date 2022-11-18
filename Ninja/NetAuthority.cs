// <copyright file = "NetAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class NetAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public NetAuthority( )
        {
        }
        
        public NetAuthority( IQuery query )
        {
        }

        public NetAuthority( IDataModel builder )
        {
        }

        public NetAuthority( DataRow dataRow )
        {
        }
    }
}

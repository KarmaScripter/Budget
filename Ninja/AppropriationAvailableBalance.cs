// <copyright file = "AppropriationAvailableBalance.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AppropriationAvailableBalance
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AppropriationAvailableBalance( )
        {
        }
        
        public AppropriationAvailableBalance( IQuery query )
        {
        }

        public AppropriationAvailableBalance( IDataModel builder )
        {
        }

        public AppropriationAvailableBalance( DataRow dataRow )
        {
        }
    }
}

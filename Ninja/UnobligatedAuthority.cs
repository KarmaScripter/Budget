// <copyright file = "UnobligatedAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class UnobligatedAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public UnobligatedAuthority( )
        {
        }
        
        public UnobligatedAuthority( IQuery query )
        {
        }

        public UnobligatedAuthority( IDataModel builder )
        {
        }

        public UnobligatedAuthority( DataRow dataRow )
        {
        }
    }
}

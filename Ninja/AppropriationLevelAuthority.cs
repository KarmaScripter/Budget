// <copyright file = "AppropriationLevelAuthority.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AppropriationLevelAuthority
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AppropriationLevelAuthority( )
        {
        }

        public AppropriationLevelAuthority( IQuery query )
        {
        }

        public AppropriationLevelAuthority( IDataModel builder )
        {
        }

        public AppropriationLevelAuthority( DataRow dataRow )
        {
        }
    }

}
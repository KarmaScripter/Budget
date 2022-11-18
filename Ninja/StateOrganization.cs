// <copyright file = "StateOrganization.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StateOrganization
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public StateOrganization( )
        {
        }
        
        public StateOrganization( IQuery query )
        {
        }

        public StateOrganization( IDataModel builder )
        {
        }

        public StateOrganization( DataRow dataRow )
        {
        }
    }
}

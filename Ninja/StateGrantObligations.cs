// <copyright file = "StateGrantObligation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StateGrantObligations
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public StateGrantObligations( )
        {
        }
        
        public StateGrantObligations( IQuery query )
        {
        }

        public StateGrantObligations( IDataModel builder )
        {
        }

        public StateGrantObligations( DataRow dataRow )
        {
        }
    }
}

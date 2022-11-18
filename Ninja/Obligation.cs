// <copyright file = "Obligation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Obligation
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Obligation( )
        {
        }
        
        public Obligation( IQuery query )
        {
        }

        public Obligation( IDataModel builder )
        {
        }

        public Obligation( DataRow dataRow )
        {
        }
    }
}

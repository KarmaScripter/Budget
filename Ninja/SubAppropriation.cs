// <copyright file = "SubAppropriation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SubAppropriation
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public SubAppropriation( )
        {
        }
        
        public SubAppropriation( IQuery query )
        {
        }

        public SubAppropriation( IDataModel builder )
        {
        }

        public SubAppropriation( DataRow dataRow )
        {
        }
    }
}

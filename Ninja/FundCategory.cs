// <copyright file = "FundCategory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class FundCategory
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public FundCategory( )
        {
        }
        
        public FundCategory( IQuery query )
        {
        }

        public FundCategory( IDataModel builder )
        {
        }

        public FundCategory( DataRow dataRow )
        {
        }
    }
}

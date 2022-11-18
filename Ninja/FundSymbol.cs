// <copyright file = "FundSymbol.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class FundSymbol
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public FundSymbol( )
        {
        }
        
        public FundSymbol( IQuery query )
        {
        }

        public FundSymbol( IDataModel builder )
        {
        }

        public FundSymbol( DataRow dataRow )
        {
        }
    }
}

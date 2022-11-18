// <copyright file = "ApportionmentData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ApportionmentData
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ApportionmentData( )
        {
        }
        
        public ApportionmentData( IQuery query )
        {
        }

        public ApportionmentData( IDataModel builder )
        {
        }

        public ApportionmentData( DataRow dataRow )
        {
        }
    }
}

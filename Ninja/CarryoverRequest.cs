// <copyright file = "CarryoverRequest.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CarryoverRequest
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CarryoverRequest( )
        {
        }
        
        public CarryoverRequest( IQuery query )
        {
        }

        public CarryoverRequest( IDataModel builder )
        {
        }

        public CarryoverRequest( DataRow dataRow )
        {
        }
    }
}

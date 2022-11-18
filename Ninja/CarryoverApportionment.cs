// <copyright file = "CarryoverApportionment.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CarryoverApportionment
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CarryoverApportionment( )
        {
        }
        
        public CarryoverApportionment( IQuery query )
        {
        }

        public CarryoverApportionment( IDataModel builder )
        {
        }

        public CarryoverApportionment( DataRow dataRow )
        {
        }
    }
}


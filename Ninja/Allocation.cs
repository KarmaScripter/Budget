// <copyright file = "Allocation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Allocation
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Allocation( )
        {
        }
        
        public Allocation( IQuery query )
        {
        }

        public Allocation( IDataModel builder )
        {
        }

        public Allocation( DataRow dataRow )
        {
        }
    }
}

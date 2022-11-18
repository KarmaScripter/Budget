// <copyright file = "CostArea.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CostArea
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CostArea( )
        {
        }
        
        public CostArea( IQuery query )
        {
        }

        public CostArea( IDataModel builder )
        {
        }

        public CostArea( DataRow dataRow )
        {
        }
    }
}

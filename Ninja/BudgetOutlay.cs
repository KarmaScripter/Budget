// <copyright file = "BudgetOutlay.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class BudgetOutlay
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public BudgetOutlay( )
        {
        }


        public BudgetOutlay( IQuery query )
        {
        }

        public BudgetOutlay( IDataModel builder )
        {
        }

        public BudgetOutlay( DataRow dataRow )
        {
        }

    }
}
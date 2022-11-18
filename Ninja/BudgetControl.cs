// <copyright file = "BudgetControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class BudgetControl
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public BudgetControl( )
        {
        }
        
        public BudgetControl( IQuery query )
        {
        }

        public BudgetControl( IDataModel builder )
        {
        }

        public BudgetControl( DataRow dataRow )
        {
        }
    }
}

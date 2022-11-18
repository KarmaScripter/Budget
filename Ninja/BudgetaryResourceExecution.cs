// <copyright file = "BudgetaryResourceExecution.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class BudgetaryResourceExecution
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public BudgetaryResourceExecution( )
        {
        }
        
        public BudgetaryResourceExecution( IQuery query )
        {
        }

        public BudgetaryResourceExecution( IDataModel builder )
        {
        }

        public BudgetaryResourceExecution( DataRow dataRow )
        {
        }
    }
}

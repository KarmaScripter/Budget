// <copyright file = "BudgetDocument.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class BudgetDocument
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public BudgetDocument( )
        {
        }
        
        public BudgetDocument( IQuery query )
        {
        }

        public BudgetDocument( IDataModel builder )
        {
        }

        public BudgetDocument( DataRow dataRow )
        {
        }
    }
}

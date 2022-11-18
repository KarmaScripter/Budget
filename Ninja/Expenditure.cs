// <copyright file = "Expenditure.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Expenditure
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Expenditure( )
        {
        }
        
        public Expenditure( IQuery query )
        {
        }

        public Expenditure( IDataModel builder )
        {
        }

        public Expenditure( DataRow dataRow )
        {
        }
    }
}

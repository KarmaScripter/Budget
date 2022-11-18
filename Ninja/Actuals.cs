// <copyright file = "Actuals.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Actuals
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Actuals( )
        {
        }
        
        public Actuals( IQuery query )
        {
        }

        public Actuals( IDataModel builder )
        {
        }

        public Actuals( DataRow dataRow )
        {
        }
    }
}

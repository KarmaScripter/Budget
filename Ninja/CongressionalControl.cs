// <copyright file = "CongressionalControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CongressionalControl
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CongressionalControl( )
        {
        }
        
        public CongressionalControl( IQuery query )
        {
        }

        public CongressionalControl( IDataModel builder )
        {
        }

        public CongressionalControl( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "CompassOutlay.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CompassOutlay
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CompassOutlay( )
        {
        }
        
        public CompassOutlay( IQuery query )
        {
        }

        public CompassOutlay( IDataModel builder )
        {
        }

        public CompassOutlay( DataRow dataRow )
        {
        }
    }
}

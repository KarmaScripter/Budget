// <copyright file = "CompassLevel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class CompassLevels
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public CompassLevels( )
        {
        }

        public CompassLevels( IQuery query )
        {
        }

        public CompassLevels( IDataModel builder )
        {
        }

        public CompassLevels( DataRow dataRow )
        {
        }
    }
}
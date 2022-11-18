// <copyright file = "StatusOfEarmarks.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StatusOfEarmarks
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public StatusOfEarmarks( )
        {
        }
        
        public StatusOfEarmarks( IQuery query )
        {
        }

        public StatusOfEarmarks( IDataModel builder )
        {
        }

        public StatusOfEarmarks( DataRow dataRow )
        {
        }
    }
}

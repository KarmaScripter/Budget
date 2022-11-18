// <copyright file = "StatusOfAppropriations.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class StatusOfAppropriations
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public StatusOfAppropriations( )
        {
        }
        
        public StatusOfAppropriations( IQuery query )
        {
        }

        public StatusOfAppropriations( IDataModel builder )
        {
        }

        public StatusOfAppropriations( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "ReferenceTable.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ReferenceTable
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ReferenceTable( )
        {
        }
        
        public ReferenceTable( IQuery query )
        {
        }

        public ReferenceTable( IDataModel builder )
        {
        }

        public ReferenceTable( DataRow dataRow )
        {
        }
    }
}

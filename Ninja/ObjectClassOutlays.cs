// <copyright file = "ObjectClassOutlays.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class ObjectClassOutlays
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public ObjectClassOutlays( )
        {
        }
        
        public ObjectClassOutlays( IQuery query )
        {
        }

        public ObjectClassOutlays( IDataModel builder )
        {
        }

        public ObjectClassOutlays( DataRow dataRow )
        {
        }
    }
}

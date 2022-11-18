// <copyright file = "Resources.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Resources
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Resources( )
        {
        }
        
        public Resources( IQuery query )
        {
        }

        public Resources( IDataModel builder )
        {
        }

        public Resources( DataRow dataRow )
        {
        }
    
    }
}

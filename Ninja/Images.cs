// <copyright file = "Images.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Images
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Images( )
        {
        }
        
        public Images( IQuery query )
        {
        }

        public Images( IDataModel builder )
        {
        }

        public Images( DataRow dataRow )
        {
        }
    }
}

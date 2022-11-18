// <copyright file = "AppropriationDocument.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class AppropriationDocument
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public AppropriationDocument( )
        {
        }
        
        public AppropriationDocument( IQuery query )
        {
        }

        public AppropriationDocument( IDataModel builder )
        {
        }

        public AppropriationDocument( DataRow dataRow )
        {
        }
    }
}

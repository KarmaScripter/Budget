// <copyright file = "SchemaType.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class SchemaTypes
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public SchemaTypes( )
        {
        }
        
        public SchemaTypes( IQuery query )
        {
        }

        public SchemaTypes( IDataModel builder )
        {
        }

        public SchemaTypes( DataRow dataRow )
        {
        }
    }
}

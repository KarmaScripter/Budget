// <copyright file = "DocumentControlNumber.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class DocumentControlNumber
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public DocumentControlNumber( )
        {
        }
        
        public DocumentControlNumber( IQuery query )
        {
        }

        public DocumentControlNumber( IDataModel builder )
        {
        }

        public DocumentControlNumber( DataRow dataRow )
        {
        }
    }
}

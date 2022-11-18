// <copyright file = "TransType.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class TransType
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public TransType( )
        {
        }
        
        public TransType( IQuery query )
        {
        }

        public TransType( IDataModel builder )
        {
        }

        public TransType( DataRow dataRow )
        {
        }
    }
}

// <copyright file = "PublicLaw.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class PublicLaw
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public PublicLaw( )
        {
        }
        
        public PublicLaw( IQuery query )
        {
        }

        public PublicLaw( IDataModel builder )
        {
        }

        public PublicLaw( DataRow dataRow )
        {
        }
    }
}

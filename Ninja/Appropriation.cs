// <copyright file = "Appropriation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Appropriation
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Appropriation( )
        {
        }
        
        public Appropriation( IQuery query )
        {
        }

        public Appropriation( IDataModel builder )
        {
        }

        public Appropriation( DataRow dataRow )
        {
        }
    }
}
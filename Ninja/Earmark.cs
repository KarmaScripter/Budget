// <copyright file = "Earmark.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Earmark
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public DataRow Record { get; set; }

        public Earmark( )
        {
        }
        
        public Earmark( IQuery query )
        {
        }

        public Earmark( IDataModel builder )
        {
        }

        public Earmark( DataRow dataRow )
        {
        }
    }
}

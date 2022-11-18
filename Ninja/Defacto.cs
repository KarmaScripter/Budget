// <copyright file = "Defacto.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Defacto
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Defacto( )
        {
        }
        
        public Defacto( IQuery query )
        {
        }

        public Defacto( IDataModel builder )
        {
        }

        public Defacto( DataRow dataRow )
        {
        }
    }
}

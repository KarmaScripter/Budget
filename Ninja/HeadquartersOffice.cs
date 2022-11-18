// <copyright file = "HeadquartersOffice.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class HeadquartersOffice
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public HeadquartersOffice( )
        {
        }
        
        public HeadquartersOffice( IQuery query )
        {
        }

        public HeadquartersOffice( IDataModel builder )
        {
        }

        public HeadquartersOffice( DataRow dataRow )
        {
        }
    }
}

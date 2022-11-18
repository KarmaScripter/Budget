// <copyright file = "Messages.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Messages
    {
        public int ID { get; set; }

        public Source Source { get; set; }

        public Messages( )
        {
        }
        
        public Messages( IQuery query )
        {
        }

        public Messages( IDataModel builder )
        {
        }

        public Messages( DataRow dataRow )
        {
        }
    }
}

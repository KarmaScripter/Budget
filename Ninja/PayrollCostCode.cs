// <copyright file = "PayrollCostCode.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PayrollCostCode : DataUnit
    {
        /// <summary>
        /// Gets or sets the rpio.
        /// </summary>
        /// <value>
        /// The rpio.
        /// </value>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public string RcCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the division.
        /// </summary>
        /// <value>
        /// The name of the division.
        /// </value>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets or sets the work code.
        /// </summary>
        /// <value>
        /// The work code.
        /// </value>
        public string WorkCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the work code.
        /// </summary>
        /// <value>
        /// The name of the work code.
        /// </value>
        public string WorkCodeName { get; set; }

        /// <summary>
        /// Gets or sets the hr org code.
        /// </summary>
        /// <value>
        /// The hr org code.
        /// </value>
        public string HrOrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the hr org.
        /// </summary>
        /// <value>
        /// The name of the hr org.
        /// </value>
        public string HrOrgName { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        public PayrollCostCode( )
        {
            Source = Source.PayrollCostCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public PayrollCostCode( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PayrollCostCodesId" ].ToString( ) );
            RPIO = Record[ "RPIO" ].ToString(  );
            AhCode = Record[ "AhCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            RcCode = Record[ "RcCode" ].ToString(  );
            WorkCode = Record[ "WorkCode" ].ToString(  );
            WorkCodeName = Record[ "WorkCodeName" ].ToString(  );
            HrOrgCode = Record[ "HrOrgCode" ].ToString(  );
            HrOrgName = Record[ "HrOrgName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public PayrollCostCode( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PayrollCostCodesId" ].ToString( ) );
            RPIO = Record[ "RPIO" ].ToString(  );
            AhCode = Record[ "AhCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            RcCode = Record[ "RcCode" ].ToString(  );
            WorkCode = Record[ "WorkCode" ].ToString(  );
            WorkCodeName = Record[ "WorkCodeName" ].ToString(  );
            HrOrgCode = Record[ "HrOrgCode" ].ToString(  );
            HrOrgName = Record[ "HrOrgName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public PayrollCostCode( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "PayrollCostCodesId" ].ToString( ) );
            RPIO = Record[ "RPIO" ].ToString(  );
            AhCode = Record[ "AhCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            RcCode = Record[ "RcCode" ].ToString(  );
            WorkCode = Record[ "WorkCode" ].ToString(  );
            WorkCodeName = Record[ "WorkCodeName" ].ToString(  );
            HrOrgCode = Record[ "HrOrgCode" ].ToString(  );
            HrOrgName = Record[ "HrOrgName" ].ToString(  );
        }

        public PayrollCostCode( PayrollCostCode code )
        {
            ID = code.ID;
            RPIO = code.RPIO;
            AhCode = code.AhCode;
            BFY = code.BFY;
            RcCode = code.RcCode;
            WorkCode = code.WorkCode;
            WorkCodeName = code.WorkCodeName;
            HrOrgCode = code.HrOrgCode;
            HrOrgName = code.HrOrgName;
        }
    }
}
﻿// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AppropriationAvailableBalance : PRC 
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public override string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public override string EFY { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public override string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public override string FundName { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        public override string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        public override string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        public override string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the name of the treasury account. </summary>
        /// <value> The name of the treasury account. </value>
        public override string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the total authority. </summary>
        /// <value> The total authority. </value>
        public double Authority { get; set; }

        /// <summary> Gets or sets the budgeted. </summary>
        /// <value> The budgeted. </value>
        public double Budgeted { get; set; }

        /// <summary> Gets or sets the carry over. </summary>
        /// <value> The carry over. </value>
        public double Carryover { get; set; }

        /// <summary> Gets or sets the total reimbursements. </summary>
        /// <value> The total reimbursements. </value>
        public double Reimbursements { get; set; }

        /// <summary> Gets or sets the total recoveries. </summary>
        /// <value> The total recoveries. </value>
        public double Recoveries { get; set; }

        /// <summary> Gets or sets the total used. </summary>
        /// <value> The total used. </value>
        public double Used { get; set; }

        /// <summary> Gets or sets the total available. </summary>
        /// <value> The total available. </value>
        public double Available { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AppropriationAvailableBalance"/>
        /// class.
        /// </summary>
        public AppropriationAvailableBalance( )
        {
            Source = Source.AppropriationAvailableBalances;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AppropriationAvailableBalance"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public AppropriationAvailableBalance( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AppropriationAvailableBalance"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public AppropriationAvailableBalance( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AppropriationAvailableBalance"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public AppropriationAvailableBalance( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( dataRow[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( dataRow[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( dataRow[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( dataRow[ "Recoveries" ].ToString( ) ?? "0" );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0" );
        }

        public AppropriationAvailableBalance( AppropriationAvailableBalance balance )
        {
            ID = balance.ID;
            BFY = balance.BFY;
            EFY = balance.EFY;
            FundCode = balance.FundCode;
            FundName = balance.FundName;
            BudgetAccountCode = balance.BudgetAccountCode;
            BudgetAccountName = balance.BudgetAccountName;
            TreasuryAccountCode = balance.TreasuryAccountCode;
            TreasuryAccountName = balance.TreasuryAccountName;
            Authority = balance.Authority;
            Budgeted = balance.Budgeted;
            Carryover = balance.Carryover;
            Reimbursements = balance.Reimbursements;
            Recoveries = balance.Recoveries;
            Used = balance.Used;
            Available = balance.Available;
        }
    }
}
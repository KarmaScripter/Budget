// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class BudgetDocument : DataUnit
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public string EFY { get; set; }

        /// <summary> Gets or sets the budget level. </summary>
        /// <value> The budget level. </value>
        public string BudgetLevel { get; set; }

        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        public string DocumentType { get; set; }

        /// <summary> Gets or sets the document number. </summary>
        /// <value> The document number. </value>
        public string DocumentNumber { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public string FundName { get; set; }

        /// <summary> Gets or sets the document date. </summary>
        /// <value> The document date. </value>
        public DateOnly DocumentDate { get; set; }

        /// <summary> Gets or sets the budgeted. </summary>
        /// <value> The budgeted. </value>
        public double Budgeted { get; set; }

        /// <summary> Gets or sets the posted. </summary>
        /// <value> The posted. </value>
        public double Posted { get; set; }

        /// <summary> Gets or sets the carry out. </summary>
        /// <value> The carry out. </value>
        public double CarryoverOut { get; set; }

        /// <summary> Gets or sets the carry in. </summary>
        /// <value> The carry in. </value>
        public double CarryoverIn { get; set; }

        /// <summary> Gets or sets the estimated recoveries. </summary>
        /// <value> The estimated recoveries. </value>
        public double Recoveries { get; set; }

        /// <summary> Gets or sets the estimated reimbursements. </summary>
        /// <value> The estimated reimbursements. </value>
        public double Reimbursements { get; set; }

        /// <summary> Gets or sets the treasury agency code. </summary>
        /// <value> The treasury agency code. </value>
        public string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        public string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        public string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public override Provider Provider { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetDocument"/>
        /// class.
        /// </summary>
        public BudgetDocument( )
        {
            Source = Source.BudgetDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetDocument"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public BudgetDocument( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            DocumentType = Record[ "DocumentType" ].ToString( );
            DocumentNumber = Record[ "DocumentNumber" ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ "DocumentDate" ].ToString( ) ?? "" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetDocument"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public BudgetDocument( IDataModel builder )
            : this( builder.Query )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            DocumentType = Record[ "DocumentType" ].ToString( );
            DocumentNumber = Record[ "DocumentNumber" ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ "DocumentDate" ].ToString( ) ?? "" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetDocument"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public BudgetDocument( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            DocumentType = dataRow[ "DocumentType" ].ToString( );
            DocumentDate = DateOnly.Parse( dataRow[ "DocumentDate" ].ToString( ) ?? "" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( dataRow[ "CarryoverOut" ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( dataRow[ "CarryoverIn" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }
    }
}
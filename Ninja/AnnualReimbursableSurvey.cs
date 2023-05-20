// <copyright file = "AnnualReimbursableSurvey.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class AnnualReimbursableSurvey : DataUnit 
    {
        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualReimbursableSurvey"/> class.
        /// </summary>
        public AnnualReimbursableSurvey( )
        {
            Source = Source.AnnualReimbursableSurvey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualReimbursableSurvey"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AnnualReimbursableSurvey( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AnnualReimbursableSurveyId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualReimbursableSurvey"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AnnualReimbursableSurvey( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AnnualReimbursableSurveyId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualReimbursableSurvey"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AnnualReimbursableSurvey( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "AnnualReimbursableSurveyId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnualReimbursableSurvey"/> class.
        /// </summary>
        /// <param name="survey">The survey.</param>
        public AnnualReimbursableSurvey( AnnualReimbursableSurvey survey )
        {
            ID = survey.ID;
            BFY = survey.BFY;
            EFY = survey.EFY;
            FundCode = survey.FundCode;
            FundName = survey.FundName;
        }
    }
}
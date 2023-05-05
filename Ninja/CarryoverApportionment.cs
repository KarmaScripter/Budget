// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class CarryoverApportionment : DataUnit, ICarryoverApportionment
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the budget account.
        /// </summary>
        /// <value>
        /// The budget account.
        /// </value>
        public string BudgetAccount { get; set; }

        /// <summary>
        /// Gets or sets the treasury account.
        /// </summary>
        /// <value>
        /// The treasury account.
        /// </value>
        public string TreasuryAccount { get; set; }

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
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the line.
        /// </summary>
        /// <value>
        /// The name of the line.
        /// </value>
        public string LineName { get; set; }

        /// <summary>
        /// Gets or sets the type of the authority.
        /// </summary>
        /// <value>
        /// The type of the authority.
        /// </value>
        public string AuthorityType { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public double Request { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets the deobligations.
        /// </summary>
        /// <value>
        /// The deobligations.
        /// </value>
        public double Deobligations { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the line split.
        /// </summary>
        /// <value>
        /// The line split.
        /// </value>
        public string LineSplit { get; set; }

        /// <summary>
        /// Gets or sets the apportionment account code.
        /// </summary>
        /// <value>
        /// The apportionment account code.
        /// </value>
        public string ApportionmentAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the treasury account.
        /// </summary>
        /// <value>
        /// The name of the treasury account.
        /// </value>
        public string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Record property.
        /// </summary>
        /// <value>
        /// The data row.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverApportionment"/> class.
        /// </summary>
        public CarryoverApportionment( )
        {
            Source = Source.CarryoverApportionments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverApportionment"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CarryoverApportionment( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverApportionmentsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Group = Record[ "Group" ].ToString( );
            Description = Record[ "Description" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            AuthorityType = Record[ "AuthorityType" ].ToString( );
            Request = double.Parse( Record[ "Request" ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ "Balance" ].ToString( ) ?? "0" );
            Deobligations = double.Parse( Record[ "Deobligations" ].ToString( ) ?? "0" );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            LineSplit = Record[ "LineSplit" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverApportionment"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CarryoverApportionment( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverApportionmentsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            Group = Record[ "Group" ].ToString( );
            Description = Record[ "Description" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            AuthorityType = Record[ "AuthorityType" ].ToString( );
            Request = double.Parse( Record[ "Request" ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ "Balance" ].ToString( ) ?? "0" );
            Deobligations = double.Parse( Record[ "Deobligations" ].ToString( ) ?? "0" );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            LineSplit = Record[ "LineSplit" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverApportionment"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CarryoverApportionment( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverApportionmentsId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            Group = dataRow[ "Group" ].ToString( );
            Description = dataRow[ "Description" ].ToString( );
            LineName = dataRow[ "LineName" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            AuthorityType = dataRow[ "AuthorityType" ].ToString( );
            Request = double.Parse( dataRow[ "Request" ].ToString( ) ?? "0" );
            Balance = double.Parse( dataRow[ "Balance" ].ToString( ) ?? "0" );
            Deobligations = double.Parse( dataRow[ "Deobligations" ].ToString( ) ?? "0" );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            LineSplit = dataRow[ "LineSplit" ].ToString( );
            ApportionmentAccountCode = dataRow[ "ApportionmentAccountCode" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverApportionment"/> class.
        /// </summary>
        /// <param name="carryover">The carryover.</param>
        public CarryoverApportionment( ICarryoverApportionment carryover )
            : this( )
        {
            ID = carryover.ID;
            BFY = carryover.BFY;
            EFY = carryover.EFY;
            Group = carryover.Group;
            Description = carryover.Description;
            LineName = carryover.LineName;
            LineNumber = carryover.LineNumber;
            AuthorityType = carryover.AuthorityType;
            Request = carryover.Request;
            Balance = carryover.Balance;
            Deobligations = carryover.Deobligations;
            Amount = carryover.Amount;
            LineSplit = carryover.LineSplit;
            ApportionmentAccountCode = carryover.ApportionmentAccountCode;
            TreasuryAccountCode = carryover.TreasuryAccountCode;
            TreasuryAccountName = carryover.TreasuryAccountName;
            BudgetAccountCode = carryover.BudgetAccountCode;
            BudgetAccountName = carryover.BudgetAccountName;
        }
    }
}
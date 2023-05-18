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
    public class CongressionalReprogramming : Reprogramming
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets or sets the reprogramming number. </summary>
        /// <value> The reprogramming number. </value>
        public override string ReprogrammingNumber { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public override string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public override string EFY { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public override string RpioCode { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        public override string AhCode { get; set; }

        /// <summary> Gets or sets the name of the ah. </summary>
        /// <value> The name of the ah. </value>
        public override string AhName { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public override string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public override string FundName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        public override string AccountCode { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        public override string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        public override string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        public override string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        public override string ProgramAreaName { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        public override string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        public override string OrgName { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        public override string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        public override string BocName { get; set; }

        /// <summary> Gets or sets the activity code. </summary>
        /// <value> The activity code. </value>
        public string ActivityCode { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        public override double Amount { get; set; }

        /// <summary> Gets or sets the description. </summary>
        /// <value> The description. </value>
        public string Description { get; set; }

        /// <summary> Gets or sets the extended description. </summary>
        /// <value> The extended description. </value>
        public string ExtendedDescription { get; set; }

        /// <summary> Gets or sets from to. </summary>
        /// <value> From to. </value>
        public override string FromTo { get; set; }

        /// <summary> Gets or sets the cycle. </summary>
        /// <value> The cycle. </value>
        public string Cycle { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public override Provider Provider { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CongressionalReprogramming"/>
        /// class.
        /// </summary>
        public CongressionalReprogramming( )
        {
            Source = Source.CongressionalReprogrammings;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CongressionalReprogramming"/>
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public CongressionalReprogramming( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) );
            Quarter = Record[ "Quarter" ].ToString( );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = Record[ "ControlNumber" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Subline = Record[ "Subline" ].ToString( );
            Purpose = Record[ "Purpose" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CongressionalReprogramming"/>
        /// class.
        /// </summary>
        /// <param name = "builder" > The builder. </param>
        public CongressionalReprogramming( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) );
            Quarter = Record[ "Quarter" ].ToString( );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = Record[ "ControlNumber" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Subline = Record[ "Subline" ].ToString( );
            Purpose = Record[ "Purpose" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CongressionalReprogramming"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" > The data row. </param>
        public CongressionalReprogramming( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CongressionalReprogrammingId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            FromTo = dataRow[ "FromTo" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = dataRow[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( dataRow[ "ProcessedDate" ].ToString( ) );
            Quarter = dataRow[ "Quarter" ].ToString( );
            ReprogrammingNumber = dataRow[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = dataRow[ "ControlNumber" ].ToString( );
            Line = dataRow[ "Line" ].ToString( );
            Subline = dataRow[ "Subline" ].ToString( );
            Purpose = dataRow[ "Purpose" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
        }
    }
}
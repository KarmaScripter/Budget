﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution 
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using BudgetExecution;
    using DocumentFormat.OpenXml.Wordprocessing;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Reprogramming : Transfer
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public override string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the document prefix.
        /// </summary>
        /// <value>
        /// The document prefix.
        /// </value>
        public  override string DocPrefix { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public  override string DocType { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the Ending Fiscal Year
        /// </summary>
        public override string EFY { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public override string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public override string RpioName { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public override string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public override string FundName { get; set; }

        /// <summary>
        /// Gets or sets the reprogramming number.
        /// </summary>
        /// <value>
        /// The reprogramming number.
        /// </value>
        public  override string ReprogrammingNumber { get; set; }

        /// <summary>
        /// Gets or sets the control number.
        /// </summary>
        /// <value>
        /// The control number.
        /// </value>
        public  override string ControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the processed date.
        /// </summary>
        /// <value>
        /// The processed date.
        /// </value>
        public  override DateOnly ProcessedDate { get; set; }

        /// <summary>
        /// Gets or sets the quarter.
        /// </summary>
        /// <value>
        /// The quarter.
        /// </value>
        public  override string Quarter { get; set; }

        /// <summary>
        /// Gets or sets the line.
        /// </summary>
        /// <value>
        /// The line.
        /// </value>
        public  override string Line { get; set; }

        /// <summary>
        /// Gets or sets the subline.
        /// </summary>
        /// <value>
        /// The subline.
        /// </value>
        public  override string Subline { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public override string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the ah.
        /// </summary>
        /// <value>
        /// The name of the ah.
        /// </value>
        public override string AhName { get; set; }

        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public override string OrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the org.
        /// </summary>
        /// <value>
        /// The name of the org.
        /// </value>
        public override string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public override string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public override string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public override string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public override string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public override string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets from to.
        /// </summary>
        /// <value>
        /// From to.
        /// </value>
        public  override string FromTo { get; set; }

        /// <summary>
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public override string BocCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the boc.
        /// </summary>
        /// <value>
        /// The name of the boc.
        /// </value>
        public override string BocName { get; set; }

        /// <summary>
        /// Gets or sets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public override string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public override double Amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        /// <value>
        /// The type of the resource.
        /// </value>
        public override string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the purpose.
        /// </summary>
        /// <value>
        /// The purpose.
        /// </value>
        public override string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the extended purpose.
        /// </summary>
        /// <value>
        /// The extended purpose.
        /// </value>
        public override string ExtendedPurpose { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public override Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        public Reprogramming( )
        {
            Source = Source.Transfers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Reprogramming( IQuery query ) 
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) );
            Quarter = Record[ "Quarter" ].ToString(  );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString(  );
            ControlNumber = Record[ "ControlNumber" ].ToString(  );
            Line = Record[ "Line" ].ToString(  );
            Subline = Record[ "Subline" ].ToString(  );
            Purpose = Record[ "Purpose" ].ToString(  );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Reprogramming( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY =  Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString(  );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) );
            Quarter = Record[ "Quarter" ].ToString(  );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString(  );
            ControlNumber = Record[ "ControlNumber" ].ToString(  );
            Line = Record[ "Line" ].ToString(  );
            Subline = Record[ "Subline" ].ToString(  );
            Purpose = Record[ "Purpose" ].ToString(  );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Reprogramming( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY =  dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString(  );
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
            ReprogrammingNumber = dataRow[ "ReprogrammingNumber" ].ToString(  );
            ControlNumber = dataRow[ "ControlNumber" ].ToString(  );
            Line = dataRow[ "Line" ].ToString( );
            Subline = dataRow[ "Subline" ].ToString( );
            Purpose = dataRow[ "Purpose" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString(  );
        }
    }
}

// <copyright file = "Obligation.cs" company = "Terry D.Eppler">
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
    /// <seealso cref="BudgetExecution.StatusOfFunds" />
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class Obligation : StatusOfFunds 
    {
        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public virtual string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the document number.
        /// </summary>
        /// <value>
        /// The document number.
        /// </value>
        public virtual string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the document control number.
        /// </summary>
        /// <value>
        /// The document control number.
        /// </value>
        public virtual string DocumentControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the reference document number.
        /// </summary>
        /// <value>
        /// The reference document number.
        /// </value>
        public virtual string ReferenceDocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the processed date.
        /// </summary>
        /// <value>
        /// The processed date.
        /// </value>
        public virtual DateOnly ProcessedDate { get; set; }

        /// <summary>
        /// Gets or sets the last activity date.
        /// </summary>
        /// <value>
        /// The last activity date.
        /// </value>
        public virtual DateOnly LastActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public virtual int Age { get; set; }

        /// <summary>
        /// Gets or sets the foc code.
        /// </summary>
        /// <value>
        /// The foc code.
        /// </value>
        public virtual string FocCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the foc.
        /// </summary>
        /// <value>
        /// The name of the foc.
        /// </value>
        public virtual string FocName { get; set; }

        /// <summary>
        /// Gets or sets the vendor code.
        /// </summary>
        /// <value>
        /// The vendor code.
        /// </value>
        public virtual string VendorCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the vendor.
        /// </summary>
        /// <value>
        /// The name of the vendor.
        /// </value>
        public virtual string VendorName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Obligation"/> class.
        /// </summary>
        public Obligation( )
        {
            Source = Source.Obligations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Obligation"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Obligation( IQuery query )
            : base( query )
        {
            Source = Source.Obligations;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? string.Empty );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? string.Empty );
            ULO = double.Parse( Record[ "ULO" ].ToString( ) ?? string.Empty );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Obligation"/> class.
        /// </summary>
        /// <param name="builder"></param>
        public Obligation( IDataModel builder )
            : base( builder )
        {
            Source = Source.Obligations;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? string.Empty );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? string.Empty );
            ULO = double.Parse( Record[ "ULO" ].ToString( ) ?? string.Empty );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Obligation"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Obligation( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.Obligations;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? string.Empty );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) ?? string.Empty );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? string.Empty );
            ULO = double.Parse( dataRow[ "ULO" ].ToString( ) ?? string.Empty );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString( ) ?? string.Empty );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) ?? string.Empty );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
            NpmName = dataRow[ "NpmName" ].ToString( );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Obligation"/> class.
        /// </summary>
        /// <param name="obligation">The obligation.</param>
        public Obligation( Obligation obligation )
        {
            BFY = obligation.BFY;
            EFY = obligation.EFY;
            FundCode = obligation.FundCode;
            FundName = obligation.FundName;
            RpioCode = obligation.RpioCode;
            RpioName = obligation.RpioName;
            AhCode = obligation.AhCode;
            AhName = obligation.AhName;
            OrgCode = obligation.OrgCode;
            OrgName = obligation.OrgName;
            AccountCode = obligation.AccountCode;
            BocCode = obligation.BocCode;
            BocName = obligation.BocName;
            Amount = obligation.Amount;
            Budgeted = obligation.Budgeted;
            Posted = obligation.Posted;
            OpenCommitments = obligation.OpenCommitments;
            ULO = obligation.ULO;
            Obligations = obligation.Obligations;
            Expenditures = obligation.Expenditures;
            Used = obligation.Used;
            Available = obligation.Available;
            ProgramProjectCode = obligation.ProgramProjectCode;
            ProgramProjectName = obligation.ProgramProjectName;
            ProgramAreaCode = obligation.ProgramAreaCode;
            ProgramAreaName = obligation.ProgramAreaName;
            NpmCode = obligation.NpmCode;
            NpmName = obligation.NpmName;
            GoalCode = obligation.GoalCode;
            GoalName = obligation.GoalName;
            ObjectiveCode = obligation.ObjectiveCode;
            ObjectiveName = obligation.ObjectiveName;
            TreasuryAccountCode = obligation.TreasuryAccountCode;
            TreasuryAccountName = obligation.TreasuryAccountName;
            BudgetAccountCode = obligation.BudgetAccountCode;
            BudgetAccountName = obligation.BudgetAccountName;
        }
    }
}
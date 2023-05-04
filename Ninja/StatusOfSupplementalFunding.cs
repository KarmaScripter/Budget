// <copyright file = "StatusOfSupplementalFunding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class StatusOfSupplementalFunding : StatusOfFunds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfSupplementalFunding"/> class.
        /// </summary>
        public StatusOfSupplementalFunding( )
        {
            Source = Source.StatusOfSupplementalFunding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfSupplementalFunding"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public StatusOfSupplementalFunding( IQuery query )
            : base( query )
        {
            Source = Source.StatusOfSupplementalFunding;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
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
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) );
            ULO = double.Parse( Record[ "ULO" ].ToString(  ) );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) );
            Used = double.Parse( Record[ "Used" ].ToString(  ) );
            Available = double.Parse( Record[ "Available" ].ToString(  ) );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
            NpmName = Record[ "NpmName" ].ToString(  );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfSupplementalFunding"/> class.
        /// </summary>
        /// <param name="dataBuilder">The builder.</param>
        public StatusOfSupplementalFunding( IDataModel dataBuilder ) 
            : base( dataBuilder )
        {
            Source = Source.StatusOfSupplementalFunding;
            Record = dataBuilder.Record;
            Data = Record.ToDictionary(  );
            BFY =  Record[ "BFY" ].ToString( );
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
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) );
            ULO = double.Parse( Record[ "ULO" ].ToString(  ) );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) );
            Used = double.Parse( Record[ "Used" ].ToString(  ) );
            Available = double.Parse( Record[ "Available" ].ToString(  ) );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
            NpmName = Record[ "NpmName" ].ToString(  );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfSupplementalFunding"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public StatusOfSupplementalFunding( DataRow dataRow ) 
            : base( dataRow )
        {
            Source = Source.StatusOfSupplementalFunding;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY =  Record[ "BFY" ].ToString( );
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
            Amount = double.Parse( Record[ "Amount" ].ToString(  ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString(  ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString(  ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            ULO = double.Parse( Record[ "ULO" ].ToString(  ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString(  ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString(  ) ?? "0" );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString(  );
            NpmName = Record[ "NpmName" ].ToString(  );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
        }
        
        public StatusOfSupplementalFunding( IAllocation allocation )
        {
            ID = allocation.ID;
            BudgetLevel = allocation.BudgetLevel;
            BFY = allocation.BFY;
            EFY = allocation.EFY;
            FundCode = allocation.FundCode;
            FundName = allocation.FundName;
            RpioCode = allocation.RpioCode;
            RpioName = allocation.RpioName;
            AhCode = allocation.AhCode;
            AhName = allocation.AhName;
            OrgCode = allocation.OrgCode;
            OrgName = allocation.OrgName;
            AccountCode = allocation.AccountCode;
            BocCode = allocation.BocCode;
            BocName = allocation.BocName;
            Amount = allocation.Amount;
            ProgramProjectCode = allocation.ProgramProjectCode;
            ProgramProjectName = allocation.ProgramProjectName;
            ProgramAreaCode = allocation.ProgramAreaCode;
            ProgramAreaName = allocation.ProgramAreaName;
            NpmCode = allocation.NpmCode;
            NpmName = allocation.NpmName;
            TreasuryAccountCode = allocation.TreasuryAccountCode;
            TreasuryAccountName = allocation.TreasuryAccountName;
            BudgetAccountCode = allocation.BudgetAccountCode;
            BudgetAccountName = allocation.BudgetAccountName;
        }
    }
}

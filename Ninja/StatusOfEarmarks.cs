// <copyright file = "StatusOfEarmarks.cs" company = "Terry D. Eppler">
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
    public class StatusOfEarmarks : StatusOfFunds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfEarmarks"/> class.
        /// </summary>
        public StatusOfEarmarks( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfEarmarks"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public StatusOfEarmarks( IQuery query ) : base( query )
        {
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
        /// Initializes a new instance of the <see cref="StatusOfEarmarks"/> class.
        /// </summary>
        /// <param name="dataBuilder">The builder.</param>
        public StatusOfEarmarks( IDataModel dataBuilder )
        {
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
        /// Initializes a new instance of the <see cref="StatusOfEarmarks"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public StatusOfEarmarks( DataRow dataRow )
        {
            Record = dataRow;
            Data = Record.ToDictionary(  );
            BFY =  dataRow[ "BFY" ].ToString( );
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
            Amount = double.Parse( dataRow[ "Amount" ].ToString(  ) );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString(  ) );
            Posted = double.Parse( dataRow[ "Posted" ].ToString(  ) );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) );
            ULO = double.Parse( dataRow[ "ULO" ].ToString(  ) );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString(  ) );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString(  ) );
            Used = double.Parse( dataRow[ "Used" ].ToString(  ) );
            Available = double.Parse( dataRow[ "Available" ].ToString(  ) );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString(  );
            NpmName = dataRow[ "NpmName" ].ToString(  );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
        }
        
        public StatusOfEarmarks( IDictionary<string, object> map )
        {
            Record = new DataBuilder( Source, map )?.Record;
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
        
        public StatusOfEarmarks( IAllocation allocation ) 
            : this( )
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

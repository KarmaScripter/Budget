﻿// <copyright file = "Defacto.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class Defacto : StatusOfFunds, IDefacto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Defacto"/> class.
        /// </summary>
        public Defacto( ) 
        {
            Source = Source.Defactos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Defacto"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Defacto( IQuery query ) 
            : base( query )
        {
            Source = Source.Defactos;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString(  );
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
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Defacto"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Defacto( IDataModel builder ) 
            : base( builder )
        {
            Source = Source.Defactos;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString(  );
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
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Defacto"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Defacto( DataRow dataRow ) 
            : base( dataRow )
        {
            Source = Source.Defactos;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString(  );
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
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString(  );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString(  );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString(  );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString(  );
        }
        
        public Defacto( IStatusOfFunds defacto )
        {
            ID = defacto.ID;
            BudgetLevel = defacto.BudgetLevel;
            BFY = defacto.BFY;
            EFY = defacto.EFY;
            FundCode = defacto.FundCode;
            FundName = defacto.FundName;
            RpioCode = defacto.RpioCode;
            RpioName = defacto.RpioName;
            AhCode = defacto.AhCode;
            AhName = defacto.AhName;
            OrgCode = defacto.OrgCode;
            OrgName = defacto.OrgName;
            AccountCode = defacto.AccountCode;
            BocCode = defacto.BocCode;
            BocName = defacto.BocName;
            Available = defacto.Available;
            ProgramProjectCode = defacto.ProgramProjectCode;
            ProgramProjectName = defacto.ProgramProjectName;
            ProgramAreaCode = defacto.ProgramAreaCode;
            ProgramAreaName = defacto.ProgramAreaName;
            NpmCode = defacto.NpmCode;
            NpmName = defacto.NpmName;
            TreasuryAccountCode = defacto.TreasuryAccountCode;
            TreasuryAccountName = defacto.TreasuryAccountName;
            BudgetAccountCode = defacto.BudgetAccountCode;
            BudgetAccountName = defacto.BudgetAccountName;
        }
    }
}

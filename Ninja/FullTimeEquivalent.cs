﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Full-time equivalent (FullTimeEquivalents) or whole time equivalent (WTE) is a
    /// unit that indicates the workload of an employed person (or student) in a way
    /// that makes workloads or class loads comparable across various contexts.
    /// FullTimeEquivalent is often used to measure a worker's or student's involvement
    /// in a project, or to track cost reductions in an organization. An
    /// FullTimeEquivalent of 1.0 is equivalent to a full-time worker or student, while
    /// an FullTimeEquivalent of 0.5 signals half of a full work or school load.
    /// </summary>
    /// <seealso cref = "ProgramResultsCode"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class FullTimeEquivalent : ProgramResultsCode
    {
        /// <summary>
        /// Gets or sets the ProgramResultCodes identifier.
        /// </summary>
        /// <value>
        /// The ProgramResultCodes identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the operating plans identifier.
        /// </summary>
        /// <value>
        /// The operating plans identifier.
        /// </value>
        public int OperatingPlansId { get; set; }

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
        public string RpioName { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public override string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public override string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public override string OrgCode { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public override string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public override string RcCode { get; set; }

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
        public string BocName { get; set; }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets it project code.
        /// </summary>
        /// <value>
        /// It project code.
        /// </value>
        public string ITProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the project code.
        /// </summary>
        /// <value>
        /// The project code.
        /// </value>
        public string ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the project type.
        /// </summary>
        /// <value>
        /// The name of the project type.
        /// </value>
        public string ProjectTypeName { get; set; }

        /// <summary>
        /// Gets or sets the project type code.
        /// </summary>
        /// <value>
        /// The project type code.
        /// </value>
        public string ProjectTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public override string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public override string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NPM.
        /// </summary>
        /// <value>
        /// The name of the NPM.
        /// </value>
        public string NpmName { get; set; }

        /// <summary>
        /// Gets or sets the name of the ah.
        /// </summary>
        /// <value>
        /// The name of the ah.
        /// </value>
        public string AhName { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the name of the org.
        /// </summary>
        /// <value>
        /// The name of the org.
        /// </value>
        public string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the name of the rc.
        /// </summary>
        /// <value>
        /// The name of the rc.
        /// </value>
        public string RcName { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public override string ActivityCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        public string ActivityName { get; set; }

        /// <summary>
        /// Gets or sets the local code.
        /// </summary>
        /// <value>
        /// The local code.
        /// </value>
        public string LocalCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the local code.
        /// </summary>
        /// <value>
        /// The name of the local code.
        /// </value>
        public string LocalCodeName { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the cost area code.
        /// </summary>
        /// <value>
        /// The cost area code.
        /// </value>
        public string CostAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the cost area.
        /// </summary>
        /// <value>
        /// The name of the cost area.
        /// </value>
        public string CostAreaName { get; set; }

        /// <summary>
        /// Gets or sets the goal code.
        /// </summary>
        /// <value>
        /// The goal code.
        /// </value>
        public string GoalCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the goal.
        /// </summary>
        /// <value>
        /// The name of the goal.
        /// </value>
        public string GoalName { get; set; }

        /// <summary>
        /// Gets or sets the objective code.
        /// </summary>
        /// <value>
        /// The objective code.
        /// </value>
        public string ObjectiveCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the objective.
        /// </summary>
        /// <value>
        /// The name of the objective.
        /// </value>
        public string ObjectiveName { get; set; }
        
        /// <summary>
        /// The source
        /// </summary>
        public override Source Source { get; set; } =  Source.FullTimeEquivalents;

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
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "T:BudgetExecution.FullTimeEquivalent"/> class.
        /// </summary>
        public FullTimeEquivalent( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "FullTimeEquivalent"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public FullTimeEquivalent( IQuery query )
            : base( query )
        {
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId  );
            Amount = double.Parse( Record[ $"{ Numeric.Amount }" ].ToString( ) );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "FullTimeEquivalent"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The databuilder.
        /// </param>
        public FullTimeEquivalent( IDataModel builder )
            : base( builder )
        {
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId  );
            Amount = double.Parse( Record[ $"{ Numeric.Amount }" ].ToString( ) );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "FullTimeEquivalent"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public FullTimeEquivalent( DataRow dataRow )
            : base( dataRow )
        {
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId  );
            Amount = double.Parse( dataRow[ $"{ Numeric.Amount }" ].ToString( ) );
        }

        /// <summary>
        /// Gets the ProgramResultCodes identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public override int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            try
            {
                return Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) && dataRow != null
                    ? int.Parse( dataRow[ $"{ primaryKey }" ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }
    }
}
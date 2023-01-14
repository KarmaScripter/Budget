// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public abstract class PRC : DataUnit
    {
        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public virtual string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public virtual string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public virtual string EFY { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public virtual string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public virtual string RpioName { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public virtual string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public virtual string FundName { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public virtual string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the ah.
        /// </summary>
        /// <value>
        /// The name of the ah.
        /// </value>
        public virtual string AhName { get; set; }

        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public virtual string OrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the org.
        /// </summary>
        /// <value>
        /// The name of the org.
        /// </value>
        public virtual string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public virtual string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public virtual string ActivityCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the activit.
        /// </summary>
        /// <value>
        /// The name of the activit.
        /// </value>
        public virtual string ActivityName { get; set; }

        /// <summary>
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public virtual string BocCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the boc.
        /// </summary>
        /// <value>
        /// The name of the boc.
        /// </value>
        public virtual string BocName { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public virtual string RcCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the rc.
        /// </summary>
        /// <value>
        /// The name of the rc.
        /// </value>
        public virtual string RcName { get; set; }

        /// <summary>
        /// Gets or sets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public virtual string NpmCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the NPM.
        /// </summary>
        /// <value>
        /// The name of the NPM.
        /// </value>
        public virtual string NpmName { get; set; }

        /// <summary>
        /// Gets or sets the goal code.
        /// </summary>
        /// <value>
        /// The goal code.
        /// </value>
        public virtual string GoalCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the goal.
        /// </summary>
        /// <value>
        /// The name of the goal.
        /// </value>
        public virtual string GoalName { get; set; }

        /// <summary>
        /// Gets or sets the objective code.
        /// </summary>
        /// <value>
        /// The objective code.
        /// </value>
        public virtual string ObjectiveCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the objective.
        /// </summary>
        /// <value>
        /// The name of the objective.
        /// </value>
        public virtual string ObjectiveName { get; set; }
        
        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public virtual string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public virtual string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public virtual string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public virtual string ProgramAreaName { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        protected PRC( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        protected PRC( IQuery query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        protected PRC( IDataModel dataBuilder )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PRC"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        protected PRC( DataRow dataRow )
        {
            NpmCode = Record[ $"{ Field.NpmCode }" ].ToString( );
            ProgramProjectCode = Record[ $"{ Field.ProgramProjectCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            GoalCode = Record[ $"{ Field.GoalCode }" ].ToString( );
            ObjectiveCode = Record[ $"{ Field.ObjectiveCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
        }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public virtual string GetField( DataRow dataRow, string field )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( field ) )
            {
                try
                {
                    return dataRow[ field ].ToString(  );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public virtual double GetNumeric( DataRow dataRow, string field )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( field ) )
            {
                try
                {
                    return double.Parse( dataRow[ field ]?.ToString( ) ?? string.Empty );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( double );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public virtual double GetNumeric( DataRow dataRow, Field field )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    return double.Parse( dataRow[ $"{ field }" ]?.ToString( ) ?? string.Empty );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( double );
                }
            }

            return default( double );
        }
    }
}

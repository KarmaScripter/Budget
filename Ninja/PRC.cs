// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
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
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public virtual string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public virtual string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public virtual string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public virtual string OrgCode { get; set; }

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
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public virtual string BocCode { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public virtual string RcCode { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public virtual string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public virtual string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public virtual IDictionary<string, object> Map { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public override DataRow Record { get; set; }
        
        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <returns>
        /// </returns>
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
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="field"></param>
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
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="field"></param>
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

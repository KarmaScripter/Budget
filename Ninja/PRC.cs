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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class PRC
    {
        /// <summary>
        /// Gets or sets the ProgramResultCodes identifier.
        /// </summary>
        /// <value>
        /// The ProgramResultCodes identifier.
        /// </value>
        public virtual int ID { get; set; }

        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public virtual string BudgetLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string BFY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string EFY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string FundCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string RpioCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AhCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string OrgCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public virtual string ActivityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        public virtual DataRow Record { get; set; }
        

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
        public virtual string GetField( DataRow dataRow, Field field )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    return dataRow.GetField( field );
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
        /// <returns></returns>
        public virtual int GetId( DataRow dataRow )
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
                return default;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public virtual int GetId( DataRow dataRow, PrimaryKey primaryKey )
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
                return default;
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}

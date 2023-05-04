// <copyright file = "Amount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IAmount" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    public class Amount : IAmount
    {
        /// <summary>
        /// The funding
        /// </summary>
        public double Funding { get; set; }

        /// <summary>
        /// The initial
        /// </summary>
        public double Initial { get; set; }

        /// <summary>
        /// The delta
        /// </summary>
        public double Delta { get; set; }

        /// <summary>
        /// The numeric
        /// </summary>
        public string Numeric { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        public Amount( )
        {
            Numeric = "Amount";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="value">The value.</param>
        public Amount( double value  ) 
            : this( )
        {
            Funding = value;
            Initial = value;
            Delta = Initial - Funding;
        }

        public Amount( DataRow dataRow, string numeric )
        {
            Numeric = numeric;
            Funding = double.Parse( dataRow[ numeric ].ToString( ) );
            Initial = Funding;
            Delta = Initial - Funding;
        }

        /// <summary>
        /// Increases the specified amount.
        /// </summary>
        /// <param name="increment">The amount.</param>
        public void Increase( int increment )
        {
            try
            {
                Delta = increment;
                Funding += increment;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Decreases the specified amount.
        /// </summary>
        /// <param name="decrement">The amount.</param>
        public void Decrease( int decrement )
        {
            try
            {
                Delta = decrement;
                Funding -= decrement;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether the specified amount is equal.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns>
        ///   <c>true</c> if the specified amount is equal; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEqual( IAmount amount )
        {
            if( amount != null )
            {
                try
                {
                    return ( amount?.Funding == Funding 
                        && amount?.Numeric?.Equals( Numeric ) == true );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified first is equal.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns>
        ///   <c>true</c> if the specified first is equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEqual( IAmount first, IAmount second )
        {
            if( first != null 
               && second != null )
            {
                try
                {
                    return ( first?.Numeric == second?.Numeric 
                        && first.Funding == second.Funding );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "Not Yet Implemented" );
                _message.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
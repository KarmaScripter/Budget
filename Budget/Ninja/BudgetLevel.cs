﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetLevel : IBudgetLevel
    {
        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        private readonly Level _level;

        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        private readonly string _code;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetLevel"/> class.
        /// </summary>
        public BudgetLevel( )
        {
            _level = Level.BudgetObjectClass;
            _code = ( (int)_level ).ToString( );
            _name = _level.ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetLevel"/> class.
        /// </summary>
        /// <param name = "budgetLevel" >
        /// The budgetLevel.
        /// </param>
        public BudgetLevel( string budgetLevel )
        {
            _level = GetLevel( budgetLevel );
            _code = ( (int)_level ).ToString( );
            _name = _level.ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "BudgetLevel"/> class.
        /// </summary>
        /// <param name = "level" >
        /// The level.
        /// </param>
        private BudgetLevel( Level level )
        {
            _level = level;
            _code = ( (int)_level ).ToString( );
            _name = _level.ToString( );
        }

        /// <summary>
        /// Gets the level number.
        /// </summary>
        /// <returns>
        /// </returns>
        public int GetNumber( )
        {
            try
            {
                return Enum.IsDefined( typeof( Level ), _level.ToString( ) )
                    ? (int)Enum.Parse( typeof( Level ), _level.ToString( ) )
                    : (int)Level.BudgetObjectClass;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the name of the level.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetName( )
        {
            try
            {
                return !string.IsNullOrEmpty( _name )
                    ? _name
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <returns>
        /// </returns>
        public Level GetLevel( )
        {
            try
            {
                return Enum.IsDefined( typeof( Level ), _level )
                    ? _level
                    : Level.Treasury;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <param name = "budgetLevel" >
        /// The budgetLevel.
        /// </param>
        /// <returns>
        /// </returns>
        private Level GetLevel( string budgetLevel )
        {
            try
            {
                return !string.IsNullOrEmpty( budgetLevel ) && int.Parse( budgetLevel ) < 9
                    && int.Parse( budgetLevel ) > 6
                    && !Enum.IsDefined( typeof( Level ), int.Parse( budgetLevel ) )
                        ? (Level)Enum.Parse( typeof( Level ), budgetLevel )
                        : Level.Treasury;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref = "string"/> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( _code )
                    ? _code
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            if( Enum.IsDefined( typeof( Level ), _level )
               && !string.IsNullOrEmpty( _code )
               && !string.IsNullOrEmpty( _name ) )
            {
                try
                {
                    return new Dictionary<string, object>( )
                    {
                        [ $"{ _level }" ] = _level.ToString( ),
                        [ $"{ _code }" ] = _code,
                        [ $"{ _name }" ] = _name
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the budget level.
        /// </summary>
        /// <returns>
        /// </returns>
        public BudgetLevel GetBudgetLevel( )
        {
            try
            {
                return (BudgetLevel)MemberwiseClone( );
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
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
    /// 
    /// </summary>
    /// <seealso cref = "IGoal"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Goal : DataUnit, IGoal 
    {
        /// <summary>
        /// The source
        /// </summary>
        public override Source Source { get; set; } = Source.Goals;

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public override string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        public Goal( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Goal( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Goal( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Goal( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Goal( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "GoalsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Goal"/> class.
        /// </summary>
        /// <param name="goal">The goal.</param>
        public Goal( IGoal goal )
        {
            ID = goal.ID;
            Code = goal.Code;
            Name = goal.Name;
        }
        
        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"Code" ] = code };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "goal" >
        /// The goal.
        /// </param>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> GetArgs( int goal )
        {
            if( goal > 0
               && goal < 5 )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ "Code" ] = goal.ToString( )
                    };
                }
                catch( SystemException ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns>
        /// </returns>
        public IGoal GetGoal( )
        {
            try
            {
                return MemberwiseClone( ) as Goal;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IGoal );
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource( )
        {
            try
            {
                return Enum.IsDefined( typeof( Source ), Source )
                    ? Source
                    : default( Source );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Source );
            }
        }
    }
}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DbDataAdapter" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AdapterBuilder : DbDataAdapter, ISource, IProvider
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// The connection
        /// </summary>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets the command builder.
        /// </summary>
        /// <value>
        /// The command builder.
        /// </value>
        public ICommand Command { get; set; }

        /// <summary>
        /// Gets the command factory.
        /// </summary>
        /// <value>
        /// The command factory.
        /// </value>
        public ICommandFactory CommandFactory { get; set; }

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value>
        /// The command text.
        /// </value>
        public string CommandText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBuilder"/> class.
        /// </summary>
        public AdapterBuilder( )
        {
            MissingMappingAction = MissingMappingAction.Ignore;
            MissingSchemaAction = MissingSchemaAction.AddWithKey;
            ContinueUpdateOnError = true;
            AcceptChangesDuringFill = true;
            AcceptChangesDuringUpdate = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBuilder"/> class.
        /// </summary>
        /// <param name="commandFactory">The commandbuilder.</param>
        public AdapterBuilder( ICommandFactory commandFactory )
            : this( )
        {
            Source = commandFactory.Source;
            Provider = commandFactory.Provider;
            CommandFactory = commandFactory;
            ConnectionFactory = new ConnectionFactory( commandFactory.Source, commandFactory.Provider );
            Connection = ConnectionFactory.GetConnection(  );
            CommandText = CommandFactory.GetCommand(  ).CommandText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBuilder"/> class.
        /// </summary>
        /// <param name="sqlStatement">The sqlstatement.</param>
        public AdapterBuilder( ISqlStatement sqlStatement )
            : this( )
        {
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            SqlStatement = sqlStatement;
            ConnectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
            Connection = ConnectionFactory.GetConnection(  );
            CommandText = sqlStatement.CommandText;
        }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns></returns>
        public DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
               && Connection != null
               && !string.IsNullOrEmpty( CommandText ) )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            var _adapter = new SQLiteDataAdapter( CommandText,
                                Connection as SQLiteConnection );

                            return _adapter;
                        }
                        case Provider.SqlCe:
                        {
                            var _adapter = new SqlCeDataAdapter( CommandText,
                                Connection as SqlCeConnection );

                            return _adapter;
                        }
                        case Provider.SqlServer:
                        {
                            var _adapter = new SqlDataAdapter( CommandText,
                                Connection as SqlConnection );

                            return _adapter;
                        }
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            var _connection = Connection as OleDbConnection;
                            var _adapter = new OleDbDataAdapter( CommandText, _connection );
                            return _adapter;
                        }
                    }
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
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
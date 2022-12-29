// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AdapterBase : DbDataAdapter, ISource, IProvider
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
        public IDictionary<string, DbCommand> Commands { get; set; }

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
        /// Initializes a new instance of the <see cref="AdapterBase"/> class.
        /// </summary>
        protected AdapterBase( )
        {
            MissingSchemaAction = MissingSchemaAction.AddWithKey;
            MissingMappingAction = MissingMappingAction.Ignore;
            ContinueUpdateOnError = true;
            AcceptChangesDuringFill = true;
            AcceptChangesDuringUpdate = true;
            ReturnProviderSpecificTypes = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBase"/> class.
        /// </summary>
        /// <param name="commandFactory">The command factory.</param>
        protected AdapterBase( ICommandFactory commandFactory )
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
        /// Initializes a new instance of the <see cref="AdapterBase"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        protected AdapterBase( ISqlStatement sqlStatement )
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
        /// Gets the sq lite adapter.
        /// </summary>
        /// <returns></returns>
        private protected SQLiteDataAdapter GetSQLiteAdapter( )
        {
            if( Connection != null
               && !string.IsNullOrEmpty( CommandText )  )
            {
                try
                {
                    var _connection = Connection as SQLiteConnection;
                    var _adapter = new SQLiteDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    _adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    _adapter.MissingMappingAction = MissingMappingAction.Passthrough;
                    var _builder = new SQLiteCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand(  );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand(  );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand(  );
                    return _adapter;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SQLiteDataAdapter );
                }
            }
            
            return default( SQLiteDataAdapter );
        }

        /// <summary>
        /// Gets the SQL adapter.
        /// </summary>
        /// <returns></returns>
        private protected SqlDataAdapter GetSqlAdapter( )
        {
            if( Connection != null 
               && !string.IsNullOrEmpty( CommandText )  )
            {
                try
                {
                    var _connection = Connection as SqlConnection;
                    var _adapter = new SqlDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    _adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    _adapter.MissingMappingAction = MissingMappingAction.Passthrough;
                    var _builder = new SqlCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand(  );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand(  );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand(  );
                    return _adapter;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SqlDataAdapter );
                }
            }
            
            return default( SqlDataAdapter );
        }

        /// <summary>
        /// Gets the OLE database adapter.
        /// </summary>
        /// <returns></returns>
        private protected OleDbDataAdapter GetOleDbAdapter( )
        {
            if( Connection != null
               && !string.IsNullOrEmpty( CommandText )  )
            {
                try
                {
                    var _connection = Connection as OleDbConnection;
                    var _adapter = new OleDbDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    _adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    _adapter.MissingMappingAction = MissingMappingAction.Passthrough;
                    var _builder = new OleDbCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand(  );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand(  );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand(  );
                    return _adapter;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( OleDbDataAdapter );
                }
            }
            
            return default( OleDbDataAdapter );
        }

        /// <summary>
        /// Gets the SQL ce adapter.
        /// </summary>
        /// <returns></returns>
        private protected DbDataAdapter GetSqlCeAdapter( )
        {
            if( Connection != null
               && !string.IsNullOrEmpty( CommandText )  )
            {
                try
                {
                    var _connection = Connection as SqlCeConnection;
                    var _adapter = new SqlCeDataAdapter( CommandText, _connection );
                    _adapter.ContinueUpdateOnError = true;
                    _adapter.AcceptChangesDuringFill = true;
                    _adapter.AcceptChangesDuringUpdate = true;
                    _adapter.ReturnProviderSpecificTypes = true;
                    _adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    _adapter.MissingMappingAction = MissingMappingAction.Passthrough;
                    var _builder = new SqlCeCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand(  );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand(  );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand(  );
                    return _adapter;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SqlCeDataAdapter );
                }
            }
            
            return default( SqlCeDataAdapter );
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


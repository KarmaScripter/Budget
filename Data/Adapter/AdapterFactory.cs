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
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DbDataAdapter" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AdapterFactory : AdapterBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterFactory"/> class.
        /// </summary>
        public AdapterFactory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterFactory"/> class.
        /// </summary>
        /// <param name="commandFactory">The commandbuilder.</param>
        public AdapterFactory( ICommandFactory commandFactory )
            : base( commandFactory )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterFactory"/> class.
        /// </summary>
        /// <param name="sqlStatement">The sqlstatement.</param>
        public AdapterFactory( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
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
                        case Provider.SqlCe:
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
                        case Provider.SqlServer:
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
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
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
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbDataAdapter );
                }
            }

            return default( DbDataAdapter );
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
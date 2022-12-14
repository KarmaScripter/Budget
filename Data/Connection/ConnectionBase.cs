// <copyright file = "ConnectionBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class ConnectionBase
    {
        /// <summary>
        /// The connector
        /// </summary>
        public ConnectionStringSettingsCollection ConnectionPath { get; set; } 

        /// <summary>
        /// Gets the client path.
        /// </summary>
        /// <value>
        /// The client path.
        /// </value>
        public NameValueCollection DbClientPath { get; set; } 

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// The provider path
        /// </summary>
        public string DbPath { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The file extension
        /// </summary>
        public EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the path extension.
        /// </summary>
        /// <value>
        /// The path extension.
        /// </value>
        public string PathExtension { get; set; }

        /// <summary>
        /// The file path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The table name
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// The connection string
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionBase"/> class.
        /// </summary>
        protected ConnectionBase( )
        {
            ConnectionPath = ConfigurationManager.ConnectionStrings;
            DbClientPath = ConfigurationManager.AppSettings; 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionBase"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        protected ConnectionBase( string fullPath )
            : this( )
        {
            Source = Source.External;
            FilePath = fullPath;
            FileName = Path.GetFileNameWithoutExtension( fullPath );
            TableName = FileName;
            PathExtension = Path.GetExtension( fullPath )?.Replace( ".", "" );
            if( PathExtension != null )
            {
                Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension.ToUpper( ) );
                Provider = (Provider)Enum.Parse( typeof( Provider ), PathExtension.ToUpper( ) );
                DbPath = DbClientPath[ Extension.ToString( ) ];
                ConnectionString = GetConnectionString( Provider );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionBase"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="provider">The provider.</param>
        protected ConnectionBase( string fullPath, Provider provider )
            : this( )
        {
            Source = Source.External;
            Provider = provider;
            FilePath = fullPath;
            FileName = Path.GetFileNameWithoutExtension( fullPath );
            TableName = FileName;
            PathExtension = Path.GetExtension( fullPath )?.Replace( ".", "" );
            if( PathExtension != null )
            {
                Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension.ToUpper( ) );
                DbPath = DbClientPath[ Extension.ToString( ) ];
                ConnectionString = GetConnectionString( Provider );
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        protected ConnectionBase( Source source, Provider provider = Provider.Access ) 
            : this( )
        {
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            ConnectionString = GetConnectionString( provider );
            FilePath = GetDbClientPath( provider );
            PathExtension = Path.GetExtension( FilePath )?.Replace( ".", "" );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
            if( !string.IsNullOrEmpty( PathExtension ) )
            {
                Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension.ToUpper( ) );
                DbPath = DbClientPath[ Extension.ToString( ) ];
            }
        }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private protected string GetDbClientPath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    return provider switch
                    {
                        Provider.Access => DbClientPath[ "ACCDB" ],
                        Provider.SQLite => DbClientPath[ "DB" ],
                        Provider.SqlCe => DbClientPath[ "SDF" ],
                        Provider.Excel => DbClientPath[ "XLSX" ],
                        Provider.SqlServer => DbClientPath[ "MDF" ],
                        Provider.CSV => DbClientPath[ "CSV" ],
                        _ => DbClientPath[ "ACCDB" ]
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }
        
        /// <summary>
        /// Sets the provider path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        private protected string GetDbClientPath( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && Path.HasExtension( filePath ) )
            {
                try
                {
                    var _file = Path.GetExtension( filePath )?.Replace( ".", "" );
                    if( !string.IsNullOrEmpty( _file ) )
                    {
                        var _ext = (EXT)Enum.Parse( typeof( EXT ), _file.ToUpper( ) );
                        var _names = Enum.GetNames( typeof( EXT ) );
                        if( _names?.Contains( _ext.ToString( ) ) == true )
                        {
                            var _clientPath = DbClientPath[ $"{ _ext }" ];
                            return !string.IsNullOrEmpty( _clientPath )
                                ? _clientPath
                                : string.Empty;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the connection string.
        /// </summary>
        /// <param name="provider">The provider.</param>
        private protected virtual string GetConnectionString( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider )
               && !string.IsNullOrEmpty( FilePath ) )
            {
                try
                {
                    var _connection = ConnectionPath[ provider.ToString( ) ]?.ConnectionString;
                    return !string.IsNullOrEmpty( _connection )
                        ? _connection?.Replace( "{FilePath}", FilePath )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private protected virtual string GetConnectionString( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath )
               && Path.HasExtension( filePath ) )
            {
                try
                {
                    var _file = Path.GetExtension( filePath );
                    if( _file != null )
                    {
                        var _ext = (EXT)Enum.Parse( typeof( EXT ), _file.ToUpper( ) );
                        var _names = Enum.GetNames( typeof( EXT ) );
                        if( _names?.Contains( _ext.ToString( ) ) == true )
                        {
                            var _connectionString = ConnectionPath[ $"{_ext}" ].ConnectionString;
                            return !string.IsNullOrEmpty( _connectionString )
                                ? _connectionString
                                : string.Empty;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
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
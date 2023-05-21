// <copyright file = "FolderBase.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Security.AccessControl;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class FolderBase
    {
        /// <summary>
        /// Gets or sets the buffer.
        /// </summary>
        /// <value>
        /// The buffer.
        /// </value>
        public virtual string Buffer { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public virtual string FullName { get; set; }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public virtual string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the modified.
        /// </summary>
        /// <value>
        /// The modified.
        /// </value>
        public virtual DateTime Modified { get; set; }

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public virtual DirectoryInfo Parent { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the sub files.
        /// </summary>
        /// <value>
        /// The sub files.
        /// </value>
        public virtual IEnumerable<string> SubFiles { get; set; }

        /// <summary>
        /// Gets or sets the sub folders.
        /// </summary>
        /// <value>
        /// The sub folders.
        /// </value>
        public virtual IEnumerable<string> SubFolders { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        public virtual DirectorySecurity Security { get; set; }

        /// <summary>
        /// Gets the sub file data.
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, FileInfo> GetSubFileData( )
        {
            if( !string.IsNullOrEmpty( FullPath ) )
            {
                try
                {
                    var _data = new Dictionary<string, FileInfo>( );
                    foreach( var file in SubFiles )
                    {
                        var _name = Path.GetFileNameWithoutExtension( file );
                        var _file = new FileInfo( file );
                        _data.Add( _name, _file );
                    }

                    return _data?.Any( ) == true
                        ? _data
                        : default( IDictionary<string, FileInfo> );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, FileInfo> );
                }
            }

            return default( IDictionary<string, FileInfo> );
        }

        /// <summary>
        /// Gets the special folders.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSpecialFolders( )
        {
            try
            {
                var _folders = Enum.GetNames( typeof( Environment.SpecialFolder ) );
                return _folders?.Any( ) == true
                    ? _folders
                    : default( string[ ] );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the sub directory data.
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, DirectoryInfo> GetSubDirectoryData( )
        {
            try
            {
                var _data = new Dictionary<string, DirectoryInfo>( );
                foreach( var file in SubFolders )
                {
                    var _name = Path.GetDirectoryName( file );
                    var _folder = new DirectoryInfo( file );
                    _data.Add( _name, _folder );
                }

                return _data?.Any( ) != true
                    ? _data
                    : default( IDictionary<string, DirectoryInfo> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, DirectoryInfo> );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBase"/> class.
        /// </summary>
        protected FolderBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        protected FolderBase( string input )
        {
            Buffer = input;
            FullPath = Path.GetFullPath( input );
            Name = Path.GetDirectoryName( input );
            FullName = new DirectoryInfo( FullPath ).FullName;
            Created = new DirectoryInfo( FullPath ).CreationTime;
            Modified = new DirectoryInfo( FullPath ).LastWriteTime;
            Parent = new DirectoryInfo( FullPath ).Parent;
            SubFiles = Directory.GetFiles( input );
            SubFolders = Directory.GetDirectories( input );
            Security = new DirectorySecurity( FullPath, AccessControlSections.Access );
        }
    }
}
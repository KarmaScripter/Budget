// <copyright file = "FileBase.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.PathBase" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class FileBase : PathBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileBase"/> class.
        /// </summary>
        public FileBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public FileBase( string input )
            : base( input )

        {
        }

        /// <summary>
        /// Moves the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public virtual void Move( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    var _source = new FileInfo( FullPath );
                    _source.MoveTo( filePath );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Copies the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public virtual void Copy( string filePath )
        {
            try
            {
                if( !string.IsNullOrEmpty( filePath )
                   && File.Exists( filePath ) )
                {
                    var _source = new FileInfo( FullPath );
                    _source.CopyTo( filePath );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public virtual void Delete( )
        {
            try
            {
                var _file = Path.GetFullPath( Buffer );
                if( !string.IsNullOrEmpty( _file )
                   && File.Exists( _file ) )
                {
                    File.Delete( _file );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the file security.
        /// </summary>
        /// <returns></returns>
        public FileSecurity GetFileSecurity( )
        {
            try
            {
                return FileSecurity ?? default( FileSecurity );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( FileSecurity );
            }
        }

        /// <summary>
        /// Gets the base stream.
        /// </summary>
        /// <returns></returns>
        public FileStream GetBaseStream( )
        {
            try
            {
                var _path = Path.GetFullPath( Buffer );
                return !string.IsNullOrEmpty( _path ) && File.Exists( _path )
                    ? new FileInfo( _path )?.Create( )
                    : default( FileStream );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileStream );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( Buffer )
                    ? Path.GetFullPath( Buffer )
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}
﻿// <copyright file = "IFolder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    public interface IFolder
    {
        /// <summary>
        /// Creates the sub directory.
        /// </summary>
        /// <param name="folderName">The folderName.</param>
        /// <returns></returns>
        DirectoryInfo CreateSubDirectory( string folderName );

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        IDictionary<string, FileInfo> GetSubFileData( );

        /// <summary>
        /// Moves the specified fullName.
        /// </summary>
        /// <param name="path">The fullName.</param>
        void Move( string path );

        /// <summary>
        /// Sets the access control.
        /// </summary>
        /// <param name="security">The security.</param>
        void SetAccessControl( DirectorySecurity security );

        /// <summary>
        /// Zips the specified destination.
        /// </summary>
        /// <param name="destination">The destination.</param>
        void Zip( string destination );

        /// <summary>
        /// Uns the zip.
        /// </summary>
        /// <param name="zipPath">The zipPath.</param>
        void UnZip( string zipPath );

        /// <summary>
        /// Gets the special folders.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetSpecialFolders( );
        
        /// <summary>
        /// Gets the sub folders.
        /// </summary>
        /// <returns></returns>
        IDictionary<string, DirectoryInfo> GetSubDirectoryData( );
    }
}
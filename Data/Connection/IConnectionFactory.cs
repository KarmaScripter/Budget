// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution;

using System.Collections.Specialized;
using System.Configuration;
using System.Data.Common;

/// <summary>
/// 
/// </summary>
public interface IConnectionFactory
{
    /// <summary>
    /// Gets the connection.
    /// </summary>
    /// <returns></returns>
    DbConnection GetConnection( );

    /// <summary>
    /// The connector
    /// </summary>
    ConnectionStringSettingsCollection ConnectionPath { get; set; }

    /// <summary>
    /// Gets the client path.
    /// </summary>
    /// <value>
    /// The client path.
    /// </value>
    NameValueCollection DbClientPath { get; set; }

    /// <summary>
    /// Gets or sets the connection.
    /// </summary>
    /// <value>
    /// The connection.
    /// </value>
    DbConnection Connection { get; set; }

    /// <summary>
    /// The provider path
    /// </summary>
    string DbPath { get; set; }

    /// <summary>
    /// The source
    /// </summary>
    Source Source { get; set; }

    /// <summary>
    /// The provider
    /// </summary>
    Provider Provider { get; set; }

    /// <summary>
    /// The file extension
    /// </summary>
    EXT Extension { get; set; }

    /// <summary>
    /// Gets or sets the path extension.
    /// </summary>
    /// <value>
    /// The path extension.
    /// </value>
    string PathExtension { get; set; }

    /// <summary>
    /// The file path
    /// </summary>
    string FilePath { get; set; }

    /// <summary>
    /// The file name
    /// </summary>
    string FileName { get; set; }

    /// <summary>
    /// The table name
    /// </summary>
    string TableName { get; set; }

    /// <summary>
    /// The connection string
    /// </summary>
    string ConnectionString { get; set; }
}
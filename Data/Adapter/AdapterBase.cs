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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
    }
}


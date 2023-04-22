// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using Google.Apis.Customsearch.v1;
    using Google.Apis.Services;
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Global" ) ]
    public class GoogleSearch
    {
        /// <summary>
        /// Gets the search configuration.
        /// </summary>
        /// <value>
        /// The search configuration.
        /// </value>
        public NameValueCollection Config { get; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public string Query { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch"/> class.
        /// </summary>
        public GoogleSearch( )
        {
            Config = ConfigurationManager.AppSettings;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the
        /// <see cref="GoogleSearch"/> class.
        /// </summary>
        /// <param name = "keywords" >
        /// </param>
        public GoogleSearch( string keywords )
        {
            Config = ConfigurationManager.AppSettings;
            Query = keywords;
        }
        
        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <returns></returns>
        public List<ResultData> GetResults( )
        {
            if( !string.IsNullOrEmpty( Query ) )
            {
                try
                {
                    var _count = 0;
                    var _data = new List<ResultData>( );
                    var _initializer = new BaseClientService.Initializer( );
                    _initializer.ApiKey = Config[ "ApiKey" ];
                    var _search = new CustomsearchService( _initializer );
                    var _request = _search?.Cse?.List( );
                    _request.Q = Query;
                    _request.Cx = Config[ "SearchEngineId" ];
                    _request.Start = _count;
                    var _list = _request.Execute( )
                        ?.Items
                        ?.ToList( );

                    for( var i = 0; i < _list.Count; i++ )
                    {
                        var _results = new ResultData( );
                        _results.Content = _list[ i ].Snippet;
                        _results.Link = _list[ i ].Link;
                        _results.Title = _list[ i ].Title;
                        _results.Name = _list[ i ].HtmlTitle;
                        _data.Add( _results );
                    }

                    return _data?.Any( ) == true
                        ? _data
                        : default( List<ResultData> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( List<ResultData> );
                }
            }

            return default( List<ResultData> );
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
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
    using System.Linq;
    using Google.Apis.Customsearch.v1.Data;

    /// <summary>
    /// 
    /// </summary>
    public class GoogleSearch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch"/> class.
        /// </summary>
        public GoogleSearch( )
        {
        }

        /// <summary>
        /// Extracts the custom search data.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        public List<ResultDataModel> ExtractCustomSearchData( string searchText )
        {
            const string apiKey = "AIzaSyBsfbY19GJMzr3MXqr6MhJ4YKDfhv4QNkw";
            const string searchEngineId = "a2f030f4bfacb4008";
            var customSearchService =
                new CustomsearchService( new BaseClientService.Initializer { ApiKey = apiKey } );

            var listRequest = customSearchService.Cse.List( searchText );
            listRequest.Cx = searchEngineId;
            var paging = new List<Result>( );
            var dataModel = new List<ResultDataModel>( );
            var count = 0;
            while( dataModel != null )
            {
                Console.WriteLine( $"Page {count}" );
                listRequest.Start = count;
                listRequest.Execute( ).Items?.ToList( ).ForEach( x =>
                    dataModel.Add( new ResultDataModel
                    {
                        Content = x.Snippet,
                        Link = x.Link,
                        Title = x.Title,
                        Name = x.HtmlTitle
                    } ) );

                if( paging != null )
                {
                    foreach( var item in paging )
                    {
                        Console.WriteLine( "Title : " + item.Title + Environment.NewLine + "Link : "
                            + item.Link + Environment.NewLine + Environment.NewLine );

                        count++;
                        if( count >= 10 )
                        {
                            break;
                        }
                    }
                }
            }

            return dataModel;
        }
    }
}
// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// 
    /// </summary>
    public partial class SqlDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        /// <summary>
        /// Gets or sets the frames.
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        public IEnumerable<Frame> Frames { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        public SqlDialog( )
        {
            InitializeComponent( );
            
            // Basic Properties
            Size = new Size( 1380, 600 );
            TabPage.TabFont = new Font( "Roboto", 9, FontStyle.Bold );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            SelectButton.Text = "Save";
            CloseButton.Text = "Exit";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="bindingSource">The binding source.</param>
        public SqlDialog( ToolType toolType, BindingSource bindingSource ) 
            : this( )
        {
            ToolType = toolType;
            BindingSource = bindingSource;
            DataTable = BindingSource.GetDataTable(  );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider.Access );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public SqlDialog( ToolType toolType, Source source, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = toolType;
            Provider = provider;
            Source = source;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Sets the active tab.
        /// </summary>
        public void SetActiveTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    switch( ToolType )
                    {
                        case ToolType.EditSqlButton:
                        {
                            TabPage.Text = "Sql Editor";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.InsertButton:
                        {
                            TabPage.Text = "SQL Insert";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.UpdateButton:
                        {
                            TabPage.Text = "SQL Update";
                            ActiveTab = TabPage;
                            break;
                        }
                        case ToolType.EditRecordButton:
                        {
                            TabPage.Text = "Edit Record";
                            ActiveTab = TabPage;
                            break;
                        }
                        default:
                        {
                            TabPage.Text = "Sql Editor";
                            ActiveTab = TabPage;
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
    
}

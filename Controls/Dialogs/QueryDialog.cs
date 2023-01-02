// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class QueryDialog : MetroForm
    {
        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }
        
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }
        
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }
        
        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }
        
        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

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
        /// Initializes a new instance
        /// of the <see cref="BudgetExecution.QueryDialog"/> class.
        /// </summary>
        public QueryDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 900, 500 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // ListBox Properties
            FirstListBox.MultiSelect = false;
            SecondListBox.MultiSelect = true;
            ThirdListBox.MultiSelect = true;
            
            // TableProperties
            FirstTable.Location = new Point( 12, 12 );
            FirstTable.Size = new Size( 280, 376 );
            FirstTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            FirstTable.Visible = true;
            SecondTable.Location = new Point( 306, 12 );
            SecondTable.Size = new Size( 280, 376 );
            SecondTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            SecondTable.Visible = true;
            ThirdTable.Location = new Point( 598, 12 );
            ThirdTable.Size = new Size( 280, 376 );
            ThirdTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            ThirdTable.Visible = true;
            
            // Button Properties
            FirstButton.Size = new Size( 160, 55 );
            FirstButton.Location = new Point( 30, 400 );
            SecondButton.Size = new Size( 160, 55 );
            SecondButton.Location = new Point( 352, 400 );
            ThirdButton.Size = new Size( 160, 55 );
            ThirdButton.Location = new Point( 670, 400 );
            
            // Event Wiring
            Load += OnLoad;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryDialog"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public QueryDialog( BindingSource bindingSource ) 
            : this( )
        {
            BindingSource = bindingSource;
        }
        
        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                ThirdButton.Click += OnCloseButtonClicked;
                SecondListBox.MultiSelect = true;
                ThirdListBox.MultiSelect = true;
                PopulateFirstListBoxItems(  );
                DataTable = (DataTable)BindingSource.DataSource;
                Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
                DataModel = new DataBuilder( Source, Provider.Access );
                Fields = DataModel.Fields;
                Numerics = DataModel.Numerics;
                PopulateSecondListBox(  );
                PopulateThirdListBoxItems( );
                SetLabelConfiguration( );
                FirstListBox.SelectedValue = $"{ Source }";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the label configuration.
        /// </summary>
        private void SetLabelConfiguration( )
        {
            try
            {
                var _tableText = "Tables: " + FirstListBox.Items.Count;
                var _selected = _tableText + "  Selected:  " + DataModel.TableName;
                FirstLabel.Text = "Tables: " + FirstListBox.Items.Count;
                SecondLabel.Text = "Fields: " + SecondListBox.Items?.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the table ListBox.
        /// </summary>
        private void PopulateFirstListBoxItems( )
        {
            try
            {
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData(  );
                var _names = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList(  );
            
                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    FirstListBox.Items.Add( name );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFirstListBoxItemSelected( object sender )
        {
            try
            {
                if( FormFilter?.Keys?.Count > 0 )
                {
                    FormFilter.Clear( );
                }
                
                BindingSource.DataSource = null;
                SqlQuery = string.Empty;
                SecondListBox.Items?.Clear( );
                ThirdListBox.Items?.Clear( );
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedValue?.ToString( );
                SelectedTable = _value;
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    SelectedTable = DataModel.DataTable?.TableName;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    PopulateSecondListBox( );
                    PopulateThirdListBoxItems( );
                }
                
                SetLabelConfiguration(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the column ListBox.
        /// </summary>
        private void PopulateSecondListBox( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    Fields = DataModel.Fields;
                    foreach( var col in Fields )
                    {
                        SecondListBox.Items.Add( col );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [column ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSecondListBoxItemSelected( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the numeric ListBox.
        /// </summary>
        private void PopulateThirdListBoxItems( )
        {
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    foreach( var col in Numerics )
                    {
                        ThirdListBox.Items.Add( col );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [numeric ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnThirdListBoxItemSelected( object sender, EventArgs e )
        {
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    foreach( var col in Numerics )
                    {
                        ThirdListBox.Items.Add( col );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}



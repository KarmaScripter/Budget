// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

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
    using Syncfusion.Windows.Forms.Chart;
    using System.Drawing;
    using DocumentFormat.OpenXml.Office2010.Excel;
    using SQLite.Designer;
    using Color = System.Drawing.Color;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public partial class ChartForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the first selected item.
        /// </summary>
        /// <value>
        /// The first selected item.
        /// </value>
        public string FirstCategory { get; set; }

        /// <summary>
        /// Gets or sets the first value.
        /// </summary>
        /// <value>
        /// The first value.
        /// </value>
        public string FirstValue { get; set; }

        /// <summary>
        /// Gets or sets the second selected item.
        /// </summary>
        /// <value>
        /// The second selected item.
        /// </value>
        public string SecondCategory { get; set; }

        /// <summary>
        /// Gets or sets the second value.
        /// </summary>
        /// <value>
        /// The second value.
        /// </value>
        public string SecondValue { get; set; }
        
        /// <summary>
        /// Gets or sets the third selected item.
        /// </summary>
        /// <value>
        /// The third selected item.
        /// </value>
        public string ThirdCategory { get; set; }

        /// <summary>
        /// Gets or sets the third value.
        /// </summary>
        /// <value>
        /// The third value.
        /// </value>
        public string ThirdValue { get; set; }

        /// <summary>
        /// Gets or sets the fourth category.
        /// </summary>
        /// <value>
        /// The fourth category.
        /// </value>
        public string FourthCategory { get; set; }

        /// <summary>
        /// Gets or sets the fourth value.
        /// </summary>
        /// <value>
        /// The fourth value.
        /// </value>
        public string FourthValue { get; set; }
        
        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the x axis.
        /// </summary>
        /// <value>
        /// The x axis.
        /// </value>
        public string xAxis { get; set; }

        /// <summary>
        /// Gets or sets the y axis.
        /// </summary>
        /// <value>
        /// The y axis.
        /// </value>
        public string yAxis { get; set; }
        
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
        public SortedDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IEnumerable<string> Fields { get; set; }

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
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        public ChartForm( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size( 1400, 800 );
            MaximumSize = new Size( 1400, 800 );
            MinimumSize = new Size( 1400, 750  );
            FormBorderStyle = FormBorderStyle.Sizable;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Event Wiring
            Load += OnLoad;
            FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
            SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
            SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
            ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
            ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
            FourthComboBox.SelectedValueChanged += OnFourthComboBoxItemSelected;
            FourthListBox.SelectedValueChanged += OnFourthListBoxItemSelected;
            RemoveFiltersButton.Click += OnRemoveFilterButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
        }
        
        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">
        /// The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                FormFilter = new SortedDictionary<string, object>( );
                BackButton.Click += OnBackButtonClicked;
                ToolStrip.Office12Mode = true;
                ToolStrip.Text = string.Empty;
                Header.Text = string.Empty;
                Chart.ChartArea.BorderStyle = BorderStyle.None;
                SecondTable.Visible = !SecondTable.Visible;
                ThirdTable.Visible = !ThirdTable.Visible;
                FourthTable.Visible = !FourthTable.Visible;
                InitData(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        private void InitData( )
        {
            if( BindingSource != null )
            {
                try
                {
                    DataTable = (DataTable)BindingSource.DataSource;
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    ToolStrip.BindingSource.DataSource = BindingSource.DataSource;
                    Chart.BindingSource = BindingSource;
                    Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
                    Chart.Title.Text = $"{ Source.ToString( ).SplitPascal( ) }";
                    Provider = Provider.Access;
                    DataModel = new DataBuilder( Source, Provider );
                    Fields = DataModel.Fields;
                    PopulateToolBarDropDownItems( );
                    PopulateFirstComboBoxItems( );
                    SqlQuery = string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                } 
            } 
        }
        
        /// <summary>
        /// Populates the tool bar drop down items.
        /// </summary>
        private void PopulateToolBarDropDownItems( )
        {
            try
            {
                var _names = Enum.GetNames( typeof( ChartSeriesType ) );
                for( var _i = 0; _i < _names.Length; _i++ )
                {
                    var name = _names[ _i ];
                    if( name != "NS" )
                    {
                        DropDown.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button 
                   && _button.ToolType == ToolType.BackButton )
                {
                    Close(  );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [remove filter button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnRemoveFilterButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button 
                   && _button.ToolType == ToolType.RemoveFiltersButton )
                {
                    ClearFilterSelections(  );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the first ComboBox items.
        /// </summary>
        private void PopulateFirstComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    foreach( var item in Fields )
                    {
                        FirstComboBox.Items.Add( item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [first ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void OnFirstComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    Header.Text = string.Empty;
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    if( FirstListBox.Items.Count > 0 )
                    {
                        FirstListBox.Items.Clear(  );
                    }
                    
                    var _filter = _comboBox.SelectedItem.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FirstCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            FirstListBox.Items.Add( item );
                        }
                    }

                    SecondTable.Visible = false;
                    ThirdTable.Visible = false;
                    FourthTable.Visible = false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [first filter selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }
                    
                    FirstValue = _listBox?.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    PopulateSecondComboBoxItems(  );
                    SecondTable.Visible = !SecondTable.Visible;
                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }

                    if( FourthTable.Visible == true )
                    {
                        FourthTable.Visible = false;
                    }

                    SqlQuery = CreateSqlText( FormFilter );
                    Header.Text = SqlQuery;
                    ThirdTable.Visible = false;
                    FourthTable.Visible = false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the second ComboBox items.
        /// </summary>
        private void PopulateSecondComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) )
                            {
                                SecondComboBox.Items.Add( item );
                            }
                        }
                    }
                    else
                    {
                        foreach( var item in Fields )
                        {
                            SecondComboBox.Items.Add( item );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [second ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void OnSecondComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    Header.Text = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    if( SecondListBox.Items.Count > 0 )
                    {
                        SecondListBox.Items.Clear(  );
                    }

                    var _filter = _comboBox.SelectedItem.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        SecondCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            SecondListBox.Items.Add( item );
                        }
                    }
                    
                    ThirdTable.Visible = false;
                    FourthTable.Visible = false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [second filter selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnSecondListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    PopulateThirdComboBoxItems(  );
                    if( ThirdTable.Visible == false )
                    {
                        ThirdTable.Visible = true;
                    }
                    
                    FourthTable.Visible = false;
                    SqlQuery = CreateSqlText( FormFilter );
                    Header.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Populates the third ComboBox items.
        /// </summary>
        private void PopulateThirdComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) 
                       && !string.IsNullOrEmpty( SecondValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) 
                               && !item.Equals( SecondCategory ) )
                            {
                                ThirdComboBox.Items.Add( item );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [third ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    Header.Text = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    if( ThirdListBox.Items.Count > 0 )
                    {
                        ThirdListBox.Items.Clear(  );
                    }
                    
                    var _filter = _comboBox?.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        ThirdCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            ThirdListBox.Items.Add( item );
                        }
                    }

                    FourthTable.Visible = false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third filter selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnThirdListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    ThirdValue = _listBox?.SelectedValue?.ToString( );
                    PopulateFourthComboBoxItems(  );
                    if( FourthTable.Visible == false )
                    {
                        FourthTable.Visible = true;
                    }
                    
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    SqlQuery = CreateSqlText( FormFilter );
                    Header.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the fourth ComboBox items.
        /// </summary>
        public void PopulateFourthComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) 
                       && !string.IsNullOrEmpty( SecondValue ) 
                       && !string.IsNullOrEmpty( ThirdValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) 
                               && !item.Equals( SecondCategory ) 
                               && !item.Equals( ThirdCategory ) )
                            {
                                FourthComboBox.Items.Add( item );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [fourth ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnFourthComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    Header.Text = string.Empty;
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    if( FourthListBox.Items.Count > 0 )
                    {
                        FourthListBox.Items.Clear(  );
                    }
                    
                    var _filter = _comboBox.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FourthCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            FourthListBox.Items.Add( item );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [fourth ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnFourthListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FourthValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    FormFilter.Add( ThirdCategory, ThirdValue  );
                    FormFilter.Add( FourthCategory, FourthValue  );
                    SqlQuery = CreateSqlText( FormFilter );
                    Header.Text = SqlQuery;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Clears the selected filter values.
        /// </summary>
        private void ClearFilterSelections( )
        {
            try
            {
                SqlQuery = string.Empty;
                Header.Text = string.Empty;
                if( FormFilter.Keys.Count > 0 )
                {
                    FormFilter.Clear( );
                }
                
                if( !string.IsNullOrEmpty( FourthValue ) )
                {
                    FourthComboBox.Items.Clear( );
                    FourthListBox.Items.Clear( );
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    FourthTable.Visible = !FourthTable.Visible;
                } 
                
                if( !string.IsNullOrEmpty( ThirdValue ) )
                {
                    ThirdComboBox.Items.Clear( );
                    ThirdListBox.Items.Clear( );
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    ThirdTable.Visible = !ThirdTable.Visible;
                }
                
                if( !string.IsNullOrEmpty( SecondValue ) )
                {
                    SecondComboBox.Items.Clear( );
                    SecondListBox.Items.Clear( );
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    SecondTable.Visible = !SecondTable.Visible;
                }
                
                if( !string.IsNullOrEmpty( FirstValue ) )
                {
                    FirstComboBox.Items.Clear( );
                    FirstListBox.Items.Clear( );
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                }
                
                PopulateFirstComboBoxItems(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the SQL text.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true )
            {
                try
                {
                    return $"SELECT * FROM { Source } "
                        + $"WHERE { where.ToCriteria(  ) };";
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
        /// Sets the label configuration.
        /// </summary>
        private void SetLabelConfiguration( )
        {
            try
            {
                Header.Text = "Chart";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Fails the specified ex.
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
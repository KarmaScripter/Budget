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
    using CheckState = MetroSet_UI.Enums.CheckState;
    using DataTable = System.Data.DataTable;
    using Size = System.Drawing.Size;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    public partial class FilterDialog : MetroForm
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
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }
        
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
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IEnumerable<string> Numerics { get; set; }
        
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
        /// Initializes a new instance of the <see cref="FilterDialog"/> class.
        /// </summary>
        public FilterDialog( )
        {
            InitializeComponent( );
            
            // Basic Properties
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Size = new Size( 874, 472 );
            
            // Event Wiring
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
            FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
            FirstButton.Click += OnFirstButtonClick;
            SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
            SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
            SecondButton.Click += OnSecondButtonClick;
            ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
            ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
            ThirdButton.Click += OnThirdButtonClick;
            AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
            SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
            SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
        }
        
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="FilterDialog"/> class.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <param name="provider">
        /// The provider.
        /// </param>
        public FilterDialog( Source source, Provider provider ) 
            : this( )
        {
            Source = source;
            Provider = provider;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataTable;
            Fields = DataModel.Fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterDialog"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public FilterDialog( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/> instance containing
        /// the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SqlQuery = string.Empty;
                FormFilter = new Dictionary<string, object>( );
                if( BindingSource.DataSource != null )
                {
                    var _text = $"{ DataTable.TableName } Filter";
                    Text = $"{ _text.SplitPascal( ) } Filter";
                    SetLabelConfiguration( );
                    FirstButton.Visible = !FirstButton.Visible;
                    SecondButton.Visible = !SecondButton.Visible;
                    TabControl.SelectedTab = FilterTab;
                    Provider = DataModel.Provider;
                    Source = DataModel.Source;
                }
                else
                {
                    TabControl.SelectedTab = TableTab;
                    PopulateTableListBoxItems( );
                    Text = "Select Data Source";
                    AccessRadioButton.Checked = true;
                    Provider = Provider.Access;
                    Source = Source.ApplicationTables;
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [RadioButton checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRadioButtonChecked( object sender )
        {
            if( sender is RadioButton _radio 
               && _radio.Tag != null )
            {
                try
                {
                    var _tag = _radio.Tag.ToString(  );

                    if ( !string.IsNullOrEmpty( _tag ) )
                    {
                        Provider = (Provider)Enum.Parse( typeof( Provider ), _tag  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Binds the data source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        private void BindDataSource( Source source, Provider provider, 
            IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), source )
               && Enum.IsDefined( typeof( Provider ), provider )
               && where?.Any( ) == true )
            {
                try
                {
                    Source = source;
                    Provider = provider;
                    DataModel = new DataBuilder( source, provider, where );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataModel.DataTable;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData(  );
                var _names = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( r => r.Field<string>( "TableName" ) )?.ToList(  );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var name = _names[ _i ];
                    TableListBox.Items.Add( name );
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
        public void OnTableListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    TabControl.SelectedTab = FilterTab;
                    SelectedTable = _listBox.SelectedValue?.ToString( );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        BindingSource.DataSource = null;
                        Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                        DataModel = new DataBuilder( Source, Provider );
                        DataTable = DataModel.DataTable;
                        BindingSource.DataSource = DataModel.DataTable;
                        Fields = DataModel.Fields;
                        Numerics = DataModel.Numerics;
                        PopulateFirstComboBoxItems( );
                        if( FirstTable.Visible == false )
                        {
                            FirstTable.Visible = true;
                        }

                        if( SecondTable.Visible == true )
                        {
                            SecondTable.Visible = false;
                        }

                        if( ThirdTable.Visible == true )
                        {
                            ThirdTable.Visible = false;
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
        /// Populates the first como box items.
        /// </summary>
        public void PopulateFirstComboBoxItems( )
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnFirstComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items.Clear(  );
                    }

                    var _filter = _comboBox.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FirstCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            FirstListBox?.Items?.Add( item );
                        }
                        
                        SetLabelConfiguration(  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [first item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        public void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FirstValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    PopulateSecondComboBoxItems( );
                    if( SecondTable.Visible == false )
                    {
                        SecondTable.Visible = true;
                    }

                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Populates the second como box items.
        /// </summary>
        public void PopulateSecondComboBoxItems( )
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

                    SecondComboBox.SelectedIndex = -1;
                    SetLabelConfiguration(  );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [second item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSecondComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( SecondListBox.Items.Count > 0 )
                    {
                        SecondListBox.Items.Clear(  );
                    }

                    var _filter = _comboBox.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        SecondCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            SecondListBox.Items.Add( item );
                        }
                        
                        SetLabelConfiguration(  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [second ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        public void OnSecondListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys?.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    PopulateThirdComboBoxItems(  );
                    if( ThirdTable.Visible != true )
                    {
                        ThirdTable.Visible = true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Populates the third como box items.
        /// </summary>
        public void PopulateThirdComboBoxItems( )
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

                        ThirdComboBox.SelectedIndex = -1;
                        SetLabelConfiguration(  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third item selected].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( ThirdListBox.Items.Count > 0 )
                    {
                        ThirdListBox.Items.Clear(  );
                    }

                    var _filter = _comboBox.SelectedItem?.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        ThirdCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            ThirdListBox.Items.Add( item );
                        }
                        
                        SetLabelConfiguration(  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third ListBox item selected].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        public void OnThirdListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    ThirdValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue  );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    SqlQuery = $"SELECT * FROM { Source } "
                        + $"WHERE { FormFilter.ToCriteria(  ) };";
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
                if( FormFilter.Keys.Count > 0 )
                {
                    FormFilter.Clear( );
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
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnFirstButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    if( FormFilter?.Any( ) == true )
                    {
                        FormFilter.Clear(  );
                        FirstCategory = null;
                        FirstValue = null;
                        FirstComboBox.Items.Clear( ); 
                        FirstListBox.Items.Clear( );
                        SecondCategory = null;
                        SecondValue = null;
                        SecondComboBox.Items.Clear( );
                        SecondListBox.Items.Clear( );
                        ThirdCategory = null;
                        ThirdValue = null;
                        ThirdComboBox.Items.Clear( );
                        ThirdListBox.Items.Clear(  );
                        FirstButton.Visible = !FirstButton.Visible;
                        SecondButton.Visible = !SecondButton.Visible;
                        SecondTable.Visible = false;
                        ThirdTable.Visible = false;
                        PopulateFirstComboBoxItems(  );
                        SetLabelConfiguration(  );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [select button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnSecondButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    var _message = "NOT YET IMPLEMENTED!";
                    var _notification = new Notification( _message );
                    _notification.Show( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third button click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnThirdButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
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
        }

        /// <summary>
        /// Called when [select button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnSelectButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button _button )
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
        }

        /// <summary>
        /// Sets the label configuration.
        /// </summary>
        private void SetLabelConfiguration( )
        {
            try
            {
                FirstLabel.Text = "Columns : " + FirstComboBox.Items.Count;
                SecondLabel.Text = "Columns : " + SecondComboBox.Items.Count;
                ThirdLabel.Text = "Columns : " + ThirdComboBox.Items.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
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

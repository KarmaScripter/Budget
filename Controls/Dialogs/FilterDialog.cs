﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using DataTable = System.Data.DataTable;
    using Size = System.Drawing.Size;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
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
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = true;
            MinimizeBox = false;
            MaximizeBox = false;
            Size = new Size( 887, 470 );
            
            // Event Wiring
            Load += OnLoad;
            FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
            FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
            FirstButton.Click += OnFirstButtonClick;
            SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
            SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
            SecondButton.Click += OnSecondButtonClick;
            ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
            ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
            ThirdButton.Click += OnThirdButtonClick;
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
                Text = $"{ DataTable.TableName.SplitPascal( ) } Data";
                PopulateFirstComoBoxItems(  );
                FirstButton.Visible = false;
                SecondButton.Visible = false;
                SecondFilterTable.Visible = false;
                ThirdFilterTable.Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the first como box items.
        /// </summary>
        public void PopulateFirstComoBoxItems( )
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
                    var _filter = _comboBox.SelectedItem.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FirstCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            FirstListBox.Items.Add( item );
                        }
                    
                        FirstLabel.Text = "Available Values : " 
                            + FirstComboBox.Items.Count;
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
                    FirstValue = _listBox.SelectedValue.ToString( );
                    PopulateSecondComoBoxItems(  );
                    SecondFilterTable.Visible = true;
                    FirstButton.Visible = true;
                    SecondButton.Visible = true;
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
        public void PopulateSecondComoBoxItems( )
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
                    var _filter = _comboBox.SelectedItem.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        SecondCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            SecondListBox.Items.Add( item );
                        }
                        
                        SecondLabel.Text = "Available Values : " 
                            + SecondListBox.Items.Count;
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
                    SecondValue = _listBox.SelectedValue.ToString( );
                    PopulateThirdComoBoxItems(  );
                    ThirdFilterTable.Visible = true;
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
        public void PopulateThirdComoBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) 
                       && !string.IsNullOrEmpty( SecondValue) )
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
                    var _filter = _comboBox.SelectedItem.ToString(  );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        ThirdCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var item in _data )
                        {
                            ThirdListBox.Items.Add( item );
                        }
                        
                        ThirdLabel.Text = "Available Values : " 
                            + ThirdListBox.Items.Count;
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
                    ThirdValue = _listBox.SelectedValue.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
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

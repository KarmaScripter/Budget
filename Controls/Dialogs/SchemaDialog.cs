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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class SchemaDialog : MetroForm
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
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns { get; set; }

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
        /// Initializes a new
        /// instance of the <see cref="SchemaDialog"/> class.
        /// </summary>
        public SchemaDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 704, 541 );
            StartPosition = FormStartPosition.CenterScreen;
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
            
            // ListBox Properties
            FirstListBox.MultiSelect = true;
            SecondListBox.MultiSelect = true;
            
            // TableProperties
            FirstTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            FirstTable.Visible = true;
            SecondTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            
            // Event Wiring
            Load += OnLoad;
            FirstListBox.SelectedValueChanged += OnFirstListBoxSelectedValueChanged;
            SecondListBox.SelectedValueChanged += OnSecondListBoxSelectedValueChanged;
            FirstButton.Click += OnFirstButtonClicked;
            SecondButton.Click += OnSecondButtonClicked;
            ThirdButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaDialog"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public SchemaDialog( BindingSource bindingSource ) 
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
                SelectedColumns = new List<string>( );
                SelectionsTextBox.Text = string.Empty;
                SelectionsTextBox.Visible = false;
                ThirdButton.Click += OnCloseButtonClicked;
                DataTable = (DataTable)BindingSource.DataSource;
                Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
                DataModel = new DataBuilder( Source, Provider.Access );
                Text = "Schema: " + DataTable.TableName.SplitPascal(  );
                Fields = DataModel.Fields;
                Numerics = DataModel.Numerics;
                PopulateFirstListBox( );
                PopulateSecondListBox( );
                SetLabelConfiguration( );
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
                FirstLabel.Text = "Fields:  " + SecondListBox.Items?.Count;
                SecondLabel.Text = "Numerics:  " + SecondListBox.Items?.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Populates the column ListBox.
        /// </summary>
        private void PopulateFirstListBox( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    foreach( var _item in Fields )
                    {
                        FirstListBox.Items.Add( _item );
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
        private void OnFirstListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = FirstListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedColumns.Add( _selectedItem );
                }
                
                UpdateHeaderText(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the numeric ListBox.
        /// </summary>
        private void PopulateSecondListBox( )
        {
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    for( var _i = 0; _i < Numerics.Count; _i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ _i ] ) )
                        {
                            SecondListBox.Items.Add( Numerics[ _i ] );
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
        /// Called when [numeric ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSecondListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = SecondListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedColumns.Add( _selectedItem );
                }
                
                UpdateHeaderText(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [first button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnFirstButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( FirstListBox.SelectedItems?.Count > 0 )
                {
                    FirstListBox.SelectedItems.Clear(  );
                    FirstListBox.Items.Clear( );
                    PopulateFirstListBox(  );
                }
                
                if( SecondListBox.SelectedItems?.Count > 0 )
                {
                    SecondListBox.SelectedItems.Clear(  );
                    SecondListBox.Items.Clear(  );
                    PopulateSecondListBox(  );
                }
                
                if( SelectedColumns?.Count > 0 )
                {
                    SelectedColumns.Clear(  );
                }

                SelectionsTextBox.Text = string.Empty;
                SelectionsTextBox.Visible = false;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [second button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnSecondButtonClicked( object sender, EventArgs e )
        {
            try
            {
                UpdateHeaderText(  );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Updates the header text.
        /// </summary>
        private void UpdateHeaderText( )
        {
            try
            {
                var _text = string.Empty;
                var _selections = string.Empty;
                if( SelectedColumns?.Any(  ) == true )
                {
                    foreach( var item in SelectedColumns )
                    {
                        _selections += $"{ item }, ";
                    }

                    var _trimmed = _selections?.TrimEnd( ", ".ToCharArray(  ) );
                    SelectionsTextBox.Text = _text + _trimmed;
                    SelectionsTextBox.BorderColor = Color.FromArgb( 65, 65, 65 );
                    SelectionsTextBox.BackColor = Color.FromArgb( 40, 40, 40 );
                    SelectionsTextBox.Visible = true;
                }
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


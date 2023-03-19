// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class ProgramProjectDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
        if( disposing && ( components != null ) )
        {
            components.Dispose( );
        }
        base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
        components =  new System.ComponentModel.Container( ) ;
        var captionImage2 = new Syncfusion.Windows.Forms.CaptionImage( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( ProgramProjectDialog ) );
        CloseButton =  new Button( ) ;
        StatutoryAuthorityTextBox =  new RichTextBox( ) ;
        BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
        StatutoryAuthorityLabel =  new Label( ) ;
        StatutoryAuthorityTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
        ProgramDescriptionTextBox =  new RichTextBox( ) ;
        ProgramAreaTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
        ProgramAreaLabel =  new Label( ) ;
        ProgramAreaNameTextBox =  new RichTextBox( ) ;
        ProgramListBox =  new ListBox( ) ;
        ProgramProjectTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
        ProgramProjectLabel =  new Label( ) ;
        ProgramProjectNameTextBox =  new RichTextBox( ) ;
        PreviousButton =  new Button( ) ;
        NextButton =  new Button( ) ;
        DescriptionLabel =  new Label( ) ;
        SearchButton =  new Button( ) ;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        StatutoryAuthorityTable.SuspendLayout( );
        ProgramAreaTable.SuspendLayout( );
        ProgramProjectTable.SuspendLayout( );
        SuspendLayout( );
        // 
        // CloseButton
        // 
        CloseButton.BindingSource =  null ;
        CloseButton.DataFilter =  null ;
        CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        CloseButton.HoverText =  null ;
        CloseButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        CloseButton.IsDerivedStyle =  true ;
        CloseButton.Location =  new System.Drawing.Point( 1055, 520 ) ;
        CloseButton.Name =  "CloseButton" ;
        CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
        CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CloseButton.PressTextColor =  System.Drawing.Color.White ;
        CloseButton.Size =  new System.Drawing.Size( 121, 46 ) ;
        CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        CloseButton.StyleManager =  null ;
        CloseButton.TabIndex =  0 ;
        CloseButton.Text =  "Close" ;
        CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
        CloseButton.ThemeName =  "Budget Execution" ;
        CloseButton.ToolTip =  null ;
        // 
        // StatutoryAuthorityTextBox
        // 
        StatutoryAuthorityTextBox.AutoWordSelection =  false ;
        StatutoryAuthorityTextBox.BindingSource =  BindingSource ;
        StatutoryAuthorityTextBox.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        StatutoryAuthorityTextBox.DataFilter =  null ;
        StatutoryAuthorityTextBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   204  ,   204  ,   204   ) ;
        StatutoryAuthorityTextBox.DisabledBorderColor =  System.Drawing.Color.FromArgb(   155  ,   155  ,   155   ) ;
        StatutoryAuthorityTextBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   136  ,   136  ,   136   ) ;
        StatutoryAuthorityTextBox.Dock =  System.Windows.Forms.DockStyle.Fill ;
        StatutoryAuthorityTextBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        StatutoryAuthorityTextBox.HoverColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        StatutoryAuthorityTextBox.HoverText =  null ;
        StatutoryAuthorityTextBox.IsDerivedStyle =  true ;
        StatutoryAuthorityTextBox.Lines =  null ;
        StatutoryAuthorityTextBox.Location =  new System.Drawing.Point( 3, 38 ) ;
        StatutoryAuthorityTextBox.MaxLength =  32767 ;
        StatutoryAuthorityTextBox.Name =  "StatutoryAuthorityTextBox" ;
        StatutoryAuthorityTextBox.Padding =  new System.Windows.Forms.Padding( 3, 10, 3, 3 ) ;
        StatutoryAuthorityTextBox.ReadOnly =  false ;
        StatutoryAuthorityTextBox.Size =  new System.Drawing.Size( 356, 157 ) ;
        StatutoryAuthorityTextBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        StatutoryAuthorityTextBox.StyleManager =  null ;
        StatutoryAuthorityTextBox.TabIndex =  1 ;
        StatutoryAuthorityTextBox.Tag =  "Laws" ;
        StatutoryAuthorityTextBox.ThemeAuthor =  "Terry D. Eppler" ;
        StatutoryAuthorityTextBox.ThemeName =  "Budget Execution" ;
        StatutoryAuthorityTextBox.ToolTip =  null ;
        StatutoryAuthorityTextBox.WordWrap =  true ;
        // 
        // StatutoryAuthorityLabel
        // 
        StatutoryAuthorityLabel.AccessibleName =  "" ;
        StatutoryAuthorityLabel.BindingSource =  null ;
        StatutoryAuthorityLabel.DataFilter =  null ;
        StatutoryAuthorityLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
        StatutoryAuthorityLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
        StatutoryAuthorityLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        StatutoryAuthorityLabel.HoverText =  null ;
        StatutoryAuthorityLabel.ImageAlign =  System.Drawing.ContentAlignment.TopLeft ;
        StatutoryAuthorityLabel.IsDerivedStyle =  true ;
        StatutoryAuthorityLabel.Location =  new System.Drawing.Point( 3, 3 ) ;
        StatutoryAuthorityLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
        StatutoryAuthorityLabel.Name =  "StatutoryAuthorityLabel" ;
        StatutoryAuthorityLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        StatutoryAuthorityLabel.Size =  new System.Drawing.Size( 356, 29 ) ;
        StatutoryAuthorityLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
        StatutoryAuthorityLabel.StyleManager =  null ;
        StatutoryAuthorityLabel.TabIndex =  0 ;
        StatutoryAuthorityLabel.Text =  "Statutory Authority" ;
        StatutoryAuthorityLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
        StatutoryAuthorityLabel.ThemeAuthor =  "Terry D. Eppler" ;
        StatutoryAuthorityLabel.ThemeName =  "Budget Execution" ;
        StatutoryAuthorityLabel.ToolTip =  null ;
        // 
        // StatutoryAuthorityTable
        // 
        StatutoryAuthorityTable.ColumnCount =  1 ;
        StatutoryAuthorityTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.8806F ) );
        StatutoryAuthorityTable.Controls.Add( StatutoryAuthorityTextBox, 0, 1 );
        StatutoryAuthorityTable.Controls.Add( StatutoryAuthorityLabel, 0, 0 );
        StatutoryAuthorityTable.Location =  new System.Drawing.Point( 25, 41 ) ;
        StatutoryAuthorityTable.Name =  "StatutoryAuthorityTable" ;
        StatutoryAuthorityTable.RowCount =  2 ;
        StatutoryAuthorityTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 18.07229F ) );
        StatutoryAuthorityTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 81.92771F ) );
        StatutoryAuthorityTable.Size =  new System.Drawing.Size( 362, 198 ) ;
        StatutoryAuthorityTable.TabIndex =  3 ;
        // 
        // ProgramDescriptionTextBox
        // 
        ProgramDescriptionTextBox.AutoWordSelection =  false ;
        ProgramDescriptionTextBox.BindingSource =  BindingSource ;
        ProgramDescriptionTextBox.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        ProgramDescriptionTextBox.DataFilter =  null ;
        ProgramDescriptionTextBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   204  ,   204  ,   204   ) ;
        ProgramDescriptionTextBox.DisabledBorderColor =  System.Drawing.Color.FromArgb(   155  ,   155  ,   155   ) ;
        ProgramDescriptionTextBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   136  ,   136  ,   136   ) ;
        ProgramDescriptionTextBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProgramDescriptionTextBox.HoverColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ProgramDescriptionTextBox.HoverText =  null ;
        ProgramDescriptionTextBox.IsDerivedStyle =  true ;
        ProgramDescriptionTextBox.Lines =  null ;
        ProgramDescriptionTextBox.Location =  new System.Drawing.Point( 25, 288 ) ;
        ProgramDescriptionTextBox.MaxLength =  32767 ;
        ProgramDescriptionTextBox.Name =  "ProgramDescriptionTextBox" ;
        ProgramDescriptionTextBox.Padding =  new System.Windows.Forms.Padding( 3, 10, 3, 3 ) ;
        ProgramDescriptionTextBox.ReadOnly =  false ;
        ProgramDescriptionTextBox.Size =  new System.Drawing.Size( 1118, 180 ) ;
        ProgramDescriptionTextBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        ProgramDescriptionTextBox.StyleManager =  null ;
        ProgramDescriptionTextBox.TabIndex =  1 ;
        ProgramDescriptionTextBox.Tag =  "Description" ;
        ProgramDescriptionTextBox.ThemeAuthor =  "Terry D. Eppler" ;
        ProgramDescriptionTextBox.ThemeName =  "Budget Execution" ;
        ProgramDescriptionTextBox.ToolTip =  null ;
        ProgramDescriptionTextBox.WordWrap =  true ;
        // 
        // ProgramAreaTable
        // 
        ProgramAreaTable.ColumnCount =  1 ;
        ProgramAreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.8806F ) );
        ProgramAreaTable.Controls.Add( ProgramAreaLabel, 0, 0 );
        ProgramAreaTable.Controls.Add( ProgramAreaNameTextBox, 0, 1 );
        ProgramAreaTable.Location =  new System.Drawing.Point( 411, 44 ) ;
        ProgramAreaTable.Name =  "ProgramAreaTable" ;
        ProgramAreaTable.RowCount =  2 ;
        ProgramAreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 36F ) );
        ProgramAreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 64F ) );
        ProgramAreaTable.Size =  new System.Drawing.Size( 365, 75 ) ;
        ProgramAreaTable.TabIndex =  7 ;
        // 
        // ProgramAreaLabel
        // 
        ProgramAreaLabel.AccessibleName =  "" ;
        ProgramAreaLabel.BindingSource =  null ;
        ProgramAreaLabel.DataFilter =  null ;
        ProgramAreaLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
        ProgramAreaLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
        ProgramAreaLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProgramAreaLabel.HoverText =  null ;
        ProgramAreaLabel.ImageAlign =  System.Drawing.ContentAlignment.TopLeft ;
        ProgramAreaLabel.IsDerivedStyle =  true ;
        ProgramAreaLabel.Location =  new System.Drawing.Point( 3, 3 ) ;
        ProgramAreaLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
        ProgramAreaLabel.Name =  "ProgramAreaLabel" ;
        ProgramAreaLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        ProgramAreaLabel.Size =  new System.Drawing.Size( 359, 21 ) ;
        ProgramAreaLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
        ProgramAreaLabel.StyleManager =  null ;
        ProgramAreaLabel.TabIndex =  0 ;
        ProgramAreaLabel.Text =  "Program Area" ;
        ProgramAreaLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
        ProgramAreaLabel.ThemeAuthor =  "Terry D. Eppler" ;
        ProgramAreaLabel.ThemeName =  "Budget Execution" ;
        ProgramAreaLabel.ToolTip =  null ;
        // 
        // ProgramAreaNameTextBox
        // 
        ProgramAreaNameTextBox.AutoWordSelection =  false ;
        ProgramAreaNameTextBox.BindingSource =  BindingSource ;
        ProgramAreaNameTextBox.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        ProgramAreaNameTextBox.DataFilter =  null ;
        ProgramAreaNameTextBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   204  ,   204  ,   204   ) ;
        ProgramAreaNameTextBox.DisabledBorderColor =  System.Drawing.Color.FromArgb(   155  ,   155  ,   155   ) ;
        ProgramAreaNameTextBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   136  ,   136  ,   136   ) ;
        ProgramAreaNameTextBox.Dock =  System.Windows.Forms.DockStyle.Fill ;
        ProgramAreaNameTextBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProgramAreaNameTextBox.HoverColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ProgramAreaNameTextBox.HoverText =  null ;
        ProgramAreaNameTextBox.IsDerivedStyle =  true ;
        ProgramAreaNameTextBox.Lines =  null ;
        ProgramAreaNameTextBox.Location =  new System.Drawing.Point( 3, 30 ) ;
        ProgramAreaNameTextBox.MaxLength =  32767 ;
        ProgramAreaNameTextBox.Name =  "ProgramAreaNameTextBox" ;
        ProgramAreaNameTextBox.Padding =  new System.Windows.Forms.Padding( 3 ) ;
        ProgramAreaNameTextBox.ReadOnly =  false ;
        ProgramAreaNameTextBox.Size =  new System.Drawing.Size( 359, 42 ) ;
        ProgramAreaNameTextBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        ProgramAreaNameTextBox.StyleManager =  null ;
        ProgramAreaNameTextBox.TabIndex =  1 ;
        ProgramAreaNameTextBox.Text =  "ProgramAreaName" ;
        ProgramAreaNameTextBox.ThemeAuthor =  "Terry D. Eppler" ;
        ProgramAreaNameTextBox.ThemeName =  "Budget Execution" ;
        ProgramAreaNameTextBox.ToolTip =  null ;
        ProgramAreaNameTextBox.WordWrap =  true ;
        // 
        // ProgramListBox
        // 
        ProgramListBox.BackColor =  System.Drawing.Color.FromArgb(   30  ,   30  ,   30   ) ;
        ProgramListBox.BindingSource =  null ;
        ProgramListBox.BorderColor =  System.Drawing.Color.FromArgb(   55  ,   55  ,   55   ) ;
        ProgramListBox.DataFilter =  null ;
        ProgramListBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        ProgramListBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        ProgramListBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProgramListBox.HoveredItemBackColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        ProgramListBox.HoveredItemColor =  System.Drawing.Color.White ;
        ProgramListBox.HoverText =  null ;
        ProgramListBox.IsDerivedStyle =  true ;
        ProgramListBox.ItemHeight =  28 ;
        ProgramListBox.Location =  new System.Drawing.Point( 805, 41 ) ;
        ProgramListBox.Margin =  new System.Windows.Forms.Padding( 1 ) ;
        ProgramListBox.MultiSelect =  true ;
        ProgramListBox.Name =  "ProgramListBox" ;
        ProgramListBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        ProgramListBox.SelectedIndex =  -1 ;
        ProgramListBox.SelectedItem =  null ;
        ProgramListBox.SelectedItemBackColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ProgramListBox.SelectedItemColor =  System.Drawing.Color.White ;
        ProgramListBox.SelectedText =  null ;
        ProgramListBox.SelectedValue =  null ;
        ProgramListBox.ShowBorder =  false ;
        ProgramListBox.ShowScrollBar =  false ;
        ProgramListBox.Size =  new System.Drawing.Size( 338, 198 ) ;
        ProgramListBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        ProgramListBox.StyleManager =  null ;
        ProgramListBox.TabIndex =  8 ;
        ProgramListBox.ThemeAuthor =  "Terry D. Eppler" ;
        ProgramListBox.ThemeName =  "Budget Execution" ;
        ProgramListBox.ToolTip =  null ;
        // 
        // ProgramProjectTable
        // 
        ProgramProjectTable.ColumnCount =  1 ;
        ProgramProjectTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.8806F ) );
        ProgramProjectTable.Controls.Add( ProgramProjectLabel, 0, 0 );
        ProgramProjectTable.Controls.Add( ProgramProjectNameTextBox, 0, 1 );
        ProgramProjectTable.Location =  new System.Drawing.Point( 411, 157 ) ;
        ProgramProjectTable.Name =  "ProgramProjectTable" ;
        ProgramProjectTable.RowCount =  2 ;
        ProgramProjectTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 32.92683F ) );
        ProgramProjectTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 67.07317F ) );
        ProgramProjectTable.Size =  new System.Drawing.Size( 365, 82 ) ;
        ProgramProjectTable.TabIndex =  9 ;
        // 
        // ProgramProjectLabel
        // 
        ProgramProjectLabel.AccessibleName =  "" ;
        ProgramProjectLabel.BindingSource =  null ;
        ProgramProjectLabel.DataFilter =  null ;
        ProgramProjectLabel.Dock =  System.Windows.Forms.DockStyle.Fill ;
        ProgramProjectLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
        ProgramProjectLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProgramProjectLabel.HoverText =  null ;
        ProgramProjectLabel.ImageAlign =  System.Drawing.ContentAlignment.TopLeft ;
        ProgramProjectLabel.IsDerivedStyle =  true ;
        ProgramProjectLabel.Location =  new System.Drawing.Point( 3, 3 ) ;
        ProgramProjectLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
        ProgramProjectLabel.Name =  "ProgramProjectLabel" ;
        ProgramProjectLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        ProgramProjectLabel.Size =  new System.Drawing.Size( 359, 21 ) ;
        ProgramProjectLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
        ProgramProjectLabel.StyleManager =  null ;
        ProgramProjectLabel.TabIndex =  0 ;
        ProgramProjectLabel.Text =  "Program Project" ;
        ProgramProjectLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
        ProgramProjectLabel.ThemeAuthor =  "Terry D. Eppler" ;
        ProgramProjectLabel.ThemeName =  "Budget Execution" ;
        ProgramProjectLabel.ToolTip =  null ;
        // 
        // ProgramProjectNameTextBox
        // 
        ProgramProjectNameTextBox.AutoWordSelection =  false ;
        ProgramProjectNameTextBox.BindingSource =  BindingSource ;
        ProgramProjectNameTextBox.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
        ProgramProjectNameTextBox.DataFilter =  null ;
        ProgramProjectNameTextBox.DisabledBackColor =  System.Drawing.Color.FromArgb(   204  ,   204  ,   204   ) ;
        ProgramProjectNameTextBox.DisabledBorderColor =  System.Drawing.Color.FromArgb(   155  ,   155  ,   155   ) ;
        ProgramProjectNameTextBox.DisabledForeColor =  System.Drawing.Color.FromArgb(   136  ,   136  ,   136   ) ;
        ProgramProjectNameTextBox.Dock =  System.Windows.Forms.DockStyle.Fill ;
        ProgramProjectNameTextBox.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ProgramProjectNameTextBox.HoverColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        ProgramProjectNameTextBox.HoverText =  null ;
        ProgramProjectNameTextBox.IsDerivedStyle =  true ;
        ProgramProjectNameTextBox.Lines =  null ;
        ProgramProjectNameTextBox.Location =  new System.Drawing.Point( 3, 30 ) ;
        ProgramProjectNameTextBox.MaxLength =  32767 ;
        ProgramProjectNameTextBox.Name =  "ProgramProjectNameTextBox" ;
        ProgramProjectNameTextBox.Padding =  new System.Windows.Forms.Padding( 3 ) ;
        ProgramProjectNameTextBox.ReadOnly =  false ;
        ProgramProjectNameTextBox.Size =  new System.Drawing.Size( 359, 49 ) ;
        ProgramProjectNameTextBox.Style =  MetroSet_UI.Enums.Style.Custom ;
        ProgramProjectNameTextBox.StyleManager =  null ;
        ProgramProjectNameTextBox.TabIndex =  1 ;
        ProgramProjectNameTextBox.Tag =  "Code" ;
        ProgramProjectNameTextBox.ThemeAuthor =  "Terry D. Eppler" ;
        ProgramProjectNameTextBox.ThemeName =  "Budget Execution" ;
        ProgramProjectNameTextBox.ToolTip =  null ;
        ProgramProjectNameTextBox.WordWrap =  true ;
        // 
        // PreviousButton
        // 
        PreviousButton.BindingSource =  null ;
        PreviousButton.DataFilter =  null ;
        PreviousButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        PreviousButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        PreviousButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        PreviousButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        PreviousButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        PreviousButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        PreviousButton.HoverColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        PreviousButton.HoverText =  null ;
        PreviousButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        PreviousButton.IsDerivedStyle =  true ;
        PreviousButton.Location =  new System.Drawing.Point( 361, 520 ) ;
        PreviousButton.Name =  "PreviousButton" ;
        PreviousButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        PreviousButton.NormalColor =  System.Drawing.Color.Transparent ;
        PreviousButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        PreviousButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        PreviousButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        PreviousButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        PreviousButton.PressTextColor =  System.Drawing.Color.White ;
        PreviousButton.Size =  new System.Drawing.Size( 121, 46 ) ;
        PreviousButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        PreviousButton.StyleManager =  null ;
        PreviousButton.TabIndex =  9 ;
        PreviousButton.Text =  "Previous" ;
        PreviousButton.ThemeAuthor =  "Terry D. Eppler" ;
        PreviousButton.ThemeName =  "Budget Execution" ;
        PreviousButton.ToolTip =  null ;
        // 
        // NextButton
        // 
        NextButton.BindingSource =  null ;
        NextButton.DataFilter =  null ;
        NextButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        NextButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        NextButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        NextButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        NextButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        NextButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        NextButton.HoverColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        NextButton.HoverText =  null ;
        NextButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        NextButton.IsDerivedStyle =  true ;
        NextButton.Location =  new System.Drawing.Point( 675, 520 ) ;
        NextButton.Name =  "NextButton" ;
        NextButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        NextButton.NormalColor =  System.Drawing.Color.Transparent ;
        NextButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        NextButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        NextButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        NextButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        NextButton.PressTextColor =  System.Drawing.Color.White ;
        NextButton.Size =  new System.Drawing.Size( 121, 46 ) ;
        NextButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        NextButton.StyleManager =  null ;
        NextButton.TabIndex =  10 ;
        NextButton.Text =  "Next" ;
        NextButton.ThemeAuthor =  "Terry D. Eppler" ;
        NextButton.ThemeName =  "Budget Execution" ;
        NextButton.ToolTip =  null ;
        // 
        // DescriptionLabel
        // 
        DescriptionLabel.BindingSource =  null ;
        DescriptionLabel.DataFilter =  null ;
        DescriptionLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
        DescriptionLabel.Font =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        DescriptionLabel.HoverText =  null ;
        DescriptionLabel.IsDerivedStyle =  true ;
        DescriptionLabel.Location =  new System.Drawing.Point( 28, 259 ) ;
        DescriptionLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
        DescriptionLabel.Name =  "DescriptionLabel" ;
        DescriptionLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        DescriptionLabel.Size =  new System.Drawing.Size( 165, 23 ) ;
        DescriptionLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
        DescriptionLabel.StyleManager =  null ;
        DescriptionLabel.TabIndex =  12 ;
        DescriptionLabel.Text =  "Description" ;
        DescriptionLabel.TextAlign =  System.Drawing.ContentAlignment.BottomLeft ;
        DescriptionLabel.ThemeAuthor =  "Terry D. Eppler" ;
        DescriptionLabel.ThemeName =  "Budget Execution" ;
        DescriptionLabel.ToolTip =  null ;
        // 
        // SearchButton
        // 
        SearchButton.BindingSource =  null ;
        SearchButton.DataFilter =  null ;
        SearchButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        SearchButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        SearchButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        SearchButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        SearchButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SearchButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        SearchButton.HoverColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
        SearchButton.HoverText =  null ;
        SearchButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        SearchButton.IsDerivedStyle =  true ;
        SearchButton.Location =  new System.Drawing.Point( 28, 520 ) ;
        SearchButton.Name =  "SearchButton" ;
        SearchButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
        SearchButton.NormalColor =  System.Drawing.Color.Transparent ;
        SearchButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SearchButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        SearchButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SearchButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        SearchButton.PressTextColor =  System.Drawing.Color.White ;
        SearchButton.Size =  new System.Drawing.Size( 121, 46 ) ;
        SearchButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        SearchButton.StyleManager =  null ;
        SearchButton.TabIndex =  13 ;
        SearchButton.Text =  "Search" ;
        SearchButton.ThemeAuthor =  "Terry D. Eppler" ;
        SearchButton.ThemeName =  "Budget Execution" ;
        SearchButton.ToolTip =  null ;
        // 
        // ProgramProjectDialog
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 6F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionBarHeight =  30 ;
        CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        CaptionFont =  new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
        CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
        captionImage2.BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        captionImage2.Image =  Properties.Resources.EPA ;
        captionImage2.Location =  new System.Drawing.Point( 5, 5 ) ;
        captionImage2.Name =  "CaptionImage1" ;
        captionImage2.Size =  new System.Drawing.Size( 42, 16 ) ;
        CaptionImages.Add( captionImage2 );
        ClientSize =  new System.Drawing.Size( 1188, 578 ) ;
        Controls.Add( SearchButton );
        Controls.Add( ProgramDescriptionTextBox );
        Controls.Add( DescriptionLabel );
        Controls.Add( NextButton );
        Controls.Add( StatutoryAuthorityTable );
        Controls.Add( PreviousButton );
        Controls.Add( CloseButton );
        Controls.Add( ProgramAreaTable );
        Controls.Add( ProgramProjectTable );
        Controls.Add( ProgramListBox );
        Font =  new System.Drawing.Font( "Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ForeColor =  System.Drawing.Color.LightSteelBlue ;
        FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
        Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
        MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
        Name =  "ProgramProjectDialog" ;
        ShowIcon =  false ;
        SizeGripStyle =  System.Windows.Forms.SizeGripStyle.Hide ;
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterParent ;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        StatutoryAuthorityTable.ResumeLayout( false );
        ProgramAreaTable.ResumeLayout( false );
        ProgramProjectTable.ResumeLayout( false );
        ResumeLayout( false );
    }

    #endregion
    private RichTextBox StatutoryAuthorityTextBox;
    private Label StatutoryAuthorityLabel;
    private System.Windows.Forms.TableLayoutPanel StatutoryAuthorityTable;
    private RichTextBox ProgramDescriptionTextBox;
    public System.Windows.Forms.BindingSource BindingSource;
    private System.Windows.Forms.TableLayoutPanel ProgramAreaTable;
    private Label ProgramAreaLabel;
    private RichTextBox ProgramAreaNameTextBox;
    public Button PreviousButton;
    public Button NextButton;
    private Button CloseButton;
    private ListBox ProgramListBox;
    private System.Windows.Forms.TableLayoutPanel ProgramProjectTable;
    private Label ProgramProjectLabel;
    private RichTextBox ProgramProjectNameTextBox;
    public Button SearchButton;
    public Label DescriptionLabel;
}
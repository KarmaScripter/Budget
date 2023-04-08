// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class LoadingDialog
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
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( LoadingDialog ) );
        Timer =  new System.Windows.Forms.Timer( components ) ;
        Worker =  new System.ComponentModel.BackgroundWorker( ) ;
        PictureBox =  new System.Windows.Forms.PictureBox( ) ;
        CloseButton =  new Button( ) ;
        ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
        SuspendLayout( );
        // 
        // PictureBox
        // 
        PictureBox.BackColor =  System.Drawing.Color.Transparent ;
        PictureBox.Image =  Properties.Resources.Loading ;
        PictureBox.Location =  new System.Drawing.Point( 265, 2 ) ;
        PictureBox.Name =  "PictureBox" ;
        PictureBox.Size =  new System.Drawing.Size( 800, 600 ) ;
        PictureBox.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.AutoSize ;
        PictureBox.TabIndex =  1 ;
        PictureBox.TabStop =  false ;
        // 
        // CloseButton
        // 
        CloseButton.BindingSource =  null ;
        CloseButton.DataFilter =  null ;
        CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
        CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
        CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
        CloseButton.Font =  new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CloseButton.ForeColor =  System.Drawing.Color.FromArgb( 0, 120, 212 ) ;
        CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb( 17, 53, 84 ) ;
        CloseButton.HoverColor =  System.Drawing.Color.FromArgb( 17, 53, 84 ) ;
        CloseButton.HoverText =  null ;
        CloseButton.HoverTextColor =  System.Drawing.Color.LightSteelBlue ;
        CloseButton.IsDerivedStyle =  true ;
        CloseButton.Location =  new System.Drawing.Point( 1176, 586 ) ;
        CloseButton.Name =  "CloseButton" ;
        CloseButton.NormalBorderColor =  System.Drawing.Color.Black ;
        CloseButton.NormalColor =  System.Drawing.Color.Black ;
        CloseButton.NormalTextColor =  System.Drawing.Color.Black ;
        CloseButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
        CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb( 0, 120, 212 ) ;
        CloseButton.PressColor =  System.Drawing.Color.FromArgb( 0, 120, 212 ) ;
        CloseButton.PressTextColor =  System.Drawing.Color.White ;
        CloseButton.Size =  new System.Drawing.Size( 140, 40 ) ;
        CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
        CloseButton.StyleManager =  null ;
        CloseButton.TabIndex =  2 ;
        CloseButton.Text =  "button1" ;
        CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
        CloseButton.ThemeName =  "Budget Execution" ;
        CloseButton.ToolTip =  null ;
        // 
        // LoadingDialog
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.Black ;
        BorderColor =  System.Drawing.Color.Transparent ;
        CaptionBarColor =  System.Drawing.Color.Black ;
        CaptionButtonColor =  System.Drawing.Color.Black ;
        CaptionButtonHoverColor =  System.Drawing.Color.Black ;
        CaptionFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CaptionForeColor =  System.Drawing.Color.Black ;
        ClientSize =  new System.Drawing.Size( 1328, 638 ) ;
        Controls.Add( CloseButton );
        Controls.Add( PictureBox );
        Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
        Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
        MaximumSize =  new System.Drawing.Size( 1340, 674 ) ;
        MetroColor =  System.Drawing.Color.Black ;
        MinimumSize =  new System.Drawing.Size( 1340, 674 ) ;
        Name =  "LoadingDialog" ;
        ShowIcon =  false ;
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
        Text =  "LoadingDialog" ;
        ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
        ResumeLayout( false );
        PerformLayout( );
    }

    #endregion

    public System.Windows.Forms.Timer Timer;
    public System.ComponentModel.BackgroundWorker Worker;
    public System.Windows.Forms.PictureBox PictureBox;
    private Button CloseButton;
}
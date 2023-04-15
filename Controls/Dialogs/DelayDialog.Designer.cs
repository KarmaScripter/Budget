// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class DelayDialog
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
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( DelayDialog ) );
        pictureBox1 =  new System.Windows.Forms.PictureBox( ) ;
        BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
        Timer =  new System.Windows.Forms.Timer( components ) ;
        ImageList =  new System.Windows.Forms.ImageList( components ) ;
        ( (System.ComponentModel.ISupportInitialize) pictureBox1  ).BeginInit( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        SuspendLayout( );
        // 
        // pictureBox1
        // 
        pictureBox1.Location =  new System.Drawing.Point( 445, 147 ) ;
        pictureBox1.Name =  "pictureBox1" ;
        pictureBox1.Size =  new System.Drawing.Size( 378, 255 ) ;
        pictureBox1.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.Zoom ;
        pictureBox1.TabIndex =  0 ;
        pictureBox1.TabStop =  false ;
        // 
        // ImageList
        // 
        ImageList.ColorDepth =  System.Windows.Forms.ColorDepth.Depth8Bit ;
        ImageList.TransparentColor =  System.Drawing.Color.Transparent ;
        // 
        // DelayDialog
        // 
        AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
        AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
        BackColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        BorderColor =  System.Drawing.Color.Transparent ;
        CaptionBarColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        CaptionButtonColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        CaptionButtonHoverColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        CaptionFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        CaptionForeColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        ClientSize =  new System.Drawing.Size( 1310, 648 ) ;
        Controls.Add( pictureBox1 );
        Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
        ForeColor =  System.Drawing.Color.LightGray ;
        FormBorderStyle =  System.Windows.Forms.FormBorderStyle.None ;
        Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
        Margin =  new System.Windows.Forms.Padding( 4, 3, 4, 3 ) ;
        MaximumSize =  new System.Drawing.Size( 1310, 648 ) ;
        MetroColor =  System.Drawing.Color.FromArgb( 20, 20, 20 ) ;
        MinimumSize =  new System.Drawing.Size( 1310, 648 ) ;
        Name =  "DelayDialog" ;
        Text =  "DelayDialog" ;
        ( (System.ComponentModel.ISupportInitialize) pictureBox1  ).EndInit( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.BindingSource BindingSource;
    public System.Windows.Forms.Timer Timer;
    public System.Windows.Forms.ImageList ImageList;
}
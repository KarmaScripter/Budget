// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{

    partial class QueryDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( QueryDialog ) );
            ThirdTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            SecondTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            FirstTable =  new System.Windows.Forms.TableLayoutPanel( ) ;
            BindingSource =  new System.Windows.Forms.BindingSource( components ) ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // ThirdTable
            // 
            ThirdTable.ColumnCount =  1 ;
            ThirdTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ThirdTable.GrowStyle =  System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize ;
            ThirdTable.Location =  new System.Drawing.Point( 841, 56 ) ;
            ThirdTable.Name =  "ThirdTable" ;
            ThirdTable.RowCount =  2 ;
            ThirdTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 9.308511F ) );
            ThirdTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90.69149F ) );
            ThirdTable.Size =  new System.Drawing.Size( 280, 351 ) ;
            ThirdTable.TabIndex =  13 ;
            // 
            // SecondTable
            // 
            SecondTable.ColumnCount =  1 ;
            SecondTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SecondTable.GrowStyle =  System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize ;
            SecondTable.Location =  new System.Drawing.Point( 462, 56 ) ;
            SecondTable.Name =  "SecondTable" ;
            SecondTable.RowCount =  2 ;
            SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 9.793815F ) );
            SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90.20618F ) );
            SecondTable.Size =  new System.Drawing.Size( 280, 351 ) ;
            SecondTable.TabIndex =  12 ;
            // 
            // FirstTable
            // 
            FirstTable.ColumnCount =  1 ;
            FirstTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FirstTable.GrowStyle =  System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize ;
            FirstTable.Location =  new System.Drawing.Point( 64, 56 ) ;
            FirstTable.Name =  "FirstTable" ;
            FirstTable.RowCount =  2 ;
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 9.574468F ) );
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90.42553F ) );
            FirstTable.Size =  new System.Drawing.Size( 280, 351 ) ;
            FirstTable.TabIndex =  11 ;
            // 
            // QueryDialog
            // 
            AutoScaleDimensions =  new System.Drawing.SizeF( 7F, 14F ) ;
            AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            ClientSize =  new System.Drawing.Size( 1188, 589 ) ;
            Controls.Add( ThirdTable );
            Controls.Add( SecondTable );
            Controls.Add( FirstTable );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 1200, 600 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 1200, 600 ) ;
            Name =  "QueryDialog" ;
            ShowIcon =  false ;
            SizeGripStyle =  System.Windows.Forms.SizeGripStyle.Hide ;
            StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen ;
            Text =  "Query Builder" ;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ThirdTable;
        private Label ThirdLabel;
        private Layout ThirdPanel;
        private System.Windows.Forms.TableLayoutPanel SecondTable;
        private Label SecondLabel;
        private Layout SecondPanel;
        private System.Windows.Forms.TableLayoutPanel FirstTable;
        private Label FirstLabel;
        private Layout FirstPanel;
        public Button FirstButton;
        public Button ThirdButton;
        private Button SecondButton;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        public ListBox ThirdListBox;
        public ListBox SecondListBox;
        public ListBox FirstListBox;
    }

}

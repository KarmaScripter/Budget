namespace BudgetExecution
{
    

    partial class MainForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem9 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem10 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem11 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem12 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem13 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem14 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem15 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem16 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem17 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem18 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem19 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem20 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem21 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem22 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem23 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem24 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.GuidanceTile = new BudgetExecution.Tile();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.DatabaseTile = new BudgetExecution.Tile();
            this.WebTile = new BudgetExecution.Tile();
            this.ClientTile = new BudgetExecution.Tile();
            this.UtilityTile = new BudgetExecution.Tile();
            this.ReportingTile = new BudgetExecution.Tile();
            this.Darkmode = new MetroSet_UI.Components.StyleManager();
            this.ExitButton = new BudgetExecution.Button();
            this.TileTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.TileTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuidanceTile
            // 
            this.GuidanceTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuidanceTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textItem1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem1.HubTile = this.GuidanceTile;
            textItem1.Text = "Banner Text";
            textItem1.TextColor = System.Drawing.Color.LightSteelBlue;
            this.GuidanceTile.Banner = textItem1;
            this.GuidanceTile.BannerColor = System.Drawing.Color.Transparent;
            this.GuidanceTile.BannerHeight = 40;
            this.GuidanceTile.BannerIcon = global::BudgetExecution.Properties.Resources.GuidanceTile;
            this.GuidanceTile.BindingSource = this.BindingSource;
            textItem2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem2.HubTile = this.GuidanceTile;
            textItem2.Text = "Body Text";
            textItem2.TextColor = System.Drawing.Color.LightSteelBlue;
            this.GuidanceTile.Body = textItem2;
            this.GuidanceTile.DataFilter = null;
            this.GuidanceTile.EnableSelectionMarker = false;
            this.GuidanceTile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem3.HubTile = this.GuidanceTile;
            textItem3.TextColor = System.Drawing.Color.LightSteelBlue;
            this.GuidanceTile.Footer = textItem3;
            this.GuidanceTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.GuidanceTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GuidanceTile.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GuidanceTile.HoverText = null;
            this.GuidanceTile.Location = new System.Drawing.Point(754, 53);
            this.GuidanceTile.Margin = new System.Windows.Forms.Padding(1);
            this.GuidanceTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.GuidanceTile.Name = "GuidanceTile";
            this.GuidanceTile.ShowBanner = true;
            this.GuidanceTile.ShowBannerIcon = true;
            this.GuidanceTile.Size = new System.Drawing.Size(225, 102);
            this.GuidanceTile.TabIndex = 0;
            textItem4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textItem4.HubTile = this.GuidanceTile;
            textItem4.Text = "This is the Title";
            textItem4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.GuidanceTile.Title = textItem4;
            this.GuidanceTile.ToolTip = this.ToolTip;
            this.GuidanceTile.TurnLiveTileOn = true;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.IsDerivedStyle = true;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // DatabaseTile
            // 
            this.DatabaseTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatabaseTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textItem5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem5.HubTile = this.DatabaseTile;
            textItem5.Text = "Banner Text";
            textItem5.TextColor = System.Drawing.Color.LightSteelBlue;
            this.DatabaseTile.Banner = textItem5;
            this.DatabaseTile.BannerColor = System.Drawing.Color.Transparent;
            this.DatabaseTile.BannerHeight = 40;
            this.DatabaseTile.BannerIcon = global::BudgetExecution.Properties.Resources.ToolsTile;
            this.DatabaseTile.BindingSource = this.BindingSource;
            textItem6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem6.HubTile = this.DatabaseTile;
            textItem6.Text = "Body Text";
            textItem6.TextColor = System.Drawing.Color.LightSteelBlue;
            this.DatabaseTile.Body = textItem6;
            this.DatabaseTile.DataFilter = null;
            this.DatabaseTile.EnableSelectionMarker = false;
            this.DatabaseTile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem7.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem7.HubTile = this.DatabaseTile;
            textItem7.TextColor = System.Drawing.Color.LightSteelBlue;
            this.DatabaseTile.Footer = textItem7;
            this.DatabaseTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DatabaseTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DatabaseTile.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DatabaseTile.HoverText = null;
            this.DatabaseTile.Location = new System.Drawing.Point(63, 53);
            this.DatabaseTile.Margin = new System.Windows.Forms.Padding(1);
            this.DatabaseTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.DatabaseTile.Name = "DatabaseTile";
            this.DatabaseTile.ShowBanner = true;
            this.DatabaseTile.ShowBannerIcon = true;
            this.DatabaseTile.Size = new System.Drawing.Size(225, 102);
            this.DatabaseTile.TabIndex = 1;
            textItem8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textItem8.HubTile = this.DatabaseTile;
            textItem8.Text = "This is the Title";
            textItem8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DatabaseTile.Title = textItem8;
            this.DatabaseTile.ToolTip = this.ToolTip;
            this.DatabaseTile.TurnLiveTileOn = true;
            // 
            // WebTile
            // 
            this.WebTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WebTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textItem9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem9.HubTile = this.WebTile;
            textItem9.Text = "Banner Text";
            textItem9.TextColor = System.Drawing.Color.LightSteelBlue;
            this.WebTile.Banner = textItem9;
            this.WebTile.BannerColor = System.Drawing.Color.Transparent;
            this.WebTile.BannerHeight = 40;
            this.WebTile.BannerIcon = global::BudgetExecution.Properties.Resources.WebClientTIle;
            this.WebTile.BindingSource = this.BindingSource;
            textItem10.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem10.HubTile = this.WebTile;
            textItem10.Text = "Body Text";
            textItem10.TextColor = System.Drawing.Color.LightSteelBlue;
            this.WebTile.Body = textItem10;
            this.WebTile.DataFilter = null;
            this.WebTile.EnableSelectionMarker = false;
            this.WebTile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem11.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem11.HubTile = this.WebTile;
            textItem11.TextColor = System.Drawing.Color.LightSteelBlue;
            this.WebTile.Footer = textItem11;
            this.WebTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.WebTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.WebTile.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.WebTile.HoverText = null;
            this.WebTile.Location = new System.Drawing.Point(63, 267);
            this.WebTile.Margin = new System.Windows.Forms.Padding(1);
            this.WebTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.WebTile.Name = "WebTile";
            this.WebTile.ShowBanner = true;
            this.WebTile.ShowBannerIcon = true;
            this.WebTile.Size = new System.Drawing.Size(225, 102);
            this.WebTile.TabIndex = 2;
            textItem12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textItem12.HubTile = this.WebTile;
            textItem12.Text = "This is the Title";
            textItem12.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.WebTile.Title = textItem12;
            this.WebTile.ToolTip = this.ToolTip;
            this.WebTile.TurnLiveTileOn = true;
            // 
            // ClientTile
            // 
            this.ClientTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textItem13.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem13.HubTile = this.ClientTile;
            textItem13.Text = "Banner Text";
            textItem13.TextColor = System.Drawing.Color.LightSteelBlue;
            this.ClientTile.Banner = textItem13;
            this.ClientTile.BannerColor = System.Drawing.Color.Transparent;
            this.ClientTile.BannerHeight = 40;
            this.ClientTile.BannerIcon = global::BudgetExecution.Properties.Resources.SqlServerTile;
            this.ClientTile.BindingSource = this.BindingSource;
            textItem14.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem14.HubTile = this.ClientTile;
            textItem14.Text = "Body Text";
            textItem14.TextColor = System.Drawing.Color.LightSteelBlue;
            this.ClientTile.Body = textItem14;
            this.ClientTile.DataFilter = null;
            this.ClientTile.EnableSelectionMarker = false;
            this.ClientTile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem15.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem15.HubTile = this.ClientTile;
            textItem15.TextColor = System.Drawing.Color.LightSteelBlue;
            this.ClientTile.Footer = textItem15;
            this.ClientTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ClientTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientTile.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientTile.HoverText = null;
            this.ClientTile.Location = new System.Drawing.Point(754, 267);
            this.ClientTile.Margin = new System.Windows.Forms.Padding(1);
            this.ClientTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.ClientTile.Name = "ClientTile";
            this.ClientTile.ShowBanner = true;
            this.ClientTile.ShowBannerIcon = true;
            this.ClientTile.Size = new System.Drawing.Size(225, 102);
            this.ClientTile.TabIndex = 3;
            textItem16.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textItem16.HubTile = this.ClientTile;
            textItem16.Text = "This is the Title";
            textItem16.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientTile.Title = textItem16;
            this.ClientTile.ToolTip = this.ToolTip;
            this.ClientTile.TurnLiveTileOn = true;
            // 
            // UtilityTile
            // 
            this.UtilityTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UtilityTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textItem17.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem17.HubTile = this.UtilityTile;
            textItem17.Text = "Banner Text";
            textItem17.TextColor = System.Drawing.Color.LightSteelBlue;
            this.UtilityTile.Banner = textItem17;
            this.UtilityTile.BannerColor = System.Drawing.Color.Transparent;
            this.UtilityTile.BannerHeight = 40;
            this.UtilityTile.BannerIcon = global::BudgetExecution.Properties.Resources.UtilityTile;
            this.UtilityTile.BindingSource = this.BindingSource;
            textItem18.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem18.HubTile = this.UtilityTile;
            textItem18.Text = "Body Text";
            textItem18.TextColor = System.Drawing.Color.LightSteelBlue;
            this.UtilityTile.Body = textItem18;
            this.UtilityTile.DataFilter = null;
            this.UtilityTile.EnableSelectionMarker = false;
            this.UtilityTile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem19.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem19.HubTile = this.UtilityTile;
            textItem19.TextColor = System.Drawing.Color.LightSteelBlue;
            this.UtilityTile.Footer = textItem19;
            this.UtilityTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.UtilityTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UtilityTile.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UtilityTile.HoverText = null;
            this.UtilityTile.Location = new System.Drawing.Point(415, 267);
            this.UtilityTile.Margin = new System.Windows.Forms.Padding(1);
            this.UtilityTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.UtilityTile.Name = "UtilityTile";
            this.UtilityTile.ShowBanner = true;
            this.UtilityTile.ShowBannerIcon = true;
            this.UtilityTile.Size = new System.Drawing.Size(225, 102);
            this.UtilityTile.TabIndex = 4;
            textItem20.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textItem20.HubTile = this.UtilityTile;
            textItem20.Text = "This is the Title";
            textItem20.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.UtilityTile.Title = textItem20;
            this.UtilityTile.ToolTip = this.ToolTip;
            this.UtilityTile.TurnLiveTileOn = true;
            // 
            // ReportingTile
            // 
            this.ReportingTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportingTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            textItem21.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem21.HubTile = this.ReportingTile;
            textItem21.Text = "Banner Text";
            textItem21.TextColor = System.Drawing.Color.LightSteelBlue;
            this.ReportingTile.Banner = textItem21;
            this.ReportingTile.BannerColor = System.Drawing.Color.Transparent;
            this.ReportingTile.BannerHeight = 40;
            this.ReportingTile.BannerIcon = global::BudgetExecution.Properties.Resources.ChartTile;
            this.ReportingTile.BindingSource = this.BindingSource;
            textItem22.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem22.HubTile = this.ReportingTile;
            textItem22.Text = "Body Text";
            textItem22.TextColor = System.Drawing.Color.LightSteelBlue;
            this.ReportingTile.Body = textItem22;
            this.ReportingTile.DataFilter = null;
            this.ReportingTile.EnableSelectionMarker = false;
            this.ReportingTile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem23.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textItem23.HubTile = this.ReportingTile;
            textItem23.TextColor = System.Drawing.Color.LightSteelBlue;
            this.ReportingTile.Footer = textItem23;
            this.ReportingTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ReportingTile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ReportingTile.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ReportingTile.HoverText = null;
            this.ReportingTile.Location = new System.Drawing.Point(415, 53);
            this.ReportingTile.Margin = new System.Windows.Forms.Padding(1);
            this.ReportingTile.MinimumSize = new System.Drawing.Size(100, 100);
            this.ReportingTile.Name = "ReportingTile";
            this.ReportingTile.ShowBanner = true;
            this.ReportingTile.ShowBannerIcon = true;
            this.ReportingTile.Size = new System.Drawing.Size(225, 102);
            this.ReportingTile.TabIndex = 5;
            textItem24.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textItem24.HubTile = this.ReportingTile;
            textItem24.Text = "This is the Title";
            textItem24.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ReportingTile.Title = textItem24;
            this.ReportingTile.ToolTip = this.ToolTip;
            this.ReportingTile.TurnLiveTileOn = true;
            // 
            // Darkmode
            // 
            this.Darkmode.CustomTheme = "C:\\Users\\terry\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.Darkmode.MetroForm = this;
            this.Darkmode.Style = MetroSet_UI.Enums.Style.Custom;
            this.Darkmode.ThemeAuthor = "Terry D. Eppler";
            this.Darkmode.ThemeName = "BudgetExecution";
            // 
            // ExitButton
            // 
            this.ExitButton.BindingSource = null;
            this.ExitButton.DataFilter = null;
            this.ExitButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ExitButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ExitButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ExitButton.HoverText = "Exit Application";
            this.ExitButton.HoverTextColor = System.Drawing.Color.White;
            this.ExitButton.IsDerivedStyle = true;
            this.ExitButton.Location = new System.Drawing.Point(1236, 711);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.NormalColor = System.Drawing.Color.Transparent;
            this.ExitButton.NormalTextColor = System.Drawing.Color.Transparent;
            this.ExitButton.Padding = new System.Windows.Forms.Padding(1);
            this.ExitButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ExitButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ExitButton.PressTextColor = System.Drawing.Color.White;
            this.ExitButton.Size = new System.Drawing.Size(140, 40);
            this.ExitButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.ExitButton.StyleManager = this.Darkmode;
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.ThemeAuthor = "Terry D. Eppler";
            this.ExitButton.ThemeName = "BudgetExecution";
            this.ExitButton.ToolTip = null;
            // 
            // TileTable
            // 
            this.TileTable.ColumnCount = 3;
            this.TileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.TileTable.Controls.Add(this.GuidanceTile, 2, 0);
            this.TileTable.Controls.Add(this.ReportingTile, 1, 0);
            this.TileTable.Controls.Add(this.DatabaseTile, 0, 0);
            this.TileTable.Controls.Add(this.WebTile, 0, 1);
            this.TileTable.Controls.Add(this.UtilityTile, 1, 1);
            this.TileTable.Controls.Add(this.ClientTile, 2, 1);
            this.TileTable.Location = new System.Drawing.Point(206, 96);
            this.TileTable.Name = "TileTable";
            this.TileTable.RowCount = 2;
            this.TileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.94614F));
            this.TileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.05386F));
            this.TileTable.Size = new System.Drawing.Size(1029, 427);
            this.TileTable.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Location = new System.Drawing.Point(4, 4);
            captionImage1.Name = "CaptionImage";
            captionImage1.Size = new System.Drawing.Size(22, 22);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1388, 763);
            this.Controls.Add(this.TileTable);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1350, 750);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.TileTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroSet_UI.Components.StyleManager Darkmode;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        private Tile GuidanceTile;
        private Tile ReportingTile;
        private Tile UtilityTile;
        private Tile ClientTile;
        private Tile WebTile;
        public Button ExitButton;
        public Tile DatabaseTile;
        private System.Windows.Forms.TableLayoutPanel TileTable;
    }
}
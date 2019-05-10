namespace POSeidon
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button addProductButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.leftsideMainPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.iconButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homepageTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homepageDataGridView = new System.Windows.Forms.DataGridView();
            this.salesAnalyticsTab = new System.Windows.Forms.TabPage();
            this.salesStatisticsPanel = new System.Windows.Forms.Panel();
            this.salesStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesStatisticsTitleLabel = new System.Windows.Forms.Label();
            this.customerStatisticsTab = new System.Windows.Forms.TabPage();
            this.customerStatisticsPanel = new System.Windows.Forms.Panel();
            this.customerStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerStatisticsTitleLable = new System.Windows.Forms.Label();
            this.salesHistoryTab = new System.Windows.Forms.TabPage();
            this.salesTitleLabel = new System.Windows.Forms.Label();
            this.salesHistoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsWindowPanel = new System.Windows.Forms.Panel();
            this.settingsCheckbox2 = new System.Windows.Forms.CheckBox();
            this.settingsCheckbox1 = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            addProductButton = new System.Windows.Forms.Button();
            this.leftsideMainPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.homepageTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepageDataGridView)).BeginInit();
            this.salesAnalyticsTab.SuspendLayout();
            this.salesStatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesStatisticsChart)).BeginInit();
            this.customerStatisticsTab.SuspendLayout();
            this.customerStatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).BeginInit();
            this.salesHistoryTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.settingsWindowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            addProductButton.AutoSize = true;
            addProductButton.BackColor = System.Drawing.Color.White;
            addProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addProductButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addProductButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addProductButton.Location = new System.Drawing.Point(5, 11);
            addProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            addProductButton.Name = "addProductButton";
            addProductButton.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            addProductButton.Size = new System.Drawing.Size(246, 64);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "ADD A NEW PRODUCT";
            addProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addProductButton.UseVisualStyleBackColor = false;
            // 
            // leftsideMainPanel
            // 
            this.leftsideMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftsideMainPanel.AutoScroll = true;
            this.leftsideMainPanel.AutoSize = true;
            this.leftsideMainPanel.Controls.Add(this.logoutButton);
            this.leftsideMainPanel.Controls.Add(this.iconButton);
            this.leftsideMainPanel.Controls.Add(this.infoLabel);
            this.leftsideMainPanel.Location = new System.Drawing.Point(8, 3);
            this.leftsideMainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftsideMainPanel.Name = "leftsideMainPanel";
            this.leftsideMainPanel.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.leftsideMainPanel.Size = new System.Drawing.Size(176, 573);
            this.leftsideMainPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackgroundImage = global::POSeidon.Properties.Resources.rsz_1logout_50x60;
            this.logoutButton.Location = new System.Drawing.Point(102, 196);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(48, 44);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // iconButton
            // 
            this.iconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton.AutoSize = true;
            this.iconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton.Image = global::POSeidon.Properties.Resources.rsz_poseidon_trident;
            this.iconButton.Location = new System.Drawing.Point(8, 10);
            this.iconButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iconButton.MaximumSize = new System.Drawing.Size(150, 162);
            this.iconButton.MinimumSize = new System.Drawing.Size(150, 162);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(150, 162);
            this.iconButton.TabIndex = 0;
            this.iconButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.Location = new System.Drawing.Point(8, 299);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.MaximumSize = new System.Drawing.Size(150, 277);
            this.infoLabel.MinimumSize = new System.Drawing.Size(150, 244);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(30, 122, 30, 122);
            this.infoLabel.Size = new System.Drawing.Size(150, 262);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Information";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.homepageTabControl);
            this.mainPanel.Location = new System.Drawing.Point(184, 3);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(820, 596);
            this.mainPanel.TabIndex = 1;
            // 
            // homepageTabControl
            // 
            this.homepageTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepageTabControl.Controls.Add(this.homeTab);
            this.homepageTabControl.Controls.Add(this.salesAnalyticsTab);
            this.homepageTabControl.Controls.Add(this.customerStatisticsTab);
            this.homepageTabControl.Controls.Add(this.salesHistoryTab);
            this.homepageTabControl.Controls.Add(this.settingsTab);
            this.homepageTabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homepageTabControl.ItemSize = new System.Drawing.Size(200, 50);
            this.homepageTabControl.Location = new System.Drawing.Point(2, 6);
            this.homepageTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homepageTabControl.Name = "homepageTabControl";
            this.homepageTabControl.Padding = new System.Drawing.Point(30, 3);
            this.homepageTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homepageTabControl.SelectedIndex = 0;
            this.homepageTabControl.Size = new System.Drawing.Size(796, 570);
            this.homepageTabControl.TabIndex = 3;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Transparent;
            this.homeTab.Controls.Add(this.homePanel);
            this.homeTab.Location = new System.Drawing.Point(4, 54);
            this.homeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeTab.Size = new System.Drawing.Size(788, 512);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // homePanel
            // 
            this.homePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePanel.AutoSize = true;
            this.homePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homePanel.BackColor = System.Drawing.Color.PowderBlue;
            this.homePanel.Controls.Add(this.homepageDataGridView);
            this.homePanel.Controls.Add(addProductButton);
            this.homePanel.Location = new System.Drawing.Point(4, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(783, 560);
            this.homePanel.TabIndex = 0;
            // 
            // homepageDataGridView
            // 
            this.homepageDataGridView.AllowUserToAddRows = false;
            this.homepageDataGridView.AllowUserToResizeColumns = false;
            this.homepageDataGridView.AllowUserToResizeRows = false;
            this.homepageDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homepageDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.homepageDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homepageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homepageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.homepageDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.homepageDataGridView.Location = new System.Drawing.Point(5, 76);
            this.homepageDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homepageDataGridView.Name = "homepageDataGridView";
            this.homepageDataGridView.ReadOnly = true;
            this.homepageDataGridView.RowTemplate.Height = 24;
            this.homepageDataGridView.Size = new System.Drawing.Size(772, 449);
            this.homepageDataGridView.TabIndex = 7;
            // 
            // salesAnalyticsTab
            // 
            this.salesAnalyticsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.salesAnalyticsTab.Controls.Add(this.salesStatisticsPanel);
            this.salesAnalyticsTab.Controls.Add(this.salesStatisticsTitleLabel);
            this.salesAnalyticsTab.Location = new System.Drawing.Point(4, 54);
            this.salesAnalyticsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesAnalyticsTab.Name = "salesAnalyticsTab";
            this.salesAnalyticsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesAnalyticsTab.Size = new System.Drawing.Size(788, 512);
            this.salesAnalyticsTab.TabIndex = 1;
            this.salesAnalyticsTab.Text = "Sales Analytics";
            // 
            // salesStatisticsPanel
            // 
            this.salesStatisticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesStatisticsPanel.AutoSize = true;
            this.salesStatisticsPanel.Controls.Add(this.salesStatisticsChart);
            this.salesStatisticsPanel.Location = new System.Drawing.Point(48, 43);
            this.salesStatisticsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesStatisticsPanel.Name = "salesStatisticsPanel";
            this.salesStatisticsPanel.Size = new System.Drawing.Size(689, 476);
            this.salesStatisticsPanel.TabIndex = 7;
            // 
            // salesStatisticsChart
            // 
            this.salesStatisticsChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.salesStatisticsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.salesStatisticsChart.Legends.Add(legend1);
            this.salesStatisticsChart.Location = new System.Drawing.Point(42, 21);
            this.salesStatisticsChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesStatisticsChart.Name = "salesStatisticsChart";
            this.salesStatisticsChart.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.salesStatisticsChart.Series.Add(series1);
            this.salesStatisticsChart.Size = new System.Drawing.Size(596, 444);
            this.salesStatisticsChart.TabIndex = 2;
            this.salesStatisticsChart.Text = "chart1";
            // 
            // salesStatisticsTitleLabel
            // 
            this.salesStatisticsTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesStatisticsTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesStatisticsTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesStatisticsTitleLabel.Location = new System.Drawing.Point(311, 18);
            this.salesStatisticsTitleLabel.Name = "salesStatisticsTitleLabel";
            this.salesStatisticsTitleLabel.Size = new System.Drawing.Size(156, 19);
            this.salesStatisticsTitleLabel.TabIndex = 6;
            this.salesStatisticsTitleLabel.Text = "SALES STATISTICS";
            this.salesStatisticsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerStatisticsTab
            // 
            this.customerStatisticsTab.BackColor = System.Drawing.Color.LightCoral;
            this.customerStatisticsTab.Controls.Add(this.customerStatisticsPanel);
            this.customerStatisticsTab.Controls.Add(this.customerStatisticsTitleLable);
            this.customerStatisticsTab.Location = new System.Drawing.Point(4, 54);
            this.customerStatisticsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerStatisticsTab.Name = "customerStatisticsTab";
            this.customerStatisticsTab.Size = new System.Drawing.Size(788, 512);
            this.customerStatisticsTab.TabIndex = 2;
            this.customerStatisticsTab.Text = "Customer Statistics";
            // 
            // customerStatisticsPanel
            // 
            this.customerStatisticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerStatisticsPanel.Controls.Add(this.customerStatisticsChart);
            this.customerStatisticsPanel.Location = new System.Drawing.Point(56, 46);
            this.customerStatisticsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerStatisticsPanel.Name = "customerStatisticsPanel";
            this.customerStatisticsPanel.Size = new System.Drawing.Size(673, 469);
            this.customerStatisticsPanel.TabIndex = 6;
            // 
            // customerStatisticsChart
            // 
            this.customerStatisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.customerStatisticsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.customerStatisticsChart.Legends.Add(legend2);
            this.customerStatisticsChart.Location = new System.Drawing.Point(20, 19);
            this.customerStatisticsChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerStatisticsChart.Name = "customerStatisticsChart";
            this.customerStatisticsChart.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.customerStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.customerStatisticsChart.Series.Add(series2);
            this.customerStatisticsChart.Size = new System.Drawing.Size(632, 435);
            this.customerStatisticsChart.TabIndex = 0;
            this.customerStatisticsChart.Text = "chart2";
            // 
            // customerStatisticsTitleLable
            // 
            this.customerStatisticsTitleLable.BackColor = System.Drawing.Color.Transparent;
            this.customerStatisticsTitleLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerStatisticsTitleLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerStatisticsTitleLable.Location = new System.Drawing.Point(300, 17);
            this.customerStatisticsTitleLable.Name = "customerStatisticsTitleLable";
            this.customerStatisticsTitleLable.Size = new System.Drawing.Size(184, 19);
            this.customerStatisticsTitleLable.TabIndex = 5;
            this.customerStatisticsTitleLable.Text = "CUSTOMER STATISTICS";
            this.customerStatisticsTitleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesHistoryTab
            // 
            this.salesHistoryTab.BackColor = System.Drawing.Color.PeachPuff;
            this.salesHistoryTab.Controls.Add(this.salesTitleLabel);
            this.salesHistoryTab.Controls.Add(this.salesHistoryTable);
            this.salesHistoryTab.Location = new System.Drawing.Point(4, 54);
            this.salesHistoryTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesHistoryTab.Name = "salesHistoryTab";
            this.salesHistoryTab.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.salesHistoryTab.Size = new System.Drawing.Size(788, 512);
            this.salesHistoryTab.TabIndex = 3;
            this.salesHistoryTab.Text = "Sales History";
            // 
            // salesTitleLabel
            // 
            this.salesTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesTitleLabel.Location = new System.Drawing.Point(328, 8);
            this.salesTitleLabel.Name = "salesTitleLabel";
            this.salesTitleLabel.Size = new System.Drawing.Size(130, 34);
            this.salesTitleLabel.TabIndex = 4;
            this.salesTitleLabel.Text = "SALES HISTORY";
            this.salesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesHistoryTable
            // 
            this.salesHistoryTable.ColumnCount = 5;
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.Location = new System.Drawing.Point(52, 54);
            this.salesHistoryTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesHistoryTable.Name = "salesHistoryTable";
            this.salesHistoryTable.RowCount = 20;
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.salesHistoryTable.Size = new System.Drawing.Size(675, 456);
            this.salesHistoryTable.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.SkyBlue;
            this.settingsTab.Controls.Add(this.settingsPanel);
            this.settingsTab.Controls.Add(this.passwordLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 54);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(788, 512);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.Controls.Add(this.settingsWindowPanel);
            this.settingsPanel.Location = new System.Drawing.Point(17, 47);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(793, 474);
            this.settingsPanel.TabIndex = 10;
            // 
            // settingsWindowPanel
            // 
            this.settingsWindowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsWindowPanel.AutoSize = true;
            this.settingsWindowPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsWindowPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsWindowPanel.Controls.Add(this.settingsCheckbox2);
            this.settingsWindowPanel.Controls.Add(this.settingsCheckbox1);
            this.settingsWindowPanel.Controls.Add(this.saveButton);
            this.settingsWindowPanel.Location = new System.Drawing.Point(214, 90);
            this.settingsWindowPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsWindowPanel.Name = "settingsWindowPanel";
            this.settingsWindowPanel.Padding = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.settingsWindowPanel.Size = new System.Drawing.Size(378, 204);
            this.settingsWindowPanel.TabIndex = 10;
            // 
            // settingsCheckbox2
            // 
            this.settingsCheckbox2.AutoSize = true;
            this.settingsCheckbox2.Location = new System.Drawing.Point(44, 89);
            this.settingsCheckbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsCheckbox2.Name = "settingsCheckbox2";
            this.settingsCheckbox2.Size = new System.Drawing.Size(226, 23);
            this.settingsCheckbox2.TabIndex = 11;
            this.settingsCheckbox2.Text = "Relogin to see sales analytics";
            this.settingsCheckbox2.UseVisualStyleBackColor = true;
            // 
            // settingsCheckbox1
            // 
            this.settingsCheckbox1.AutoSize = true;
            this.settingsCheckbox1.Location = new System.Drawing.Point(44, 49);
            this.settingsCheckbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsCheckbox1.Name = "settingsCheckbox1";
            this.settingsCheckbox1.Size = new System.Drawing.Size(250, 23);
            this.settingsCheckbox1.TabIndex = 10;
            this.settingsCheckbox1.Text = "Relogin to see customer statistics";
            this.settingsCheckbox1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(124, 135);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 37);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.Location = new System.Drawing.Point(352, 13);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 32);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "SETTINGS";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Price";
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StockAmount";
            this.Column3.HeaderText = "Stock Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftsideMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 630);
            this.MinimumSize = new System.Drawing.Size(1027, 596);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSeidon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftsideMainPanel.ResumeLayout(false);
            this.leftsideMainPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.homepageTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepageDataGridView)).EndInit();
            this.salesAnalyticsTab.ResumeLayout(false);
            this.salesAnalyticsTab.PerformLayout();
            this.salesStatisticsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesStatisticsChart)).EndInit();
            this.customerStatisticsTab.ResumeLayout(false);
            this.customerStatisticsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).EndInit();
            this.salesHistoryTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.settingsWindowPanel.ResumeLayout(false);
            this.settingsWindowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftsideMainPanel;
        private System.Windows.Forms.TabControl homepageTabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button iconButton;
        private System.Windows.Forms.Button logoutButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.DataGridView homepageDataGridView;
        private System.Windows.Forms.TabPage salesAnalyticsTab;
        private System.Windows.Forms.Panel salesStatisticsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesStatisticsChart;
        private System.Windows.Forms.Label salesStatisticsTitleLabel;
        private System.Windows.Forms.TabPage customerStatisticsTab;
        private System.Windows.Forms.Panel customerStatisticsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart customerStatisticsChart;
        private System.Windows.Forms.Label customerStatisticsTitleLable;
        private System.Windows.Forms.TabPage salesHistoryTab;
        private System.Windows.Forms.Label salesTitleLabel;
        private System.Windows.Forms.TableLayoutPanel salesHistoryTable;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel settingsWindowPanel;
        private System.Windows.Forms.CheckBox settingsCheckbox2;
        private System.Windows.Forms.CheckBox settingsCheckbox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
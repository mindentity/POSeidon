namespace POSeidon
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
            System.Windows.Forms.Button addProduct;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.homePagePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.homepageTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.salesAnalyticsTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerStatisticsTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesHistoryTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.salesHistoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsCheckbox2 = new System.Windows.Forms.CheckBox();
            this.settingsCheckbox1 = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            addProduct = new System.Windows.Forms.Button();
            this.homePagePanel.SuspendLayout();
            this.homepageTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.salesAnalyticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.customerStatisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.salesHistoryTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            addProduct.AutoSize = true;
            addProduct.BackColor = System.Drawing.Color.White;
            addProduct.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addProduct.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            addProduct.Location = new System.Drawing.Point(5, 16);
            addProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            addProduct.Name = "addProduct";
            addProduct.Size = new System.Drawing.Size(202, 56);
            addProduct.TabIndex = 1;
            addProduct.UseVisualStyleBackColor = false;
            // 
            // homePagePanel
            // 
            this.homePagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanel.Controls.Add(this.button1);
            this.homePagePanel.Controls.Add(this.infoLabel);
            this.homePagePanel.Location = new System.Drawing.Point(0, 0);
            this.homePagePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePagePanel.Name = "homePagePanel";
            this.homePagePanel.Size = new System.Drawing.Size(187, 458);
            this.homePagePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::POSeidon.Properties.Resources.rsz_poseidon_trident;
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 162);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.Location = new System.Drawing.Point(8, 182);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(30, 122, 30, 122);
            this.infoLabel.Size = new System.Drawing.Size(166, 262);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Information/Notes";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homepageTabControl
            // 
            this.homepageTabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homepageTabControl.Controls.Add(this.homeTab);
            this.homepageTabControl.Controls.Add(this.salesAnalyticsTab);
            this.homepageTabControl.Controls.Add(this.customerStatisticsTab);
            this.homepageTabControl.Controls.Add(this.salesHistoryTab);
            this.homepageTabControl.Controls.Add(this.settingsTab);
            this.homepageTabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homepageTabControl.ItemSize = new System.Drawing.Size(200, 50);
            this.homepageTabControl.Location = new System.Drawing.Point(172, 0);
            this.homepageTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homepageTabControl.Name = "homepageTabControl";
            this.homepageTabControl.Padding = new System.Drawing.Point(30, 3);
            this.homepageTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homepageTabControl.SelectedIndex = 0;
            this.homepageTabControl.Size = new System.Drawing.Size(626, 458);
            this.homepageTabControl.TabIndex = 1;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Transparent;
            this.homeTab.Controls.Add(this.homePanel);
            this.homeTab.Location = new System.Drawing.Point(4, 54);
            this.homeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeTab.Size = new System.Drawing.Size(618, 400);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.PowderBlue;
            this.homePanel.Controls.Add(this.dataGridView1);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(addProduct);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(2, 2);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(614, 396);
            this.homePanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 305);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADD A NEW PRODUCT";
            // 
            // salesAnalyticsTab
            // 
            this.salesAnalyticsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.salesAnalyticsTab.Controls.Add(this.label4);
            this.salesAnalyticsTab.Controls.Add(this.chart1);
            this.salesAnalyticsTab.Location = new System.Drawing.Point(4, 54);
            this.salesAnalyticsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesAnalyticsTab.Name = "salesAnalyticsTab";
            this.salesAnalyticsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesAnalyticsTab.Size = new System.Drawing.Size(618, 400);
            this.salesAnalyticsTab.TabIndex = 1;
            this.salesAnalyticsTab.Text = "Sales Analytics";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(206, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "SALES STATISTICS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(105, 60);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(375, 261);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // customerStatisticsTab
            // 
            this.customerStatisticsTab.BackColor = System.Drawing.Color.LightCoral;
            this.customerStatisticsTab.Controls.Add(this.label3);
            this.customerStatisticsTab.Controls.Add(this.chart2);
            this.customerStatisticsTab.Location = new System.Drawing.Point(4, 54);
            this.customerStatisticsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerStatisticsTab.Name = "customerStatisticsTab";
            this.customerStatisticsTab.Size = new System.Drawing.Size(618, 400);
            this.customerStatisticsTab.TabIndex = 2;
            this.customerStatisticsTab.Text = "Customer Statistics";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(220, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "CUSTOMER STATISTICS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(113, 55);
            this.chart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(375, 261);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // salesHistoryTab
            // 
            this.salesHistoryTab.BackColor = System.Drawing.Color.PeachPuff;
            this.salesHistoryTab.Controls.Add(this.label2);
            this.salesHistoryTab.Controls.Add(this.salesHistoryTable);
            this.salesHistoryTab.Location = new System.Drawing.Point(4, 54);
            this.salesHistoryTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesHistoryTab.Name = "salesHistoryTab";
            this.salesHistoryTab.Size = new System.Drawing.Size(618, 400);
            this.salesHistoryTab.TabIndex = 3;
            this.salesHistoryTab.Text = "Sales History";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "SALES HISTORY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesHistoryTable
            // 
            this.salesHistoryTable.ColumnCount = 5;
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.salesHistoryTable.Location = new System.Drawing.Point(69, 46);
            this.salesHistoryTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesHistoryTable.Name = "salesHistoryTable";
            this.salesHistoryTable.RowCount = 20;
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.salesHistoryTable.Size = new System.Drawing.Size(461, 324);
            this.salesHistoryTable.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.SkyBlue;
            this.settingsTab.Controls.Add(this.panel2);
            this.settingsTab.Controls.Add(this.passwordLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 54);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(618, 400);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.settingsCheckbox2);
            this.panel2.Controls.Add(this.settingsCheckbox1);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Location = new System.Drawing.Point(173, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 183);
            this.panel2.TabIndex = 9;
            // 
            // settingsCheckbox2
            // 
            this.settingsCheckbox2.AutoSize = true;
            this.settingsCheckbox2.Location = new System.Drawing.Point(22, 64);
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
            this.settingsCheckbox1.Location = new System.Drawing.Point(22, 24);
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
            this.saveButton.Location = new System.Drawing.Point(112, 119);
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
            this.passwordLabel.Location = new System.Drawing.Point(250, 55);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 32);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "SETTINGS";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(794, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 402);
            this.panel1.TabIndex = 7;
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = global::POSeidon.Properties.Resources.rsz_1logout_50x60;
            this.logoutButton.Location = new System.Drawing.Point(824, 4);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(46, 44);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(911, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.homepageTabControl);
            this.Controls.Add(this.homePagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "POSeidon";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.homePagePanel.ResumeLayout(false);
            this.homePagePanel.PerformLayout();
            this.homepageTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.salesAnalyticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.customerStatisticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.salesHistoryTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePagePanel;
        private System.Windows.Forms.TabControl homepageTabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage salesAnalyticsTab;
        private System.Windows.Forms.TabPage customerStatisticsTab;
        private System.Windows.Forms.TabPage salesHistoryTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TableLayoutPanel salesHistoryTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox settingsCheckbox2;
        private System.Windows.Forms.CheckBox settingsCheckbox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
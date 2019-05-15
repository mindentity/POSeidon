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
            System.Windows.Forms.Button addProductButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftsideMainPanel = new System.Windows.Forms.Panel();
            this.shoppingCartLeftSidePanelButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.iconButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homepageTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homepageDataGridView = new System.Windows.Forms.DataGridView();
            this.StatisticsTab = new System.Windows.Forms.TabPage();
            this.statisticsPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.statisticsHomepageNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.customerStatisticsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.customerStatisticsPanel = new System.Windows.Forms.Panel();
            this.customerStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesStatisticsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.salesStatisticsPanel = new System.Windows.Forms.Panel();
            this.salesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customersTabLabel = new System.Windows.Forms.Label();
            this.customerTabDataGridView = new System.Windows.Forms.DataGridView();
            this.customerFirstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCustomerDataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.suppliersTab = new System.Windows.Forms.TabPage();
            this.suppliersTabLabe = new System.Windows.Forms.Label();
            this.suppliersTabDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierNameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteSupplierDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.salesAndPurchasingTab = new System.Windows.Forms.TabPage();
            this.salesAndPurchasingPanel = new System.Windows.Forms.Panel();
            this.salesAndPurchasingNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.salesNavigatorPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.salesHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleAmountSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.purchasingNavigatorPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.purchasingDataGridView = new System.Windows.Forms.DataGridView();
            this.productNamePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPricePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPurchasingAmountPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPricePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelLogPurchasingDataGridViewImageBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsChildPanel1 = new System.Windows.Forms.Panel();
            this.settingsCheckbox2 = new System.Windows.Forms.CheckBox();
            this.settingsCheckbox1 = new System.Windows.Forms.CheckBox();
            this.settingsChildPanel2 = new System.Windows.Forms.Panel();
            this.weightUnitComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.weightUnitSettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.currencySettingsGroupSizeNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.currencySettingsGroupSizeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsGroupSeparatorComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.currencySettingsDecimalSeparatorComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.currencySettingsGroupSeparatorLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsDecimalSeparatorLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsPutSpaceCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.currencySettingsSymbolPlacementRightRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.currencySettingsSymbolPlacementLeftRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.currencySettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsSymbolPlacementLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.currencySettingsComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.productNameHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddHomePageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            addProductButton = new System.Windows.Forms.Button();
            this.leftsideMainPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.homepageTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepageDataGridView)).BeginInit();
            this.StatisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPanel)).BeginInit();
            this.statisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsHomepageNavigator)).BeginInit();
            this.statisticsHomepageNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsPage)).BeginInit();
            this.customerStatisticsPage.SuspendLayout();
            this.customerStatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesStatisticsPage)).BeginInit();
            this.salesStatisticsPage.SuspendLayout();
            this.salesStatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTabDataGridView)).BeginInit();
            this.suppliersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).BeginInit();
            this.salesAndPurchasingTab.SuspendLayout();
            this.salesAndPurchasingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesAndPurchasingNavigator)).BeginInit();
            this.salesAndPurchasingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesNavigatorPage)).BeginInit();
            this.salesNavigatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingNavigatorPage)).BeginInit();
            this.purchasingNavigatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingDataGridView)).BeginInit();
            this.settingsTab.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.settingsChildPanel1.SuspendLayout();
            this.settingsChildPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUnitComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox.Panel)).BeginInit();
            this.currencySettingsGroupBox.Panel.SuspendLayout();
            this.currencySettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupSeparatorComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsDecimalSeparatorComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsComboBox)).BeginInit();
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
            addProductButton.Location = new System.Drawing.Point(2, 7);
            addProductButton.Margin = new System.Windows.Forms.Padding(2);
            addProductButton.Name = "addProductButton";
            addProductButton.Padding = new System.Windows.Forms.Padding(4);
            addProductButton.Size = new System.Drawing.Size(249, 64);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "ADD A NEW PRODUCT";
            addProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // leftsideMainPanel
            // 
            this.leftsideMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftsideMainPanel.AutoScroll = true;
            this.leftsideMainPanel.AutoSize = true;
            this.leftsideMainPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.leftsideMainPanel.Controls.Add(this.shoppingCartLeftSidePanelButton);
            this.leftsideMainPanel.Controls.Add(this.logoutButton);
            this.leftsideMainPanel.Controls.Add(this.iconButton);
            this.leftsideMainPanel.Controls.Add(this.infoLabel);
            this.leftsideMainPanel.Location = new System.Drawing.Point(8, 3);
            this.leftsideMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftsideMainPanel.Name = "leftsideMainPanel";
            this.leftsideMainPanel.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.leftsideMainPanel.Size = new System.Drawing.Size(214, 573);
            this.leftsideMainPanel.TabIndex = 0;
            // 
            // shoppingCartLeftSidePanelButton
            // 
            this.shoppingCartLeftSidePanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingCartLeftSidePanelButton.AutoSize = true;
            this.shoppingCartLeftSidePanelButton.BackColor = System.Drawing.Color.Transparent;
            this.shoppingCartLeftSidePanelButton.BackgroundImage = global::POSeidon.Properties.Resources.order;
            this.shoppingCartLeftSidePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shoppingCartLeftSidePanelButton.Location = new System.Drawing.Point(21, 196);
            this.shoppingCartLeftSidePanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.shoppingCartLeftSidePanelButton.Name = "shoppingCartLeftSidePanelButton";
            this.shoppingCartLeftSidePanelButton.Size = new System.Drawing.Size(70, 72);
            this.shoppingCartLeftSidePanelButton.TabIndex = 5;
            this.shoppingCartLeftSidePanelButton.UseVisualStyleBackColor = false;
            this.shoppingCartLeftSidePanelButton.Click += new System.EventHandler(this.ShoppingCartLeftSidePanelButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = global::POSeidon.Properties.Resources.rsz_1logout_50x60;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.Location = new System.Drawing.Point(110, 196);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(48, 44);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.UseVisualStyleBackColor = false;
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
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(820, 573);
            this.mainPanel.TabIndex = 1;
            // 
            // homepageTabControl
            // 
            this.homepageTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepageTabControl.Controls.Add(this.homeTab);
            this.homepageTabControl.Controls.Add(this.StatisticsTab);
            this.homepageTabControl.Controls.Add(this.customersTab);
            this.homepageTabControl.Controls.Add(this.suppliersTab);
            this.homepageTabControl.Controls.Add(this.salesAndPurchasingTab);
            this.homepageTabControl.Controls.Add(this.settingsTab);
            this.homepageTabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homepageTabControl.ItemSize = new System.Drawing.Size(200, 50);
            this.homepageTabControl.Location = new System.Drawing.Point(2, 6);
            this.homepageTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.homepageTabControl.Name = "homepageTabControl";
            this.homepageTabControl.Padding = new System.Drawing.Point(30, 3);
            this.homepageTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homepageTabControl.SelectedIndex = 0;
            this.homepageTabControl.Size = new System.Drawing.Size(796, 547);
            this.homepageTabControl.TabIndex = 3;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Transparent;
            this.homeTab.Controls.Add(this.homePanel);
            this.homeTab.Location = new System.Drawing.Point(4, 54);
            this.homeTab.Margin = new System.Windows.Forms.Padding(2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(2);
            this.homeTab.Size = new System.Drawing.Size(788, 489);
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
            this.homePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(786, 560);
            this.homePanel.TabIndex = 0;
            // 
            // homepageDataGridView
            // 
            this.homepageDataGridView.AllowUserToAddRows = false;
            this.homepageDataGridView.AllowUserToDeleteRows = false;
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
            this.productNameHomePageDataGridViewTextBoxColumn,
            this.productPriceHomePageDataGridViewTextBoxColumn,
            this.productStockHomePageDataGridViewTextBoxColumn,
            this.productAddHomePageDataGridViewImageColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.homepageDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.homepageDataGridView.Location = new System.Drawing.Point(0, 75);
            this.homepageDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.homepageDataGridView.MultiSelect = false;
            this.homepageDataGridView.Name = "homepageDataGridView";
            this.homepageDataGridView.ReadOnly = true;
            this.homepageDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.homepageDataGridView.RowTemplate.Height = 24;
            this.homepageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.homepageDataGridView.Size = new System.Drawing.Size(786, 425);
            this.homepageDataGridView.TabIndex = 7;
            this.homepageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomepageDataGridView_CellClick);
            // 
            // StatisticsTab
            // 
            this.StatisticsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.StatisticsTab.Controls.Add(this.statisticsPanel);
            this.StatisticsTab.Location = new System.Drawing.Point(4, 54);
            this.StatisticsTab.Margin = new System.Windows.Forms.Padding(2);
            this.StatisticsTab.Name = "StatisticsTab";
            this.StatisticsTab.Padding = new System.Windows.Forms.Padding(2);
            this.StatisticsTab.Size = new System.Drawing.Size(788, 489);
            this.StatisticsTab.TabIndex = 1;
            this.StatisticsTab.Text = "Statistics";
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsPanel.Controls.Add(this.statisticsHomepageNavigator);
            this.statisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.statisticsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(785, 500);
            this.statisticsPanel.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.statisticsPanel.TabIndex = 7;
            // 
            // statisticsHomepageNavigator
            // 
            this.statisticsHomepageNavigator.Location = new System.Drawing.Point(0, 0);
            this.statisticsHomepageNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsHomepageNavigator.Name = "statisticsHomepageNavigator";
            this.statisticsHomepageNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.statisticsHomepageNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.customerStatisticsPage,
            this.salesStatisticsPage});
            this.statisticsHomepageNavigator.SelectedIndex = 1;
            this.statisticsHomepageNavigator.Size = new System.Drawing.Size(1044, 596);
            this.statisticsHomepageNavigator.TabIndex = 0;
            this.statisticsHomepageNavigator.Text = "kryptonNavigator1";
            // 
            // customerStatisticsPage
            // 
            this.customerStatisticsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.customerStatisticsPage.Controls.Add(this.customerStatisticsPanel);
            this.customerStatisticsPage.Flags = 65534;
            this.customerStatisticsPage.LastVisibleSet = true;
            this.customerStatisticsPage.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.customerStatisticsPage.Name = "customerStatisticsPage";
            this.customerStatisticsPage.Size = new System.Drawing.Size(786, 457);
            this.customerStatisticsPage.Text = "Customer";
            this.customerStatisticsPage.ToolTipTitle = "Page ToolTip";
            this.customerStatisticsPage.UniqueName = "1fbf379b70634940bcf9c585c1b0ac13";
            // 
            // customerStatisticsPanel
            // 
            this.customerStatisticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerStatisticsPanel.Controls.Add(this.customerStatisticsChart);
            this.customerStatisticsPanel.Location = new System.Drawing.Point(123, 15);
            this.customerStatisticsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsPanel.Name = "customerStatisticsPanel";
            this.customerStatisticsPanel.Size = new System.Drawing.Size(645, 423);
            this.customerStatisticsPanel.TabIndex = 7;
            // 
            // customerStatisticsChart
            // 
            this.customerStatisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea7";
            this.customerStatisticsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend7";
            this.customerStatisticsChart.Legends.Add(legend1);
            this.customerStatisticsChart.Location = new System.Drawing.Point(20, 19);
            this.customerStatisticsChart.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsChart.Name = "customerStatisticsChart";
            this.customerStatisticsChart.Padding = new System.Windows.Forms.Padding(8);
            this.customerStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea7";
            series1.Legend = "Legend7";
            series1.Name = "Series7";
            this.customerStatisticsChart.Series.Add(series1);
            this.customerStatisticsChart.Size = new System.Drawing.Size(604, 389);
            this.customerStatisticsChart.TabIndex = 0;
            this.customerStatisticsChart.Text = "Customer Statistics";
            // 
            // salesStatisticsPage
            // 
            this.salesStatisticsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.salesStatisticsPage.Controls.Add(this.salesStatisticsPanel);
            this.salesStatisticsPage.Flags = 65534;
            this.salesStatisticsPage.LastVisibleSet = true;
            this.salesStatisticsPage.Margin = new System.Windows.Forms.Padding(2);
            this.salesStatisticsPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.salesStatisticsPage.Name = "salesStatisticsPage";
            this.salesStatisticsPage.Size = new System.Drawing.Size(1042, 567);
            this.salesStatisticsPage.Text = "Sales";
            this.salesStatisticsPage.ToolTipTitle = "Page ToolTip";
            this.salesStatisticsPage.UniqueName = "1f51a78fbc9a446f981d86768a13541a";
            // 
            // salesStatisticsPanel
            // 
            this.salesStatisticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesStatisticsPanel.Controls.Add(this.salesChart);
            this.salesStatisticsPanel.Location = new System.Drawing.Point(123, 15);
            this.salesStatisticsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.salesStatisticsPanel.Name = "salesStatisticsPanel";
            this.salesStatisticsPanel.Size = new System.Drawing.Size(900, 533);
            this.salesStatisticsPanel.TabIndex = 8;
            // 
            // salesChart
            // 
            this.salesChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea8";
            this.salesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend8";
            this.salesChart.Legends.Add(legend2);
            this.salesChart.Location = new System.Drawing.Point(20, 19);
            this.salesChart.Margin = new System.Windows.Forms.Padding(2);
            this.salesChart.Name = "salesChart";
            this.salesChart.Padding = new System.Windows.Forms.Padding(8);
            this.salesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea8";
            series2.Legend = "Legend8";
            series2.Name = "Series8";
            this.salesChart.Series.Add(series2);
            this.salesChart.Size = new System.Drawing.Size(860, 498);
            this.salesChart.TabIndex = 0;
            this.salesChart.Text = "Sales Chart";
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.customersTab.Controls.Add(this.customersTabLabel);
            this.customersTab.Controls.Add(this.customerTabDataGridView);
            this.customersTab.Location = new System.Drawing.Point(4, 54);
            this.customersTab.Margin = new System.Windows.Forms.Padding(2);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(788, 489);
            this.customersTab.TabIndex = 2;
            this.customersTab.Text = "Customers";
            // 
            // customersTabLabel
            // 
            this.customersTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.customersTabLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersTabLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customersTabLabel.Location = new System.Drawing.Point(332, 4);
            this.customersTabLabel.Name = "customersTabLabel";
            this.customersTabLabel.Size = new System.Drawing.Size(130, 34);
            this.customersTabLabel.TabIndex = 11;
            this.customersTabLabel.Text = "CUSTOMERS";
            this.customersTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerTabDataGridView
            // 
            this.customerTabDataGridView.AllowUserToAddRows = false;
            this.customerTabDataGridView.AllowUserToResizeColumns = false;
            this.customerTabDataGridView.AllowUserToResizeRows = false;
            this.customerTabDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerTabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerTabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerTabDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.customerTabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerFirstNameDataGridViewTextBoxColumn1,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn2,
            this.customerEmailDataGridViewTextBoxColumn3,
            this.customerAddressDataGridViewTextBoxColumn4,
            this.deleteCustomerDataGridViewImageColumn3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerTabDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerTabDataGridView.Location = new System.Drawing.Point(0, 40);
            this.customerTabDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customerTabDataGridView.Name = "customerTabDataGridView";
            this.customerTabDataGridView.RowTemplate.Height = 24;
            this.customerTabDataGridView.Size = new System.Drawing.Size(789, 460);
            this.customerTabDataGridView.TabIndex = 10;
            // 
            // customerFirstNameDataGridViewTextBoxColumn1
            // 
            this.customerFirstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.customerFirstNameDataGridViewTextBoxColumn1.Name = "customerFirstNameDataGridViewTextBoxColumn1";
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneDataGridViewTextBoxColumn2
            // 
            this.customerPhoneDataGridViewTextBoxColumn2.HeaderText = "Phone";
            this.customerPhoneDataGridViewTextBoxColumn2.Name = "customerPhoneDataGridViewTextBoxColumn2";
            // 
            // customerEmailDataGridViewTextBoxColumn3
            // 
            this.customerEmailDataGridViewTextBoxColumn3.HeaderText = "Email";
            this.customerEmailDataGridViewTextBoxColumn3.Name = "customerEmailDataGridViewTextBoxColumn3";
            // 
            // customerAddressDataGridViewTextBoxColumn4
            // 
            this.customerAddressDataGridViewTextBoxColumn4.HeaderText = "Address";
            this.customerAddressDataGridViewTextBoxColumn4.Name = "customerAddressDataGridViewTextBoxColumn4";
            // 
            // deleteCustomerDataGridViewImageColumn3
            // 
            this.deleteCustomerDataGridViewImageColumn3.HeaderText = "Delete";
            this.deleteCustomerDataGridViewImageColumn3.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteCustomerDataGridViewImageColumn3.Name = "deleteCustomerDataGridViewImageColumn3";
            // 
            // suppliersTab
            // 
            this.suppliersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.suppliersTab.Controls.Add(this.suppliersTabLabe);
            this.suppliersTab.Controls.Add(this.suppliersTabDataGridView);
            this.suppliersTab.Location = new System.Drawing.Point(4, 54);
            this.suppliersTab.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersTab.Name = "suppliersTab";
            this.suppliersTab.Size = new System.Drawing.Size(788, 489);
            this.suppliersTab.TabIndex = 5;
            this.suppliersTab.Text = "Suppliers";
            // 
            // suppliersTabLabe
            // 
            this.suppliersTabLabe.BackColor = System.Drawing.Color.Transparent;
            this.suppliersTabLabe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersTabLabe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suppliersTabLabe.Location = new System.Drawing.Point(331, 4);
            this.suppliersTabLabe.Name = "suppliersTabLabe";
            this.suppliersTabLabe.Size = new System.Drawing.Size(130, 34);
            this.suppliersTabLabe.TabIndex = 10;
            this.suppliersTabLabe.Text = "SUPPLIERS";
            this.suppliersTabLabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suppliersTabDataGridView
            // 
            this.suppliersTabDataGridView.AllowUserToAddRows = false;
            this.suppliersTabDataGridView.AllowUserToResizeColumns = false;
            this.suppliersTabDataGridView.AllowUserToResizeRows = false;
            this.suppliersTabDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppliersTabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersTabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.suppliersTabDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(210)))), ((int)(((byte)(232)))));
            this.suppliersTabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersTabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNameDataGridViewTextBoxColumn5,
            this.supplierPhoneDataGridViewTextBoxColumn6,
            this.supplierEmailDataGridViewTextBoxColumn8,
            this.supplierAddressDataGridViewTextBoxColumn8,
            this.deleteSupplierDataGridViewImageColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersTabDataGridView.Location = new System.Drawing.Point(0, 40);
            this.suppliersTabDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersTabDataGridView.Name = "suppliersTabDataGridView";
            this.suppliersTabDataGridView.RowTemplate.Height = 24;
            this.suppliersTabDataGridView.Size = new System.Drawing.Size(790, 460);
            this.suppliersTabDataGridView.TabIndex = 9;
            // 
            // supplierNameDataGridViewTextBoxColumn5
            // 
            this.supplierNameDataGridViewTextBoxColumn5.HeaderText = "Name";
            this.supplierNameDataGridViewTextBoxColumn5.Name = "supplierNameDataGridViewTextBoxColumn5";
            // 
            // supplierPhoneDataGridViewTextBoxColumn6
            // 
            this.supplierPhoneDataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.supplierPhoneDataGridViewTextBoxColumn6.Name = "supplierPhoneDataGridViewTextBoxColumn6";
            // 
            // supplierEmailDataGridViewTextBoxColumn8
            // 
            this.supplierEmailDataGridViewTextBoxColumn8.HeaderText = "Email";
            this.supplierEmailDataGridViewTextBoxColumn8.Name = "supplierEmailDataGridViewTextBoxColumn8";
            // 
            // supplierAddressDataGridViewTextBoxColumn8
            // 
            this.supplierAddressDataGridViewTextBoxColumn8.HeaderText = "Address";
            this.supplierAddressDataGridViewTextBoxColumn8.Name = "supplierAddressDataGridViewTextBoxColumn8";
            // 
            // deleteSupplierDataGridViewImageColumn
            // 
            this.deleteSupplierDataGridViewImageColumn.HeaderText = "Delete";
            this.deleteSupplierDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteSupplierDataGridViewImageColumn.Name = "deleteSupplierDataGridViewImageColumn";
            // 
            // salesAndPurchasingTab
            // 
            this.salesAndPurchasingTab.BackColor = System.Drawing.Color.PeachPuff;
            this.salesAndPurchasingTab.Controls.Add(this.salesAndPurchasingPanel);
            this.salesAndPurchasingTab.Location = new System.Drawing.Point(4, 54);
            this.salesAndPurchasingTab.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingTab.Name = "salesAndPurchasingTab";
            this.salesAndPurchasingTab.Padding = new System.Windows.Forms.Padding(8);
            this.salesAndPurchasingTab.Size = new System.Drawing.Size(788, 489);
            this.salesAndPurchasingTab.TabIndex = 3;
            this.salesAndPurchasingTab.Text = "Sales and Purchasing";
            // 
            // salesAndPurchasingPanel
            // 
            this.salesAndPurchasingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesAndPurchasingPanel.AutoSize = true;
            this.salesAndPurchasingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.salesAndPurchasingPanel.Controls.Add(this.salesAndPurchasingNavigator);
            this.salesAndPurchasingPanel.Location = new System.Drawing.Point(0, 0);
            this.salesAndPurchasingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingPanel.Name = "salesAndPurchasingPanel";
            this.salesAndPurchasingPanel.Size = new System.Drawing.Size(1055, 617);
            this.salesAndPurchasingPanel.TabIndex = 0;
            // 
            // salesAndPurchasingNavigator
            // 
            this.salesAndPurchasingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesAndPurchasingNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingNavigator.Name = "salesAndPurchasingNavigator";
            this.salesAndPurchasingNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.salesAndPurchasingNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.salesNavigatorPage,
            this.purchasingNavigatorPage});
            this.salesAndPurchasingNavigator.SelectedIndex = 1;
            this.salesAndPurchasingNavigator.Size = new System.Drawing.Size(1053, 615);
            this.salesAndPurchasingNavigator.TabIndex = 0;
            this.salesAndPurchasingNavigator.Text = "Sales and Purchasing";
            // 
            // salesNavigatorPage
            // 
            this.salesNavigatorPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.salesNavigatorPage.AutoScroll = true;
            this.salesNavigatorPage.Controls.Add(this.salesHistoryDataGridView);
            this.salesNavigatorPage.Flags = 65534;
            this.salesNavigatorPage.LastVisibleSet = true;
            this.salesNavigatorPage.Margin = new System.Windows.Forms.Padding(2);
            this.salesNavigatorPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.salesNavigatorPage.Name = "salesNavigatorPage";
            this.salesNavigatorPage.Size = new System.Drawing.Size(788, 473);
            this.salesNavigatorPage.Text = "Sales";
            this.salesNavigatorPage.ToolTipTitle = "Page ToolTip";
            this.salesNavigatorPage.UniqueName = "6c08f90acd56447b9d6f9ea6bd5cfcc4";
            // 
            // salesHistoryDataGridView
            // 
            this.salesHistoryDataGridView.AllowUserToAddRows = false;
            this.salesHistoryDataGridView.AllowUserToResizeColumns = false;
            this.salesHistoryDataGridView.AllowUserToResizeRows = false;
            this.salesHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesHistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salesHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameSalesDataGridViewTextBoxColumn,
            this.salePriceSalesDataGridViewTextBoxColumn,
            this.saleAmountSalesDataGridViewTextBoxColumn,
            this.totalPriceSalesDataGridViewTextBoxColumn,
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.salesHistoryDataGridView.Location = new System.Drawing.Point(2, 2);
            this.salesHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.salesHistoryDataGridView.Name = "salesHistoryDataGridView";
            this.salesHistoryDataGridView.RowTemplate.Height = 24;
            this.salesHistoryDataGridView.Size = new System.Drawing.Size(785, 472);
            this.salesHistoryDataGridView.TabIndex = 9;
            // 
            // productNameSalesDataGridViewTextBoxColumn
            // 
            this.productNameSalesDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameSalesDataGridViewTextBoxColumn.Name = "productNameSalesDataGridViewTextBoxColumn";
            // 
            // salePriceSalesDataGridViewTextBoxColumn
            // 
            this.salePriceSalesDataGridViewTextBoxColumn.HeaderText = "Price";
            this.salePriceSalesDataGridViewTextBoxColumn.Name = "salePriceSalesDataGridViewTextBoxColumn";
            // 
            // saleAmountSalesDataGridViewTextBoxColumn
            // 
            this.saleAmountSalesDataGridViewTextBoxColumn.HeaderText = "Sale Amount";
            this.saleAmountSalesDataGridViewTextBoxColumn.Name = "saleAmountSalesDataGridViewTextBoxColumn";
            // 
            // totalPriceSalesDataGridViewTextBoxColumn
            // 
            this.totalPriceSalesDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceSalesDataGridViewTextBoxColumn.Name = "totalPriceSalesDataGridViewTextBoxColumn";
            // 
            // cancelLogSalesHistoryDataGridViewImageBoxColumn
            // 
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.HeaderText = "Cancel";
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Name = "cancelLogSalesHistoryDataGridViewImageBoxColumn";
            // 
            // purchasingNavigatorPage
            // 
            this.purchasingNavigatorPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.purchasingNavigatorPage.AutoScroll = true;
            this.purchasingNavigatorPage.Controls.Add(this.purchasingDataGridView);
            this.purchasingNavigatorPage.Flags = 65534;
            this.purchasingNavigatorPage.LastVisibleSet = true;
            this.purchasingNavigatorPage.Margin = new System.Windows.Forms.Padding(2);
            this.purchasingNavigatorPage.MinimumSize = new System.Drawing.Size(38, 41);
            this.purchasingNavigatorPage.Name = "purchasingNavigatorPage";
            this.purchasingNavigatorPage.Size = new System.Drawing.Size(1051, 586);
            this.purchasingNavigatorPage.Text = "Purchasing";
            this.purchasingNavigatorPage.ToolTipTitle = "Page ToolTip";
            this.purchasingNavigatorPage.UniqueName = "3753607d328a4c3a9448a9b19123061d";
            // 
            // purchasingDataGridView
            // 
            this.purchasingDataGridView.AllowUserToAddRows = false;
            this.purchasingDataGridView.AllowUserToResizeColumns = false;
            this.purchasingDataGridView.AllowUserToResizeRows = false;
            this.purchasingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purchasingDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchasingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNamePurchasingDataGridViewTextBoxColumn,
            this.productPricePurchasingDataGridViewTextBoxColumn,
            this.productPurchasingAmountPurchasingDataGridViewTextBoxColumn,
            this.totalPricePurchasingDataGridViewTextBoxColumn,
            this.cancelLogPurchasingDataGridViewImageBoxColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchasingDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.purchasingDataGridView.Location = new System.Drawing.Point(-1, 2);
            this.purchasingDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.purchasingDataGridView.Name = "purchasingDataGridView";
            this.purchasingDataGridView.RowTemplate.Height = 24;
            this.purchasingDataGridView.Size = new System.Drawing.Size(1048, 583);
            this.purchasingDataGridView.TabIndex = 9;
            // 
            // productNamePurchasingDataGridViewTextBoxColumn
            // 
            this.productNamePurchasingDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNamePurchasingDataGridViewTextBoxColumn.Name = "productNamePurchasingDataGridViewTextBoxColumn";
            // 
            // productPricePurchasingDataGridViewTextBoxColumn
            // 
            this.productPricePurchasingDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPricePurchasingDataGridViewTextBoxColumn.Name = "productPricePurchasingDataGridViewTextBoxColumn";
            // 
            // productPurchasingAmountPurchasingDataGridViewTextBoxColumn
            // 
            this.productPurchasingAmountPurchasingDataGridViewTextBoxColumn.HeaderText = "Purchase Amount";
            this.productPurchasingAmountPurchasingDataGridViewTextBoxColumn.Name = "productPurchasingAmountPurchasingDataGridViewTextBoxColumn";
            // 
            // totalPricePurchasingDataGridViewTextBoxColumn
            // 
            this.totalPricePurchasingDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPricePurchasingDataGridViewTextBoxColumn.Name = "totalPricePurchasingDataGridViewTextBoxColumn";
            // 
            // cancelLogPurchasingDataGridViewImageBoxColumn
            // 
            this.cancelLogPurchasingDataGridViewImageBoxColumn.HeaderText = "Cancel";
            this.cancelLogPurchasingDataGridViewImageBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.cancelLogPurchasingDataGridViewImageBoxColumn.Name = "cancelLogPurchasingDataGridViewImageBoxColumn";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.settingsTab.Controls.Add(this.settingsPanel);
            this.settingsTab.Controls.Add(this.passwordLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 54);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(788, 489);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            this.settingsTab.Enter += new System.EventHandler(this.SettingsTab_Enter);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.settingsChildPanel1);
            this.settingsPanel.Controls.Add(this.settingsChildPanel2);
            this.settingsPanel.Controls.Add(this.saveButton);
            this.settingsPanel.Location = new System.Drawing.Point(0, 35);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(788, 463);
            this.settingsPanel.TabIndex = 10;
            // 
            // settingsChildPanel1
            // 
            this.settingsChildPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsChildPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsChildPanel1.Controls.Add(this.settingsCheckbox2);
            this.settingsChildPanel1.Controls.Add(this.settingsCheckbox1);
            this.settingsChildPanel1.Location = new System.Drawing.Point(12, 15);
            this.settingsChildPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.settingsChildPanel1.Name = "settingsChildPanel1";
            this.settingsChildPanel1.Size = new System.Drawing.Size(283, 145);
            this.settingsChildPanel1.TabIndex = 12;
            // 
            // settingsCheckbox2
            // 
            this.settingsCheckbox2.AutoSize = true;
            this.settingsCheckbox2.Location = new System.Drawing.Point(9, 15);
            this.settingsCheckbox2.Margin = new System.Windows.Forms.Padding(2);
            this.settingsCheckbox2.Name = "settingsCheckbox2";
            this.settingsCheckbox2.Size = new System.Drawing.Size(226, 23);
            this.settingsCheckbox2.TabIndex = 11;
            this.settingsCheckbox2.Text = "Relogin to see sales analytics";
            this.settingsCheckbox2.UseVisualStyleBackColor = true;
            // 
            // settingsCheckbox1
            // 
            this.settingsCheckbox1.AutoSize = true;
            this.settingsCheckbox1.Location = new System.Drawing.Point(9, 64);
            this.settingsCheckbox1.Margin = new System.Windows.Forms.Padding(2);
            this.settingsCheckbox1.Name = "settingsCheckbox1";
            this.settingsCheckbox1.Size = new System.Drawing.Size(250, 23);
            this.settingsCheckbox1.TabIndex = 10;
            this.settingsCheckbox1.Text = "Relogin to see customer statistics";
            this.settingsCheckbox1.UseVisualStyleBackColor = true;
            // 
            // settingsChildPanel2
            // 
            this.settingsChildPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsChildPanel2.AutoSize = true;
            this.settingsChildPanel2.BackColor = System.Drawing.Color.Transparent;
            this.settingsChildPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsChildPanel2.Controls.Add(this.weightUnitComboBox);
            this.settingsChildPanel2.Controls.Add(this.weightUnitSettingsLabel);
            this.settingsChildPanel2.Controls.Add(this.currencySettingsGroupBox);
            this.settingsChildPanel2.Location = new System.Drawing.Point(326, 15);
            this.settingsChildPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.settingsChildPanel2.Name = "settingsChildPanel2";
            this.settingsChildPanel2.Padding = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.settingsChildPanel2.Size = new System.Drawing.Size(388, 375);
            this.settingsChildPanel2.TabIndex = 10;
            // 
            // weightUnitComboBox
            // 
            this.weightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightUnitComboBox.DropDownWidth = 121;
            this.weightUnitComboBox.Location = new System.Drawing.Point(149, 319);
            this.weightUnitComboBox.Name = "weightUnitComboBox";
            this.weightUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.weightUnitComboBox.TabIndex = 18;
            // 
            // weightUnitSettingsLabel
            // 
            this.weightUnitSettingsLabel.Location = new System.Drawing.Point(37, 320);
            this.weightUnitSettingsLabel.Name = "weightUnitSettingsLabel";
            this.weightUnitSettingsLabel.Size = new System.Drawing.Size(79, 20);
            this.weightUnitSettingsLabel.TabIndex = 17;
            this.weightUnitSettingsLabel.Values.Text = "Weight Unit:";
            // 
            // currencySettingsGroupBox
            // 
            this.currencySettingsGroupBox.CaptionOverlap = 0D;
            this.currencySettingsGroupBox.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.currencySettingsGroupBox.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.currencySettingsGroupBox.Location = new System.Drawing.Point(16, 27);
            this.currencySettingsGroupBox.Name = "currencySettingsGroupBox";
            // 
            // currencySettingsGroupBox.Panel
            // 
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsGroupSizeNumericUpDown);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsGroupSizeLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsGroupSeparatorComboBox);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsDecimalSeparatorComboBox);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsGroupSeparatorLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsDecimalSeparatorLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsPutSpaceCheckBox);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsSymbolPlacementRightRadioButton);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsSymbolPlacementLeftRadioButton);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsSymbolPlacementLabel);
            this.currencySettingsGroupBox.Panel.Controls.Add(this.currencySettingsComboBox);
            this.currencySettingsGroupBox.Size = new System.Drawing.Size(343, 270);
            this.currencySettingsGroupBox.TabIndex = 16;
            this.currencySettingsGroupBox.Values.Heading = "Currency Settings";
            // 
            // currencySettingsGroupSizeNumericUpDown
            // 
            this.currencySettingsGroupSizeNumericUpDown.DecimalPlaces = 99;
            this.currencySettingsGroupSizeNumericUpDown.Location = new System.Drawing.Point(131, 193);
            this.currencySettingsGroupSizeNumericUpDown.Name = "currencySettingsGroupSizeNumericUpDown";
            this.currencySettingsGroupSizeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.currencySettingsGroupSizeNumericUpDown.TabIndex = 23;
            // 
            // currencySettingsGroupSizeLabel
            // 
            this.currencySettingsGroupSizeLabel.Location = new System.Drawing.Point(19, 195);
            this.currencySettingsGroupSizeLabel.Name = "currencySettingsGroupSizeLabel";
            this.currencySettingsGroupSizeLabel.Size = new System.Drawing.Size(72, 20);
            this.currencySettingsGroupSizeLabel.TabIndex = 22;
            this.currencySettingsGroupSizeLabel.Values.Text = "Group Size:";
            // 
            // currencySettingsGroupSeparatorComboBox
            // 
            this.currencySettingsGroupSeparatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsGroupSeparatorComboBox.DropDownWidth = 121;
            this.currencySettingsGroupSeparatorComboBox.Items.AddRange(new object[] {
            ".",
            ","});
            this.currencySettingsGroupSeparatorComboBox.Location = new System.Drawing.Point(131, 164);
            this.currencySettingsGroupSeparatorComboBox.Name = "currencySettingsGroupSeparatorComboBox";
            this.currencySettingsGroupSeparatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.currencySettingsGroupSeparatorComboBox.TabIndex = 21;
            // 
            // currencySettingsDecimalSeparatorComboBox
            // 
            this.currencySettingsDecimalSeparatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsDecimalSeparatorComboBox.DropDownWidth = 121;
            this.currencySettingsDecimalSeparatorComboBox.Items.AddRange(new object[] {
            ".",
            ","});
            this.currencySettingsDecimalSeparatorComboBox.Location = new System.Drawing.Point(131, 124);
            this.currencySettingsDecimalSeparatorComboBox.Name = "currencySettingsDecimalSeparatorComboBox";
            this.currencySettingsDecimalSeparatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.currencySettingsDecimalSeparatorComboBox.TabIndex = 20;
            // 
            // currencySettingsGroupSeparatorLabel
            // 
            this.currencySettingsGroupSeparatorLabel.Location = new System.Drawing.Point(19, 166);
            this.currencySettingsGroupSeparatorLabel.Name = "currencySettingsGroupSeparatorLabel";
            this.currencySettingsGroupSeparatorLabel.Size = new System.Drawing.Size(104, 20);
            this.currencySettingsGroupSeparatorLabel.TabIndex = 19;
            this.currencySettingsGroupSeparatorLabel.Values.Text = "Group Separator:";
            // 
            // currencySettingsDecimalSeparatorLabel
            // 
            this.currencySettingsDecimalSeparatorLabel.Location = new System.Drawing.Point(19, 126);
            this.currencySettingsDecimalSeparatorLabel.Name = "currencySettingsDecimalSeparatorLabel";
            this.currencySettingsDecimalSeparatorLabel.Size = new System.Drawing.Size(113, 20);
            this.currencySettingsDecimalSeparatorLabel.TabIndex = 18;
            this.currencySettingsDecimalSeparatorLabel.Values.Text = "Decimal Separator:";
            // 
            // currencySettingsPutSpaceCheckBox
            // 
            this.currencySettingsPutSpaceCheckBox.Location = new System.Drawing.Point(19, 96);
            this.currencySettingsPutSpaceCheckBox.Name = "currencySettingsPutSpaceCheckBox";
            this.currencySettingsPutSpaceCheckBox.Size = new System.Drawing.Size(290, 20);
            this.currencySettingsPutSpaceCheckBox.TabIndex = 17;
            this.currencySettingsPutSpaceCheckBox.Values.Text = "Put a space between the amount and the symbol";
            // 
            // currencySettingsSymbolPlacementRightRadioButton
            // 
            this.currencySettingsSymbolPlacementRightRadioButton.Location = new System.Drawing.Point(193, 57);
            this.currencySettingsSymbolPlacementRightRadioButton.Name = "currencySettingsSymbolPlacementRightRadioButton";
            this.currencySettingsSymbolPlacementRightRadioButton.Size = new System.Drawing.Size(51, 20);
            this.currencySettingsSymbolPlacementRightRadioButton.TabIndex = 16;
            this.currencySettingsSymbolPlacementRightRadioButton.Values.Text = "Right";
            // 
            // currencySettingsSymbolPlacementLeftRadioButton
            // 
            this.currencySettingsSymbolPlacementLeftRadioButton.Checked = true;
            this.currencySettingsSymbolPlacementLeftRadioButton.Location = new System.Drawing.Point(131, 58);
            this.currencySettingsSymbolPlacementLeftRadioButton.Name = "currencySettingsSymbolPlacementLeftRadioButton";
            this.currencySettingsSymbolPlacementLeftRadioButton.Size = new System.Drawing.Size(43, 20);
            this.currencySettingsSymbolPlacementLeftRadioButton.TabIndex = 15;
            this.currencySettingsSymbolPlacementLeftRadioButton.Values.Text = "Left";
            // 
            // currencySettingsLabel
            // 
            this.currencySettingsLabel.Location = new System.Drawing.Point(19, 15);
            this.currencySettingsLabel.Name = "currencySettingsLabel";
            this.currencySettingsLabel.Size = new System.Drawing.Size(62, 20);
            this.currencySettingsLabel.TabIndex = 13;
            this.currencySettingsLabel.Values.Text = "Currency:";
            // 
            // currencySettingsSymbolPlacementLabel
            // 
            this.currencySettingsSymbolPlacementLabel.Location = new System.Drawing.Point(19, 58);
            this.currencySettingsSymbolPlacementLabel.Name = "currencySettingsSymbolPlacementLabel";
            this.currencySettingsSymbolPlacementLabel.Size = new System.Drawing.Size(114, 20);
            this.currencySettingsSymbolPlacementLabel.TabIndex = 14;
            this.currencySettingsSymbolPlacementLabel.Values.Text = "Symbol Placement:";
            // 
            // currencySettingsComboBox
            // 
            this.currencySettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencySettingsComboBox.DropDownWidth = 178;
            this.currencySettingsComboBox.Location = new System.Drawing.Point(131, 15);
            this.currencySettingsComboBox.Name = "currencySettingsComboBox";
            this.currencySettingsComboBox.Size = new System.Drawing.Size(178, 21);
            this.currencySettingsComboBox.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(308, 404);
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
            this.passwordLabel.Location = new System.Drawing.Point(346, 2);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 32);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "SETTINGS";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Add";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 246;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::POSeidon.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 201;
            // 
            // productNameHomePageDataGridViewTextBoxColumn
            // 
            this.productNameHomePageDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.productNameHomePageDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameHomePageDataGridViewTextBoxColumn.Name = "productNameHomePageDataGridViewTextBoxColumn";
            this.productNameHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceHomePageDataGridViewTextBoxColumn
            // 
            this.productPriceHomePageDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.productPriceHomePageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.productPriceHomePageDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceHomePageDataGridViewTextBoxColumn.Name = "productPriceHomePageDataGridViewTextBoxColumn";
            this.productPriceHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productStockHomePageDataGridViewTextBoxColumn
            // 
            this.productStockHomePageDataGridViewTextBoxColumn.DataPropertyName = "StockAmountText";
            this.productStockHomePageDataGridViewTextBoxColumn.HeaderText = "Stock Amount";
            this.productStockHomePageDataGridViewTextBoxColumn.Name = "productStockHomePageDataGridViewTextBoxColumn";
            this.productStockHomePageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAddHomePageDataGridViewImageColumn
            // 
            this.productAddHomePageDataGridViewImageColumn.HeaderText = "Add";
            this.productAddHomePageDataGridViewImageColumn.Image = ((System.Drawing.Image)(resources.GetObject("productAddHomePageDataGridViewImageColumn.Image")));
            this.productAddHomePageDataGridViewImageColumn.Name = "productAddHomePageDataGridViewImageColumn";
            this.productAddHomePageDataGridViewImageColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 578);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftsideMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 627);
            this.MinimumSize = new System.Drawing.Size(1026, 594);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSeidon";
            this.leftsideMainPanel.ResumeLayout(false);
            this.leftsideMainPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.homepageTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepageDataGridView)).EndInit();
            this.StatisticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPanel)).EndInit();
            this.statisticsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsHomepageNavigator)).EndInit();
            this.statisticsHomepageNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsPage)).EndInit();
            this.customerStatisticsPage.ResumeLayout(false);
            this.customerStatisticsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesStatisticsPage)).EndInit();
            this.salesStatisticsPage.ResumeLayout(false);
            this.salesStatisticsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesChart)).EndInit();
            this.customersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTabDataGridView)).EndInit();
            this.suppliersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).EndInit();
            this.salesAndPurchasingTab.ResumeLayout(false);
            this.salesAndPurchasingTab.PerformLayout();
            this.salesAndPurchasingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesAndPurchasingNavigator)).EndInit();
            this.salesAndPurchasingNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesNavigatorPage)).EndInit();
            this.salesNavigatorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingNavigatorPage)).EndInit();
            this.purchasingNavigatorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasingDataGridView)).EndInit();
            this.settingsTab.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.settingsChildPanel1.ResumeLayout(false);
            this.settingsChildPanel1.PerformLayout();
            this.settingsChildPanel2.ResumeLayout(false);
            this.settingsChildPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUnitComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox.Panel)).EndInit();
            this.currencySettingsGroupBox.Panel.ResumeLayout(false);
            this.currencySettingsGroupBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox)).EndInit();
            this.currencySettingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupSeparatorComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsDecimalSeparatorComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsComboBox)).EndInit();
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
        private System.Windows.Forms.TabPage StatisticsTab;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.TabPage salesAndPurchasingTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel settingsChildPanel2;
        private System.Windows.Forms.CheckBox settingsCheckbox2;
        private System.Windows.Forms.CheckBox settingsCheckbox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox currencySettingsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox currencySettingsPutSpaceCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton currencySettingsSymbolPlacementRightRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton currencySettingsSymbolPlacementLeftRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsSymbolPlacementLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsGroupSeparatorComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsDecimalSeparatorComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsGroupSeparatorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsDecimalSeparatorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown currencySettingsGroupSizeNumericUpDown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsGroupSizeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox weightUnitComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel weightUnitSettingsLabel;
        private System.Windows.Forms.Button shoppingCartLeftSidePanelButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel settingsChildPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel statisticsPanel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator statisticsHomepageNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage customerStatisticsPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage salesStatisticsPage;
        private System.Windows.Forms.Panel customerStatisticsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart customerStatisticsChart;
        private System.Windows.Forms.Panel salesStatisticsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesChart;
        private System.Windows.Forms.TabPage suppliersTab;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView customerTabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn deleteCustomerDataGridViewImageColumn3;
        private System.Windows.Forms.DataGridView suppliersTabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn deleteSupplierDataGridViewImageColumn;
        private System.Windows.Forms.Label customersTabLabel;
        private System.Windows.Forms.Label suppliersTabLabe;
        private System.Windows.Forms.Panel salesAndPurchasingPanel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator salesAndPurchasingNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage salesNavigatorPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage purchasingNavigatorPage;
        private System.Windows.Forms.DataGridView salesHistoryDataGridView;
        private System.Windows.Forms.DataGridView purchasingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleAmountSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cancelLogSalesHistoryDataGridViewImageBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNamePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPricePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPurchasingAmountPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPricePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cancelLogPurchasingDataGridViewImageBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productAddHomePageDataGridViewImageColumn;
    }
}
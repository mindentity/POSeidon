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
            System.Windows.Forms.Button addCustomerButton;
            System.Windows.Forms.Button addSupplierButton;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.leftsideMainPanel = new System.Windows.Forms.Panel();
            this.nameTextLabel = new System.Windows.Forms.Label();
            this.usernameTextLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.shoppingCartLeftSidePanelButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePageMainPanel = new System.Windows.Forms.Panel();
            this.homePageDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockHomePageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddHomePageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.homePageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.statisticsPagePanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customersPageMainPanel = new System.Windows.Forms.Panel();
            this.customersTabDataGridView = new System.Windows.Forms.DataGridView();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCustomerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.customersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customerSearchTextBox = new System.Windows.Forms.TextBox();
            this.suppliersTab = new System.Windows.Forms.TabPage();
            this.suppliersPageMainPanel = new System.Windows.Forms.Panel();
            this.suppliersTabDataGridView = new System.Windows.Forms.DataGridView();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteSupplierDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.suppliersPageHeaderPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.supplierSearchTextBox = new System.Windows.Forms.TextBox();
            this.salesAndPurchasingTab = new System.Windows.Forms.TabPage();
            this.salesAndPurchasingPanel = new System.Windows.Forms.Panel();
            this.salesAndPurchasingNavigator = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.salesNavigatorPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.salesHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSalesHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasingNavigatorPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.purchasingDataGridView = new System.Windows.Forms.DataGridView();
            this.productPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchasingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.languageSettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.languageSettingsComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.weightUnitSettingsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.weightUnitComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.currencySettingsGroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.supplierStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerStatisticsPanel = new System.Windows.Forms.Panel();
            this.customerStatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customerStatisticsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            addProductButton = new System.Windows.Forms.Button();
            addCustomerButton = new System.Windows.Forms.Button();
            addSupplierButton = new System.Windows.Forms.Button();
            this.leftsideMainPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.homePageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePageDataGridView)).BeginInit();
            this.homePageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPagePanel)).BeginInit();
            this.statisticsPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.customersTab.SuspendLayout();
            this.customersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTabDataGridView)).BeginInit();
            this.customersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.suppliersTab.SuspendLayout();
            this.suppliersPageMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).BeginInit();
            this.suppliersPageHeaderPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageSettingsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUnitComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox.Panel)).BeginInit();
            this.currencySettingsGroupBox.Panel.SuspendLayout();
            this.currencySettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupSeparatorComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsDecimalSeparatorComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierStatisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsPage)).BeginInit();
            this.customerStatisticsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addProductButton.BackColor = System.Drawing.Color.White;
            addProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addProductButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addProductButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addProductButton.Location = new System.Drawing.Point(3, 8);
            addProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addProductButton.Name = "addProductButton";
            addProductButton.Padding = new System.Windows.Forms.Padding(5);
            addProductButton.Size = new System.Drawing.Size(210, 84);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "ADD PRODUCT";
            addProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // addCustomerButton
            // 
            addCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addCustomerButton.BackColor = System.Drawing.Color.White;
            addCustomerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addCustomerButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addCustomerButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addCustomerButton.Location = new System.Drawing.Point(3, 8);
            addCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Padding = new System.Windows.Forms.Padding(5);
            addCustomerButton.Size = new System.Drawing.Size(210, 84);
            addCustomerButton.TabIndex = 1;
            addCustomerButton.Text = "ADD CUSTOMER";
            addCustomerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addCustomerButton.UseVisualStyleBackColor = false;
            addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // addSupplierButton
            // 
            addSupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addSupplierButton.BackColor = System.Drawing.Color.White;
            addSupplierButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            addSupplierButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            addSupplierButton.Image = global::POSeidon.Properties.Resources.rsz_plus;
            addSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addSupplierButton.Location = new System.Drawing.Point(3, 8);
            addSupplierButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addSupplierButton.Name = "addSupplierButton";
            addSupplierButton.Padding = new System.Windows.Forms.Padding(5);
            addSupplierButton.Size = new System.Drawing.Size(210, 84);
            addSupplierButton.TabIndex = 1;
            addSupplierButton.Text = "ADD PRODUCT";
            addSupplierButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addSupplierButton.UseVisualStyleBackColor = false;
            addSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // leftsideMainPanel
            // 
            this.leftsideMainPanel.AutoScroll = true;
            this.leftsideMainPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.leftsideMainPanel.Controls.Add(this.nameTextLabel);
            this.leftsideMainPanel.Controls.Add(this.usernameTextLabel);
            this.leftsideMainPanel.Controls.Add(this.nameLabel);
            this.leftsideMainPanel.Controls.Add(this.usernameLabel);
            this.leftsideMainPanel.Controls.Add(this.shoppingCartLeftSidePanelButton);
            this.leftsideMainPanel.Controls.Add(this.logoutButton);
            this.leftsideMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftsideMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftsideMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftsideMainPanel.Name = "leftsideMainPanel";
            this.leftsideMainPanel.Size = new System.Drawing.Size(202, 548);
            this.leftsideMainPanel.TabIndex = 0;
            // 
            // nameTextLabel
            // 
            this.nameTextLabel.AutoSize = true;
            this.nameTextLabel.Location = new System.Drawing.Point(88, 75);
            this.nameTextLabel.Name = "nameTextLabel";
            this.nameTextLabel.Size = new System.Drawing.Size(55, 13);
            this.nameTextLabel.TabIndex = 9;
            this.nameTextLabel.Text = "POSeidon";
            // 
            // usernameTextLabel
            // 
            this.usernameTextLabel.AutoSize = true;
            this.usernameTextLabel.Location = new System.Drawing.Point(88, 44);
            this.usernameTextLabel.Name = "usernameTextLabel";
            this.usernameTextLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameTextLabel.TabIndex = 8;
            this.usernameTextLabel.Text = "admin";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 44);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username:";
            // 
            // shoppingCartLeftSidePanelButton
            // 
            this.shoppingCartLeftSidePanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shoppingCartLeftSidePanelButton.AutoSize = true;
            this.shoppingCartLeftSidePanelButton.BackColor = System.Drawing.Color.Transparent;
            this.shoppingCartLeftSidePanelButton.BackgroundImage = global::POSeidon.Properties.Resources.order;
            this.shoppingCartLeftSidePanelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shoppingCartLeftSidePanelButton.Location = new System.Drawing.Point(12, 448);
            this.shoppingCartLeftSidePanelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shoppingCartLeftSidePanelButton.Name = "shoppingCartLeftSidePanelButton";
            this.shoppingCartLeftSidePanelButton.Size = new System.Drawing.Size(49, 43);
            this.shoppingCartLeftSidePanelButton.TabIndex = 5;
            this.shoppingCartLeftSidePanelButton.UseVisualStyleBackColor = false;
            this.shoppingCartLeftSidePanelButton.Click += new System.EventHandler(this.ShoppingCartLeftSidePanelButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = global::POSeidon.Properties.Resources.rsz_1logout_50x60;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutButton.Location = new System.Drawing.Point(154, 449);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(43, 40);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.mainTabControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(202, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(978, 548);
            this.mainPanel.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.homeTab);
            this.mainTabControl.Controls.Add(this.statisticsTab);
            this.mainTabControl.Controls.Add(this.customersTab);
            this.mainTabControl.Controls.Add(this.suppliersTab);
            this.mainTabControl.Controls.Add(this.salesAndPurchasingTab);
            this.mainTabControl.Controls.Add(this.settingsTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainTabControl.ItemSize = new System.Drawing.Size(200, 50);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(30, 3);
            this.mainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(978, 548);
            this.mainTabControl.TabIndex = 3;
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.Color.Transparent;
            this.homeTab.Controls.Add(this.homePageMainPanel);
            this.homeTab.Controls.Add(this.homePageHeaderPanel);
            this.homeTab.Location = new System.Drawing.Point(4, 54);
            this.homeTab.Margin = new System.Windows.Forms.Padding(2);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(970, 490);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // homePageMainPanel
            // 
            this.homePageMainPanel.Controls.Add(this.homePageDataGridView);
            this.homePageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePageMainPanel.Location = new System.Drawing.Point(0, 100);
            this.homePageMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePageMainPanel.Name = "homePageMainPanel";
            this.homePageMainPanel.Size = new System.Drawing.Size(970, 390);
            this.homePageMainPanel.TabIndex = 8;
            // 
            // homePageDataGridView
            // 
            this.homePageDataGridView.AllowUserToAddRows = false;
            this.homePageDataGridView.AllowUserToDeleteRows = false;
            this.homePageDataGridView.AllowUserToOrderColumns = true;
            this.homePageDataGridView.AllowUserToResizeColumns = false;
            this.homePageDataGridView.AllowUserToResizeRows = false;
            this.homePageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homePageDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.homePageDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homePageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homePageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameHomePageDataGridViewTextBoxColumn,
            this.productPriceHomePageDataGridViewTextBoxColumn,
            this.productStockHomePageDataGridViewTextBoxColumn,
            this.productAddHomePageDataGridViewImageColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.homePageDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.homePageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePageDataGridView.Location = new System.Drawing.Point(0, 0);
            this.homePageDataGridView.MultiSelect = false;
            this.homePageDataGridView.Name = "homePageDataGridView";
            this.homePageDataGridView.ReadOnly = true;
            this.homePageDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.homePageDataGridView.RowTemplate.Height = 24;
            this.homePageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.homePageDataGridView.Size = new System.Drawing.Size(970, 390);
            this.homePageDataGridView.TabIndex = 7;
            this.homePageDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HomePageDataGridView_CellClick);
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
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.productPriceHomePageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
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
            // homePageHeaderPanel
            // 
            this.homePageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homePageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.homePageHeaderPanel.Controls.Add(this.tableLayoutPanel1);
            this.homePageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.homePageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePageHeaderPanel.Name = "homePageHeaderPanel";
            this.homePageHeaderPanel.Size = new System.Drawing.Size(970, 100);
            this.homePageHeaderPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(addProductButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productSearchTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productSearchTextBox.Location = new System.Drawing.Point(704, 38);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.productSearchTextBox.TabIndex = 16;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(941, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // statisticsTab
            // 
            this.statisticsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.statisticsTab.Controls.Add(this.statisticsPagePanel);
            this.statisticsTab.Location = new System.Drawing.Point(4, 54);
            this.statisticsTab.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(2);
            this.statisticsTab.Size = new System.Drawing.Size(970, 490);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.Enter += new System.EventHandler(this.StatisticsTab_Enter);
            // 
            // statisticsPagePanel
            // 
            this.statisticsPagePanel.Controls.Add(this.statisticsChart);
            this.statisticsPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsPagePanel.Location = new System.Drawing.Point(2, 2);
            this.statisticsPagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsPagePanel.Name = "statisticsPagePanel";
            this.statisticsPagePanel.Size = new System.Drawing.Size(966, 486);
            this.statisticsPagePanel.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.statisticsPagePanel.TabIndex = 7;
            // 
            // statisticsChart
            // 
            chartArea4.AxisY.Title = "Amount";
            chartArea4.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea4);
            this.statisticsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsChart.Location = new System.Drawing.Point(0, 0);
            this.statisticsChart.Name = "statisticsChart";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            series4.XValueMember = "ProductName";
            series4.YValueMembers = "Amount";
            this.statisticsChart.Series.Add(series4);
            this.statisticsChart.Size = new System.Drawing.Size(966, 486);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "chart1";
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.customersTab.Controls.Add(this.customersPageMainPanel);
            this.customersTab.Controls.Add(this.customersPageHeaderPanel);
            this.customersTab.Location = new System.Drawing.Point(4, 54);
            this.customersTab.Margin = new System.Windows.Forms.Padding(2);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(970, 490);
            this.customersTab.TabIndex = 2;
            this.customersTab.Text = "Customers";
            // 
            // customersPageMainPanel
            // 
            this.customersPageMainPanel.Controls.Add(this.customersTabDataGridView);
            this.customersPageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersPageMainPanel.Location = new System.Drawing.Point(0, 100);
            this.customersPageMainPanel.Name = "customersPageMainPanel";
            this.customersPageMainPanel.Size = new System.Drawing.Size(970, 390);
            this.customersPageMainPanel.TabIndex = 14;
            // 
            // customersTabDataGridView
            // 
            this.customersTabDataGridView.AllowUserToAddRows = false;
            this.customersTabDataGridView.AllowUserToDeleteRows = false;
            this.customersTabDataGridView.AllowUserToResizeColumns = false;
            this.customersTabDataGridView.AllowUserToResizeRows = false;
            this.customersTabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customersTabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customersTabDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.customersTabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.deleteCustomerDataGridViewImageColumn});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.customersTabDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTabDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customersTabDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customersTabDataGridView.MultiSelect = false;
            this.customersTabDataGridView.Name = "customersTabDataGridView";
            this.customersTabDataGridView.RowTemplate.Height = 24;
            this.customersTabDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.customersTabDataGridView.Size = new System.Drawing.Size(970, 390);
            this.customersTabDataGridView.TabIndex = 10;
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            this.customerFirstNameDataGridViewTextBoxColumn.Width = 108;
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            this.customerLastNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.Width = 82;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            this.customerEmailDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 90;
            // 
            // deleteCustomerDataGridViewImageColumn
            // 
            this.deleteCustomerDataGridViewImageColumn.HeaderText = "Delete";
            this.deleteCustomerDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteCustomerDataGridViewImageColumn.Name = "deleteCustomerDataGridViewImageColumn";
            this.deleteCustomerDataGridViewImageColumn.Width = 64;
            // 
            // customersPageHeaderPanel
            // 
            this.customersPageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.customersPageHeaderPanel.Controls.Add(this.tableLayoutPanel2);
            this.customersPageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersPageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.customersPageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customersPageHeaderPanel.Name = "customersPageHeaderPanel";
            this.customersPageHeaderPanel.Size = new System.Drawing.Size(970, 100);
            this.customersPageHeaderPanel.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.customerSearchTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(addCustomerButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(941, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // customerSearchTextBox
            // 
            this.customerSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customerSearchTextBox.Location = new System.Drawing.Point(704, 38);
            this.customerSearchTextBox.Name = "customerSearchTextBox";
            this.customerSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.customerSearchTextBox.TabIndex = 17;
            // 
            // suppliersTab
            // 
            this.suppliersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.suppliersTab.Controls.Add(this.suppliersPageMainPanel);
            this.suppliersTab.Controls.Add(this.suppliersPageHeaderPanel);
            this.suppliersTab.Location = new System.Drawing.Point(4, 54);
            this.suppliersTab.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersTab.Name = "suppliersTab";
            this.suppliersTab.Size = new System.Drawing.Size(970, 490);
            this.suppliersTab.TabIndex = 5;
            this.suppliersTab.Text = "Suppliers";
            // 
            // suppliersPageMainPanel
            // 
            this.suppliersPageMainPanel.Controls.Add(this.suppliersTabDataGridView);
            this.suppliersPageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersPageMainPanel.Location = new System.Drawing.Point(0, 100);
            this.suppliersPageMainPanel.Name = "suppliersPageMainPanel";
            this.suppliersPageMainPanel.Size = new System.Drawing.Size(970, 390);
            this.suppliersPageMainPanel.TabIndex = 17;
            // 
            // suppliersTabDataGridView
            // 
            this.suppliersTabDataGridView.AllowUserToAddRows = false;
            this.suppliersTabDataGridView.AllowUserToDeleteRows = false;
            this.suppliersTabDataGridView.AllowUserToResizeColumns = false;
            this.suppliersTabDataGridView.AllowUserToResizeRows = false;
            this.suppliersTabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.suppliersTabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.suppliersTabDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(210)))), ((int)(((byte)(232)))));
            this.suppliersTabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersTabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierPhoneDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn,
            this.deleteSupplierDataGridViewImageColumn});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersTabDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.suppliersTabDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersTabDataGridView.Location = new System.Drawing.Point(0, 0);
            this.suppliersTabDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersTabDataGridView.MultiSelect = false;
            this.suppliersTabDataGridView.Name = "suppliersTabDataGridView";
            this.suppliersTabDataGridView.RowTemplate.Height = 24;
            this.suppliersTabDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.suppliersTabDataGridView.Size = new System.Drawing.Size(970, 390);
            this.suppliersTabDataGridView.TabIndex = 9;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // supplierPhoneDataGridViewTextBoxColumn
            // 
            this.supplierPhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.supplierPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.supplierPhoneDataGridViewTextBoxColumn.Name = "supplierPhoneDataGridViewTextBoxColumn";
            this.supplierPhoneDataGridViewTextBoxColumn.Width = 82;
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            this.supplierEmailDataGridViewTextBoxColumn.Width = 75;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            this.supplierAddressDataGridViewTextBoxColumn.Width = 90;
            // 
            // deleteSupplierDataGridViewImageColumn
            // 
            this.deleteSupplierDataGridViewImageColumn.HeaderText = "Delete";
            this.deleteSupplierDataGridViewImageColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.deleteSupplierDataGridViewImageColumn.Name = "deleteSupplierDataGridViewImageColumn";
            this.deleteSupplierDataGridViewImageColumn.Width = 64;
            // 
            // suppliersPageHeaderPanel
            // 
            this.suppliersPageHeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.suppliersPageHeaderPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.suppliersPageHeaderPanel.Controls.Add(this.tableLayoutPanel3);
            this.suppliersPageHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppliersPageHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.suppliersPageHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersPageHeaderPanel.Name = "suppliersPageHeaderPanel";
            this.suppliersPageHeaderPanel.Size = new System.Drawing.Size(970, 100);
            this.suppliersPageHeaderPanel.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.supplierSearchTextBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(addSupplierButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = global::POSeidon.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(941, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // supplierSearchTextBox
            // 
            this.supplierSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.supplierSearchTextBox.Location = new System.Drawing.Point(704, 38);
            this.supplierSearchTextBox.Name = "supplierSearchTextBox";
            this.supplierSearchTextBox.Size = new System.Drawing.Size(231, 24);
            this.supplierSearchTextBox.TabIndex = 18;
            this.supplierSearchTextBox.TextChanged += new System.EventHandler(this.SuppliersSearchTextBox_TextChanged);
            // 
            // salesAndPurchasingTab
            // 
            this.salesAndPurchasingTab.BackColor = System.Drawing.Color.PeachPuff;
            this.salesAndPurchasingTab.Controls.Add(this.salesAndPurchasingPanel);
            this.salesAndPurchasingTab.Location = new System.Drawing.Point(4, 54);
            this.salesAndPurchasingTab.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingTab.Name = "salesAndPurchasingTab";
            this.salesAndPurchasingTab.Size = new System.Drawing.Size(970, 490);
            this.salesAndPurchasingTab.TabIndex = 3;
            this.salesAndPurchasingTab.Text = "Sales and Purchasing";
            // 
            // salesAndPurchasingPanel
            // 
            this.salesAndPurchasingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.salesAndPurchasingPanel.Controls.Add(this.salesAndPurchasingNavigator);
            this.salesAndPurchasingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesAndPurchasingPanel.Location = new System.Drawing.Point(0, 0);
            this.salesAndPurchasingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingPanel.Name = "salesAndPurchasingPanel";
            this.salesAndPurchasingPanel.Size = new System.Drawing.Size(970, 490);
            this.salesAndPurchasingPanel.TabIndex = 0;
            // 
            // salesAndPurchasingNavigator
            // 
            this.salesAndPurchasingNavigator.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.salesAndPurchasingNavigator.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.salesAndPurchasingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesAndPurchasingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesAndPurchasingNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.salesAndPurchasingNavigator.Name = "salesAndPurchasingNavigator";
            this.salesAndPurchasingNavigator.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.salesAndPurchasingNavigator.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.salesNavigatorPage,
            this.purchasingNavigatorPage});
            this.salesAndPurchasingNavigator.SelectedIndex = 0;
            this.salesAndPurchasingNavigator.Size = new System.Drawing.Size(970, 490);
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
            this.salesNavigatorPage.Size = new System.Drawing.Size(968, 461);
            this.salesNavigatorPage.Text = "Sales";
            this.salesNavigatorPage.ToolTipTitle = "Page ToolTip";
            this.salesNavigatorPage.UniqueName = "6c08f90acd56447b9d6f9ea6bd5cfcc4";
            this.salesNavigatorPage.Enter += new System.EventHandler(this.SalesNavigatorPage_Enter);
            // 
            // salesHistoryDataGridView
            // 
            this.salesHistoryDataGridView.AllowUserToAddRows = false;
            this.salesHistoryDataGridView.AllowUserToDeleteRows = false;
            this.salesHistoryDataGridView.AllowUserToResizeColumns = false;
            this.salesHistoryDataGridView.AllowUserToResizeRows = false;
            this.salesHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.salesHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesHistoryDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salesHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameSalesHistoryDataGridViewTextBoxColumn,
            this.productPriceSalesHistoryDataGridViewTextBoxColumn,
            this.productAmountSalesHistoryDataGridViewTextBoxColumn,
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn,
            this.customerNameSalesHistoryDataGridViewTextBoxColumn,
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn,
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn,
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn,
            this.dateSalesHistoryDataGridViewTextBoxColumn});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.salesHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.salesHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.salesHistoryDataGridView.MultiSelect = false;
            this.salesHistoryDataGridView.Name = "salesHistoryDataGridView";
            this.salesHistoryDataGridView.RowTemplate.Height = 24;
            this.salesHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.salesHistoryDataGridView.Size = new System.Drawing.Size(968, 461);
            this.salesHistoryDataGridView.TabIndex = 9;
            this.salesHistoryDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SalesHistoryDataGridView_CellFormatting);
            // 
            // productNameSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productNameSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.Name = "productNameSalesHistoryDataGridViewTextBoxColumn";
            this.productNameSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameSalesHistoryDataGridViewTextBoxColumn.Width = 92;
            // 
            // productPriceSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.Name = "productPriceSalesHistoryDataGridViewTextBoxColumn";
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPriceSalesHistoryDataGridViewTextBoxColumn.Width = 71;
            // 
            // productAmountSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.Name = "productAmountSalesHistoryDataGridViewTextBoxColumn";
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productAmountSalesHistoryDataGridViewTextBoxColumn.Width = 92;
            // 
            // productTotalPriceSalesHistoryDataGridViewTextBoxColumn
            // 
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "ProductTotalPrice";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Total";
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.Name = "productTotalPriceSalesHistoryDataGridViewTextBoxColumn";
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTotalPriceSalesHistoryDataGridViewTextBoxColumn.Width = 70;
            // 
            // customerNameSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.Name = "customerNameSalesHistoryDataGridViewTextBoxColumn";
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameSalesHistoryDataGridViewTextBoxColumn.Width = 103;
            // 
            // customerPhoneSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.Name = "customerPhoneSalesHistoryDataGridViewTextBoxColumn";
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerPhoneSalesHistoryDataGridViewTextBoxColumn.Width = 82;
            // 
            // customerEmailSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Email";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.Name = "customerEmailSalesHistoryDataGridViewTextBoxColumn";
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerEmailSalesHistoryDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerAddressSalesHistoryDataGridViewTextBoxColumn
            // 
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.Name = "customerAddressSalesHistoryDataGridViewTextBoxColumn";
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerAddressSalesHistoryDataGridViewTextBoxColumn.Width = 90;
            // 
            // dateSalesHistoryDataGridViewTextBoxColumn
            // 
            this.dateSalesHistoryDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateSalesHistoryDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateSalesHistoryDataGridViewTextBoxColumn.Name = "dateSalesHistoryDataGridViewTextBoxColumn";
            this.dateSalesHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateSalesHistoryDataGridViewTextBoxColumn.Width = 72;
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
            this.purchasingNavigatorPage.Size = new System.Drawing.Size(968, 461);
            this.purchasingNavigatorPage.Text = "Purchasing";
            this.purchasingNavigatorPage.ToolTipTitle = "Page ToolTip";
            this.purchasingNavigatorPage.UniqueName = "3753607d328a4c3a9448a9b19123061d";
            // 
            // purchasingDataGridView
            // 
            this.purchasingDataGridView.AllowUserToAddRows = false;
            this.purchasingDataGridView.AllowUserToDeleteRows = false;
            this.purchasingDataGridView.AllowUserToResizeColumns = false;
            this.purchasingDataGridView.AllowUserToResizeRows = false;
            this.purchasingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.purchasingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purchasingDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.purchasingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productPurchasingDataGridViewTextBoxColumn,
            this.amountPurchasingDataGridViewTextBoxColumn,
            this.supplierPurchasingDataGridViewTextBoxColumn,
            this.phonePurchasingDataGridViewTextBoxColumn,
            this.emailPurchasingDataGridViewTextBoxColumn,
            this.addressPurchasingDataGridViewTextBoxColumn,
            this.totalPurchasingDataGridViewTextBoxColumn,
            this.datePurchasingDataGridViewTextBoxColumn});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchasingDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.purchasingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.purchasingDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.purchasingDataGridView.MultiSelect = false;
            this.purchasingDataGridView.Name = "purchasingDataGridView";
            this.purchasingDataGridView.RowTemplate.Height = 24;
            this.purchasingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.purchasingDataGridView.Size = new System.Drawing.Size(968, 461);
            this.purchasingDataGridView.TabIndex = 9;
            this.purchasingDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PurchasingDataGridView_CellFormatting);
            // 
            // productPurchasingDataGridViewTextBoxColumn
            // 
            this.productPurchasingDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productPurchasingDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productPurchasingDataGridViewTextBoxColumn.Name = "productPurchasingDataGridViewTextBoxColumn";
            this.productPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.productPurchasingDataGridViewTextBoxColumn.Width = 92;
            // 
            // amountPurchasingDataGridViewTextBoxColumn
            // 
            this.amountPurchasingDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.amountPurchasingDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountPurchasingDataGridViewTextBoxColumn.Name = "amountPurchasingDataGridViewTextBoxColumn";
            this.amountPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountPurchasingDataGridViewTextBoxColumn.Width = 92;
            // 
            // supplierPurchasingDataGridViewTextBoxColumn
            // 
            this.supplierPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierPurchasingDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierPurchasingDataGridViewTextBoxColumn.Name = "supplierPurchasingDataGridViewTextBoxColumn";
            this.supplierPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierPurchasingDataGridViewTextBoxColumn.Width = 93;
            // 
            // phonePurchasingDataGridViewTextBoxColumn
            // 
            this.phonePurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierPhone";
            this.phonePurchasingDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phonePurchasingDataGridViewTextBoxColumn.Name = "phonePurchasingDataGridViewTextBoxColumn";
            this.phonePurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonePurchasingDataGridViewTextBoxColumn.Width = 82;
            // 
            // emailPurchasingDataGridViewTextBoxColumn
            // 
            this.emailPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmail";
            this.emailPurchasingDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailPurchasingDataGridViewTextBoxColumn.Name = "emailPurchasingDataGridViewTextBoxColumn";
            this.emailPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailPurchasingDataGridViewTextBoxColumn.Width = 75;
            // 
            // addressPurchasingDataGridViewTextBoxColumn
            // 
            this.addressPurchasingDataGridViewTextBoxColumn.DataPropertyName = "SupplierAddress";
            this.addressPurchasingDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressPurchasingDataGridViewTextBoxColumn.Name = "addressPurchasingDataGridViewTextBoxColumn";
            this.addressPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressPurchasingDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalPurchasingDataGridViewTextBoxColumn
            // 
            this.totalPurchasingDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.totalPurchasingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.totalPurchasingDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPurchasingDataGridViewTextBoxColumn.Name = "totalPurchasingDataGridViewTextBoxColumn";
            this.totalPurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPurchasingDataGridViewTextBoxColumn.Width = 70;
            // 
            // datePurchasingDataGridViewTextBoxColumn
            // 
            this.datePurchasingDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.datePurchasingDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datePurchasingDataGridViewTextBoxColumn.Name = "datePurchasingDataGridViewTextBoxColumn";
            this.datePurchasingDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePurchasingDataGridViewTextBoxColumn.Width = 72;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(207)))), ((int)(((byte)(237)))));
            this.settingsTab.Controls.Add(this.settingsPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 54);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(970, 490);
            this.settingsTab.TabIndex = 4;
            this.settingsTab.Text = "Settings";
            this.settingsTab.Enter += new System.EventHandler(this.SettingsTab_Enter);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.tableLayoutPanel4);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(970, 490);
            this.settingsPanel.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.currencySettingsGroupBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.16327F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.83673F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(970, 490);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.languageSettingsLabel);
            this.panel1.Controls.Add(this.languageSettingsComboBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.weightUnitSettingsLabel);
            this.panel1.Controls.Add(this.weightUnitComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 199);
            this.panel1.TabIndex = 17;
            // 
            // languageSettingsLabel
            // 
            this.languageSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.languageSettingsLabel.Location = new System.Drawing.Point(324, 64);
            this.languageSettingsLabel.Name = "languageSettingsLabel";
            this.languageSettingsLabel.Size = new System.Drawing.Size(67, 20);
            this.languageSettingsLabel.TabIndex = 19;
            this.languageSettingsLabel.Values.Text = "Language:";
            // 
            // languageSettingsComboBox
            // 
            this.languageSettingsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.languageSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSettingsComboBox.DropDownWidth = 121;
            this.languageSettingsComboBox.Location = new System.Drawing.Point(435, 63);
            this.languageSettingsComboBox.Name = "languageSettingsComboBox";
            this.languageSettingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageSettingsComboBox.TabIndex = 20;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(553, 108);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 57);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // weightUnitSettingsLabel
            // 
            this.weightUnitSettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightUnitSettingsLabel.Location = new System.Drawing.Point(324, 17);
            this.weightUnitSettingsLabel.Name = "weightUnitSettingsLabel";
            this.weightUnitSettingsLabel.Size = new System.Drawing.Size(79, 20);
            this.weightUnitSettingsLabel.TabIndex = 17;
            this.weightUnitSettingsLabel.Values.Text = "Weight Unit:";
            // 
            // weightUnitComboBox
            // 
            this.weightUnitComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weightUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightUnitComboBox.DropDownWidth = 121;
            this.weightUnitComboBox.Location = new System.Drawing.Point(435, 16);
            this.weightUnitComboBox.Name = "weightUnitComboBox";
            this.weightUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.weightUnitComboBox.TabIndex = 18;
            // 
            // currencySettingsGroupBox
            // 
            this.currencySettingsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currencySettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.currencySettingsGroupBox.CaptionOverlap = 0D;
            this.currencySettingsGroupBox.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.currencySettingsGroupBox.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.currencySettingsGroupBox.Location = new System.Drawing.Point(310, 3);
            this.currencySettingsGroupBox.MinimumSize = new System.Drawing.Size(350, 250);
            this.currencySettingsGroupBox.Name = "currencySettingsGroupBox";
            // 
            // currencySettingsGroupBox.Panel
            // 
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
            this.currencySettingsGroupBox.Size = new System.Drawing.Size(350, 250);
            this.currencySettingsGroupBox.TabIndex = 16;
            this.currencySettingsGroupBox.Values.Heading = "Currency Settings";
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
            // cancelLogSalesHistoryDataGridViewImageBoxColumn
            // 
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.HeaderText = "Cancel";
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Image = global::POSeidon.Properties.Resources.delete;
            this.cancelLogSalesHistoryDataGridViewImageBoxColumn.Name = "cancelLogSalesHistoryDataGridViewImageBoxColumn";
            // 
            // supplierStatisticsChart
            // 
            this.supplierStatisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea8";
            this.supplierStatisticsChart.ChartAreas.Add(chartArea5);
            legend2.Name = "Legend8";
            this.supplierStatisticsChart.Legends.Add(legend2);
            this.supplierStatisticsChart.Location = new System.Drawing.Point(20, 19);
            this.supplierStatisticsChart.Margin = new System.Windows.Forms.Padding(2);
            this.supplierStatisticsChart.Name = "supplierStatisticsChart";
            this.supplierStatisticsChart.Padding = new System.Windows.Forms.Padding(8);
            this.supplierStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea8";
            series5.Legend = "Legend8";
            series5.Name = "Series8";
            this.supplierStatisticsChart.Series.Add(series5);
            this.supplierStatisticsChart.Size = new System.Drawing.Size(570, 494);
            this.supplierStatisticsChart.TabIndex = 0;
            // 
            // customerStatisticsPanel
            // 
            this.customerStatisticsPanel.Location = new System.Drawing.Point(67, 32);
            this.customerStatisticsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsPanel.Name = "customerStatisticsPanel";
            this.customerStatisticsPanel.Size = new System.Drawing.Size(610, 529);
            this.customerStatisticsPanel.TabIndex = 7;
            // 
            // customerStatisticsChart
            // 
            this.customerStatisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea7";
            this.customerStatisticsChart.ChartAreas.Add(chartArea6);
            this.customerStatisticsChart.Location = new System.Drawing.Point(20, 19);
            this.customerStatisticsChart.Margin = new System.Windows.Forms.Padding(2);
            this.customerStatisticsChart.Name = "customerStatisticsChart";
            this.customerStatisticsChart.Padding = new System.Windows.Forms.Padding(8);
            this.customerStatisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.ChartArea = "ChartArea7";
            series6.Name = "test";
            series6.XValueMember = "ProductName";
            series6.YValueMembers = "Amount";
            this.customerStatisticsChart.Series.Add(series6);
            this.customerStatisticsChart.Size = new System.Drawing.Size(569, 400);
            this.customerStatisticsChart.TabIndex = 0;
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
            this.customerStatisticsPage.Size = new System.Drawing.Size(748, 563);
            this.customerStatisticsPage.Text = "Customer";
            this.customerStatisticsPage.ToolTipTitle = "Page ToolTip";
            this.customerStatisticsPage.UniqueName = "1fbf379b70634940bcf9c585c1b0ac13";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1180, 548);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftsideMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSeidon";
            this.leftsideMainPanel.ResumeLayout(false);
            this.leftsideMainPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homePageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePageDataGridView)).EndInit();
            this.homePageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statisticsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsPagePanel)).EndInit();
            this.statisticsPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.customersTab.ResumeLayout(false);
            this.customersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersTabDataGridView)).EndInit();
            this.customersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.suppliersTab.ResumeLayout(false);
            this.suppliersPageMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTabDataGridView)).EndInit();
            this.suppliersPageHeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.salesAndPurchasingTab.ResumeLayout(false);
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languageSettingsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUnitComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox.Panel)).EndInit();
            this.currencySettingsGroupBox.Panel.ResumeLayout(false);
            this.currencySettingsGroupBox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupBox)).EndInit();
            this.currencySettingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsGroupSeparatorComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsDecimalSeparatorComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencySettingsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierStatisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerStatisticsPage)).EndInit();
            this.customerStatisticsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftsideMainPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button shoppingCartLeftSidePanelButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.Panel homePageMainPanel;
        private System.Windows.Forms.DataGridView homePageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockHomePageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productAddHomePageDataGridViewImageColumn;
        private System.Windows.Forms.TabPage statisticsTab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel statisticsPagePanel;
        private System.Windows.Forms.Panel customerStatisticsPanel;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView customersTabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteCustomerDataGridViewImageColumn;
        private System.Windows.Forms.TabPage suppliersTab;
        private System.Windows.Forms.DataGridView suppliersTabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteSupplierDataGridViewImageColumn;
        private System.Windows.Forms.TabPage salesAndPurchasingTab;
        private System.Windows.Forms.Panel salesAndPurchasingPanel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator salesAndPurchasingNavigator;
        private ComponentFactory.Krypton.Navigator.KryptonPage salesNavigatorPage;
        private System.Windows.Forms.DataGridView salesHistoryDataGridView;
        private ComponentFactory.Krypton.Navigator.KryptonPage purchasingNavigatorPage;
        private System.Windows.Forms.DataGridView purchasingDataGridView;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel settingsPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox weightUnitComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel weightUnitSettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox currencySettingsGroupBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsGroupSeparatorComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsDecimalSeparatorComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsGroupSeparatorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsDecimalSeparatorLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox currencySettingsPutSpaceCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton currencySettingsSymbolPlacementRightRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton currencySettingsSymbolPlacementLeftRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel currencySettingsSymbolPlacementLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox currencySettingsComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewImageColumn cancelLogPurchasingDataGridViewImageBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNamePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn cancelLogSalesHistoryDataGridViewImageBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart supplierStatisticsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart customerStatisticsChart;
        private ComponentFactory.Krypton.Navigator.KryptonPage customerStatisticsPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Panel homePageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel customersPageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel suppliersPageHeaderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.TextBox customerSearchTextBox;
        private System.Windows.Forms.Panel customersPageMainPanel;
        private System.Windows.Forms.Panel suppliersPageMainPanel;
        private System.Windows.Forms.TextBox supplierSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotalPriceSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSalesHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchasingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel languageSettingsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox languageSettingsComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label nameTextLabel;
        private System.Windows.Forms.Label usernameTextLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
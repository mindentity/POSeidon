namespace POSeidon
{
    partial class ShoppingCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shoppingCartFormPanel = new System.Windows.Forms.Panel();
            this.customerComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.customerCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.totalPriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.totalPriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeShoppingCartDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.shoppingCartFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartFormPanel
            // 
            resources.ApplyResources(this.shoppingCartFormPanel, "shoppingCartFormPanel");
            this.shoppingCartFormPanel.Controls.Add(this.customerComboBox);
            this.shoppingCartFormPanel.Controls.Add(this.customerCheckBox);
            this.shoppingCartFormPanel.Controls.Add(this.totalPriceTextBox);
            this.shoppingCartFormPanel.Controls.Add(this.totalPriceLabel);
            this.shoppingCartFormPanel.Controls.Add(this.checkoutButton);
            this.shoppingCartFormPanel.Controls.Add(this.shoppingCartDataGridView);
            this.shoppingCartFormPanel.Name = "shoppingCartFormPanel";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.DropDownWidth = 129;
            resources.ApplyResources(this.customerComboBox, "customerComboBox");
            this.customerComboBox.Name = "customerComboBox";
            // 
            // customerCheckBox
            // 
            resources.ApplyResources(this.customerCheckBox, "customerCheckBox");
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Values.Text = resources.GetString("customerCheckBox.Values.Text");
            this.customerCheckBox.CheckedChanged += new System.EventHandler(this.CustomerCheckBox_CheckedChanged);
            // 
            // totalPriceTextBox
            // 
            resources.ApplyResources(this.totalPriceTextBox, "totalPriceTextBox");
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.StateDisabled.Content.Color1 = System.Drawing.Color.Teal;
            // 
            // totalPriceLabel
            // 
            resources.ApplyResources(this.totalPriceLabel, "totalPriceLabel");
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Values.Text = resources.GetString("totalPriceLabel.Values.Text");
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.checkoutButton, "checkoutButton");
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.AllowUserToAddRows = false;
            this.shoppingCartDataGridView.AllowUserToDeleteRows = false;
            this.shoppingCartDataGridView.AllowUserToResizeColumns = false;
            this.shoppingCartDataGridView.AllowUserToResizeRows = false;
            this.shoppingCartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shoppingCartDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.shoppingCartDataGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameShoppingCartDataGridViewTextBoxColumn,
            this.productPriceShoppingCartDataGridViewTextBoxColumn,
            this.productAmountShoppingCartDataGridViewTextBoxColumn,
            this.weightUnitShoppingCartDataGridViewTextBoxColumn,
            this.totalPriceShoppingCartDataGridViewTextBoxColumn,
            this.removeShoppingCartDataGridViewButtonColumn});
            this.shoppingCartDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            resources.ApplyResources(this.shoppingCartDataGridView, "shoppingCartDataGridView");
            this.shoppingCartDataGridView.MultiSelect = false;
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shoppingCartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShoppingCartDataGridView_CellClick);
            this.shoppingCartDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ShoppingCartDataGridView_CellFormatting);
            this.shoppingCartDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ShoppingCartDataGridView_CellValidating);
            this.shoppingCartDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ShoppingCartDataGridView_DataBindingComplete);
            // 
            // productNameShoppingCartDataGridViewTextBoxColumn
            // 
            this.productNameShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Product.Name";
            resources.ApplyResources(this.productNameShoppingCartDataGridViewTextBoxColumn, "productNameShoppingCartDataGridViewTextBoxColumn");
            this.productNameShoppingCartDataGridViewTextBoxColumn.Name = "productNameShoppingCartDataGridViewTextBoxColumn";
            this.productNameShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceShoppingCartDataGridViewTextBoxColumn
            // 
            this.productPriceShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productPriceShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Product.Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.productPriceShoppingCartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.productPriceShoppingCartDataGridViewTextBoxColumn, "productPriceShoppingCartDataGridViewTextBoxColumn");
            this.productPriceShoppingCartDataGridViewTextBoxColumn.Name = "productPriceShoppingCartDataGridViewTextBoxColumn";
            this.productPriceShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAmountShoppingCartDataGridViewTextBoxColumn
            // 
            this.productAmountShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productAmountShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            resources.ApplyResources(this.productAmountShoppingCartDataGridViewTextBoxColumn, "productAmountShoppingCartDataGridViewTextBoxColumn");
            this.productAmountShoppingCartDataGridViewTextBoxColumn.Name = "productAmountShoppingCartDataGridViewTextBoxColumn";
            // 
            // weightUnitShoppingCartDataGridViewTextBoxColumn
            // 
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "WeightUnit";
            resources.ApplyResources(this.weightUnitShoppingCartDataGridViewTextBoxColumn, "weightUnitShoppingCartDataGridViewTextBoxColumn");
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.Name = "weightUnitShoppingCartDataGridViewTextBoxColumn";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceShoppingCartDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle2.NullValue = "$0.00";
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.totalPriceShoppingCartDataGridViewTextBoxColumn, "totalPriceShoppingCartDataGridViewTextBoxColumn");
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.Name = "totalPriceShoppingCartDataGridViewTextBoxColumn";
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // removeShoppingCartDataGridViewButtonColumn
            // 
            resources.ApplyResources(this.removeShoppingCartDataGridViewButtonColumn, "removeShoppingCartDataGridViewButtonColumn");
            this.removeShoppingCartDataGridViewButtonColumn.Name = "removeShoppingCartDataGridViewButtonColumn";
            this.removeShoppingCartDataGridViewButtonColumn.Text = "Remove";
            this.removeShoppingCartDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ShoppingCartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shoppingCartFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShoppingCartForm";
            this.shoppingCartFormPanel.ResumeLayout(false);
            this.shoppingCartFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel shoppingCartFormPanel;
        private System.Windows.Forms.Button checkoutButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox totalPriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel totalPriceLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox customerComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox customerCheckBox;
        private System.Windows.Forms.DataGridView shoppingCartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn removeShoppingCartDataGridViewButtonColumn;
    }
}
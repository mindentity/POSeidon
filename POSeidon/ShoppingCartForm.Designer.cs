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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
            this.shoppingCartFormPanel = new System.Windows.Forms.Panel();
            this.totalPriceTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.totalPriceLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.customerComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.shoppingCartFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartFormPanel
            // 
            this.shoppingCartFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingCartFormPanel.AutoSize = true;
            this.shoppingCartFormPanel.Controls.Add(this.customerComboBox);
            this.shoppingCartFormPanel.Controls.Add(this.customerCheckBox);
            this.shoppingCartFormPanel.Controls.Add(this.totalPriceTextBox);
            this.shoppingCartFormPanel.Controls.Add(this.totalPriceLabel);
            this.shoppingCartFormPanel.Controls.Add(this.checkoutButton);
            this.shoppingCartFormPanel.Controls.Add(this.shoppingCartDataGridView);
            this.shoppingCartFormPanel.Location = new System.Drawing.Point(1, 1);
            this.shoppingCartFormPanel.Margin = new System.Windows.Forms.Padding(2);
            this.shoppingCartFormPanel.Name = "shoppingCartFormPanel";
            this.shoppingCartFormPanel.Size = new System.Drawing.Size(802, 450);
            this.shoppingCartFormPanel.TabIndex = 0;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Enabled = false;
            this.totalPriceTextBox.Location = new System.Drawing.Point(49, 413);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalPriceTextBox.TabIndex = 5;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Location = new System.Drawing.Point(3, 416);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(40, 20);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Values.Text = "Total:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Orange;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Location = new System.Drawing.Point(693, 416);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(74, 23);
            this.checkoutButton.TabIndex = 3;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.AllowUserToAddRows = false;
            this.shoppingCartDataGridView.AllowUserToDeleteRows = false;
            this.shoppingCartDataGridView.AllowUserToResizeColumns = false;
            this.shoppingCartDataGridView.AllowUserToResizeRows = false;
            this.shoppingCartDataGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameShoppingCartDataGridViewTextBoxColumn,
            this.productPriceShoppingCartDataGridViewTextBoxColumn,
            this.productAmountShoppingCartDataGridViewTextBoxColumn,
            this.weightUnitShoppingCartDataGridViewTextBoxColumn});
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(2, 19);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(797, 384);
            this.shoppingCartDataGridView.TabIndex = 2;
            this.shoppingCartDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ShoppingCartDataGridView_CellFormatting);
            this.shoppingCartDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ShoppingCartDataGridView_CellValidating);
            this.shoppingCartDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ShoppingCartDataGridView_DataBindingComplete);
            // 
            // productNameShoppingCartDataGridViewTextBoxColumn
            // 
            this.productNameShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Product.Name";
            this.productNameShoppingCartDataGridViewTextBoxColumn.HeaderText = "Product";
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
            this.productPriceShoppingCartDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceShoppingCartDataGridViewTextBoxColumn.Name = "productPriceShoppingCartDataGridViewTextBoxColumn";
            this.productPriceShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productAmountShoppingCartDataGridViewTextBoxColumn
            // 
            this.productAmountShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productAmountShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.productAmountShoppingCartDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.productAmountShoppingCartDataGridViewTextBoxColumn.Name = "productAmountShoppingCartDataGridViewTextBoxColumn";
            // 
            // weightUnitShoppingCartDataGridViewTextBoxColumn
            // 
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "WeightUnit";
            dataGridViewCellStyle2.NullValue = "pcs";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.Name = "weightUnitShoppingCartDataGridViewTextBoxColumn";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.Location = new System.Drawing.Point(400, 416);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(79, 20);
            this.customerCheckBox.TabIndex = 6;
            this.customerCheckBox.Values.Text = "Customer:";
            this.customerCheckBox.CheckedChanged += new System.EventHandler(this.CustomerCheckBox_CheckedChanged);
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.DropDownWidth = 129;
            this.customerComboBox.Enabled = false;
            this.customerComboBox.Location = new System.Drawing.Point(485, 415);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(129, 21);
            this.customerComboBox.TabIndex = 7;
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shoppingCartFormPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.shoppingCartFormPanel.ResumeLayout(false);
            this.shoppingCartFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel shoppingCartFormPanel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.DataGridView shoppingCartDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox totalPriceTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel totalPriceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitShoppingCartDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox customerComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox customerCheckBox;
    }
}
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
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.DropDownWidth = 129;
            this.customerComboBox.Enabled = false;
            this.customerComboBox.Location = new System.Drawing.Point(96, 418);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(207, 21);
            this.customerComboBox.TabIndex = 7;
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.Location = new System.Drawing.Point(11, 419);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(79, 20);
            this.customerCheckBox.TabIndex = 6;
            this.customerCheckBox.Values.Text = "Customer:";
            this.customerCheckBox.CheckedChanged += new System.EventHandler(this.CustomerCheckBox_CheckedChanged);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Enabled = false;
            this.totalPriceTextBox.Location = new System.Drawing.Point(583, 416);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalPriceTextBox.StateDisabled.Content.Color1 = System.Drawing.Color.Teal;
            this.totalPriceTextBox.TabIndex = 5;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Location = new System.Drawing.Point(537, 419);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(40, 20);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Values.Text = "Total:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Orange;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Location = new System.Drawing.Point(703, 416);
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
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(2, 19);
            this.shoppingCartDataGridView.MultiSelect = false;
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(797, 384);
            this.shoppingCartDataGridView.TabIndex = 2;
            this.shoppingCartDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShoppingCartDataGridView_CellClick);
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
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.Name = "weightUnitShoppingCartDataGridViewTextBoxColumn";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceShoppingCartDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle2.NullValue = "$0.00";
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.Name = "totalPriceShoppingCartDataGridViewTextBoxColumn";
            this.totalPriceShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // removeShoppingCartDataGridViewButtonColumn
            // 
            this.removeShoppingCartDataGridViewButtonColumn.HeaderText = "Remove";
            this.removeShoppingCartDataGridViewButtonColumn.Name = "removeShoppingCartDataGridViewButtonColumn";
            this.removeShoppingCartDataGridViewButtonColumn.Text = "Remove";
            this.removeShoppingCartDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shoppingCartFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
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
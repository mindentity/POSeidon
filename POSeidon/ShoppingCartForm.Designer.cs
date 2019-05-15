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
            this.checkoutButton = new System.Windows.Forms.Button();
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingCartFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartFormPanel
            // 
            this.shoppingCartFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingCartFormPanel.AutoSize = true;
            this.shoppingCartFormPanel.Controls.Add(this.checkoutButton);
            this.shoppingCartFormPanel.Controls.Add(this.shoppingCartDataGridView);
            this.shoppingCartFormPanel.Location = new System.Drawing.Point(1, 1);
            this.shoppingCartFormPanel.Name = "shoppingCartFormPanel";
            this.shoppingCartFormPanel.Size = new System.Drawing.Size(1070, 554);
            this.shoppingCartFormPanel.TabIndex = 0;
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Orange;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Location = new System.Drawing.Point(924, 512);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(98, 28);
            this.checkoutButton.TabIndex = 3;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.AllowUserToDeleteRows = false;
            this.shoppingCartDataGridView.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameShoppingCartDataGridViewTextBoxColumn,
            this.productPriceShoppingCartDataGridViewTextBoxColumn,
            this.productAmountShoppingCartDataGridViewTextBoxColumn,
            this.weightUnitShoppingCartDataGridViewTextBoxColumn});
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(3, 23);
            this.shoppingCartDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(1063, 473);
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
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.shoppingCartFormPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.shoppingCartFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel shoppingCartFormPanel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.DataGridView shoppingCartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitShoppingCartDataGridViewTextBoxColumn;
    }
}
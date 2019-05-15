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
            this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
            this.productNameShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightUnitShoppingCartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingCartDataGridView
            // 
            this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameShoppingCartDataGridViewTextBoxColumn,
            this.productPriceShoppingCartDataGridViewTextBoxColumn,
            this.productAmountShoppingCartDataGridViewTextBoxColumn,
            this.weightUnitShoppingCartDataGridViewTextBoxColumn});
            this.shoppingCartDataGridView.Location = new System.Drawing.Point(82, 67);
            this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
            this.shoppingCartDataGridView.Size = new System.Drawing.Size(543, 150);
            this.shoppingCartDataGridView.TabIndex = 0;
            this.shoppingCartDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ShoppingCartDataGridView_CellFormatting);
            this.shoppingCartDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ShoppingCartDataGridView_CellValidating);
            this.shoppingCartDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ShoppingCartDataGridView_DataBindingComplete);
            // 
            // productNameShoppingCartDataGridViewTextBoxColumn
            // 
            this.productNameShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Product.Name";
            this.productNameShoppingCartDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameShoppingCartDataGridViewTextBoxColumn.Name = "productNameShoppingCartDataGridViewTextBoxColumn";
            this.productNameShoppingCartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceShoppingCartDataGridViewTextBoxColumn
            // 
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
            this.productAmountShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.productAmountShoppingCartDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.productAmountShoppingCartDataGridViewTextBoxColumn.Name = "productAmountShoppingCartDataGridViewTextBoxColumn";
            // 
            // weightUnitShoppingCartDataGridViewTextBoxColumn
            // 
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.DataPropertyName = "WeightUnit";
            dataGridViewCellStyle2.NullValue = "pcs";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.weightUnitShoppingCartDataGridViewTextBoxColumn.Name = "weightUnitShoppingCartDataGridViewTextBoxColumn";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(550, 256);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(75, 23);
            this.checkoutButton.TabIndex = 1;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.shoppingCartDataGridView);
            this.Name = "ShoppingCartForm";
            this.Text = "Shopping Cart";
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shoppingCartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightUnitShoppingCartDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button checkoutButton;
    }
}
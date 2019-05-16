using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSeidon
{
    public partial class ShoppingCartForm : Form
    {
        private BindingSource totalPriceBindingSource;

        public ShoppingCartForm()
        {
            InitializeComponent();
            shoppingCartDataGridView.AutoGenerateColumns = false;
            shoppingCartDataGridView.DataSource = Controller.ShoppingCart.Items;
            totalPriceBindingSource = new BindingSource();
            totalPriceBindingSource.DataSource = Controller.ShoppingCart;
            totalPriceTextBox.DataBindings.Add(
                "Text", totalPriceBindingSource, "TotalPrice", true,
                DataSourceUpdateMode.OnPropertyChanged, 0.0M, "C2"
            );
            shoppingCartDataGridView.CellValueChanged += ShoppingCartDataGridView_CellValueChanged;
            customerComboBox.DataSource = Controller.Customers;
            customerComboBox.DisplayMember = "FullName";
        }

        private void ShoppingCartDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem != null
                && shoppingCartDataGridView.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {
                e.Value = UIUtils.BindProperty(
                    shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem,
                    shoppingCartDataGridView.Columns[e.ColumnIndex].DataPropertyName
                );
            }
        }

        private void ShoppingCartDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in shoppingCartDataGridView.Rows)
            {
                var item = row.DataBoundItem as ShoppingCartItem;
                if (!item.Product.IsCountable)
                {
                    var cell = new DataGridViewComboBoxCell();
                    foreach (var weightUnit in Controller.Settings.AvailableWeightUnits)
                    {
                        cell.Items.Add(weightUnit.Symbol);
                    }
                    cell.Value = cell.Items[0];
                    row.Cells[3] = cell;
                    row.Cells[3].ReadOnly = false;
                }
            }
        }

        private void ShoppingCartDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var cell = shoppingCartDataGridView[e.ColumnIndex, e.RowIndex];
                var item = shoppingCartDataGridView.Rows[e.RowIndex].DataBoundItem as ShoppingCartItem;
                try
                {
                    
                    var oldAmount = (double) shoppingCartDataGridView[e.ColumnIndex, e.RowIndex].Value;
                    var newAmount = Double.Parse(e.FormattedValue.ToString());
                    if (newAmount > 0 && newAmount <= item.Product.StockAmount)
                    {
                        Controller.ShoppingCart.TotalPrice += (decimal)(newAmount - oldAmount) * item.Product.Price;

                    }
                    else
                    {
                        e.Cancel = true;
                    }

                }
                catch
                {
                    e.Cancel = true;
                }
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to proceed to checkout?", "POSeidon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Customer customer = null;
                if (customerCheckBox.Checked)
                {
                    customer = customerComboBox.SelectedItem as Customer;
                }
                Controller.ShoppingCart.Checkout(customer);
                MessageBox.Show("Checkout is successful.", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ShoppingCartDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                totalPriceBindingSource.ResetCurrentItem();
            }
        }

        private void CustomerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customerCheckBox.Checked)
            {
                customerComboBox.Enabled = true;
            }
            else
            {
                customerComboBox.Enabled = false;
            }
        }
    }
}

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
        public ShoppingCartForm()
        {
            InitializeComponent();
            shoppingCartDataGridView.AutoGenerateColumns = false;
            shoppingCartDataGridView.DataSource = Controller.ShoppingCart.Items;
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
                    if (item.Product.IsCountable)
                    {
                        Int32.Parse(e.FormattedValue.ToString());
                    }
                    else
                    {
                        Double.Parse(e.FormattedValue.ToString());
                    }
                }
                catch
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

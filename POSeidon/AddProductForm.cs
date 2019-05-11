using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace POSeidon
{
    public partial class addProductForm : Form
    {
        public addProductForm()
        {
            InitializeComponent();
            newProductTypeComboBox.SelectedIndex = 0;
            existingProductComboBox.DataSource = Controller.Products;
            existingProductComboBox.DisplayMember = "Name";
            productSupplierComboBox.DataSource = Controller.Suppliers;
            productSupplierComboBox.DisplayMember = "Name";
        }

        private void ExistingProductRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KryptonRadioButton rb = sender as KryptonRadioButton;
            if (rb.Checked)
            {
                addProductNavigator.SelectedIndex = 0;
            }
            else
            {
                addProductNavigator.SelectedIndex = 1;
            }
        }
    }
}

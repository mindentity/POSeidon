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
    public partial class mainForm : Form
    {
        private IEnumerable<Product> Products { get; set; }

        public mainForm()
        {
            InitializeComponent();
            homepageDataGridView.AutoGenerateColumns = false;
            homepageDataGridView.DataSource = Controller.Products;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm();
            addProductForm.ShowDialog();
        }
    }
}

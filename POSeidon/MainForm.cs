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
        private BindingSource bindingSource1 = new BindingSource();

        public mainForm()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Products = DBUtils.GetAllProducts().ToList();
            foreach (Product p in Products)
            {
                bindingSource1.Add(p);
            }
            homepageDataGridView.AutoGenerateColumns = false;
            homepageDataGridView.DataSource = bindingSource1;

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm();
            addProductForm.ShowDialog();
        }
    }
}

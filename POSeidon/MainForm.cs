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
    public partial class MainForm : Form
    {
        private IEnumerable<Product> Products { get; set; }
        private BindingSource bindingSource1 = new BindingSource();

        public MainForm()
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
            /*
            mDialog = new Form();
            mDialog.FormClosed += (o, ea) => mDialog = null;
            mDialog.Show(this);
            while (mDialog != null) Application.DoEvents();
            */
        }
            
    }
}

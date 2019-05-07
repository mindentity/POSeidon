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
        }
    }
}

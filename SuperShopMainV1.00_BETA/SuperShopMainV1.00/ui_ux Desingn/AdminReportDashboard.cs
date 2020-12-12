using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopMainV1._00
{
    public partial class adminReport : Form
    {
        public adminReport()
        {
            InitializeComponent();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void RemonveProduct_Click(object sender, EventArgs e)
        {
            DeleteProductsFromInventory dld = new DeleteProductsFromInventory();
            dld.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

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
    public partial class DeleteProductsFromInventory : Form
    {
        public DeleteProductsFromInventory()
        {
            InitializeComponent();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login logut = new Login();
            logut.Show();
            this.Hide();
        }

        private void RemonveProduct_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            adminReport adr = new adminReport();
            adr.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

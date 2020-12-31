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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void RemonveProduct_Click(object sender, EventArgs e)
        {
            DeleteProductsFromInventory delpd = new DeleteProductsFromInventory();
            delpd.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            adminReport adm = new adminReport();
            adm.Show();
            this.Hide();
        }

        private void addedbuttoninventory_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchinventory_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superShopMSDBDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.superShopMSDBDataSet1.PRODUCT);
            // TODO: This line of code loads data into the 'superShopMSDBDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.superShopMSDBDataSet.PRODUCT);

        }
    }
}

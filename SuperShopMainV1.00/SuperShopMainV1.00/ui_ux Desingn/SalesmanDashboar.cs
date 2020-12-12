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
    public partial class SalesmanDashboar : Form
    {
        public static double totalcounter = 0.00;
        public SalesmanDashboar()
        {
            InitializeComponent();
        }

        private void SalesmanDashboar_Load(object sender, EventArgs e)
        {

        }

        private void Dashboradpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Membershipdropdown_Click(object sender, EventArgs e)
        {

        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Addcutomerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubCustomerDashborad cclb = new ClubCustomerDashborad();
            cclb.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void addedbutton_Click(object sender, EventArgs e)
        {
            double ttp = Convert.ToDouble(pricetxtbox.Text) * Convert.ToDouble(Qtytextbox.Text);
            customersalesdatagrid.Rows.Add(productidtextbox.Text, ProductNametextBox.Text, Qtytextbox.Text, pricetxtbox.Text,ttp);
            totalcounter = totalcounter + ttp;
            productidtextbox.Text=" ";
            ProductNametextBox.Text=" ";
            Qtytextbox.Text=" ";
            pricetxtbox.Text = " ";
            textBox3.Text = totalcounter.ToString();

        }


        private void Qtytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = totalcounter.ToString();
        }

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.customersalesdatagrid.SelectedRows) //Delete Funciton
            {
                customersalesdatagrid.Rows.RemoveAt(item.Index);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            iDelete();
        }

    }
}

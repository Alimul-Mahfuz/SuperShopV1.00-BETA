using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperShopMainV1._00
{
    public partial class SalesmanDashboar : Form
    {
        public static double totalcounter = 0.00;
        public SalesmanDashboar()
        {
            InitializeComponent();
            Qtytextbox.Text = "1";
            grandtotalcount.Text = "0.00";
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
        private void enterkeyserach()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True;");
            sqlcon.Open();
            string query = "Select PRODUCT_NAME from PRODUCT WHERE PRODUCT_ID =" + int.Parse(productidtextbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtp = new DataTable();
            sda.Fill(dtp);
            ProductNametextBox.Text = dtp.Rows[0][0].ToString();

        }

        private void addedbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string price;
                SqlConnection sqlcon = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True;");
                sqlcon.Open();
                string query = "Select PRODUCT_NAME,SELLING_PRICE from PRODUCT WHERE PRODUCT_ID =" + int.Parse(productidtextbox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                ProductNametextBox.Text = dtb.Rows[0][0].ToString();
                price = dtb.Rows[0][1].ToString();
                float fineprice = float.Parse(price);
                int qtyp=int.Parse(Qtytextbox.Text);
                float sum=qtyp*fineprice;
                customersalesdatagrid.Rows.Add(productidtextbox.Text, ProductNametextBox.Text, Qtytextbox.Text, price,sum.ToString());
                totalcounter = totalcounter + sum;
                grandtotalcount.Text = totalcounter.ToString();
                sqlcon.Close();


            }
            catch (Exception exd)
            {
                
                MessageBox.Show("FAILD");
            }
    

        }


        private void Qtytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            grandtotalcount.Text = totalcounter.ToString();
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

        private void customersalesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

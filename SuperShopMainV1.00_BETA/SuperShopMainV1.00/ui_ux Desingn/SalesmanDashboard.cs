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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True;");
        public static double totalcounter = 0.00;
        public string cnt = "";
        DateTime dateTime = DateTime.UtcNow.Date;
        public SalesmanDashboar()
        {   
            InitializeComponent();
            Qtytextbox.Text = "1";
            grandtotalcount.Text = "0.00";
            datetimeviewer.Text = dateTime.ToString("dd-MM-yyyy");
           
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
            if(productidtextbox.Text!=""&&cnametextbox.Text!="")
            {
                  try
                {
                    string price;
                    sqlcon.Open();
                    string query = "Select PRODUCT_NAME,SELLING_PRICE from PRODUCT WHERE PRODUCT_ID =" + int.Parse(productidtextbox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtb = new DataTable();
                    sda.Fill(dtb);
                    ProductNametextBox.Text = dtb.Rows[0][0].ToString();
                    price = dtb.Rows[0][1].ToString();
                    float fineprice = float.Parse(price);
                    int qtyp = int.Parse(Qtytextbox.Text);
                    float sum = qtyp * fineprice;
                    customersalesdatagrid.Rows.Add(productidtextbox.Text, ProductNametextBox.Text, Qtytextbox.Text, price, sum.ToString());
                    totalcounter = totalcounter + sum;
                    totaltextbox.Text = totalcounter.ToString();
                    sqlcon.Close();


                }
                catch (Exception exd)
                {

                    MessageBox.Show(exd.Message);
                }
            }
            else
            {
                MessageBox.Show("Customer Name field or Product ID field is Empty");
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

        private void productidtextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void proccedtopay_Click(object sender, EventArgs e)
        {

        }
        private void datetimeviewer_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void payconfig(Confirmpay psd)
        {
            string[,] Datavalue = new string[customersalesdatagrid.Rows.Count, customersalesdatagrid.Columns.Count];
            foreach (DataGridViewRow row in customersalesdatagrid.Rows)
            {
                foreach (DataGridViewColumn col in customersalesdatagrid.Columns)
                {
                    Datavalue[row.Index, col.Index] = customersalesdatagrid.Rows[row.Index].Cells[col.Index].Value.ToString();

                }
            }
            int i = 1;
            string strval = "";
            foreach(string ss in Datavalue)
            {
                strval += ss;
                if (i == 5)
                {
                    psd.listBoxitem.Items.Add(strval);
                    strval = " "+" ";
                    i = 0;
                }
                i++;

            }
            
        }
        public void insbdetails()
        {
            string[,] Datavalue = new string[customersalesdatagrid.Rows.Count, customersalesdatagrid.Columns.Count];
            foreach (DataGridViewRow row in customersalesdatagrid.Rows)
            {
                foreach (DataGridViewColumn col in customersalesdatagrid.Columns)
                {
                    Datavalue[row.Index, col.Index] = customersalesdatagrid.Rows[row.Index].Cells[col.Index].Value.ToString();

                }
            }
            string query = "Select BILL_ID from BILLDETAIL WHERE CUSTOMER_ID  =" + int.Parse(cnt);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            string bid = dtb.Rows[0][0].ToString();

            int i = 1;
            string strval = "";
            foreach (string ss in Datavalue)
            {
                strval = ss ;
                if (i == 1)
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("insert into BILL_DETAILS values(@BILL_ID,@PRODUCT_ID)", sqlcon);
                    cmd.Parameters.AddWithValue("@BILL_ID", bid);
                    cmd.Parameters.AddWithValue("@PRODUCT_ID", ss);
                    int j = cmd.ExecuteNonQuery();
                    if (j == 1)
                    {
                        MessageBox.Show("Data Saved");
                    }
                    
                    i = 0;
                }
                i++;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (productidtextbox.Text!="")
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True;");
                    sqlcon.Open();
                    string query = "Select PRODUCT_NAME,SELLING_PRICE from PRODUCT WHERE PRODUCT_ID =" + int.Parse(productidtextbox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtb = new DataTable();
                    sda.Fill(dtb);
                    ProductNametextBox.Text = dtb.Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("PRODUCT NOT FOUND");
                    productidtextbox.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("Product ID Is Empty ");
            }
        }
        public void inscnt()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into CONTACT values(@CONTACT_ID,@NAME,@EMAIL,@PHONE,@ADDRESS,@CATAGORY)", sqlcon);
            cmd.Parameters.AddWithValue("@NAME",cnametextbox.Text);
            cmd.Parameters.AddWithValue("@EMAIL",null);
            cmd.Parameters.AddWithValue("@PHONE",custphonetextbox.Text);
            cmd.Parameters.AddWithValue("@ADDRESS",null);
            cmd.Parameters.AddWithValue("@CATAGORY","CUSTOMER");
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Data Saved");
            }
        }
        public void insbill(Confirmpay isl)
        {
            string query = "Select CONTACT_ID from PRODUCT WHERE PHONE =" + int.Parse(custphonetextbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            string cntid = dtb.Rows[0][0].ToString();
            cnt = cntid;
            SqlCommand cmd = new SqlCommand("insert into BILL values(@CUSTOMER_ID,@PAYMENT_METHOD,@VAT,@DISCOUNT,@TOTAL_PAYABLE,@RECIEVED_CASH,@CHANGE,@ISSUE_DATE)", sqlcon);
            cmd.Parameters.AddWithValue("@CUSTOMER_ID", cntid);
            cmd.Parameters.AddWithValue("@MAYMENT_METHOD",isl.paymentmethodselector.Text);
            cmd.Parameters.AddWithValue("@VAT",null);
            cmd.Parameters.AddWithValue("@DISCOUNT", null);
            cmd.Parameters.AddWithValue("@TOTAL_PAYABLE",totalcounter.ToString());
            cmd.Parameters.AddWithValue("@RECIEVED_CASH", isl.recievedcashbox.Text);
            cmd.Parameters.AddWithValue("@CHANGE", (totalcounter-int.Parse(isl.recievedcashbox.Text)).ToString());
            cmd.Parameters.AddWithValue("@ISSUE_DATE", dateTime.ToString("dd-MM-yyyy"));
            int i = cmd.ExecuteNonQuery();
        }

        public void inscust()
        {
            string query = "Select CONTACT_ID from PRODUCT WHERE PHONE =" + int.Parse(custphonetextbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            string cntid = dtb.Rows[0][0].ToString();
            SqlCommand smd = new SqlCommand("insert into CUSTOMER values(@CONTACT_ID,@MEMBER_ID)", sqlcon);
            smd.Parameters.AddWithValue("@NAME",cntid);
            int i = smd.ExecuteNonQuery();
            {
                MessageBox.Show("Data Saved");
            }

        }


   
        private void proceedtopay_Click(object sender, EventArgs e)
        {
            if (memberdropdown.Text == "Member")
            {
                memconfirmation meconfig = new memconfirmation();
                meconfig.Show();
            }
            if(memberdropdown.Text=="Non Member")
            {
                Confirmpay cfp = new Confirmpay(cnametextbox.Text, totalcounter.ToString());
                payconfig(cfp);
                cfp.Show();

            }
            if(memberdropdown.Text=="")
            {
                MessageBox.Show("Enter Membership Status");
            }

        }


    }
}

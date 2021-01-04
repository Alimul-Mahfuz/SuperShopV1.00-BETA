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
/*Contributor(Form): Alimul Mahfuz Tushar
 * ID:19-39831-1
 * Contributor(code):JEBA FAWJIA
 * ID:19-39815-1
 * Contributor2(code): FATIN ISHRAK
 * ID:19-39862-1
 * */


namespace SuperShopMainV1._00
{
    public partial class ClubCustomerDashborad : Form
    {
        SqlConnection son = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True;");
        public ClubCustomerDashborad()
        {
            InitializeComponent();
            disp();
        }
        public void disp()
        {
            son.Open();
            SqlDataAdapter sdpt = new SqlDataAdapter("select MEMBER.MEMBER_ID, CONTACT.CONTACT_ID, CONTACT.NAME, CONTACT.EMAIL, CONTACT.ADDRESS FROM MEMBER,CONTACT WHERE MEMBER.CONTACT_ID=CONTACT.CONTACT_ID;", son);
            SqlCommandBuilder cb = new SqlCommandBuilder(sdpt);
            DataTable dt = new DataTable();
            sdpt.Fill(dt);
            clubcustomerdatagrid.DataSource = dt;
            son.Close();

        }

        private void ClubCustomerDashboarplanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanDashboar ssld = new SalesmanDashboar();
            ssld.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login logout = new Login();
            logout.Show();
        }



        private void addedbutton_Click(object sender, EventArgs e)
        {
            try
            {
                son.Open();
                SqlCommand cmd = new SqlCommand("insert into CONTACT values(@NAME,@EMAIL,@PHONE,@ADDRESS,@CATAGORY)", son);
                cmd.Parameters.AddWithValue("@NAME",CustomerNameTextboxSales.Text);
                cmd.Parameters.AddWithValue("@EMAIL", CustomerEmailTextbox.Text);
                cmd.Parameters.AddWithValue("@PHONE", PhneTextClub.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", clubcustomeraddress.Text);
                cmd.Parameters.AddWithValue("@CATAGORY", "CUSTOMER");
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("CUSTOMER ADDED");
                    string quer = "SELECT CONTACT_ID FROM CONTACT WHERE PHONE=" + int.Parse(PhneTextClub.Text);
                    SqlDataAdapter asd = new SqlDataAdapter(quer, son);
                    DataTable dtbl = new DataTable();
                    asd.Fill(dtbl);
                    string cuntid = dtbl.Rows[0][0].ToString();
                    SqlCommand smd = new SqlCommand("insert into MEMBER values(@CONTACT_ID,@MEMBERSHIP_DATE)", son);
                    smd.Parameters.AddWithValue("@CONTACT_ID", cuntid);
                    smd.Parameters.AddWithValue("@MEMBERSHIP_DATE", DateTime.UtcNow.ToString("dd/MM/yyyy"));
                    int p = smd.ExecuteNonQuery();

                    if (p == 1)
                    {
                        MessageBox.Show("Data Saved");
                        CustomerNameTextboxSales.Text = "";
                        CustomerEmailTextbox.Text = "";
                        PhneTextClub.Text = "";
                        clubcustomeraddress.Text = "";

                    }

                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            son.Close();
            disp();

        }

        private void refreshclubmemberbtn_Click(object sender, EventArgs e)
        {
            disp();
            this.Show();
        }

        private void Addcutomerbutton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MngBIll_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillDetailsDashboard bdl = new BillDetailsDashboard();
            bdl.Show();
        }
 

    }
}

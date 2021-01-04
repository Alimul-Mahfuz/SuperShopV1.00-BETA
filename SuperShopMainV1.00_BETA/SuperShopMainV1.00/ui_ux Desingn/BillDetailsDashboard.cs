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
    /*
     *Contributor(Form):ALIMUL MAHFUZ TUSHAR
     *ID:19-39831-1
     *Contributor(Form):ABDUL WAZED
     *ID:19-39806-1
     Contributor(code): JEBA FAWJIA
     ID: 19-39815-1
     Contributor(code):FATIN ISRAK
     ID:19-39862-1
     */
    public partial class BillDetailsDashboard : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True");
        public BillDetailsDashboard()
        {
            InitializeComponent();
            binddatagrid();
        }
        private void binddatagrid()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from BILLDETAILS", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void searchbill_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from BILLDETAILS Where BILL_ID=" +int.Parse(billdetailsidtexbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesmanDashboar ssl = new SalesmanDashboar();
            this.Hide();
            ssl.Show();
        }

        private void Addcutomerbutton_Click(object sender, EventArgs e)
        {
            ClubCustomerDashborad dds = new ClubCustomerDashborad();
            this.Hide();
            dds.Show();
            
        }

        private void MngBIll_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }
    }
}

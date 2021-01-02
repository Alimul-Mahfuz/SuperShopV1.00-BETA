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
    public partial class adminReport : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=TSR1998\SQLEXPRESS;Initial Catalog=SuperShopMSDB;Integrated Security=True;");
        public adminReport()
        {
            InitializeComponent();
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from REPORT";
            cmd.ExecuteNonQuery();// executing the CommandText

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd); //here the sql datadapter is catching the data  using sql language
            da.Fill(dt); //here the sql datadapter is filling the data into the datatable
            dgvReport.DataSource = dt; //the datatable is showing into the data grid view


            sqlConnection.Close();
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

        private void Inventory_Click(object sender, EventArgs e)
        {
            AdminDashboard add = new AdminDashboard();
            this.Hide();
            add.Show();
        }
    }
}

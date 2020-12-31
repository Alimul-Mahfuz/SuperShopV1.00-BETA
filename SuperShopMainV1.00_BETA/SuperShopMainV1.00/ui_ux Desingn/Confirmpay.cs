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
    public partial class Confirmpay : Form
    {
        public Confirmpay(string a,string b)
        {
            payconfigtotalpay.Text = b;
            payconfcnametext.Text = a;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RoleSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

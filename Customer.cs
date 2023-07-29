using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            uC_Viewcustomer1.Visible = false;
            uC_Addcustomer1.Visible = false;

            uC_Placeorder1.Visible = false;
            gunaButton1.PerformClick();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            uC_Viewcustomer1.Visible = true;
            uC_Viewcustomer1.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            uC_Addcustomer1.Visible = true;
            uC_Addcustomer1.BringToFront();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

            uC_Placeorder1.Visible = true;

            uC_Placeorder1.BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();
            this.Hide();
        }
    }
}

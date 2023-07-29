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
    public partial class admin : Form
    {
        String user = "";
        public admin()
        {
            InitializeComponent();
            uC_ViewUser1.ID = ID;
        }
        public admin(String username)
        {
            InitializeComponent();
            user= username;
            uC_ViewUser1.ID = ID;
        }
        public string ID
        {
            get { return user.ToString(); }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_Adduser1.Visible = false;
            uC_ViewUser1.Visible = false;

            uC_profile3.Visible = false;
            gunaButton1.PerformClick();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
        Form1 fm = new Form1();
            fm.ShowDialog();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
           
            uC_Dashboard1.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            uC_Adduser1.Visible = true;
            uC_Adduser1.BringToFront();
        }

        private void btnviewuser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
     
            uC_profile3.Visible= true;
            uC_profile3.BringToFront();
           
        }
    }
}

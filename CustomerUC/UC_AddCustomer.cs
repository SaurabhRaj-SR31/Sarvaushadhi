using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.CustomerUC
{
    public partial class UC_Addcustomer : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_Addcustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Addcustomer_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(txtcid.Text);
            Int64 pin = Int64.Parse(txtcpin.Text);
            String name = txtcname.Text;
            String address = txtaddress.Text;
            Int64 phone = Int64.Parse(txtcphone.Text);
            String city = txtccity.Text;
            try
            {
                query = " insert into customer_details(cid,cname,caddress,ccity,cpin,cphone)  values ('" + id + "','" + name + "','" + address + "','" + city + "','" + pin + "','" + phone + "')";
                
                fn.setData(query, "Sign up Succesfull !!");
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong !!! Pls try again  later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

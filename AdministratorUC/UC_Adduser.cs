using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Math;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_Adduser : UserControl
    {
        function fn = new function();
        String query,query2;
        public UC_Adduser()
        {
            InitializeComponent();
        }

        private void UC_Adduser_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            String role =txtuserrole.Text;
            String name =txtname.Text;
            String password =txtpassword.Text;
            String dob= txtdob.Text;
            Int64 mobile= Int64.Parse(txtmobile.Text);
            String email= txtemail.Text;
            String username= txtusername.Text;

            try
            {


              
                
             

                        query = "insert into user_type(userrole,name,dob,mobile,email,username,pass)  values ('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + password + "')";
                        fn.setData(query, "Sign up Succesfull !!");
                    

                
              



            }

            catch (Exception) {

                MessageBox.Show("Something went wrong !!! Pls try again  later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

                
            
                
              
                

        }
        public void clearAll()
        {
            txtdob.ResetText();
            txtusername.Clear(); 
            txtpassword.Clear();
            txtname.Clear();
            txtmobile.Clear();
            txtemail.Clear();
            txtuserrole.SelectedIndex = -1;


        }
        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
} 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_profile : UserControl
    {
        function fn = new function();
        String query;
      

        public UC_profile()
        {
            InitializeComponent();
        }
        String gender;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int id=int.Parse(gunaTextBox1.Text);
            String f_name=gunaTextBox2.Text.ToString();
            String l_name = gunaTextBox3.Text.ToString();
            int age = int.Parse(gunaTextBox4.Text);
            String add = gunaTextBox5.Text.ToString();
            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "female";
            }
            String yr = gunaTextBox7.Text.ToString();

            String pos = gunaTextBox6.Text.ToString();

            query = "insert into admin (a_id,fname,lname,age,address,gender,joining_year,position) values ('" + id + "','" + f_name + "','" + l_name + "','" + age + "','" + add + "','" + gender + "','" + yr + "','" + pos + "')";
           fn.setData(query, "Data Added !!");

        }

        private void UC_profile_Load(object sender, EventArgs e)
        {
            radioButton1.Checked =false;
            radioButton2.Checked = false;
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            admin am = new admin();
            am.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            query = "select * from user_type";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if (textBox1.Text == "root" && textBox2.Text == "root")
                {
                    admin am = new admin();
                    am.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from user_type where username='" + textBox1.Text + "'and pass='" + textBox2.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {

                        admin am = new admin(textBox1.Text);
                        am.ShowDialog();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist ph = new Pharmacist();
                        ph.ShowDialog();
                        this.Hide();
                    }
                    else if (role == "Customer")
                    {
                        Customer ph = new Customer();
                        ph.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("wrong username or password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }




            }
        
       
        
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
        Close();
        }
    }
}

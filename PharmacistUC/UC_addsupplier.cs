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
using Guna.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_addsupplier : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_addsupplier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gunaTextBox1.Text);
            String s_name = gunaTextBox2.Text.ToString();
            String s_city = gunaTextBox3.Text.ToString();
            int m_id = int.Parse(gunaTextBox4.Text);
        
    

            query = "insert into supplier (sup_ID,sup_name,sup_city,sup_medID) values ('" + id + "','" + s_name + "','" + s_city + "','" +m_id+ "')";
            fn.setData(query, "Data Added !!");
        }

        private void UC_addsupplier_Load(object sender, EventArgs e)
        {
            listboxmedicines.Items.Clear();
            query = "select sup_name from supplier  ";
            ds = fn.getData(query);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listboxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtsearchbox_TextChanged(object sender, EventArgs e)
        {
            listboxmedicines.Items.Clear();
            query = "select sup_name from supplier where sup_name  like '" + txtsearchbox.Text + "%' ";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listboxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_addsupplier_Load(this, null);
        }
    }
}

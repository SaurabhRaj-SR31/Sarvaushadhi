using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {

        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(gunaTextBox1.Text!="" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" && gunaTextBox5.Text != "" && gunaTextBox4.Text != "")
            {
                String mid = gunaTextBox1.Text;
                String mname = gunaTextBox2.Text;  
                String mnumber = gunaTextBox3.Text;
                String edate = gunaDateTimePicker4.Text;
                String mdate = gunaDateTimePicker1.Text;
                Int64 quantity = Int64.Parse(gunaTextBox5.Text);
                Int64 perunit = Int64.Parse(gunaTextBox4.Text);

                query = "insert into medic(mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('"+mid+"','"+mname+"','"+mnumber+"','"+mdate+ "','"+edate+ "',"+quantity+","+perunit+")";
                fn.setData(query, "Medicine added to Database.");
            }

            else
            {
                MessageBox.Show("Enter all data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            gunaTextBox1.Clear();
            gunaTextBox2.Clear();
            gunaTextBox3.Clear();
            gunaTextBox5.Clear();
            gunaTextBox4.Clear();
            gunaDateTimePicker1.ResetText();
            gunaDateTimePicker4.ResetText();

        }
    }
}

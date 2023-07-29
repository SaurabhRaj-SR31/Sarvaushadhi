using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Microsoft.VisualBasic.ApplicationServices;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_ViewUser : UserControl
    {
   String current= "";
        function fn = new function();
        String query;
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { current=value; }
        }
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            query="select * from user_type where username like '"+txtusername.Text+"%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from user_type";
            DataSet ds=fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String username;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = gunaDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete Confirmation !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                if (current != username)
                {
                    query = "delete from user_type where username='" + username + "'";
                    fn.setData(query, "Record deleted!!");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("you are trying to delete your own profile!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           

        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}

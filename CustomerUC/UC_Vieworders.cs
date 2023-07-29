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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.CustomerUC
{
    public partial class UC_Vieworders : UserControl
    {
        String current = "";
        function fn = new function();
        String query;
        String qury;
        public UC_Vieworders()
        {
            InitializeComponent();
        }
        
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void UC_Vieworders_Load(object sender, EventArgs e)
        {
        qury = "select * from orders o natural join customer_details c where o.cid in ( select c1.cust_id from customer c1 natural join customer_details c2  where c.cid=c2.cid)";
            
           
           
            
            query = "select * from  orders ";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from orders where c_id like '" + txtusername.Text + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
        String username;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = gunaDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_Vieworders_Load(this, null);
        }
    }
}

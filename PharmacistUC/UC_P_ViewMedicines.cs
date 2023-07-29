using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_ViewMedicines : UserControl
    {
        String current = "";
        function fn = new function();
        String query;
        public UC_P_ViewMedicines()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { current = value; }
        }

        private void UC_P_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + gunaTextBox1.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        String medicineId;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (current != medicineId)
                {
                    query = "delete from medic where mid='" + medicineId + "'";
                    fn.setData(query, "Record deleted!!");
                    UC_P_ViewMedicines_Load(this, null);
                }
                else
                {
                    MessageBox.Show("cant delete this medicine !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicines_Load(this, null);
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

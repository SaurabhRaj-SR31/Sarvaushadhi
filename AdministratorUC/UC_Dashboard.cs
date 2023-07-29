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
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query="select count(userrole) from user_type where userrole='Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "select count(userrole) from user_type where userrole='Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharmaLabel);


            query = "select count(userrole) from user_type where userrole='Customer'";
            ds = fn.getData(query);
            setLabel(ds, CustomerLabel);
        }

        private void setLabel(DataSet ds,Label lbl)
        {
            if (ds.Tables[0].Rows.Count!=0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();

            }

            else
            {
                lbl.Text = "0";
            }

        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }
    }
}

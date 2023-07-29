using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementSystem.AdministratorUC;

namespace PharmacyManagementSystem
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicines1.Visible = true;

            uC_P_ViewMedicines1.BringToFront();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;

            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_addsupplier1.Visible = false;
            uC_P_Dashboard1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicines1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            gunaButton1.PerformClick();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
          uC_P_AddMedicine1.Visible = true;

            uC_P_AddMedicine1.BringToFront();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();
            this.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;

            uC_P_SellMedicine1.BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            uC_addsupplier1.Visible = true;

            uC_addsupplier1.BringToFront();
        }

        private void uC_addsupplier1_Load(object sender, EventArgs e)
        {

        }
    }
}

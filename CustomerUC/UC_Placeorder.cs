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
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Math;

    
namespace PharmacyManagementSystem.CustomerUC

{ 
    
    public partial class UC_Placeorder : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
      Int64 unitprice;
     

        public UC_Placeorder()
        {
            InitializeComponent();
        }

        private void listboxmedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Clear();
            String name = listboxmedicines.GetItemText(listboxmedicines.SelectedItem);

            txtmedname.Text = name;
            query = "select mid,perUnit from medic where mname='" + name + "'";
            ds = fn.getData(query);
            txtmedid.Text = ds.Tables[0].Rows[0][0].ToString();
            unitprice = Int64.Parse(ds.Tables[0].Rows[0][1].ToString());


        }

        private void txtsearchbox_TextChanged(object sender, EventArgs e)
        {
            listboxmedicines.Items.Clear();
            query = "select mname from medic where mname like '" + txtsearchbox.Text + "%' and edate >= getdate()  and quantity >'0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listboxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtmedid.Text != "")
            {
               
                Int64 noofunit = Int64.Parse(txtquantity.Text);
                Int64 totalamount = unitprice * noofunit;
                txttotalprice.Text = totalamount.ToString();

            }

            else
            {
                txttotalprice.Clear();
            }
        }

        protected int n, totalamount = 0;
        public Int64 quantity, newquantity;

        private void UC_Placeorder_Load(object sender, EventArgs e)
        {
            listboxmedicines.Items.Clear();
            query = "select mname from medic where eDate>= getdate() and quantity >'0' ";
            ds = fn.getData(query);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listboxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtfinalprice_Click(object sender, EventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (valueid != null)
            {
                try
                {
                    gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
                }
                catch { }
                finally
                {
                    query = "select quantity from medic where mid ='" + valueid + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noofunit;
                    query = "update medic set quantity ='" + newquantity + "' where mid='" + valueid + "'";
                    fn.setData(query, "medicine Removed from Cart.");
                    totalamount -= valueamount;
                    txtfinalprice.Text = totalamount.ToString();


                }
                UC_Placeorder_Load(this, null);
            }
        }
       
        int valueamount;
        String valueid;
        public Int64 noofunit;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueid = gunaDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                noofunit = Int64.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch { }
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gunaDataGridView1.Rows.Count; i++)
            {
                if (gunaDataGridView1.Rows[i].Cells[0].Value != null
                    && gunaDataGridView1.Rows[i].Cells[1].Value != null
                    && gunaDataGridView1.Rows[i].Cells[2].Value != null
                    && gunaDataGridView1.Rows[i].Cells[3].Value != null
                    && gunaDataGridView1.Rows[i].Cells[4].Value != null)
                {
                    String num = gunaDataGridView1.Rows[i].Cells[0].Value.ToString();
                    String naam = gunaDataGridView1.Rows[i].Cells[1].Value.ToString();
                    String mid = gunaDataGridView1.Rows[i].Cells[2].Value.ToString();
                    Int64 q = Int64.Parse(gunaDataGridView1.Rows[i].Cells[3].Value.ToString());
                    Int64 t = Int64.Parse(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());

                    Int64 o_num = fn.order_id();

                    query = "insert into orders(order_id,c_id,medname,medid,quantity,totalprice) values('" + o_num + "','" + num + "','" + naam + "','" + mid + "','" + q + "','" + t + "')";

                    fn.setData(query, "Purchase Succesfull !!");
                }
            }

        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (txtmedid.Text != "")
            {
                query = "select quantity from medic where mid ='" + txtmedid.Text + "'";

                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(txtquantity.Text);
                if (newquantity >= 0)
                {
                    n = gunaDataGridView1.Rows.Add();
                    gunaDataGridView1.Rows[n].Cells[0].Value = txtcid.Text;
                    gunaDataGridView1.Rows[n].Cells[1].Value = txtmedname.Text;
                    gunaDataGridView1.Rows[n].Cells[2].Value = txtmedid.Text;
                    gunaDataGridView1.Rows[n].Cells[3].Value = txtquantity.Text;
                    gunaDataGridView1.Rows[n].Cells[4].Value = txttotalprice.Text;

                    

                    totalamount += int.Parse(txttotalprice.Text);

                    txtfinalprice.Text = "Rs. " + totalamount.ToString();

                    query = "update medic set quantity ='" + newquantity + "' where mid ='" + txtmedid.Text + "'";
                    fn.setData(query, "Added to cart !!");


                }

                else
                {
                    MessageBox.Show(" Selected Medicine is out of stock .\n Only " + quantity + " left ", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearall();
                UC_Placeorder_Load(this, null);
            }

            else
            {
                MessageBox.Show(" Select item pls ", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearall()
        {
            txtcid.Clear();
            txtmedid.Clear();
            txtmedname.Clear();
            txtcname.Clear();
            txtquantity.Clear();
            txttotalprice.Clear();

        }
    }
}

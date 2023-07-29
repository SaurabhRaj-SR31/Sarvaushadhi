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
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String querry;
        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            querry = "create or replace procedure sell_pro(id in number) as cursor cr is select * from medic natural join valid_medicine where med_id = mid; c1 cr%rowtype; begin for c1 in cr loop insert into pharma_cart values(:new.c1.mednum ,:new.c1.med_name,:new.c1.quan ,:new.c1.exp_date,:new.c1.ord_no,:new.c1.total";
            listboxmedicines.Items.Clear();
        query = "select mname from medic where eDate>= getdate() and quantity >'0' ";
          ds =fn.getData(query);


            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listboxmedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
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

        private void listboxmedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Clear();
            String name = listboxmedicines.GetItemText(listboxmedicines.SelectedItem);

           txtmedname.Text = name;
            query = "select mid,eDate,perUnit from medic where mname='" + name + "'";
            ds = fn.getData(query);
            txtmedid.Text = ds.Tables[0].Rows[0][0].ToString();
        
            txtedate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtunitprice.Text = ds.Tables[0].Rows[0][2].ToString();
          
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if(txtunitprice.Text!="")
            {
                Int64 unitprice = Int64.Parse(txtunitprice.Text);
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

        

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if(txtmedid.Text!="")
            {
                query="select quantity from medic where mid ='"+txtmedid.Text+"'";   

                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newquantity = quantity - Int64.Parse(txtquantity.Text);
                if(newquantity>=0)
                {
                    n = gunaDataGridView1.Rows.Add();
                    gunaDataGridView1.Rows[n].Cells[0].Value = txtmedid.Text;
                    gunaDataGridView1.Rows[n].Cells[1].Value = txtmedname.Text;
                    gunaDataGridView1.Rows[n].Cells[2].Value = txtedate.Text;
                    gunaDataGridView1.Rows[n].Cells[3].Value = txtunitprice.Text;
                    gunaDataGridView1.Rows[n].Cells[4].Value = txtquantity.Text;

                    gunaDataGridView1.Rows[n].Cells[5].Value = txttotalprice.Text;

                    totalamount += int.Parse(txttotalprice.Text);

                    txtfinalprice.Text = "Rs. "+totalamount.ToString();
                    
                    query = "update medic set quantity ='" + newquantity + "' where mid ='" + txtmedid.Text + "'";
                    fn.setData(query, "Added to cart !!");


                }

                else
                {
                    MessageBox.Show(" Selected Medicine is out of stock .\n Only " + quantity + " left ", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearall();
                UC_P_SellMedicine_Load(this, null);
            }
             
            else
            {
                MessageBox.Show(" Select item pls ", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueamount;
        String valueid;
        public Int64 noofunit;

       

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueamount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueid = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noofunit = Int64.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

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
                    && gunaDataGridView1.Rows[i].Cells[4].Value != null
                    && gunaDataGridView1.Rows[i].Cells[5].Value != null)
                {

                    String num = gunaDataGridView1.Rows[i].Cells[0].Value.ToString();
                    String naam = gunaDataGridView1.Rows[i].Cells[1].Value.ToString();
                    String edate = gunaDataGridView1.Rows[i].Cells[2].Value.ToString();
                    Int64 q = Int64.Parse(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());
                    Int64 t = Int64.Parse(gunaDataGridView1.Rows[i].Cells[5].Value.ToString());

                    Int64 o_num = fn.order_id();

                    query = "insert into pharma_cart(med_num,med_name,exp_date,quan,total,ord_no) values('" + num + "','" + naam + "','" + edate + "','" + q + "','" + t + "','" + o_num + "')";
                    fn.setData(query, "Purchase Succesfull !!");
                }


            }
        }

        private void txtfinalprice_Click(object sender, EventArgs e)
        {

        }

        private void txtmedid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmedname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if(valueid!=null)
            {
                try
                {
                    gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
                }
                catch { }
                finally 
                {
                    query = "select quantity from medic where mid ='"+valueid+"'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newquantity = quantity + noofunit;
                    query = "update medic set quantity ='" + newquantity + "' where mid='" + valueid + "'";
                    fn.setData(query, "medicine Removed from Cart.");
                    totalamount -= valueamount;
                    txtfinalprice.Text = totalamount.ToString();


                }
                UC_P_SellMedicine_Load(this, null);
            }
        }
        private void clearall()
        {
            txtmedid.Clear();
            txtmedname.Clear(); 
            txtunitprice.Clear();
            txtquantity.Clear();
            txttotalprice.Clear();
            
        }
    }
}

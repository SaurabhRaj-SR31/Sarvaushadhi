using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-9C6JRJL;database=pharmacy;integrated security = true";
            return con;
        }
        public DataSet getData(String query)
        {
            
            
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            
            
        }

     public    Int64 order_id()
        {
            
            Random random = new Random();

           
            Int64 randomNumber = random.Next(0, 101);
            return randomNumber;
            
        }
        public void setData(String query,String msg ) {
        
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Connection=con;
            con.Open();
            cmd.CommandText=query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        
        
        
        }
    }
}

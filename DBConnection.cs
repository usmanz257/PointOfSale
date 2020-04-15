using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale
{
   public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-LQJTKTO\USMAN;Initial Catalog=PointOfSale;Integrated Security=True";
            return con;
        }
        public double GetVal() {
            double vat = 0;
            try {
                
                cn.ConnectionString = MyConnection();
                cn.Open();
                cm = new SqlCommand("select * from tblVat", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    vat = Double.Parse(dr["vat"].ToString());
                }
                dr.Close();
                cn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return vat;
        }
    
    }
}

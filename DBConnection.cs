using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PointOfSale
{
   public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private double dailySales;
        private int productline;
        private int stockOnHand;
        private int critical;
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-LQJTKTO\USMAN;Initial Catalog=PointOfSale;Integrated Security=True";
            //string _provider= string.Format("providername = \"{0}\"","System.Data.SqlClient");
           // string con = ConfigurationManager.ConnectionStrings["CharityManagement"].ConnectionString;
           // string con= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=|DataDirectory|\PointOfSale.mdf; Initial Catalog=PointOfSale;Integrated Security=True";
            return con;
        }
        public double DailySales()
        {
            string sdate = DateTime.Now.ToShortDateString();
            
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select isnull(sum(total),0) as total from tblcart where sdate between '" + sdate + "' and '" + sdate + "' and status like 'Sold'", cn);
            dailySales = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return dailySales;
        }
        public int ProductLine()
        {
             cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select count(*) from tblproduct", cn);
            productline = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return productline;
        }
        public int StockOnHand()
        {
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select isnull(sum(qty),0) as qty from tblproduct", cn);
            stockOnHand = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return stockOnHand;
        }
        public int CriticalStock()
        {
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select count(*) from vwCriticalItems", cn);
            critical = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return critical;
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
        public string GetPassword(string user)
        {
            string password="";
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select * from tbluser where username = @username", cn);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows) 
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            cn.Close();
            return password;
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PointOfSale
{
    public partial class frmStockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmStockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridProduct.Rows.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("Select pcode,pdesc,price from tblProduct where pdesc like '%" + txtSearchProduct.Text + "%' order by pdesc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++ ;
                dataGridProduct.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString()) ;
            }
            dr.Close();
            cn.Close();


        }
        private void frmStockIn_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

  
    }
}

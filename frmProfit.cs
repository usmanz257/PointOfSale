using PointOfSale.Preview_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class frmProfit : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        private double TotalCost, totalsales, profit;
        public frmProfit()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadRecords();
            this.profit = this.totalsales - this.TotalCost;
            this.lblProfit.Text = Convert.ToString(this.profit);
        }

        private void btnTopSellingPrintPreview_Click(object sender, EventArgs e)
        {
            frmProfitpreview frm = new frmProfitpreview(this);
            frm.ShowDialog();
        }

        private void dataGridprofit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadRecords()
        {
            int i = 0;
            dataGridprofit.Rows.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select transno,pcode,pdesc,qty,cost,price,disc,costtotal,total from vwProfit where sdate between'"+dt1.Value +"' and '"+dt2.Value+ "' and status = 'sold'  order by transno ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                this.TotalCost += Convert.ToDouble(dr["costtotal"].ToString());
                double tempTotal = Convert.ToDouble(dr["total"].ToString()) - Convert.ToDouble(dr["disc"].ToString());
                this.totalsales += tempTotal;
                
                dataGridprofit.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), dr["cost"].ToString(), dr["price"].ToString(), dr["disc"].ToString(), dr["costtotal"].ToString(), tempTotal);
               
            }
        }
    }
}

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
    public partial class frmRecords : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmRecords()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            LoadRecord();
        }
        private void LoadRecord()
        {
            int i = 0;
            cn.Open();
            string query = string.Format("select top 10 pcode, pdesc, sum(qty) as qty from vwSold where sdate between '{0}' and '{1}' and status like '{2}' group by pcode,pdesc order by qty desc", dt1.Value, dt1.Value, "Sold");
            cm = new SqlCommand(query, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridProduct.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLoadSoldItems_Click(object sender, EventArgs e)
        {
            try 
            {

                int i = 0;
                cn.Open();
                string query = string.Format("select c.pcode, p.pdesc, c.price, sum(c.qty) as tot_qty, sum(c.disc) as tot_disc, sum(c.total) as total from tblcart as c inner join tblproduct as p on c.pcode = p.pcode where status like '{2}' and sdate between '{0}' and '{1}' group by c.pcode,p.pdesc, c.price",dt3.Value,dt4.Value,"Sold");
                cm = new SqlCommand(query, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                   dataGridSold2.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), Double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["tot_qty"].ToString(), dr["tot_disc"].ToString(), dr["total"].ToString());
                }
                dr.Close();
                cn.Close();

                String x;
                cn.Open();
                string query2 = string.Format("select isnull(sum(total),0) from tblcart where status like 'Sold' and sdate between '{0}' and '{1}'", dt3.Value, dt4.Value);
                cm = new SqlCommand(query2, cn);
                x = Double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");
                lblTotalSale.Text = x;
            }
            catch (Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void LoadCriticalItems() 
        {
            try 
            {
                int i=0;
                dataGridReorder.Rows.Clear();
                cn.Open();
                string sqlQuery = "Select * from vwCriticalItems";
                cm = new SqlCommand(sqlQuery,cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridReorder.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                cn.Close();

            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }


        }
    }
}

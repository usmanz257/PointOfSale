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
            string query = "";
            dataGridProduct.Rows.Clear();
            int i = 0;
            cn.Open();
            if(cboTopSelect.Text== string.Empty)
            {
                MessageBox.Show("Please select sort type from the dropdown list","Suggestion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cn.Close();
                return;
            }
            else if (cboTopSelect.Text == "SORT BY QTY")
            {
                query = string.Format("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total from vwSold where sdate between '{0}' and '{1}' and status like '{2}' group by pcode,pdesc order by qty desc", dt1.Value, dt2.Value, "Sold");
            
            }
            else if (cboTopSelect.Text == "SORT BY TOTAL")
            {
                query = string.Format("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total from vwSold where sdate between '{0}' and '{1}' and status like '{2}' group by pcode,pdesc order by total desc", dt1.Value, dt2.Value, "Sold");
            }
            cm = new SqlCommand(query, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridProduct.Rows.Add(i, dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
            }
            dr.Close();
            cn.Close();
        }

        public void LoadCancelledOrders()
        {
            dataGridCancelOrder.Rows.Clear();
            int i = 0;
            cn.Open();
            string query = string.Format(" select * from vwCancelledOrder where sdate between'{0}' and '{1}'", dt5.Value, dt6.Value);
            cm = new SqlCommand(query, cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridCancelOrder.Rows.Add(i, dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString(), dr["sdate"].ToString(), dr["voidby"].ToString(), dr["cancelledby"].ToString(), dr["reason"].ToString(), dr["action"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLoadSoldItems_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridSold2.Rows.Clear();
                int i = 0;
                cn.Open();
                string query = string.Format("select c.pcode, p.pdesc, c.price, sum(c.qty) as tot_qty, sum(c.disc) as tot_disc, sum(c.total) as total from tblcart as c inner join tblproduct as p on c.pcode = p.pcode where status like '{2}' and sdate between '{0}' and '{1}' group by c.pcode,p.pdesc, c.price", dt3.Value, dt4.Value, "Sold");
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
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void LoadCriticalItems()
        {
            try
            {
                int i = 0;
                dataGridReorder.Rows.Clear();
                cn.Open();
                string sqlQuery = "Select * from vwCriticalItems";
                cm = new SqlCommand(sqlQuery, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridReorder.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadInventory()
        {
            try
            {
                int i = 0;
                dataGridInventory.Rows.Clear();
                cn.Open();
                string sqlQuery = "Select p.pcode,p.barcode, p.pdesc, b.brand, category, p.price ,p.qty, p.reorder from tblProduct as p inner join tblbrand as b on p.bid= b.id inner join tblcategory as c on p.cid = c.id";
                cm = new SqlCommand(sqlQuery, cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridInventory.Rows.Add(i, dr["pcode"].ToString(), dr["barcode"].ToString(), dr["pdesc"].ToString(), dr["brand"].ToString(), dr["Category"].ToString(), dr["price"].ToString(), dr["reorder"].ToString(), dr[6].ToString(), dr["qty"].ToString());
                }
                this.cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }


        }
        public void LoadStockInHistory()
        {
            dataGridStockInHistory.Rows.Clear();
            int i = 0;
            cn.Close();
            cn.Open();

            cm = new SqlCommand("Select * from vwstockin where cast(sdate as date) between '" + dt7.Value.ToShortDateString() + "' and '" + dt8.Value.ToShortDateString() + "'and status like 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridStockInHistory.Rows.Add(i, dr["id"].ToString(), dr["refno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), DateTime.Parse(dr["sdate"].ToString()).ToShortDateString(), dr["stockinby"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnLoadCancelOrder_Click(object sender, EventArgs e)
        {
            LoadCancelledOrders();
        }

        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadStock_Click(object sender, EventArgs e)
        {
            this.LoadStockInHistory();
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboTopSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadInventory();
        }

        private void btnReloadCriticalStock_Click(object sender, EventArgs e)
        {
            this.LoadCriticalItems();
        }

        private void btnPrintPreviewCritical_Click(object sender, EventArgs e)
        {
            frmCriticalStockPreview frm = new frmCriticalStockPreview();
            frm.ShowDialog();
        }

        private void btnTopSellingPrintPreview_Click(object sender, EventArgs e)
        {
            frmTopSellingItem frm = new frmTopSellingItem(this);
            frm.Show();
        }

        
    }
}

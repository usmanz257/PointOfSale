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
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        } 
        private void LoadStockInHistory()
        {
            int i = 0;
            dataGridStockInHistory.Rows.Clear();
            cn.Close();
            cn.Open();

            cm = new SqlCommand("Select * from vwstockin where cast(sdate as date) between '"+ dt1.Value.ToShortDateString()+ "' and '"+ dt2.Value.ToShortDateString() +"'and status like 'Done'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridStockInHistory.Rows.Add(i, dr["id"].ToString(), dr["refno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), DateTime.Parse(dr["sdate"].ToString()).ToShortDateString(), dr["stockinby"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadStockIn() 
        {   
            //Loading stock in STOCK INBY grid using current reference number entered by the user
            //usman zulfiqar
            //13-04-2020
            int i= 0;
            dataGridStockIn.Rows.Clear();
            cn.Close();
            cn.Open();

            cm = new SqlCommand("Select * from vwstockin where refno like '"+txtRefNo.Text+"' and status like 'Pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                i++;
                dataGridStockIn.Rows.Add(i,dr["id"].ToString(), dr["refno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(),dr["stockinby"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void Clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            txtStockInDate.Value = DateTime.Now;
        }
        private void dataGridStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridStockIn.Columns[e.ColumnIndex].Name;
            if (colname == "colDelete")
            {
                if(MessageBox.Show("remove this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("delete from tblstockin where id = '"+ dataGridStockIn.Rows[e.RowIndex].Cells[1].Value.ToString()+"'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("item has been successfully deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        private void lnkProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearchProductStockin frm = new frmSearchProductStockin(this);
            frm.LoadProduct();
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridStockIn.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure to save this recod? ","", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) { 
                        for(int i=0; i< dataGridStockIn.Rows.Count; i++)
                        {
                            // update product quantity
                            cn.Open();
                            cm = new SqlCommand("Update tblproduct set qty=qty + "+ int.Parse(dataGridStockIn.Rows[i].Cells[5].Value.ToString())+" where pcode like '"+ dataGridStockIn.Rows[i].Cells[3].Value.ToString() +"'" ,cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update tblstock in qty
                            cn.Open();
                            cm = new SqlCommand("Update tblstockin set qty=qty +  " + int.Parse(dataGridStockIn.Rows[i].Cells[5].Value.ToString()) + ", status  = 'Done' where id like '" + dataGridStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        Clear();
                        LoadStockIn();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStockInHistory();
        }
    }
}

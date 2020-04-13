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
            cm = new SqlCommand("Select pcode,pdesc,qty from tblProduct where pdesc like '%" + txtSearchProduct.Text + "%' order by pdesc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridProduct.Columns[e.ColumnIndex].Name;
                if (colName == "colSelect")
                {
                    if (txtRefNo.Text == string.Empty) { MessageBox.Show("Please enter refrence no", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtRefNo.Focus(); return; }
                    if (txtStockInBy.Text == string.Empty) { MessageBox.Show("Please enter stock in by", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtStockInBy.Focus(); return; }

                    if (MessageBox.Show("Add this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string getPcode = dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                        cn.Open();

                        //<task>inserting stock 
                        //<author>usman zulfiqar 
                        //<date>13/04/2020
                        cm = new SqlCommand("Insert into tblstockin(refno,pcode,sdate,stockinby)values(@refno,@pcode,@sdate,@stockinby)", cn);
                        cm.Parameters.AddWithValue("@refno", txtRefNo.Text);
                        cm.Parameters.AddWithValue("@pcode", getPcode);
                        cm.Parameters.AddWithValue("@sdate", txtStockInDate.Value);
                        cm.Parameters.AddWithValue("@stockinby", txtStockInBy.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Successfully Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStockIn();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            cm = new SqlCommand("Select * from vwstockin where refno like '"+txtRefNo.Text+"'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                i++;
                dataGridStockIn.Rows.Add(i,dr["id"].ToString(), dr["refno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["qty"].ToString(), dr["sdate"].ToString(),dr["stockinby"].ToString());
            }
            dr.Close();
            cn.Close();
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
    }
}

﻿using System;
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
    public partial class frmSearchProductStockin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmStockIn slist;
        public frmSearchProductStockin(frmStockIn flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            slist = flist;
        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridProduct.Rows.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("Select pcode,pdesc,cost,qty from tblProduct where pdesc like '%" + txtSearchProduct.Text + "%' order by pdesc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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
                if(slist.cboVandor.Text == string.Empty)
                {
                    MessageBox.Show("Please Select the vendor first", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string colName = dataGridProduct.Columns[e.ColumnIndex].Name;
                if (colName == "colSelect")
                {
                    if (slist.txtRefNo.Text == string.Empty) { MessageBox.Show("Please enter refrence no", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); slist.txtRefNo.Focus(); return; }
                    if (slist.txtStockInBy.Text == string.Empty) { MessageBox.Show("Please enter stock in by", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); slist.txtStockInBy.Focus(); return; }

                    if (MessageBox.Show("Add this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string getPcode = dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string getCost = dataGridProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                        cn.Open();
                        //<task>inserting stock 
                        //<author>usman zulfiqar 
                        //<date>13/04/2020
                        cm = new SqlCommand("Insert into tblstockin(refno,pcode,newCost,sdate,stockinby,vendorid)values(@refno,@pcode,@newCost,@sdate,@stockinby,@vendorid)", cn);
                        cm.Parameters.AddWithValue("@refno", slist.txtRefNo.Text);
                        cm.Parameters.AddWithValue("@pcode", getPcode);
                        cm.Parameters.AddWithValue("@newCost", Convert.ToDouble(getCost));
                        cm.Parameters.AddWithValue("@sdate", slist.txtStockInDate.Value);
                        cm.Parameters.AddWithValue("@stockinby", slist.txtStockInBy.Text);
                        cm.Parameters.AddWithValue("@vendorid", slist._vandorId); 
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Successfully Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        slist.LoadStockIn();
                    }

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}

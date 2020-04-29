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
    public partial class frmStockAdjustment : Form
    {
        SqlConnection cn ;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        MainForm f;
        int _qty;
        string _sqlStatement;
        public frmStockAdjustment(MainForm frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ReferenceNo()
        {
            Random rnd = new Random();
            txtRefNo.Text = rnd.Next().ToString();
        }
        public void LoadProducts()
        {
            int i = 0;
            dataGridStockAdjustment.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select p.pcode,p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty,p.reorder from tblProduct as p inner join tblBrand as b on b.id = p.bid inner join tblCategory as c on c.id = p.cid where p.pdesc like '" + txtSearchProduct.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridStockAdjustment.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            cn.Close();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void lnkGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ReferenceNo();
        }

        private void dataGridStockAdjustment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridStockAdjustment.Columns[e.ColumnIndex].Name;
            if(colName== "Select")
            {
                txtPcode.Text = dataGridStockAdjustment.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescription.Text = dataGridStockAdjustment.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dataGridStockAdjustment.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dataGridStockAdjustment.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to do Adjusments to stock?", "STOCK AJUSTMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (int.Parse(txtQty.Text) > _qty)
                    {
                        MessageBox.Show("STOCK ON HAND QUANTITY SHOULD BE GREATER THAN THE ADJUSTMENT QTY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //UPDATEING STOCK
                    if (cboCommand.Text == "REMOVE FROM INVENTORY")
                    {
                        _sqlStatement = "Update tblproduct set qty = (qty- " + int.Parse(txtQty.Text) + ") where pcode like '" + txtPcode.Text + "'";
                        SqlStatement(_sqlStatement);
                    }
                    else if (cboCommand.Text == "ADD TO INVENTORY")
                    {

                        _sqlStatement = "Update tblproduct set qty = (qty+ " + int.Parse(txtQty.Text) + ") where pcode like '" + txtPcode.Text + "'";
                        SqlStatement(_sqlStatement);
                    }
                    SqlStatement("insert into tblstockadjustment(referenceno , pcode, qty, action, remarks, sdate, [user])VALUES('" + txtRefNo.Text + "','" + txtPcode.Text + "','" + int.Parse(txtQty.Text) + "','" + cboCommand.Text + "','" + txtRemarks.Text + "','" + DateTime.Now.ToString() + "','" + txtUser.Text + "')");
                    MessageBox.Show("STOCK HAS BEEN SUCCESSFULLY ADJUSTED.", "PROCESS COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridStockAdjustment.Rows.Clear();
                    this.LoadProducts();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void SqlStatement(string _sql)
        {
            cn.Open();
            cm = new SqlCommand(_sql, cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void Clear()
        {
            txtDescription.Clear();
            txtPcode.Clear();
            txtQty.Clear();
            txtRefNo.Clear();
            txtRemarks.Clear();
            cboCommand.Text = "";
            ReferenceNo();
        }
    }
}

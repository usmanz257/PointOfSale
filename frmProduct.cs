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
    public partial class frmProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmProductList plist;
        public frmProduct(frmProductList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            plist = frm;
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        public void LoadBrand()
        {
            cboBrands.Items.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select brand from tblBrand order by brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboBrands.Items.Add(dr[0]).ToString();
            }
            dr.Close();
            dr.Close();
        }
        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select category from tblCategory order by Category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCategory.Items.Add(dr[0]).ToString();
            }
            dr.Close();
            dr.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBarcode.Clear();
            txtPCode.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            cboBrands.Text = "";
            cboCategory.Text = "";
            txtPCode.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to save this Product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string bid = ""; string cid = "";
                    //Getting the id of brand
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("select id from tblBrand where brand like '" + cboBrands.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { bid = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();
                    //getting the id of category
                    cn.Open();
                    cm = new SqlCommand("select id from tblCategory where Category like '" + cboCategory.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { cid = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();
                    //Saving Product
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo tblProduct(pcode,barcode, pdesc, bid, cid, price, reorder)VALUES(@pcode,@barcode, @pdesc, @bid, @cid, @price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPCode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cm.Parameters.AddWithValue("@bid", bid);
                    cm.Parameters.AddWithValue("@cid", cid);
                    cm.Parameters.AddWithValue("@price", Double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", int.Parse(txtReorder.Text));
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    plist.LoadProducts();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update this Product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string bid = ""; string cid = "";
                    //Getting the id of brand
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("select id from tblBrand where brand like '" + cboBrands.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { bid = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();
                    //getting the id of category
                    cn.Open();
                    cm = new SqlCommand("select id from tblCategory where Category like '" + cboCategory.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows) { cid = dr[0].ToString(); }
                    dr.Close();
                    cn.Close();
                    //Saving Product
                    cn.Open();
                    cm = new SqlCommand("update tblProduct Set barcode=@barcode, pdesc=@pdesc, bid=@bid, cid=@cid, price=@price, reorder=@reorder where pcode like @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPCode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cm.Parameters.AddWithValue("@bid", bid);
                    cm.Parameters.AddWithValue("@cid", cid);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.Parameters.AddWithValue("@reorder", txtReorder.Text);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    plist.LoadProducts();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {   if ((e.KeyChar == 46))
            {
                //accept . char
            }
            else if (e.KeyChar == 8) { 
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))// ascii code 48-57 between 0-9
            {
                e.Handled = true;
            }
        }

       
    }
}

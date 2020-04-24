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
    public partial class frmProductList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmProductList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct(this);
            frmProduct.btnSave.Enabled = true;
            frmProduct.btnUpdate.Enabled = false;
            frmProduct.LoadBrand();
            frmProduct.LoadCategory();
            frmProduct.ShowDialog();
        }
        public void LoadProducts()
        {
            int i = 0;
            dataGridProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select p.pcode,p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty,p.reorder from tblProduct as p inner join tblBrand as b on b.id = p.bid inner join tblCategory as c on c.id = p.cid where p.pdesc like '" + txtSearchProduct.Text + "%'",cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridProduct.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            cn.Close();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridProduct.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                frmProduct frmPro = new frmProduct(this);
                frmPro.btnSave.Enabled = false;
                frmPro.btnUpdate.Enabled = true;
                frmPro.txtPCode.Text = dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmPro.txtBarcode.Text = dataGridProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmPro.txtDescription.Text = dataGridProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmPro.cboBrands.Text = dataGridProduct.Rows[e.RowIndex].Cells[4].Value.ToString();          
                frmPro.cboCategory.Text = dataGridProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                frmPro.txtPrice.Text = dataGridProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                frmPro.txtReorder.Text = dataGridProduct.Rows[e.RowIndex].Cells[8].Value.ToString();
                frmPro.ShowDialog();

            }
            else 
            {
                if(MessageBox.Show("Are you sure to delete this product?","Delete Product",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblproduct where pcode like '" + dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString() +"'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadProducts();
                }
              
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

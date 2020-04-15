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
    public partial class frmLookup : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmPOS f;
        public frmLookup(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
        public void LoadProducts()
        {
            int i = 0;
            dataGridProduct.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("Select p.pcode,p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty from tblProduct as p inner join tblBrand as b on b.id = p.bid inner join tblCategory as c on c.id = p.cid where p.pdesc like '" + txtSearchProduct.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            cn.Close();
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dataGridProduct.Columns[e.ColumnIndex].Name;
                if (colName == "Select")
                {
                    
                        frmQty frm = new frmQty(f);
                        frm.ProductDetail(dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dataGridProduct.Rows[e.RowIndex].Cells[6].Value.ToString()), f.lblTransNo.Text);
                        dr.Close();
                        cn.Close();
                        frm.ShowDialog();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchProduct_Click(object sender, EventArgs e)
        {

        }
    }
}

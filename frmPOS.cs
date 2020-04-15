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
    public partial class frmPOS : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }
        private void getTransNo()
        {
            try 
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string transNo;
                int count;
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select top 1 transno from tblCart where transno like'" + sdate + "%' order by id desc",cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) {
                    transNo = dr[0].ToString();
                    count = int.Parse(transNo.Substring(8,4));
                    lblTransNo.Text = sdate + (count + 1);
                } 
                else {
                    transNo = sdate + "1001";
                    this.lblTransNo.Text = transNo;
                } 
                dr.Close();
                cn.Close();
                
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            getTransNo();
            txtSearchProduct.Enabled = true;
            txtSearchProduct.Focus();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchProduct.Text == string.Empty) { return; }
                if(lblTransNo.Text == "0000000000000000") 
                { 
                    MessageBox.Show("Please Click on new transection button first", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("select * from tblProduct where barcode like '" + txtSearchProduct.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        frmQty frm = new frmQty(this);
                        frm.ProductDetail(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransNo.Text);
                        dr.Close();
                        cn.Close();
                        frm.ShowDialog();

                    }
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void loadCart()
        {
            try
            {
                dataGridSale.Rows.Clear();
                int i = 0;
                double total = 0;
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tblCart as c inner join tblProduct as p on c.pcode=p.pcode where transno like '" + lblTransNo.Text + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["Total"].ToString());
                    dataGridSale.Rows.Add(i,dr["Id"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["Total"].ToString()).ToString("#,##0.00"));
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");
                GetCartTotal();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetCartTotal()
        {

            double sales = Double.Parse(lblTotal.Text);
            double discount = 0;
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(lblTransNo.Text == "0000000000000000")
            {
                MessageBox.Show("Please Click on new transection button first", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; }
                frmLookup frm = new frmLookup(this);
                frm.LoadProducts();
                frm.ShowDialog();
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridSale.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure to remove this item?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblCart where id like '" + dataGridSale.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("item Successfully removed.","Item removed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadCart();
                }
            }
        }
    }
}

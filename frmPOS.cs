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
        string id;
        string price;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        int qty;
        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }
        public void getTransNo()
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
            if (dataGridSale.Rows.Count > 0)
            {
                return;
            }
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
                        qty = int.Parse(dr["qty"].ToString());
                        frmQty frm = new frmQty(this);
                        frm.ProductDetail(dr["pcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransNo.Text,qty);
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
                bool hasrecord = false;
                dataGridSale.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total from tblCart as c inner join tblProduct as p on c.pcode=p.pcode where transno like '" + lblTransNo.Text + "' and status like 'Pending'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["Total"].ToString());
                    discount += Double.Parse(dr["disc"].ToString());
                    dataGridSale.Rows.Add(i, dr["Id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["Total"].ToString()).ToString("#,##0.00"));
                    hasrecord = true;
                }
                dr.Close();
                cn.Close();
                this.lblTotal.Text = total.ToString("#,##0.00");
                this.lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
                if (hasrecord == true) { btnSettle.Enabled = true; btnDiscount.Enabled = true; } else { btnSettle.Enabled = false; btnDiscount.Enabled = false; };
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetCartTotal()
        {
            
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblTotal.Text);
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;
            lblTotal.Text = sales.ToString("#,##0.00");
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            this.lblDisplayTotal.Text = sales.ToString("#,##0.00");
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
            if (dataGridSale.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout, Please cancel the transection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("logout Application?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              
                this.Hide();
                frmSecurity frm = new frmSecurity();
                frm.ShowDialog();
            }
            
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

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount frm = new frmDiscount(this);
            frm.lblID.Text = id;
            frm.txtprice.Text = price;
            frm.ShowDialog();
        }

        private void dataGridSale_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridSale.CurrentRow.Index;
            id = dataGridSale[1, i].Value.ToString();
            price = dataGridSale[4,i].Value.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToString("hh:MM:ss tt");
            //lblDateDay.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            frmSettle frm = new frmSettle(this);
            frm.txtSale.Text = lblDisplayTotal.Text;
            frm.ShowDialog();
        }

        private void btnDailySale_Click(object sender, EventArgs e)
        {
            frmSoldItems frm = new frmSoldItems();
            frm.dt1.Enabled = false;
            frm.dt2.Enabled = false;
            frm.suser = this.lblUser.Text;
            frm.cboCashier.Enabled = false;
            frm.cboCashier.Text = lblUser.Text;
            frm.ShowDialog();
        }

        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNew_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnSearch_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnDiscount_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnSettle_Click(sender, e);
            }
        }
    }
}

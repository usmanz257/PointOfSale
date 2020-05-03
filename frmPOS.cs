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
            NotifyCriticalItems(); 
            this.KeyPreview = true;
        }
        public void NotifyCriticalItems()
        {
            frmNotification frm = new frmNotification();
            string _critical = "";
            int i = 0;
            string count = "";
            cn.Open();
            cm = new SqlCommand("select count(*) from vwCriticalItems", cn);
            count = cm.ExecuteScalar().ToString();
            if (count == string.Empty)
            {
                frm.lblNotificationCounter.Text = "CRITICAL STOCK";
                frm.lblNotifications.Text = "No Critical item";
            }
            else
            {
                frm.lblNotificationCounter.Text = count + " Critical items";
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select * from vwCriticalItems", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    _critical += i + "." + dr["pdesc"].ToString() + Environment.NewLine;
                }

            }

            dr.Close();
            cn.Close();
            frm.lblNotifications.Text = "Critical stock is :" + Environment.NewLine + _critical;
            frm.ShowDialog();

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
                cm = new SqlCommand("select top 1 transno from tblCart where transno like'" + sdate + "%' order by id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) {
                    transNo = dr[0].ToString();
                    count = int.Parse(transNo.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);
                }
                else {
                    transNo = sdate + "1001";
                    this.lblTransNo.Text = transNo;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                if (lblTransNo.Text == "0000000000000000")
                {
                    MessageBox.Show("Please Click on new transection button first", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; }
                else
                {
                    String _pcode;
                    double _price;
                    int _qty;
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("select * from tblProduct where barcode like '" + txtSearchProduct.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        this.qty = int.Parse(dr["qty"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);
                        dr.Close();
                        cn.Close();

                        AddToCart(_pcode,_price, _qty);
                    }
                    else 
                    {
                        dr.Close();
                        cn.Close();

                    }

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AddToCart(String _pcode, double _price, int _qty)
            {
            String id = "";
            bool found = false;
            int cart_qty=0;
            cn.Open();
            cm = new SqlCommand("Select * from tblcart where transno = @transno and pcode =@pcode", cn);
            cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
            cm.Parameters.AddWithValue("@pcode", _pcode);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                found = true;
                id = dr["id"].ToString();
                cart_qty = int.Parse(dr["qty"].ToString());
            }
            else { found = false; }
            dr.Close();
            cn.Close();

            if (found == true)
            {
                if (qty < int.Parse(txtQty.Text) + cart_qty)
                {
                    MessageBox.Show("Unable to proceed. remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Close();
                cn.Open();
                cm = new SqlCommand("update tblCart set qty = (qty + " + _qty + ") where id = '" + id + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                txtSearchProduct.SelectionStart = 0;
                txtSearchProduct.SelectionLength = txtSearchProduct.Text.Length;
                loadCart();
               

            }
            else
            {
                cn.Close();
                cn.Open();
                cm = new SqlCommand("insert into tblCart (transno, pcode, price, qty, sdate, cashier)values(@transno, @pcode, @price, @qty, @sdate, @cashier)", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                cm.Parameters.AddWithValue("@price", _price);
                cm.Parameters.AddWithValue("@qty", _qty);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@cashier", lblUser.Text);
                cm.ExecuteNonQuery();
                cn.Close();

                txtSearchProduct.Clear();
                txtSearchProduct.Focus();
                loadCart();
            
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
                    dataGridSale.Rows.Add(i, dr["Id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["Total"].ToString()).ToString("#,##0.00"),"[ + ]","[ - ]");
                    hasrecord = true;
                }
                dr.Close();
                cn.Close();
                this.lblTotal.Text = total.ToString("#,##0.00");
                this.lblDiscount.Text = discount.ToString("#,##0.00");
                GetCartTotal();
                if (hasrecord == true) { btnSettle.Enabled = true; btnDiscount.Enabled = true; btnCancelSale.Enabled = true; } else { btnSettle.Enabled = false; btnDiscount.Enabled = false; btnCancelSale.Enabled = false; };
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
                    cm = new SqlCommand("delete from tblcart where id like '" + dataGridSale.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                     
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("item Successfully removed.","Item removed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadCart();
                }
            }
            else if (colName == "colAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("Select sum(qty) as qty from tblproduct where pcode like '" + dataGridSale.Rows[e.RowIndex].Cells[2].Value.ToString() + "' group by pcode",cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dataGridSale.Rows[e.RowIndex].Cells[5].Value.ToString()) <= i)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblcart set qty  = qty + '" + int.Parse(txtQty.Text) + "' where transno like '" + lblTransNo.Text + "' and  pcode like '" + dataGridSale.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    loadCart();
                }
                else {
                    MessageBox.Show("Remaining qty on hand is " + i + " !", "Out of stock",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (colName == "colRemove")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("Select sum(qty) as qty from tblcart where pcode like '" + dataGridSale.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and transno like '"+ lblTransNo.Text +"' group by transno, pcode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (i > 1)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblcart set qty  = qty - '" + int.Parse(txtQty.Text) + "' where transno like '" + lblTransNo.Text + "' and  pcode like '" + dataGridSale.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    loadCart();
                }
                else
                {
                    MessageBox.Show("Remaining qty on cart is " + i + " !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
            lblTime.Text = DateTime.Now.ToString("hh:MM:ss tt");
            lblDateDay.Text = DateTime.Now.ToLongDateString();
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

        //public void ProductDetail(String pcode, double price, String transno, int qty)
        //{
        //    this.pcode = pcode;
        //    this.price = price;
        //    this.transno = transno;
        //    this.qty = qty;
        //}

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
                if(btnDiscount.Enabled == false)
                {
                    MessageBox.Show("Add Product in cart please");
                    return;
                }
                btnDiscount_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                if (btnDiscount.Enabled == false)
                {
                    MessageBox.Show("Add Product in cart please");
                    return;
                }
                btnSettle_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                if (btnDiscount.Enabled == false)
                {
                    MessageBox.Show("Add Product in cart please");
                    return;
                }
                btnCancelSale_Click(sender, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                btnDailySale_Click(sender, e);
            }
            if (e.KeyCode == Keys.F7)
            {
                btnChangePassword_Click(sender, e);
            }
            if (e.KeyCode == Keys.F10)
            {
                btnExit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                txtSearchProduct.SelectionStart = 0;
                txtSearchProduct.SelectionLength = txtSearchProduct.Text.Length;
                txtSearchProduct.Focus();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangepassword frm =new frmChangepassword(this);
            frm.ShowDialog();

        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Remove all iterms from cart","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from tblcart where transno like '" + lblTransNo.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("all iterms has been successfully remove!", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadCart();
            }

        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

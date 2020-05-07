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
    public partial class frmQty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        private String pcode;
        private double price;
        private int qty;
        private String transno;
        private double disc_per;
        frmPOS fpos;
        public frmQty(frmPOS frmpos)
        {
            InitializeComponent();
            fpos = frmpos;
            cn = new SqlConnection(dbcon.MyConnection());

        }
        private void frmQty_Load(object sender, EventArgs e)
        {

        }
        public void ProductDetail( String pcode,double price, String transno, int qty,double disc_per)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
            this.disc_per = disc_per;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
            {
                String id="";
                int cart_qty=0;
                bool found = false;
                
                if (qty<int.Parse(txtQty.Text))
                {
                    MessageBox.Show("Unable to proceed. remaining qty on hand is " + qty,"Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("Select * from tblcart where transno = @transno and pcode =@pcode", cn);
                cm.Parameters.AddWithValue("@transno",fpos.lblTransNo.Text);
                cm.Parameters.AddWithValue("@pcode", pcode);
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
                    if (qty < int.Parse(txtQty.Text)+cart_qty)
                    {
                        MessageBox.Show("Unable to proceed. remaining qty on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("update tblCart set qty = (qty + " + int.Parse(txtQty.Text) + ") where id = '" + id + "'", cn);           
                    cm.ExecuteNonQuery();
                    cn.Close();

                    fpos.txtSearchProduct.Clear();
                    fpos.txtSearchProduct.Focus();
                    fpos.loadCart();
                    this.Dispose();

                }
                else
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("insert into tblCart (transno, pcode, price,disc_percent, qty, sdate, cashier)values(@transno, @pcode, @price,@disc_percent, @qty, @sdate, @cashier)", cn);
                    cm.Parameters.AddWithValue("@transno", transno);
                    cm.Parameters.AddWithValue("@pcode", pcode);
                    cm.Parameters.AddWithValue("@price", price);
                    cm.Parameters.AddWithValue("@disc_percent", disc_per);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@cashier", fpos.lblUser.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    fpos.txtSearchProduct.Clear();
                    fpos.txtSearchProduct.Focus();
                    fpos.loadCart();
                    this.Dispose();

                }                
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

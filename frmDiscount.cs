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
    public partial class frmDiscount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmPOS f;
        public frmDiscount(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
            this.KeyPreview = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                double discount = (Double.Parse(txtprice.Text) * Double.Parse(txtPercent.Text))/100;
                txtAmount.Text = discount.ToString("#,##0.00");
            }
            catch (Exception ex) 
            {
               txtAmount.Text="0.00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtPercent.Text) < 0) || (int.Parse(txtPercent.Text) > 100))
            {
                MessageBox.Show("Please enter valid amount of discount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            try {
                cn.Open();
                cm = new SqlCommand("Update tblCart set disc = @disc, disc_percent= @disc_percent where id = @id", cn);
                cm.Parameters.AddWithValue("@disc", double.Parse(txtAmount.Text));
                cm.Parameters.AddWithValue("@disc_percent", double.Parse(txtPercent.Text));
                cm.Parameters.AddWithValue("@id", int.Parse(lblID.Text));
                cm.ExecuteNonQuery();
                cn.Close();
                f.loadCart();
                this.Dispose();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);

            }
            }
        }

        private void frmDiscount_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void txtPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46))
            {
                //accept . char
            }
            else if (e.KeyChar == 8)
            {
                //accept backspace
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))// ascii code 48-57 between 0-9
            {
                e.Handled = true;
            }

        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void txtPercent_KeyDown(object sender, KeyEventArgs e)
        {

           if (e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}

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

    public partial class frmAllStockDiscount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmProductList f;
        public frmAllStockDiscount(frmProductList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                cn.Open();
                cm = new SqlCommand("Select * from tblProduct", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("update tblProduct set disc_per = @disc_per", cn);
                    cm.Parameters.AddWithValue("@disc_per", double.Parse(txtDiscount.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Discount updated Successfully", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.LoadProducts();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("You have no Product in Record");
                }
            }
            catch (Exception ex) {
                cn.Close();
                MessageBox.Show(ex.Message);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

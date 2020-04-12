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
    public partial class frmBrand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBrandList frmlist;
        public frmBrand(frmBrandList flist,bool btnEnablevalue)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.frmlist = flist;
            this.btnSave.Enabled = btnEnablevalue;
            this.btnUpdate.Enabled = !btnEnablevalue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure to save this brand?","Save Record",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo tblBrand(Brand)VALUEs(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.","POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    frmlist.loadRecords();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update this brand?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("update tblbrand set brand = @brand where id like'"+lblID.Text+"'", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    frmlist.loadRecords();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

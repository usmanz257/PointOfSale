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
    public partial class frmVendor : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmVendorList f;
        public string _id;
        public frmVendor(frmVendorList frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.f = frm;
        }
        private void clear()
        {
            txtAddress.Clear();
            txtContactPerson.Clear();
            txtEmail.Clear();
            txtFax.Clear();
            txtTelephone.Clear();
            txtVendor.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to save this Vandor?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Saving Product
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo tblVendor(vendor, address, contactperson, telephone, email, fax)VALUES(@vendor, @address, @contactperson, @telephone, @email, @fax)", cn);
                    cm.Parameters.AddWithValue("@vendor", txtVendor.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtContactPerson.Text);
                    cm.Parameters.AddWithValue("@telephone", txtVendor.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFax.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    f.LoadVandors();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update this Vandor?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    //Saving Product
                    cn.Open();
                    cm = new SqlCommand("update tblVendor set vendor=@vendor, address=@address, contactperson=@contactperson, telephone=@contactperson, email=@email, fax=@fax where id = @id ", cn);
                    cm.Parameters.AddWithValue("@id", _id);
                    cm.Parameters.AddWithValue("@vendor", txtVendor.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtContactPerson.Text);
                    cm.Parameters.AddWithValue("@telephone", txtVendor.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFax.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    f.LoadVandors();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}

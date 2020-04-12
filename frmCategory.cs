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
    public partial class frmCategory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmCategoryList frmList;
        public frmCategory(frmCategoryList frm)
        { 
            InitializeComponent();
            frmList = frm;
            cn = new SqlConnection(dbcon.MyConnection());
        }
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to save this Category?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Close();
                    cn.Open();
                    cm = new SqlCommand("INSERT INTo tblCategory(Category)VALUEs(@Category)", cn);
                    cm.Parameters.AddWithValue("@Category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    frmList.loadRecords();
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
                    cm = new SqlCommand("update tblcategory set Category = @Category where id like'" + lblID.Text + "'", cn);
                    cm.Parameters.AddWithValue("@Category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully updated.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    frmList.loadRecords();
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

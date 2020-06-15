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
    public partial class frmVendorList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmVendorList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
        }
        public void LoadVandors()
        {
            int i = 0;
            dataGridVendor.Rows.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from tblVendor order by vendor", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridVendor.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            
                int i = 0;
                dataGridVendor.Rows.Clear();
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select * from tblVendor where vendor like '"+ txtSearchVendor.Text + "%' order by vendor", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridVendor.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                }
                dr.Close();
                cn.Close();
            
        }

        private void dataGridVendor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dataGridVendor.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                frmVendor frm = new frmVendor(this);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm._id = frm.txtVendor.Text = dataGridVendor.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtVendor.Text = dataGridVendor.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtAddress.Text = dataGridVendor.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtContactPerson.Text = dataGridVendor.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.txtTelephone.Text = dataGridVendor.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtEmail.Text = dataGridVendor.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.txtFax.Text = dataGridVendor.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure to delete this Vendor?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblVendor where id like '" + dataGridVendor.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("RECORD SUCCESFLLY DELETED", "DELETED RECORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVandors();
                }

            }
        }

        private void btnAddVandor_Click(object sender, EventArgs e)
        {
            frmVendor f = new frmVendor(this);
            f.btnSave.Enabled = true;
            f.btnUpdate.Enabled = false;
            f.ShowDialog();
        }
    }
}

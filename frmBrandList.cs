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
    public partial class frmBrandList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public frmBrandList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            loadRecords();

        }

        public void loadRecords()
        {
            int i = 0;
            dataGridBrand.Rows.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from tblBrand where deleteStatus = 'false' order by brand", cn);
            dr= cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridBrand.Rows.Add(i,dr["id"].ToString(),dr["brand"].ToString());
            }
        }
        private void dataGridBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dataGridBrand.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmBrand frm = new frmBrand(this,false);
                frm.lblID.Text = dataGridBrand[1, e.RowIndex].Value.ToString();
                frm.txtBrand.Text = dataGridBrand[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();
                
            }
            if (colName == "Delete")
            {
                //removing brand
                try
                {
                    if (MessageBox.Show("Are you sure to delete this brand?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Close();
                        cn.Open();
                        cm = new SqlCommand("update tblBrand set deleteStatus = 'true' WHERE id like'" + dataGridBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully Deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecords();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //removing brand forever 
                //try
                //{
                //    if (MessageBox.Show("Are you sure to delete this brand?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        cn.Close();
                //        cn.Open();
                //        cm = new SqlCommand("DELETE FROM tblBrand WHERE id like'" + dataGridBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                //        cm.ExecuteNonQuery();
                //        cn.Close();
                //        MessageBox.Show("Record has been successfully Deleted.","POS", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //        loadRecords();
                //    }

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

            }
        } 

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand(this, true);
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

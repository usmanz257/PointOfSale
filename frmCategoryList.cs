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
    public partial class frmCategoryList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmCategoryList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadRecords()
        {
            int i = 0;
            dataGridCategory.Rows.Clear();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from tblCategory order by category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridCategory.Rows.Add(i, dr["id"].ToString(), dr["Category"].ToString());
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory(this);
            frmCategory.btnSave.Enabled = true;
            frmCategory.btnUpdate.Enabled = false;
            frmCategory.ShowDialog();
        }

        private void dataGridCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dataGridCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmCategory frmCategory = new frmCategory(this);
                frmCategory.lblID.Text = dataGridCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmCategory.txtCategory.Text = dataGridCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                frmCategory.btnSave.Enabled = false;
                frmCategory.btnUpdate.Enabled = true;
               
                frmCategory.ShowDialog();

            }
            if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure to delete this Category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Close();
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblCategory WHERE id like'" + dataGridCategory[1, e.RowIndex].Value.ToString() + "'", cn);
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

            }
        }
    }
}

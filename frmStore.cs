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
    public partial class frmStore : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmStore()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadRecords()
        {
            cn.Open();
            cm = new SqlCommand("Select * from tblstore", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtStoreName.Text = dr["store"].ToString();
                txtAddress.Text = dr["address"].ToString();

            }
            else
            {
                txtStoreName.Clear();
                txtAddress.Clear();
            }
            dr.Close();
            cn.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if(MessageBox.Show("Save Store Details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(getStoreInfo() > 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tblstore set store=@store, address = @address", cn);
                        cm.Parameters.AddWithValue("@store", txtStoreName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    else
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblstore(store,address)values(@store, @address)", cn);
                        cm.Parameters.AddWithValue("@store", txtStoreName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    MessageBox.Show("Store details has been successfully saved", "Save record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int getStoreInfo()
        {
            int count;
            cn.Open();
            cm = new SqlCommand("select count(*) from tblstore", cn);
            count = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return count;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

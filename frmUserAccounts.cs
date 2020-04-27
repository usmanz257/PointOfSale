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
    public partial class frmUserAccounts : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmUserAccounts()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUserAccounts_Resize(object sender, EventArgs e)
        {
           // metroTabControl1.Left = (this.Width - metroTabControl1.Width) / 2;
          //  metroTabControl1.Top = (this.Width - metroTabControl1.Height) / 2;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUserAccounts_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if(txtPassword.Text != txtRetypePassword.Text )
                {
                    MessageBox.Show("password did not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("insert into tbluser(username,password,role, name)values(@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username",txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                cm.Parameters.AddWithValue("@role", cboRole.Text);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User Created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear() {
            txtName.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            txtUsername.Clear();
            cboRole.Text = "";
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

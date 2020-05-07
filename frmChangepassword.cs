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
    public partial class frmChangepassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmPOS fp;
        public frmChangepassword(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fp = frm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                string _username = fp.lblUser.Text;
                string _oldPassword = dbcon.GetPassword(_username);
                if (_oldPassword != txtOldPassword.Text)
                {
                    MessageBox.Show("Old password did not match !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(txtNewPassword.Text != txtConfirmNewPassword.Text)
                {
                    MessageBox.Show("Confirm and new password did not match !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if(MessageBox.Show("Chnage Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tbluser set password = @password where username = @username", cn);
                        cm.Parameters.AddWithValue("@password", txtNewPassword.Text);
                        cm.Parameters.AddWithValue("@username", fp.lblUser.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Password changed succesfully", "save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();

                    }


                }

            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

        private void txtConfirmNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void frmChangepassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}

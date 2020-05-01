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
        MainForm f;
        public frmUserAccounts(MainForm frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
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
            txtUserNameChange.Text = f.lblName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtRetypePassword.Text)
                {
                    MessageBox.Show("password did not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("insert into tbluser(username,password,role, name)values(@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
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
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePaswword();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NewClear();
        }

        private void btnSaveActive_Click(object sender, EventArgs e)
        {
            SaveUserStatus();
        }

        private void txtUserActive_TextChanged(object sender, EventArgs e)
        {
            this.UsarStatus();
        } 
        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string colName = dataGridUser.Columns[e.ColumnIndex].Name;
                if (colName == "Select")
                {
                    txtUserActive.Text = dataGridUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            this.SearchUser();
        }
        public void LoadUser()
        {
            try
            {
                int i = 0;
                dataGridUser.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select name,username, isactive from tbluser", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridUser.Rows.Add(i, dr["username"].ToString(), dr["name"].ToString(), dr["isactive"].ToString());
                };
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void ChangePaswword()
        {
            
            try
            {
                string _oldPass = txtOldPassword.Text;
                if (_oldPass != f._pass)
                {
                    MessageBox.Show("Old password did not match !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                {
                    MessageBox.Show("Confirm and new password did not match !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (MessageBox.Show("Change Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tbluser set password = @password where username = @username", cn);
                        cm.Parameters.AddWithValue("@password", txtNewPassword.Text);
                        cm.Parameters.AddWithValue("@username", txtUserNameChange.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Password changed succesfully", "save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NewClear();
                    }
                }
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewClear();
    }
}
        public void UsarStatus()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from tbluser where username = @username", cn);
                cm.Parameters.AddWithValue("@username", txtUserActive.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    bool _status = bool.Parse(dr["isactive"].ToString());
                    chkActive.Checked = _status;
                }
                else
                {
                    chkActive.Checked = false;
                }
                cn.Close();
                NewClear();
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void SearchUser()
        {
            try
            {
                int i = 0;
                dataGridUser.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select name,username, isactive from tbluser where username like '" + txtSearchUser.Text + "%'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridUser.Rows.Add(i, dr["name"].ToString(), dr["username"].ToString(), dr["isactive"].ToString());
                };
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void SaveUserStatus()
        {
            if(MessageBox.Show("Do tou really want to Change user status?","STATUS CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
            try
            {
                bool found = true;
                cn.Open();
                cm = new SqlCommand("select * from tbluser where username = @username", cn);
                cm.Parameters.AddWithValue("@username", txtUserActive.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) { found = true; } else { found = false; }
                dr.Close();
                cn.Close();
                if (found == true)
                {
                    cn.Open();
                    cm = new SqlCommand("update tbluser set isactive = @isactive where username = @username", cn);
                    cm.Parameters.AddWithValue("@isactive", chkActive.Checked.ToString());
                    cm.Parameters.AddWithValue("@username", txtUserActive.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Account has been successfully updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserActive.Clear();
                    chkActive.Checked = false;
                    this.LoadUser();
                }
                else
                {
                    MessageBox.Show("Account not Existd!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            }
        }
        private void Clear()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            txtUsername.Clear();
            cboRole.Text = "";
            txtUsername.Focus();
        }

        private void NewClear()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtRetypePassword.Clear();
        }

        private void btnStatusCancel_Click(object sender, EventArgs e)
        {
            txtUserActive.Clear();
            chkActive.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

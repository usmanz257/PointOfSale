﻿using System;
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
    public partial class frmSecurity : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public string _pass;
        public bool _isactive = false;
        public frmSecurity()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _userName = "", _role = "", _name = "";
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("Select * from tbluser where username = @username and password = @password ", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _userName = dr["username"].ToString();
                    _role = dr["role"].ToString();
                    _name = dr["name"].ToString();
                    this._pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if (found == true)
                {
                    if (_isactive == false)
                    {
                        MessageBox.Show("Account is inactive. Unable to Login" + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (_role == "Cashier")
                        {
                            MessageBox.Show("Welcome " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Clear();
                            txtUsername.Clear();
                            this.Hide();
                            frmPOS frm = new frmPOS();
                            frm.lblUser.Text = _userName;
                            frm.lblRole.Text = " | " + _role;
                            frm.lblRole.Visible = true;
                            frm.ShowDialog();

                        }
                        if (_role == "System Administrator")
                        {
                            MessageBox.Show("Welcome " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Clear();
                            txtUsername.Clear();
                            this.Hide();
                            MainForm frm = new MainForm();
                            frm.lblName.Text = _name;
                            frm.Name = _name;
                            frm._pass = this._pass;
                            frm.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password" + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User Not Found" + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}

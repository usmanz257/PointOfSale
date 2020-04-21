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
    public partial class frmVoid : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmCancelDetails f;
        public frmVoid(frmCancelDetails frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                string user="";
                cn.Open();
                cm = new SqlCommand("select * from tbluser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    user = dr["username"].ToString();
                    dr.Close();
                    cn.Close();

                    SaveCancelOrder(user);
                    if(f.cboAction.Text == "Yes")
                    {
                        string query1 = "update tblproduct set qty = qty + " + int.Parse(f.txtCancelQty.Text) + " where pcode = '" + f.txtPcode.Text + "'";
                        UpdateData(query1);
                    }
                    string query2= string.Format("update tblcart set qty=qty- {0} where id like '{1}'",int.Parse(f.txtCancelQty.Text), f.txtID.Text);

                    UpdateData(query2);
                    MessageBox.Show("Order transection successfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    f.RefreshList();
                    f.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("No user found");
                }
                dr.Close();
                cn.Close();

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SaveCancelOrder(string user)
        {
            cn.Open();
            cm = new SqlCommand("insert into tblCancel (transno,pcode,price,qty,sdate,voidby,cancelledby,reason,action) values(@transno, @pcode, @price, @qty, @sdate, @voidby, @cancelledby, @reason, @action)", cn);
            cm.Parameters.AddWithValue("@transno",f.txtTransno.Text);
            cm.Parameters.AddWithValue("@pcode", f.txtPcode.Text);
            cm.Parameters.AddWithValue("@price", double.Parse(f.txtPrice.Text));
            cm.Parameters.AddWithValue("@qty", int.Parse(f.txtCancelQty.Text));
            cm.Parameters.AddWithValue("@sdate",DateTime.Now);
            cm.Parameters.AddWithValue("@voidby", user);
            cm.Parameters.AddWithValue("@cancelledby", f.txtCancel.Text);
            cm.Parameters.AddWithValue("@reason", f.txtReason.Text);
            cm.Parameters.AddWithValue("@action", f.cboAction.Text);
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void UpdateData(string sql)
        {
            cn.Open();
            cm = new SqlCommand(sql,cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}

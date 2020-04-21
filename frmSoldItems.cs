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
    public partial class frmSoldItems : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public frmSoldItems()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            dt1.Value = DateTime.Now;
            dt1.Value = DateTime.Now;
            LoadRecord();
            LoadCashier();
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }
        public void LoadRecord() 
        {
            int counter = 0;
            double _total = 0;
            dataGridSale.Rows.Clear();
            cn.Open();
            if (cboCashier.Text == "All Cashier")
            {
                String query = string.Format("Select c.id ,c.transno,c.pcode, p.pdesc, c.price, c.qty,c.disc,c.total from tblCart as c inner join tblproduct as p on c.pcode=p.pcode where status like 'Sold' and sdate between'{0}' and '{1}'", this.dt1.Value, this.dt1.Value);
                cm = new SqlCommand(query, cn);
            }
            else 
            {
                String query = string.Format("Select c.id ,c.transno,c.pcode, p.pdesc, c.price, c.qty,c.disc,c.total from tblCart as c inner join tblproduct as p on c.pcode=p.pcode where status like 'Sold' and sdate between'{0}' and '{1}' and cashier like'{2}'", this.dt1.Value, this.dt1.Value, cboCashier.Text);
                cm = new SqlCommand(query, cn);
            }
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                counter+=1;
                _total += double.Parse(dr["total"].ToString());
                dataGridSale.Rows.Add(counter, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString()); 
            }
            dr.Close();
            cn.Close();
            lblDailyTotal.Text = _total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            LoadRecord();

        }

        private void dataGridSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboCashier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void LoadCashier()
        {
            cboCashier.Items.Clear();
            cboCashier.Items.Add("All Cashier");
            cn.Open();
            cm = new SqlCommand("Select * from tbluser where role like 'Cashier'",cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboCashier.Items.Add(dr["name"].ToString());

            }
            cn.Close();
        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecord();
        }
    }
}

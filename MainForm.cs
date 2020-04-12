﻿using System;
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
    public partial class MainForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public MainForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
           //cn.Open();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnbrand_Click(object sender, EventArgs e)
        {
            frmBrandList frmBrand = new frmBrandList();
            frmBrand.TopLevel = false;
            MainPanel.Controls.Add(frmBrand);
            frmBrand.BringToFront();
            frmBrand.Show();
        }

        private void btnCloseMainForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList frmCategory = new frmCategoryList();
            frmCategory.TopLevel = false;
            MainPanel.Controls.Add(frmCategory);
            frmCategory.BringToFront();
            frmCategory.loadRecords();
            frmCategory.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProductList frmProduct = new frmProductList();
            frmProduct.TopLevel = false;
            MainPanel.Controls.Add(frmProduct);
            frmProduct.BringToFront();
            frmProduct.LoadProducts();
            //frmProduct.loadRecords();
            frmProduct.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockIn frmStock = new frmStockIn();
            frmStock.LoadProduct();
            frmStock.ShowDialog();
        }
    }
}

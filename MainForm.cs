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
    public partial class MainForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public MainForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Close();
            NotifyCriticalItems();
            
           //cn.Open();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDashBoard_Click(sender, e);
        }
        public void NotifyCriticalItems() 
        {
            string _critical = "";
            int i = 0;
            string count="";
            cn.Open();
            cm = new SqlCommand("select count(*) from vwCriticalItems", cn);
            count = cm.ExecuteScalar().ToString();
            cn.Close();
            cn.Open();
            cm = new SqlCommand("select * from vwCriticalItems", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                _critical += i +"."+ dr["pdesc"].ToString() + Environment.NewLine;
            }
            dr.Close();
            cn.Close();

            MessageBox.Show("Critical stock is :" + Environment.NewLine + _critical, count + " Critical items",MessageBoxButtons.OK,MessageBoxIcon.Information);

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
            if (MessageBox.Show("Are you sure to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmSecurity frm = new frmSecurity();
                frm.ShowDialog();
            }

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
            frmStock.TopLevel = false;
            MainPanel.Controls.Add(frmStock);
            frmStock.BringToFront();
            frmStock.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.ShowDialog();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.lblDailySales.Text = dbcon.DailySales().ToString("#,##0.00");
            frm.lblTotalProducts.Text = dbcon.ProductLine().ToString();
            frm.lblStockOnHand.Text = dbcon.StockOnHand().ToString();
            frm.lblCritical.Text = dbcon.CriticalStock().ToString();
            frm.BringToFront();
            frm.Show();

        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            frmUserAccounts frm = new frmUserAccounts();
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            frmSoldItems frm = new frmSoldItems();
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            frmRecords frm = new frmRecords();
            frm.TopLevel = false;
            frm.LoadCriticalItems();
            frm.LoadInventory();
            frm.LoadCancelledOrders();
            frm.LoadStockInHistory();
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you realy want to Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmSecurity frm = new frmSecurity();
                frm.ShowDialog();
            }
            
        }

        private void btnStoreSettings_Click(object sender, EventArgs e)
        {
            frmStore frm = new frmStore();
            frm.LoadRecords();
            frm.ShowDialog();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            frmVendorList frm = new frmVendorList();
            frm.TopLevel = false;
            frm.LoadVandors();
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}

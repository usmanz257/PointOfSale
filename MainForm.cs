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
        Form ReferenceFrm = new frmDashboard();
        public string Name;
        public string _pass;
        Button ReferenceBtn;

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
            Button test = new Button();
            ReferenceBtn = test;
            btnDashBoard_Click(sender, e);
        }
        public void NotifyCriticalItems() 
        {
            frmNotification frm = new frmNotification();
            string _critical = "";
            int i = 0;
            string count="";
            cn.Open();
            cm = new SqlCommand("select count(*) from vwCriticalItems", cn);
            count = cm.ExecuteScalar().ToString();
            if ((count == string.Empty) || (count == "0"))
            {
                frm.lblNotificationCounter.Text = "CRITICAL STOCK";
                frm.lblNotifications.Text = "No Critical item";
            }
            else 
            {
                frm.lblNotificationCounter.Text = count + " Critical items";
                cn.Close();
                cn.Open();
                cm = new SqlCommand("select * from vwCriticalItems", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    _critical += i + "." + dr["pdesc"].ToString() + Environment.NewLine;
                }

            }
          
            dr.Close();
            cn.Close();
            frm.lblNotifications.Text ="Critical stock is :" + Environment.NewLine + _critical;
            frm.ShowDialog();

        }
        private void btnbrand_Click(object sender, EventArgs e)
        {
            btnbrand.Enabled = false;
            ReferenceFrm.Dispose();
            ReferenceBtn.Enabled = true;
            frmBrandList frmBrand = new frmBrandList();
            ReferenceFrm = frmBrand;
            ReferenceBtn = btnbrand;
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
            btnCategory.Enabled = false;
            ReferenceFrm.Dispose();
            ReferenceBtn.Enabled = true;
            frmCategoryList frmCategory = new frmCategoryList();
            ReferenceFrm = frmCategory;
            ReferenceBtn = btnCategory;
            frmCategory.TopLevel = false;
            MainPanel.Controls.Add(frmCategory);
            frmCategory.BringToFront();
            frmCategory.loadRecords();
            frmCategory.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnProduct.Enabled = false;
            frmProductList frmProduct = new frmProductList();
            ReferenceFrm = frmProduct;
            ReferenceBtn = btnProduct;
            frmProduct.TopLevel = false;
            MainPanel.Controls.Add(frmProduct);
            frmProduct.BringToFront();
            frmProduct.LoadProducts();
            //frmProduct.loadRecords();
            frmProduct.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnStock.Enabled = false;
            frmStockIn frmStock = new frmStockIn();
            ReferenceFrm = frmStock;
            ReferenceBtn = btnStock;
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
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnDashBoard.Enabled = false;
            frmDashboard frmDashBoard = new frmDashboard();
            ReferenceFrm = frmDashBoard;
            ReferenceBtn = btnDashBoard;
            frmDashBoard.TopLevel = false;
            MainPanel.Controls.Add(frmDashBoard);
            frmDashBoard.lblDailySales.Text = dbcon.DailySales().ToString("#,##0.00");
            frmDashBoard.lblTotalProducts.Text = dbcon.ProductLine().ToString();
            frmDashBoard.lblStockOnHand.Text = dbcon.StockOnHand().ToString();
            frmDashBoard.lblCritical.Text = dbcon.CriticalStock().ToString();
            frmDashBoard.BringToFront();
            frmDashBoard.Show();

        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnUserSettings.Enabled = false;
            frmUserAccounts frmAccounts = new frmUserAccounts(this);
            ReferenceFrm = frmAccounts;
            ReferenceBtn = btnUserSettings;
            frmAccounts.TopLevel = false;
            frmAccounts.LoadUser();
            MainPanel.Controls.Add(frmAccounts);
            frmAccounts.BringToFront();
            frmAccounts.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnSold.Enabled = false;
            frmSoldItems frmSolid = new frmSoldItems();
            ReferenceFrm = frmSolid;
            ReferenceBtn = btnSold;
            frmSolid.TopLevel = false;
            MainPanel.Controls.Add(frmSolid);
            frmSolid.BringToFront();
            frmSolid.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnRecords.Enabled = false;
            frmRecords frm = new frmRecords();
            ReferenceFrm = frm;
            ReferenceBtn = btnRecords;
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
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Dispose();
            btnStoreSettings.Enabled = false;
            frmStore frm = new frmStore();
            ReferenceFrm = frm;
            ReferenceBtn = btnStoreSettings;
            frm.LoadRecords();
            frm.ShowDialog();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Close();
            btnVendor.Enabled = false;
            frmVendorList frm = new frmVendorList();
            ReferenceFrm = frm;
            ReferenceBtn = btnVendor;
            frm.TopLevel = false;
            frm.LoadVandors();
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            ReferenceBtn.Enabled = true;
            ReferenceFrm.Close();
            btnStockAdjustment.Enabled = false;
            frmStockAdjustment frm = new frmStockAdjustment(this);
            ReferenceFrm = frm;
            ReferenceBtn = btnStockAdjustment;
            frm.TopLevel = false;
            frm.LoadProducts();
            frm.txtUser.Text = lblName.Text;
            frm.txtUser.Text = this.Name;
            frm.ReferenceNo();
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }
    }
}

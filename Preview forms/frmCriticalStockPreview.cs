using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PointOfSale.CrystalReport;

namespace PointOfSale.Preview_forms
{
    public partial class frmCriticalStockPreview : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmCriticalStockPreview()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void frmCriticalStockPreview_Load(object sender, EventArgs e)
        {
            try
            {
                string query;
                DataTable criticalItems = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                //Query fill data tables
                query = "Select * from vwCriticalItems";
                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(criticalItems);
                cn.Close();
                //creating object
                crptCriticaltems crptCriticalStock = new crptCriticaltems();
                //Inserting data to dataset by using crticalitems datatable
                crptCriticalStock.Database.Tables["dtCriticalStock"].SetDataSource(criticalItems);
                crvCriticalStock.ReportSource = null;
                crvCriticalStock.ReportSource = crptCriticalStock;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

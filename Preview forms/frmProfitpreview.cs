using CrystalDecisions.CrystalReports.Engine;
using PointOfSale.CrystalReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale.Preview_forms
{
    public partial class frmProfitpreview : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmProfit f;
        public frmProfitpreview(frmProfit frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void frmProfitpreview_Load(object sender, EventArgs e)
        {
            try
            {
                string query;
                DataTable dtProfit = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                //Query fill data tables
                query = "select transno,pcode,pdesc,qty,cost,price,disc,costtotal,total from vwProfit where sdate between'" + f.dt1.Value + "' and '" + f.dt2.Value + "' and status = 'sold'  order by transno ";
                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(dtProfit);
                cn.Close();
                //creating object
                crptProfit crptPro = new crptProfit();
                //Inserting data to dataset by using crticalitems datatable
                TextObject dateFrom = (TextObject)crptPro.ReportDefinition.Sections["Section1"].ReportObjects["txtDateFrom"];
                TextObject DateTo = (TextObject)crptPro.ReportDefinition.Sections["Section1"].ReportObjects["txtDateTo"];
                TextObject totalCost = (TextObject)crptPro.ReportDefinition.Sections["Section4"].ReportObjects["txtTotalCost"];
                TextObject totalDisc = (TextObject)crptPro.ReportDefinition.Sections["Section4"].ReportObjects["txtTotalDisc"];
                TextObject totalSales = (TextObject)crptPro.ReportDefinition.Sections["Section4"].ReportObjects["txtTotalSales"];
                TextObject totalprofit = (TextObject)crptPro.ReportDefinition.Sections["Section4"].ReportObjects["txtProfit"];
                dateFrom.Text = f.dt1.Text;
                DateTo.Text = f.dt2.Text;
                totalCost.Text = f.txtCost.Text;
                totalDisc.Text = f.txtDisc.Text;
                totalSales.Text = f.txtSales.Text;
                totalprofit.Text = f.txtProfit.Text;
                crptPro.Database.Tables["dtProfit"].SetDataSource(dtProfit);
                crvProfit.ReportSource = null;
                crvProfit.ReportSource = crptPro;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crvProfit_Load(object sender, EventArgs e)
        {

        }
    }
}

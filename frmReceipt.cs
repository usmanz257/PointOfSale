using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace PointOfSale
{
    public partial class frmReceipt : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmPOS f;
        public frmReceipt(frmPOS frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void Loadreport() 
        {
            ReportDataSource rptDataSource;
            try 
            {
                
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                Receipt ds = new Receipt();
                SqlDataAdapter da = new SqlDataAdapter();
                
                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id, c.transno,c.pcode,c.price,c.qty,c.disc,c.total,c.sdate,c.status, p.pdesc from tblCart as c inner join tblProduct as p on p.pcode = c.pcode where transno = '" + f.lblTransNo.Text  +"'",cn);
                da.Fill(ds.Tables["dtSold"]);
                cn.Close();
                
                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtSold"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 30;

            }
            catch (Exception ex) 
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
       

    }
}

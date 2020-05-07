using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Reporting.WinForms;
using PointOfSale.CrystalReport;

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
            try { 
              DataTable Sales = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter();
              cn.Open();
              da.SelectCommand = new SqlCommand("select c.id, c.transno,c.pcode,c.price,c.qty,c.disc,c.total,c.sdate,c.status, p.pdesc from tblcart as c inner join tblproduct as p on p.pcode = c.pcode where transno = '" + f.lblTransNo.Text + "'", cn);
              da.Fill(Sales);
              cn.Close();

            
                
            crptSales crptSales = new crptSales();
                TextObject transCode = (TextObject)crptSales.ReportDefinition.Sections["Section1"].ReportObjects["txtTransCode"];
                transCode.Text = f.lblTransNo.Text;
            crptSales.Database.Tables["dtSold"].SetDataSource(Sales);
            crvSales.ReportSource = null;
            crvSales.ReportSource = crptSales;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadreport()
        {

           
        }

        private void crvSales_Load(object sender, EventArgs e)
        {
        }

    }
}

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
    public partial class frmdailysalesReportPreview : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmSoldItems f;
        public frmdailysalesReportPreview(frmSoldItems frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f= frm;
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmdailysalesReportPreview_Load(object sender, EventArgs e)
        {
            try
            {
                string query;
                DataTable dailySales = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                if (f.cboCashier.Text == "All Cashier")
                {
                     query = string.Format("Select c.id ,c.transno,c.pcode, p.pdesc, c.price, c.qty,c.disc,c.total from tblCart as c inner join tblproduct as p on c.pcode=p.pcode where status like 'Sold' and sdate between'{0}' and '{1}'", Convert.ToString(f.dt1.Value), Convert.ToString(f.dt2.Value));
                    cm = new SqlCommand(query, cn);
                }
                else
                {
                    query = string.Format("Select c.id ,c.transno,c.pcode, p.pdesc, c.price, c.qty,c.disc,c.total from tblCart as c inner join tblproduct as p on c.pcode=p.pcode where status like 'Sold' and sdate between'{0}' and '{1}' and c.cashier = '{2}'", Convert.ToString(f.dt1.Value), Convert.ToString(f.dt2.Value), Convert.ToString(f.cboCashier.Text));
                    //String query = string.Format("Select c.id ,c.transno,c.pcode, p.pdesc, c.price, c.qty,c.disc,c.total from tblCart as c inner join tblproduct as p on c.pcode=p.pcode where status like 'Sold' and sdate between '{0}' and '{1}'", dt1.Value, dt2.Value);
                    //String query = string.Format("Select c.id ,c.transno,c.pcode, p.pdesc, c.price, c.qty,c.disc,c.total from tblCart as c inner join tblproduct as p on c.pcode=p.pcode where status like 'Sold'");

                    cm = new SqlCommand(query, cn);
                }
                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(dailySales);
                cn.Close();



                DailySales crptDailySales = new DailySales();
                TextObject dateFrom = (TextObject)crptDailySales.ReportDefinition.Sections["Section1"].ReportObjects["txtDateFrom"];
                TextObject DateTo = (TextObject)crptDailySales.ReportDefinition.Sections["Section1"].ReportObjects["txtDateTo"];
                TextObject username = (TextObject) crptDailySales.ReportDefinition.Sections["Section1"].ReportObjects["txtReportUserName"];
                dateFrom.Text = f.dt1.Text;
                DateTo.Text = f.dt2.Text;
                username.Text = f.cboCashier.Text;
                crptDailySales.Database.Tables["dtSoldReport"].SetDataSource(dailySales);
                crvDailySalesViewer.ReportSource = null;
                crvDailySalesViewer.ReportSource = crptDailySales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crvDailySalesViewer_Load(object sender, EventArgs e)
        {

        }
    }
}

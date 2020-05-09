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
    public partial class frmTopSellingItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmRecords f;
        public frmTopSellingItem(frmRecords frm)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void frmTopSellingItem_Load(object sender, EventArgs e)
        {
            try
            {
                string query="";
                DataTable topSellingitemDTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                //Query fill data tables
                if (f.cboTopSelect.Text == string.Empty)
                {
                    MessageBox.Show("Please select sort type from the dropdown list", "Suggestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    return;
                }
                else if (f.cboTopSelect.Text == "SORT BY QTY")
                {
                    query = string.Format("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total from vwSold where sdate between '{0}' and '{1}' and status like '{2}' group by pcode,pdesc order by qty desc", f.dt1.Value, f.dt2.Value, "Sold");

                }
                else if (f.cboTopSelect.Text == "SORT BY TOTAL")
                {
                    query = string.Format("select top 10 pcode, pdesc, isnull(sum(qty),0) as qty, isnull(sum(total),0) as total from vwSold where sdate between '{0}' and '{1}' and status like '{2}' group by pcode,pdesc order by total desc", f.dt1.Value, f.dt2.Value, "Sold");
                }

                da.SelectCommand = new SqlCommand(query, cn);
                da.Fill(topSellingitemDTable);
                cn.Close();
                //creating object
                crptTopSellingitem crptTopSelling = new crptTopSellingitem();
                //Inserting data to dataset by using crticalitems datatable
                crptTopSelling.Database.Tables["dtTopSelingItems"].SetDataSource(topSellingitemDTable);
                crvTopSellingItem.ReportSource = null;
                crvTopSellingItem.ReportSource = crptTopSelling;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

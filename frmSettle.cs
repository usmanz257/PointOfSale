using System;
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

    public partial class frmSettle : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        frmPOS fpos;
        public frmSettle( frmPOS fp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fpos = fp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try {
                double sale = double.Parse(txtSale.Text);
                double cash = double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(txtChange.Text) <= 0) || (txtChange.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient amount. Please enter the correct amount!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    
                    for (int i = 0; i < fpos.dataGridSale.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand ("update tblproduct set qty = qty - " + int.Parse(fpos.dataGridSale.Rows[i].Cells[5].Value.ToString()) + " where pcode = '" + int.Parse(fpos.dataGridSale.Rows[i].Cells[2].Value.ToString())+"'", cn);
                        cm.ExecuteNonQuery();                      
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("update tblCart set status = 'Sold' where id = '" + fpos.dataGridSale.Rows[i].Cells[1].Value.ToString()+"'",cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        
                    }
                    MessageBox.Show("Payment successfully saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fpos.getTransNo();
                    fpos.loadCart();
                    this.Dispose();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

       
    } 
}

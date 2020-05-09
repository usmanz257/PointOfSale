namespace PointOfSale.Preview_forms
{
    partial class frmCriticalStockPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvCriticalStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCriticalStock
            // 
            this.crvCriticalStock.ActiveViewIndex = -1;
            this.crvCriticalStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCriticalStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCriticalStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCriticalStock.Location = new System.Drawing.Point(0, 0);
            this.crvCriticalStock.Name = "crvCriticalStock";
            this.crvCriticalStock.Size = new System.Drawing.Size(800, 450);
            this.crvCriticalStock.TabIndex = 0;
            // 
            // frmCriticalStockPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvCriticalStock);
            this.Name = "frmCriticalStockPreview";
            this.Text = "frmCriticalStockPreview";
            this.Load += new System.EventHandler(this.frmCriticalStockPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCriticalStock;
    }
}
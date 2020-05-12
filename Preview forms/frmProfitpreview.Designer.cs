namespace PointOfSale.Preview_forms
{
    partial class frmProfitpreview
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
            this.crvProfit = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProfit
            // 
            this.crvProfit.ActiveViewIndex = -1;
            this.crvProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProfit.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProfit.Location = new System.Drawing.Point(0, 0);
            this.crvProfit.Name = "crvProfit";
            this.crvProfit.Size = new System.Drawing.Size(984, 534);
            this.crvProfit.TabIndex = 0;
            this.crvProfit.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvProfit.Load += new System.EventHandler(this.crvProfit_Load);
            // 
            // frmProfitpreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 534);
            this.Controls.Add(this.crvProfit);
            this.Name = "frmProfitpreview";
            this.Text = "frmProfitpreview";
            this.Load += new System.EventHandler(this.frmProfitpreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProfit;
    }
}
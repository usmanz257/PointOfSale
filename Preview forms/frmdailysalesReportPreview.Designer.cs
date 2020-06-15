namespace PointOfSale.Preview_forms
{
    partial class frmdailysalesReportPreview
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
            this.crvDailySalesViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDailySalesViewer
            // 
            this.crvDailySalesViewer.ActiveViewIndex = -1;
            this.crvDailySalesViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDailySalesViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDailySalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDailySalesViewer.Location = new System.Drawing.Point(0, 0);
            this.crvDailySalesViewer.Name = "crvDailySalesViewer";
            this.crvDailySalesViewer.Size = new System.Drawing.Size(1132, 553);
            this.crvDailySalesViewer.TabIndex = 3;
            this.crvDailySalesViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvDailySalesViewer.Load += new System.EventHandler(this.crvDailySalesViewer_Load);
            // 
            // frmdailysalesReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.crvDailySalesViewer);
            this.Name = "frmdailysalesReportPreview";
            this.Text = "DAILY SALES REPORT PREVIEW";
            this.Load += new System.EventHandler(this.frmdailysalesReportPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDailySalesViewer;
    }
}
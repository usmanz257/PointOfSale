namespace PointOfSale.Preview_forms
{
    partial class frmTopSellingItem
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
            this.crvTopSellingItem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTopSellingItem
            // 
            this.crvTopSellingItem.ActiveViewIndex = -1;
            this.crvTopSellingItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTopSellingItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTopSellingItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTopSellingItem.Location = new System.Drawing.Point(0, 0);
            this.crvTopSellingItem.Name = "crvTopSellingItem";
            this.crvTopSellingItem.Size = new System.Drawing.Size(800, 450);
            this.crvTopSellingItem.TabIndex = 0;
            // 
            // frmTopSellingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvTopSellingItem);
            this.Name = "frmTopSellingItem";
            this.Text = "frmTopSellingItem";
            this.Load += new System.EventHandler(this.frmTopSellingItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTopSellingItem;
    }
}
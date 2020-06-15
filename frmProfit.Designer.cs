namespace PointOfSale
{
    partial class frmProfit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTopSellingPrintPreview = new System.Windows.Forms.Button();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridprofit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridprofit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 40);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROFIT/LOSE";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnTopSellingPrintPreview);
            this.panel3.Controls.Add(this.dt2);
            this.panel3.Controls.Add(this.dt1);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1111, 44);
            this.panel3.TabIndex = 5;
            // 
            // btnTopSellingPrintPreview
            // 
            this.btnTopSellingPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnTopSellingPrintPreview.Enabled = false;
            this.btnTopSellingPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnTopSellingPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSellingPrintPreview.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSellingPrintPreview.ForeColor = System.Drawing.Color.White;
            this.btnTopSellingPrintPreview.Location = new System.Drawing.Point(689, 4);
            this.btnTopSellingPrintPreview.Name = "btnTopSellingPrintPreview";
            this.btnTopSellingPrintPreview.Size = new System.Drawing.Size(159, 32);
            this.btnTopSellingPrintPreview.TabIndex = 9;
            this.btnTopSellingPrintPreview.Text = "PRINT PREVIEW";
            this.btnTopSellingPrintPreview.UseVisualStyleBackColor = false;
            this.btnTopSellingPrintPreview.Click += new System.EventHandler(this.btnTopSellingPrintPreview_Click);
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(318, 6);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(212, 30);
            this.dt2.TabIndex = 8;
            this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(98, 6);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(212, 30);
            this.dt1.TabIndex = 7;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(547, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(136, 32);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "LOAD DATA";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter By";
            // 
            // dataGridprofit
            // 
            this.dataGridprofit.AllowUserToAddRows = false;
            this.dataGridprofit.AllowUserToDeleteRows = false;
            this.dataGridprofit.AllowUserToResizeColumns = false;
            this.dataGridprofit.AllowUserToResizeRows = false;
            this.dataGridprofit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridprofit.BackgroundColor = System.Drawing.Color.White;
            this.dataGridprofit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridprofit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridprofit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridprofit.ColumnHeadersHeight = 30;
            this.dataGridprofit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridprofit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column7,
            this.Column5,
            this.Column10,
            this.Column6});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridprofit.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridprofit.EnableHeadersVisualStyles = false;
            this.dataGridprofit.Location = new System.Drawing.Point(12, 90);
            this.dataGridprofit.MultiSelect = false;
            this.dataGridprofit.Name = "dataGridprofit";
            this.dataGridprofit.RowHeadersVisible = false;
            this.dataGridprofit.RowHeadersWidth = 51;
            this.dataGridprofit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridprofit.RowTemplate.Height = 24;
            this.dataGridprofit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridprofit.Size = new System.Drawing.Size(1087, 378);
            this.dataGridprofit.TabIndex = 8;
            this.dataGridprofit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridprofit_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 47;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "TRANS NO.";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 128;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "PCODE";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 93;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DESCRIPTION";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle38;
            this.Column4.HeaderText = "QTY";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 69;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "COST";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 81;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle39;
            this.Column7.HeaderText = "PRICE";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 83;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle40;
            this.Column5.HeaderText = "DISCOUNT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 124;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "COST TOTAL";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 137;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle41;
            this.Column6.HeaderText = "SALES TOTAL";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 143;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtProfit);
            this.panel2.Controls.Add(this.txtSales);
            this.panel2.Controls.Add(this.txtDisc);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 104);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(307, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "TOTAL COST :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(307, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "TOTAL DISC. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(719, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOTAL SALES :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(719, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "PROFIT/LOSS :";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCost.Location = new System.Drawing.Point(433, 14);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(232, 34);
            this.txtCost.TabIndex = 15;
            // 
            // txtDisc
            // 
            this.txtDisc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisc.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDisc.Location = new System.Drawing.Point(433, 54);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(232, 34);
            this.txtDisc.TabIndex = 16;
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSales.Location = new System.Drawing.Point(851, 14);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(232, 34);
            this.txtSales.TabIndex = 17;
            // 
            // txtProfit
            // 
            this.txtProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtProfit.Location = new System.Drawing.Point(851, 54);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(232, 34);
            this.txtProfit.TabIndex = 18;
            // 
            // frmProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridprofit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProfit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridprofit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnTopSellingPrintPreview;
        public System.Windows.Forms.DateTimePicker dt2;
        public System.Windows.Forms.DateTimePicker dt1;
        public System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridprofit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtProfit;
        public System.Windows.Forms.TextBox txtSales;
        public System.Windows.Forms.TextBox txtDisc;
        public System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
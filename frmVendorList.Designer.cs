namespace PointOfSale
{
    partial class frmVendorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendorList));
            this.dataGridVendor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchVendor = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddVandor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVendor
            // 
            this.dataGridVendor.AllowUserToAddRows = false;
            this.dataGridVendor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVendor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVendor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVendor.ColumnHeadersHeight = 30;
            this.dataGridVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVendor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridVendor.EnableHeadersVisualStyles = false;
            this.dataGridVendor.Location = new System.Drawing.Point(3, 114);
            this.dataGridVendor.Name = "dataGridVendor";
            this.dataGridVendor.RowHeadersVisible = false;
            this.dataGridVendor.RowHeadersWidth = 51;
            this.dataGridVendor.RowTemplate.Height = 24;
            this.dataGridVendor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVendor.Size = new System.Drawing.Size(1146, 332);
            this.dataGridVendor.TabIndex = 10;
            this.dataGridVendor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVendor_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 56;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "VENDOR NAME";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 188;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "ADDRESS";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "CONTACT PERSON";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 215;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column13.HeaderText = "TELEPHONE";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 152;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column14.HeaderText = "EMAIL";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 99;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column15.HeaderText = "FAX";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 75;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "VANDOR LIST";
            // 
            // txtSearchVendor
            // 
            // 
            // 
            // 
            this.txtSearchVendor.CustomButton.Image = null;
            this.txtSearchVendor.CustomButton.Location = new System.Drawing.Point(419, 2);
            this.txtSearchVendor.CustomButton.Name = "";
            this.txtSearchVendor.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtSearchVendor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchVendor.CustomButton.TabIndex = 1;
            this.txtSearchVendor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchVendor.CustomButton.UseSelectable = true;
            this.txtSearchVendor.CustomButton.Visible = false;
            this.txtSearchVendor.DisplayIcon = true;
            this.txtSearchVendor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSearchVendor.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchVendor.Icon")));
            this.txtSearchVendor.Lines = new string[0];
            this.txtSearchVendor.Location = new System.Drawing.Point(3, 8);
            this.txtSearchVendor.MaxLength = 32767;
            this.txtSearchVendor.Name = "txtSearchVendor";
            this.txtSearchVendor.PasswordChar = '\0';
            this.txtSearchVendor.PromptText = "Search Vandor";
            this.txtSearchVendor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchVendor.SelectedText = "";
            this.txtSearchVendor.SelectionLength = 0;
            this.txtSearchVendor.SelectionStart = 0;
            this.txtSearchVendor.ShortcutsEnabled = true;
            this.txtSearchVendor.Size = new System.Drawing.Size(457, 40);
            this.txtSearchVendor.TabIndex = 0;
            this.txtSearchVendor.UseSelectable = true;
            this.txtSearchVendor.WaterMark = "Search Vandor";
            this.txtSearchVendor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchVendor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVendor.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 50);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1149, 58);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddVandor);
            this.panel4.Controls.Add(this.txtSearchVendor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(424, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(725, 58);
            this.panel4.TabIndex = 3;
            // 
            // btnAddVandor
            // 
            this.btnAddVandor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVandor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAddVandor.FlatAppearance.BorderSize = 0;
            this.btnAddVandor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVandor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVandor.ForeColor = System.Drawing.Color.White;
            this.btnAddVandor.Location = new System.Drawing.Point(515, 10);
            this.btnAddVandor.Name = "btnAddVandor";
            this.btnAddVandor.Size = new System.Drawing.Size(198, 38);
            this.btnAddVandor.TabIndex = 40;
            this.btnAddVandor.Text = "ADD VANDOR";
            this.btnAddVandor.UseVisualStyleBackColor = false;
            this.btnAddVandor.Click += new System.EventHandler(this.btnAddVandor_Click);
            // 
            // frmVendorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridVendor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVendorList";
            this.Text = "frmVandorList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVendor;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSearchVendor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnAddVandor;
    }
}
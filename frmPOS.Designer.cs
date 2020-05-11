namespace PointOfSale
{
    partial class frmPOS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnDailySale = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridSale = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVatable = new System.Windows.Forms.Label();
            this.lblDateDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(105, 42);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(121, 29);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Cashier Name";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS Software";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.lblRole);
            this.panel5.Controls.Add(this.lblDisplayTotal);
            this.panel5.Controls.Add(this.lblUser);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1302, 81);
            this.panel5.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(300, 42);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(121, 29);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRole.Visible = false;
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTotal.Location = new System.Drawing.Point(1173, 19);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(104, 45);
            this.lblDisplayTotal.TabIndex = 0;
            this.lblDisplayTotal.Text = "0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.txtSearchProduct);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblTransNo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 111);
            this.panel3.TabIndex = 6;
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.DisplayIcon = true;
            this.txtQty.Enabled = false;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtQty.Lines = new string[] {
        "1"};
            this.txtQty.Location = new System.Drawing.Point(816, 67);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PromptText = "QTY";
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(62, 35);
            this.txtQty.TabIndex = 7;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.UseSelectable = true;
            this.txtQty.Visible = false;
            this.txtQty.WaterMark = "QTY";
            this.txtQty.WaterMarkColor = System.Drawing.Color.SteelBlue;
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSearchProduct
            // 
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(574, 1);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.CustomButton.Visible = false;
            this.txtSearchProduct.DisplayIcon = true;
            this.txtSearchProduct.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSearchProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSearchProduct.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchProduct.Icon")));
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(202, 68);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PromptText = "Scan Barcode Here";
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(608, 35);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Scan Barcode Here";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.SteelBlue;
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 28);
            this.label16.TabIndex = 5;
            this.label16.Text = "[F8] Barcode";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(197, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(204, 28);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "0000000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date";
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNo.ForeColor = System.Drawing.Color.Brown;
            this.lblTransNo.Location = new System.Drawing.Point(197, 5);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(204, 28);
            this.lblTransNo.TabIndex = 1;
            this.lblTransNo.Text = "0000000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Transection No.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnDailySale);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCancelSale);
            this.panel1.Controls.Add(this.btnSettle);
            this.panel1.Controls.Add(this.btnDiscount);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(993, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 595);
            this.panel1.TabIndex = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 282);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(307, 47);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "  [ F7 ] Change Passowrd";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDailySale
            // 
            this.btnDailySale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDailySale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnDailySale.FlatAppearance.BorderSize = 0;
            this.btnDailySale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDailySale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySale.ForeColor = System.Drawing.Color.White;
            this.btnDailySale.Image = ((System.Drawing.Image)(resources.GetObject("btnDailySale.Image")));
            this.btnDailySale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySale.Location = new System.Drawing.Point(0, 235);
            this.btnDailySale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDailySale.Name = "btnDailySale";
            this.btnDailySale.Size = new System.Drawing.Size(307, 47);
            this.btnDailySale.TabIndex = 7;
            this.btnDailySale.Text = "  [ F6 ] Daily Sale";
            this.btnDailySale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDailySale.UseVisualStyleBackColor = false;
            this.btnDailySale.Click += new System.EventHandler(this.btnDailySale_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 549);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(307, 47);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  [ 10 ] Logout";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCancelSale.Enabled = false;
            this.btnCancelSale.FlatAppearance.BorderSize = 0;
            this.btnCancelSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelSale.Image")));
            this.btnCancelSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelSale.Location = new System.Drawing.Point(0, 189);
            this.btnCancelSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(307, 47);
            this.btnCancelSale.TabIndex = 6;
            this.btnCancelSale.Text = "  [ F5 ] Cancel Sales";
            this.btnCancelSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnSettle.Enabled = false;
            this.btnSettle.FlatAppearance.BorderSize = 0;
            this.btnSettle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettle.ForeColor = System.Drawing.Color.White;
            this.btnSettle.Image = ((System.Drawing.Image)(resources.GetObject("btnSettle.Image")));
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.Location = new System.Drawing.Point(0, 142);
            this.btnSettle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(307, 47);
            this.btnSettle.TabIndex = 5;
            this.btnSettle.Text = "  [ F4 ] Settle Payment";
            this.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettle.UseVisualStyleBackColor = false;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnDiscount.Enabled = false;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(0, 95);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(307, 47);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "  [ F3 ] Add Discount";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(307, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "  [ F2 ] Search Product";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(0, 1);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(307, 47);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "  [ F1 ] New Transection";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridSale
            // 
            this.dataGridSale.AllowUserToAddRows = false;
            this.dataGridSale.AllowUserToDeleteRows = false;
            this.dataGridSale.AllowUserToResizeColumns = false;
            this.dataGridSale.AllowUserToResizeRows = false;
            this.dataGridSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSale.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSale.ColumnHeadersHeight = 30;
            this.dataGridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column9,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6,
            this.colAdd,
            this.colRemove,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSale.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridSale.EnableHeadersVisualStyles = false;
            this.dataGridSale.Location = new System.Drawing.Point(3, 0);
            this.dataGridSale.MultiSelect = false;
            this.dataGridSale.Name = "dataGridSale";
            this.dataGridSale.RowHeadersVisible = false;
            this.dataGridSale.RowHeadersWidth = 51;
            this.dataGridSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSale.RowTemplate.Height = 24;
            this.dataGridSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSale.Size = new System.Drawing.Size(984, 334);
            this.dataGridSale.TabIndex = 7;
            this.dataGridSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSale_CellContentClick);
            this.dataGridSale.SelectionChanged += new System.EventHandler(this.dataGridSale_SelectionChanged);
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
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "PCODE";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 92;
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
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "COST";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 79;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "PRICE";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 82;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "QTY";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 67;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "DISCOUNT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 121;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column6.HeaderText = "TOTAL";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 84;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdd.HeaderText = "";
            this.colAdd.MinimumWidth = 6;
            this.colAdd.Name = "colAdd";
            this.colAdd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAdd.Width = 6;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "";
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRemove.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.ToolTipText = "delete item";
            this.Delete.Width = 6;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.dataGridSale);
            this.panel7.Location = new System.Drawing.Point(0, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(990, 334);
            this.panel7.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.lblVatable);
            this.panel2.Controls.Add(this.lblDateDay);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblVat);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 144);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblVatable
            // 
            this.lblVatable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVatable.AutoSize = true;
            this.lblVatable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatable.ForeColor = System.Drawing.Color.White;
            this.lblVatable.Location = new System.Drawing.Point(609, 59);
            this.lblVatable.Name = "lblVatable";
            this.lblVatable.Size = new System.Drawing.Size(45, 23);
            this.lblVatable.TabIndex = 9;
            this.lblVatable.Text = "0.00";
            this.lblVatable.Visible = false;
            // 
            // lblDateDay
            // 
            this.lblDateDay.AutoSize = true;
            this.lblDateDay.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDay.ForeColor = System.Drawing.Color.White;
            this.lblDateDay.Location = new System.Drawing.Point(24, 98);
            this.lblDateDay.Name = "lblDateDay";
            this.lblDateDay.Size = new System.Drawing.Size(99, 34);
            this.lblDateDay.TabIndex = 1;
            this.lblDateDay.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(404, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vatable";
            this.label5.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(6, 5);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(392, 94);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            // 
            // lblVat
            // 
            this.lblVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.White;
            this.lblVat.Location = new System.Drawing.Point(609, 28);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(45, 23);
            this.lblVat.TabIndex = 5;
            this.lblVat.Text = "0.00";
            this.lblVat.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(404, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "VAT";
            this.label13.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.lblDiscount);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.lblTotal);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(660, 532);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(329, 144);
            this.panel8.TabIndex = 13;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(256, 77);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(53, 28);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "Discount";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(256, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 28);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sales Total";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "delete item";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1302, 680);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPOS_KeyDown);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnChangePassword;
        public System.Windows.Forms.Button btnDailySale;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnCancelSale;
        public System.Windows.Forms.Button btnSettle;
        public System.Windows.Forms.Button btnDiscount;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Button btnNew;
        public MetroFramework.Controls.MetroTextBox txtSearchProduct;
        public System.Windows.Forms.Label lblTransNo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateDay;
        public System.Windows.Forms.DataGridView dataGridSale;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblRole;
        public MetroFramework.Controls.MetroTextBox txtQty;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label lblVatable;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
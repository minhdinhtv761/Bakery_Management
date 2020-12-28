namespace Bakery_Management.UI.UC_Admin
{
    partial class ucAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccount));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxNameAcount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxDisplayAcount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.ResetPassword = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtgvAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.tbxNameAcount);
            this.panel3.Controls.Add(this.tbxDisplayAcount);
            this.panel3.Controls.Add(this.ResetPassword);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.btnDeleteAccount);
            this.panel3.Controls.Add(this.btnAddAccount);
            this.panel3.Controls.Add(this.btnFixAccount);
            this.panel3.Controls.Add(this.btnShowAccount);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(455, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 449);
            this.panel3.TabIndex = 29;
            // 
            // tbxNameAcount
            // 
            this.tbxNameAcount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxNameAcount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxNameAcount.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxNameAcount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNameAcount.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxNameAcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxNameAcount.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxNameAcount.HintText = "";
            this.tbxNameAcount.isPassword = false;
            this.tbxNameAcount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxNameAcount.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxNameAcount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxNameAcount.LineThickness = 1;
            this.tbxNameAcount.Location = new System.Drawing.Point(243, 95);
            this.tbxNameAcount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameAcount.MaxLength = 32767;
            this.tbxNameAcount.Name = "tbxNameAcount";
            this.tbxNameAcount.Size = new System.Drawing.Size(219, 30);
            this.tbxNameAcount.TabIndex = 39;
            this.tbxNameAcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxDisplayAcount
            // 
            this.tbxDisplayAcount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxDisplayAcount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxDisplayAcount.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxDisplayAcount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxDisplayAcount.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxDisplayAcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxDisplayAcount.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxDisplayAcount.HintText = "";
            this.tbxDisplayAcount.isPassword = false;
            this.tbxDisplayAcount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxDisplayAcount.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxDisplayAcount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxDisplayAcount.LineThickness = 1;
            this.tbxDisplayAcount.Location = new System.Drawing.Point(243, 152);
            this.tbxDisplayAcount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDisplayAcount.MaxLength = 32767;
            this.tbxDisplayAcount.Name = "tbxDisplayAcount";
            this.tbxDisplayAcount.Size = new System.Drawing.Size(219, 30);
            this.tbxDisplayAcount.TabIndex = 38;
            this.tbxDisplayAcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.numericUpDown1.Location = new System.Drawing.Point(252, 213);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(76, 26);
            this.numericUpDown1.TabIndex = 36;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(103, 220);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(116, 19);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Loại tài khoản:";
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.lbDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbDisplay.Location = new System.Drawing.Point(74, 21);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(30, 13);
            this.lbDisplay.TabIndex = 34;
            this.lbDisplay.Text = "Xem";
            this.lbDisplay.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(103, 163);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(98, 19);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Tên hiển thị:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 106);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(112, 19);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Tên tài khoản:";
            // 
            // dtgvAccount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvAccount.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.Size = new System.Drawing.Size(455, 449);
            this.dtgvAccount.TabIndex = 28;
            // 
            // ResetPassword
            // 
            this.ResetPassword.ActiveBorderThickness = 1;
            this.ResetPassword.ActiveCornerRadius = 15;
            this.ResetPassword.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.ResetPassword.ActiveForecolor = System.Drawing.Color.White;
            this.ResetPassword.ActiveLineColor = System.Drawing.Color.Transparent;
            this.ResetPassword.AllowDrop = true;
            this.ResetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.ResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetPassword.BackgroundImage")));
            this.ResetPassword.ButtonText = "Reset Password";
            this.ResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassword.ForeColor = System.Drawing.Color.White;
            this.ResetPassword.IdleBorderThickness = 1;
            this.ResetPassword.IdleCornerRadius = 15;
            this.ResetPassword.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.ResetPassword.IdleForecolor = System.Drawing.Color.White;
            this.ResetPassword.IdleLineColor = System.Drawing.Color.Transparent;
            this.ResetPassword.Location = new System.Drawing.Point(315, 348);
            this.ResetPassword.Margin = new System.Windows.Forms.Padding(5);
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.Size = new System.Drawing.Size(147, 52);
            this.ResetPassword.TabIndex = 37;
            this.ResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetPassword.Click += new System.EventHandler(this.ResetPassword_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.Image = global::Bakery_Management.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteAccount.ImageActive = null;
            this.btnDeleteAccount.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteAccount.TabIndex = 33;
            this.btnDeleteAccount.TabStop = false;
            this.btnDeleteAccount.Zoom = 10;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            this.btnDeleteAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteAccount_MouseMove);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Image = global::Bakery_Management.Properties.Resources.add_plus_512;
            this.btnAddAccount.ImageActive = null;
            this.btnAddAccount.Location = new System.Drawing.Point(6, 112);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(62, 46);
            this.btnAddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddAccount.TabIndex = 32;
            this.btnAddAccount.TabStop = false;
            this.btnAddAccount.Zoom = 10;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            this.btnAddAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddAccount_MouseMove);
            // 
            // btnFixAccount
            // 
            this.btnFixAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnFixAccount.Image = global::Bakery_Management.Properties.Resources._39_512;
            this.btnFixAccount.ImageActive = null;
            this.btnFixAccount.Location = new System.Drawing.Point(6, 233);
            this.btnFixAccount.Name = "btnFixAccount";
            this.btnFixAccount.Size = new System.Drawing.Size(62, 46);
            this.btnFixAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixAccount.TabIndex = 31;
            this.btnFixAccount.TabStop = false;
            this.btnFixAccount.Zoom = 10;
            this.btnFixAccount.Click += new System.EventHandler(this.btnFixAccount_Click);
            this.btnFixAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixAccount_MouseMove);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAccount.Image = global::Bakery_Management.Properties.Resources.visibility_512;
            this.btnShowAccount.ImageActive = null;
            this.btnShowAccount.Location = new System.Drawing.Point(6, 7);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(62, 46);
            this.btnShowAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowAccount.TabIndex = 30;
            this.btnShowAccount.TabStop = false;
            this.btnShowAccount.Zoom = 10;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            this.btnShowAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowAccount_MouseMove);
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label lbDisplay;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnAddAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnFixAccount;
        private Bunifu.Framework.UI.BunifuImageButton btnShowAccount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxNameAcount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxDisplayAcount;
    }
}

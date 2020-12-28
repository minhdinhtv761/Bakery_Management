namespace Bakery_Management.UI.UC_Admin
{
    partial class ucAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnThemes = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTaiKhoan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbBanAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDanhMuc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbThucAn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbDoanhThu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pnThemes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 501);
            this.panel1.TabIndex = 0;
            // 
            // pnThemes
            // 
            this.pnThemes.BackColor = System.Drawing.SystemColors.Control;
            this.pnThemes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThemes.Location = new System.Drawing.Point(0, 50);
            this.pnThemes.Name = "pnThemes";
            this.pnThemes.Size = new System.Drawing.Size(944, 451);
            this.pnThemes.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbTaiKhoan);
            this.panel2.Controls.Add(this.lbBanAn);
            this.panel2.Controls.Add(this.lbDanhMuc);
            this.panel2.Controls.Add(this.lbThucAn);
            this.panel2.Controls.Add(this.lbDoanhThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 50);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(118, 47);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(103, 3);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 3);
            this.panel3.TabIndex = 5;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.BackColor = System.Drawing.Color.White;
            this.lbTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTaiKhoan.Location = new System.Drawing.Point(710, 9);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(93, 23);
            this.lbTaiKhoan.TabIndex = 4;
            this.lbTaiKhoan.Text = "Tài khoản";
            this.lbTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTaiKhoan.Click += new System.EventHandler(this.lbTaiKhoan_Click);
            // 
            // lbBanAn
            // 
            this.lbBanAn.AutoSize = true;
            this.lbBanAn.BackColor = System.Drawing.Color.White;
            this.lbBanAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBanAn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbBanAn.Location = new System.Drawing.Point(580, 9);
            this.lbBanAn.Name = "lbBanAn";
            this.lbBanAn.Size = new System.Drawing.Size(69, 23);
            this.lbBanAn.TabIndex = 3;
            this.lbBanAn.Text = "Bàn ăn";
            this.lbBanAn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbBanAn.Click += new System.EventHandler(this.lbBanAn_Click);
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.AutoSize = true;
            this.lbDanhMuc.BackColor = System.Drawing.Color.White;
            this.lbDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDanhMuc.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbDanhMuc.Location = new System.Drawing.Point(411, 9);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(96, 23);
            this.lbDanhMuc.TabIndex = 2;
            this.lbDanhMuc.Text = "Danh mục";
            this.lbDanhMuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDanhMuc.Click += new System.EventHandler(this.lbDoanhMuc_Click);
            // 
            // lbThucAn
            // 
            this.lbThucAn.AutoSize = true;
            this.lbThucAn.BackColor = System.Drawing.Color.White;
            this.lbThucAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbThucAn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThucAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbThucAn.Location = new System.Drawing.Point(269, 9);
            this.lbThucAn.Name = "lbThucAn";
            this.lbThucAn.Size = new System.Drawing.Size(81, 23);
            this.lbThucAn.TabIndex = 1;
            this.lbThucAn.Text = "Thức ăn";
            this.lbThucAn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbThucAn.Click += new System.EventHandler(this.lbThucAn_Click);
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.BackColor = System.Drawing.Color.White;
            this.lbDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDoanhThu.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbDoanhThu.Location = new System.Drawing.Point(120, 9);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(98, 23);
            this.lbDoanhThu.TabIndex = 0;
            this.lbDoanhThu.Text = "Doanh thu";
            this.lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDoanhThu.Click += new System.EventHandler(this.lbDoanhThu_Click);
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(944, 501);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbThucAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDoanhThu;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTaiKhoan;
        private Bunifu.Framework.UI.BunifuCustomLabel lbBanAn;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDanhMuc;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pnThemes;
        private System.Windows.Forms.Panel panel3;
    }
}

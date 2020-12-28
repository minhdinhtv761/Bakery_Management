namespace Bakery_Management.UI.UC_Admin
{
    partial class ucBanAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxTableName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxIDTable = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTableFind = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.btnDeleteTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFindTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.dmStatus = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgvTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.dmStatus);
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.tbxTableName);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.tbxIDTable);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.btnDeleteTable);
            this.panel3.Controls.Add(this.btnAddTable);
            this.panel3.Controls.Add(this.btnFixTable);
            this.panel3.Controls.Add(this.btnShowTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(455, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 410);
            this.panel3.TabIndex = 29;
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.lbDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbDisplay.Location = new System.Drawing.Point(74, 26);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(30, 13);
            this.lbDisplay.TabIndex = 46;
            this.lbDisplay.Text = "Xem";
            this.lbDisplay.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(103, 220);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel3.TabIndex = 44;
            this.bunifuCustomLabel3.Text = "Trạng thái:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // tbxTableName
            // 
            this.tbxTableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxTableName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxTableName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxTableName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTableName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxTableName.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxTableName.HintText = "";
            this.tbxTableName.isPassword = false;
            this.tbxTableName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxTableName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxTableName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxTableName.LineThickness = 1;
            this.tbxTableName.Location = new System.Drawing.Point(243, 152);
            this.tbxTableName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTableName.MaxLength = 32767;
            this.tbxTableName.Name = "tbxTableName";
            this.tbxTableName.Size = new System.Drawing.Size(219, 30);
            this.tbxTableName.TabIndex = 43;
            this.tbxTableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 163);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 19);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Tên bàn:";
            // 
            // tbxIDTable
            // 
            this.tbxIDTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxIDTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxIDTable.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbxIDTable.BackColor = System.Drawing.SystemColors.Control;
            this.tbxIDTable.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxIDTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxIDTable.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxIDTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxIDTable.HintForeColor = System.Drawing.Color.Transparent;
            this.tbxIDTable.HintText = "";
            this.tbxIDTable.isPassword = false;
            this.tbxIDTable.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxIDTable.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxIDTable.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxIDTable.LineThickness = 1;
            this.tbxIDTable.Location = new System.Drawing.Point(243, 95);
            this.tbxIDTable.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDTable.MaxLength = 32767;
            this.tbxIDTable.Name = "tbxIDTable";
            this.tbxIDTable.Size = new System.Drawing.Size(219, 30);
            this.tbxIDTable.TabIndex = 41;
            this.tbxIDTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(103, 106);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(29, 19);
            this.bunifuCustomLabel4.TabIndex = 40;
            this.bunifuCustomLabel4.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnFindTable);
            this.panel1.Controls.Add(this.cbTableFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 0;
            // 
            // cbTableFind
            // 
            this.cbTableFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbTableFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbTableFind.BackColor = System.Drawing.SystemColors.Control;
            this.cbTableFind.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbTableFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTableFind.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbTableFind.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.cbTableFind.HintText = "Search...";
            this.cbTableFind.isPassword = false;
            this.cbTableFind.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.cbTableFind.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbTableFind.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.cbTableFind.LineThickness = 2;
            this.cbTableFind.Location = new System.Drawing.Point(266, 4);
            this.cbTableFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbTableFind.MaxLength = 32767;
            this.cbTableFind.Name = "cbTableFind";
            this.cbTableFind.Size = new System.Drawing.Size(219, 31);
            this.cbTableFind.TabIndex = 40;
            this.cbTableFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.ReadOnly = true;
            this.dtgvTable.Size = new System.Drawing.Size(455, 449);
            this.dtgvTable.TabIndex = 28;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTable.Image = global::Bakery_Management.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteTable.ImageActive = null;
            this.btnDeleteTable.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteTable.TabIndex = 33;
            this.btnDeleteTable.TabStop = false;
            this.btnDeleteTable.Zoom = 10;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            this.btnDeleteTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteTable_MouseMove);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTable.Image = global::Bakery_Management.Properties.Resources.add_plus_512;
            this.btnAddTable.ImageActive = null;
            this.btnAddTable.Location = new System.Drawing.Point(6, 112);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(62, 46);
            this.btnAddTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddTable.TabIndex = 32;
            this.btnAddTable.TabStop = false;
            this.btnAddTable.Zoom = 10;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            this.btnAddTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddTable_MouseMove);
            // 
            // btnFixTable
            // 
            this.btnFixTable.BackColor = System.Drawing.Color.Transparent;
            this.btnFixTable.Image = global::Bakery_Management.Properties.Resources._39_512;
            this.btnFixTable.ImageActive = null;
            this.btnFixTable.Location = new System.Drawing.Point(6, 233);
            this.btnFixTable.Name = "btnFixTable";
            this.btnFixTable.Size = new System.Drawing.Size(62, 46);
            this.btnFixTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixTable.TabIndex = 31;
            this.btnFixTable.TabStop = false;
            this.btnFixTable.Zoom = 10;
            this.btnFixTable.Click += new System.EventHandler(this.btnFixTable_Click);
            this.btnFixTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixTable_MouseMove);
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.Color.Transparent;
            this.btnShowTable.Image = global::Bakery_Management.Properties.Resources.visibility_512;
            this.btnShowTable.ImageActive = null;
            this.btnShowTable.Location = new System.Drawing.Point(6, 7);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(62, 46);
            this.btnShowTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowTable.TabIndex = 30;
            this.btnShowTable.TabStop = false;
            this.btnShowTable.Zoom = 10;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            this.btnShowTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowTable_MouseMove);
            // 
            // btnFindTable
            // 
            this.btnFindTable.BackColor = System.Drawing.Color.Transparent;
            this.btnFindTable.Image = global::Bakery_Management.Properties.Resources.search_100px;
            this.btnFindTable.ImageActive = null;
            this.btnFindTable.Location = new System.Drawing.Point(461, 3);
            this.btnFindTable.Name = "btnFindTable";
            this.btnFindTable.Size = new System.Drawing.Size(24, 30);
            this.btnFindTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFindTable.TabIndex = 29;
            this.btnFindTable.TabStop = false;
            this.btnFindTable.Zoom = 10;
            this.btnFindTable.Click += new System.EventHandler(this.btnFindTable_Click);
            // 
            // dmStatus
            // 
            this.dmStatus.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.dmStatus.FormattingEnabled = true;
            this.dmStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.dmStatus.Location = new System.Drawing.Point(243, 213);
            this.dmStatus.Name = "dmStatus";
            this.dmStatus.Size = new System.Drawing.Size(217, 26);
            this.dmStatus.TabIndex = 48;
            // 
            // ucBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucBanAn";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnFindTable;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxTableName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxIDTable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteTable;
        private Bunifu.Framework.UI.BunifuImageButton btnAddTable;
        private Bunifu.Framework.UI.BunifuImageButton btnFixTable;
        private Bunifu.Framework.UI.BunifuImageButton btnShowTable;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbTableFind;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.ComboBox dmStatus;
    }
}

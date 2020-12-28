namespace Bakery_Management.UI.UC_Admin
{
    partial class ucDanhMuc
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.tbxTypeName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxIDType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategoryFind = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFindCategory = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgvCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.tbxTypeName);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.tbxIDType);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.btnDeleteCategory);
            this.panel3.Controls.Add(this.btnAddCategory);
            this.panel3.Controls.Add(this.btnFixCategory);
            this.panel3.Controls.Add(this.btnShowCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(455, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 410);
            this.panel3.TabIndex = 29;
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbDisplay.Location = new System.Drawing.Point(74, 20);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(31, 15);
            this.lbDisplay.TabIndex = 44;
            this.lbDisplay.Text = "Xem";
            this.lbDisplay.Visible = false;
            // 
            // tbxTypeName
            // 
            this.tbxTypeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxTypeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxTypeName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxTypeName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTypeName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxTypeName.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxTypeName.HintText = "";
            this.tbxTypeName.isPassword = false;
            this.tbxTypeName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxTypeName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxTypeName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxTypeName.LineThickness = 1;
            this.tbxTypeName.Location = new System.Drawing.Point(252, 183);
            this.tbxTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTypeName.MaxLength = 32767;
            this.tbxTypeName.Name = "tbxTypeName";
            this.tbxTypeName.Size = new System.Drawing.Size(219, 30);
            this.tbxTypeName.TabIndex = 43;
            this.tbxTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(112, 194);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Danh mục:";
            // 
            // tbxIDType
            // 
            this.tbxIDType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxIDType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxIDType.BackColor = System.Drawing.SystemColors.Control;
            this.tbxIDType.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxIDType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxIDType.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxIDType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxIDType.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxIDType.HintText = "";
            this.tbxIDType.isPassword = false;
            this.tbxIDType.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxIDType.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxIDType.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxIDType.LineThickness = 1;
            this.tbxIDType.Location = new System.Drawing.Point(252, 128);
            this.tbxIDType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDType.MaxLength = 32767;
            this.tbxIDType.Name = "tbxIDType";
            this.tbxIDType.Size = new System.Drawing.Size(219, 30);
            this.tbxIDType.TabIndex = 41;
            this.tbxIDType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(112, 139);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(29, 19);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnFindCategory);
            this.panel1.Controls.Add(this.cbCategoryFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 0;
            // 
            // cbCategoryFind
            // 
            this.cbCategoryFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbCategoryFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbCategoryFind.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.cbCategoryFind.BackColor = System.Drawing.SystemColors.Control;
            this.cbCategoryFind.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbCategoryFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbCategoryFind.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbCategoryFind.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.cbCategoryFind.HintText = "Search...";
            this.cbCategoryFind.isPassword = false;
            this.cbCategoryFind.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.cbCategoryFind.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbCategoryFind.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.cbCategoryFind.LineThickness = 2;
            this.cbCategoryFind.Location = new System.Drawing.Point(266, 4);
            this.cbCategoryFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoryFind.MaxLength = 32767;
            this.cbCategoryFind.Name = "cbCategoryFind";
            this.cbCategoryFind.Size = new System.Drawing.Size(219, 31);
            this.cbCategoryFind.TabIndex = 39;
            this.cbCategoryFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cbCategoryFind.OnValueChanged += new System.EventHandler(this.cbCategoryFind_OnValueChanged);
            // 
            // dtgvCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvCategory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.ReadOnly = true;
            this.dtgvCategory.Size = new System.Drawing.Size(455, 449);
            this.dtgvCategory.TabIndex = 28;
            this.dtgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellContentClick);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.Image = global::Bakery_Management.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteCategory.ImageActive = null;
            this.btnDeleteCategory.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteCategory.TabIndex = 33;
            this.btnDeleteCategory.TabStop = false;
            this.btnDeleteCategory.Zoom = 10;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            this.btnDeleteCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteCategory_MouseMove);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Image = global::Bakery_Management.Properties.Resources.add_plus_512;
            this.btnAddCategory.ImageActive = null;
            this.btnAddCategory.Location = new System.Drawing.Point(6, 112);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(62, 46);
            this.btnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCategory.TabIndex = 32;
            this.btnAddCategory.TabStop = false;
            this.btnAddCategory.Zoom = 10;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            this.btnAddCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddCategory_MouseMove);
            // 
            // btnFixCategory
            // 
            this.btnFixCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnFixCategory.Image = global::Bakery_Management.Properties.Resources._39_512;
            this.btnFixCategory.ImageActive = null;
            this.btnFixCategory.Location = new System.Drawing.Point(6, 233);
            this.btnFixCategory.Name = "btnFixCategory";
            this.btnFixCategory.Size = new System.Drawing.Size(62, 46);
            this.btnFixCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixCategory.TabIndex = 31;
            this.btnFixCategory.TabStop = false;
            this.btnFixCategory.Zoom = 10;
            this.btnFixCategory.Click += new System.EventHandler(this.btnFixCategory_Click);
            this.btnFixCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixCategory_MouseMove);
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCategory.Image = global::Bakery_Management.Properties.Resources.visibility_512;
            this.btnShowCategory.ImageActive = null;
            this.btnShowCategory.Location = new System.Drawing.Point(6, 7);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(62, 46);
            this.btnShowCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowCategory.TabIndex = 30;
            this.btnShowCategory.TabStop = false;
            this.btnShowCategory.Zoom = 10;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            this.btnShowCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowCategory_MouseMove);
            // 
            // btnFindCategory
            // 
            this.btnFindCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCategory.Image = global::Bakery_Management.Properties.Resources.search_100px;
            this.btnFindCategory.ImageActive = null;
            this.btnFindCategory.Location = new System.Drawing.Point(461, 4);
            this.btnFindCategory.Name = "btnFindCategory";
            this.btnFindCategory.Size = new System.Drawing.Size(24, 28);
            this.btnFindCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFindCategory.TabIndex = 29;
            this.btnFindCategory.TabStop = false;
            this.btnFindCategory.Zoom = 10;
            this.btnFindCategory.Click += new System.EventHandler(this.btnFindCategory_Click);
            // 
            // ucDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucDanhMuc";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteCategory;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCategory;
        private Bunifu.Framework.UI.BunifuImageButton btnFixCategory;
        private Bunifu.Framework.UI.BunifuImageButton btnShowCategory;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnFindCategory;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbCategoryFind;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxIDType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxTypeName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label lbDisplay;
    }
}

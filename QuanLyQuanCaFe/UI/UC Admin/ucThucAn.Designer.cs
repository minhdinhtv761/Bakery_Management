namespace Bakery_Management.UI.UC_Admin
{
    partial class ucThucAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFoodFind = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbCategoryFood = new System.Windows.Forms.ComboBox();
            this.tbxPriceFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxFoodName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxIDFood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.btnDeleteFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFixFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnShowFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFindFood = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnFindFood);
            this.panel1.Controls.Add(this.cbFoodFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 39);
            this.panel1.TabIndex = 0;
            // 
            // cbFoodFind
            // 
            this.cbFoodFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cbFoodFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbFoodFind.BackColor = System.Drawing.SystemColors.Control;
            this.cbFoodFind.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbFoodFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbFoodFind.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbFoodFind.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.cbFoodFind.HintText = "Search...";
            this.cbFoodFind.isPassword = false;
            this.cbFoodFind.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.cbFoodFind.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbFoodFind.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.cbFoodFind.LineThickness = 2;
            this.cbFoodFind.Location = new System.Drawing.Point(266, 4);
            this.cbFoodFind.Margin = new System.Windows.Forms.Padding(4);
            this.cbFoodFind.MaxLength = 32767;
            this.cbFoodFind.Name = "cbFoodFind";
            this.cbFoodFind.Size = new System.Drawing.Size(219, 31);
            this.cbFoodFind.TabIndex = 41;
            this.cbFoodFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgvFood
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgvFood.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.ReadOnly = true;
            this.dtgvFood.Size = new System.Drawing.Size(455, 449);
            this.dtgvFood.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgvFood);
            this.panel2.Controls.Add(this.tbxTemp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 449);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.cbCategoryFood);
            this.panel3.Controls.Add(this.tbxPriceFood);
            this.panel3.Controls.Add(this.tbxFoodName);
            this.panel3.Controls.Add(this.tbxIDFood);
            this.panel3.Controls.Add(this.lbDisplay);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.btnFixFood);
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(455, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 410);
            this.panel3.TabIndex = 29;
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Location = new System.Drawing.Point(226, 203);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.Size = new System.Drawing.Size(217, 26);
            this.cbCategoryFood.TabIndex = 47;
            // 
            // tbxPriceFood
            // 
            this.tbxPriceFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxPriceFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxPriceFood.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxPriceFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPriceFood.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriceFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxPriceFood.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxPriceFood.HintText = "";
            this.tbxPriceFood.isPassword = false;
            this.tbxPriceFood.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxPriceFood.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxPriceFood.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxPriceFood.LineThickness = 1;
            this.tbxPriceFood.Location = new System.Drawing.Point(226, 248);
            this.tbxPriceFood.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPriceFood.MaxLength = 32767;
            this.tbxPriceFood.Name = "tbxPriceFood";
            this.tbxPriceFood.Size = new System.Drawing.Size(219, 30);
            this.tbxPriceFood.TabIndex = 44;
            this.tbxPriceFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxFoodName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFoodName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxFoodName.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxFoodName.HintText = "";
            this.tbxFoodName.isPassword = false;
            this.tbxFoodName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxFoodName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxFoodName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxFoodName.LineThickness = 1;
            this.tbxFoodName.Location = new System.Drawing.Point(226, 140);
            this.tbxFoodName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFoodName.MaxLength = 32767;
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(219, 30);
            this.tbxFoodName.TabIndex = 43;
            this.tbxFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxIDFood
            // 
            this.tbxIDFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxIDFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxIDFood.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxIDFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxIDFood.Font = new System.Drawing.Font("Roboto", 12F);
            this.tbxIDFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxIDFood.HintForeColor = System.Drawing.SystemColors.Control;
            this.tbxIDFood.HintText = "";
            this.tbxIDFood.isPassword = false;
            this.tbxIDFood.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxIDFood.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxIDFood.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tbxIDFood.LineThickness = 1;
            this.tbxIDFood.Location = new System.Drawing.Point(226, 86);
            this.tbxIDFood.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDFood.MaxLength = 32767;
            this.tbxIDFood.Name = "tbxIDFood";
            this.tbxIDFood.Size = new System.Drawing.Size(219, 30);
            this.tbxIDFood.TabIndex = 42;
            this.tbxIDFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(103, 259);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 19);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Giá:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(103, 205);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Danh mục:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(103, 151);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(77, 19);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Tên món:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(29, 19);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "ID:";
            // 
            // tbxTemp
            // 
            this.tbxTemp.Location = new System.Drawing.Point(191, 146);
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.Size = new System.Drawing.Size(100, 20);
            this.tbxTemp.TabIndex = 35;
            this.tbxTemp.TextChanged += new System.EventHandler(this.tbxTemp_TextChanged);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFood.Image = global::Bakery_Management.Properties.Resources.delete_1432400_1211078;
            this.btnDeleteFood.ImageActive = null;
            this.btnDeleteFood.Location = new System.Drawing.Point(6, 354);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(62, 46);
            this.btnDeleteFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteFood.TabIndex = 33;
            this.btnDeleteFood.TabStop = false;
            this.btnDeleteFood.Zoom = 10;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            this.btnDeleteFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeleteFood_MouseMove);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFood.Image = global::Bakery_Management.Properties.Resources.add_plus_512;
            this.btnAddFood.ImageActive = null;
            this.btnAddFood.Location = new System.Drawing.Point(6, 112);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(62, 46);
            this.btnAddFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddFood.TabIndex = 32;
            this.btnAddFood.TabStop = false;
            this.btnAddFood.Zoom = 10;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            this.btnAddFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddFood_MouseMove);
            // 
            // btnFixFood
            // 
            this.btnFixFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnFixFood.Image = global::Bakery_Management.Properties.Resources._39_512;
            this.btnFixFood.ImageActive = null;
            this.btnFixFood.Location = new System.Drawing.Point(6, 233);
            this.btnFixFood.Name = "btnFixFood";
            this.btnFixFood.Size = new System.Drawing.Size(62, 46);
            this.btnFixFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFixFood.TabIndex = 31;
            this.btnFixFood.TabStop = false;
            this.btnFixFood.Zoom = 10;
            this.btnFixFood.Click += new System.EventHandler(this.btnFixFood_Click);
            this.btnFixFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFixFood_MouseMove);
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowFood.Image = global::Bakery_Management.Properties.Resources.visibility_512;
            this.btnShowFood.ImageActive = null;
            this.btnShowFood.Location = new System.Drawing.Point(6, 7);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(62, 46);
            this.btnShowFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowFood.TabIndex = 30;
            this.btnShowFood.TabStop = false;
            this.btnShowFood.Zoom = 10;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            this.btnShowFood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowFood_MouseMove);
            // 
            // btnFindFood
            // 
            this.btnFindFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnFindFood.Image = global::Bakery_Management.Properties.Resources.search_100px;
            this.btnFindFood.ImageActive = null;
            this.btnFindFood.Location = new System.Drawing.Point(461, 4);
            this.btnFindFood.Name = "btnFindFood";
            this.btnFindFood.Size = new System.Drawing.Size(24, 28);
            this.btnFindFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFindFood.TabIndex = 29;
            this.btnFindFood.TabStop = false;
            this.btnFindFood.Zoom = 10;
            this.btnFindFood.Click += new System.EventHandler(this.btnFindFood_Click);
            // 
            // ucThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucThucAn";
            this.Size = new System.Drawing.Size(944, 449);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFixFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFindFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnFindFood;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteFood;
        private Bunifu.Framework.UI.BunifuImageButton btnAddFood;
        private Bunifu.Framework.UI.BunifuImageButton btnFixFood;
        private Bunifu.Framework.UI.BunifuImageButton btnShowFood;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.TextBox tbxTemp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxPriceFood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxFoodName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxIDFood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cbFoodFind;
        private System.Windows.Forms.ComboBox cbCategoryFood;
    }
}

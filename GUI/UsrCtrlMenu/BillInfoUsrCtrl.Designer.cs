namespace GUI.UsrCtrlMenu
{
    partial class BillInfoUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillInfoUsrCtrl));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.icBtnTrash = new FontAwesome.Sharp.IconButton();
            this.lbNO = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txbQTY = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnUp = new FontAwesome.Sharp.IconPictureBox();
            this.btnDown = new FontAwesome.Sharp.IconPictureBox();
            this.shadowPanel = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            this.shadowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbName.Location = new System.Drawing.Point(38, 6);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbName.Size = new System.Drawing.Size(212, 39);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Item name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.UseCompatibleTextRendering = true;
            this.lbName.UseMnemonic = false;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPrice.Location = new System.Drawing.Point(38, 32);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbPrice.Size = new System.Drawing.Size(137, 25);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPrice.UseCompatibleTextRendering = true;
            this.lbPrice.UseMnemonic = false;
            // 
            // icBtnTrash
            // 
            this.icBtnTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icBtnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icBtnTrash.FlatAppearance.BorderSize = 0;
            this.icBtnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnTrash.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.icBtnTrash.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icBtnTrash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnTrash.IconSize = 20;
            this.icBtnTrash.Location = new System.Drawing.Point(575, 9);
            this.icBtnTrash.Name = "icBtnTrash";
            this.icBtnTrash.Size = new System.Drawing.Size(40, 44);
            this.icBtnTrash.TabIndex = 8;
            this.icBtnTrash.UseVisualStyleBackColor = true;
            this.icBtnTrash.Click += new System.EventHandler(this.icBtnTrash_Click);
            // 
            // lbNO
            // 
            this.lbNO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNO.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbNO.Location = new System.Drawing.Point(4, 6);
            this.lbNO.Name = "lbNO";
            this.lbNO.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbNO.Size = new System.Drawing.Size(36, 52);
            this.lbNO.TabIndex = 0;
            this.lbNO.Text = "1";
            this.lbNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNO.UseCompatibleTextRendering = true;
            this.lbNO.UseMnemonic = false;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTotal.Location = new System.Drawing.Point(444, 6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbTotal.Size = new System.Drawing.Size(125, 49);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "Total";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTotal.UseCompatibleTextRendering = true;
            this.lbTotal.UseMnemonic = false;
            // 
            // txbQTY
            // 
            this.txbQTY.AcceptsReturn = false;
            this.txbQTY.AcceptsTab = false;
            this.txbQTY.AnimationSpeed = 200;
            this.txbQTY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbQTY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbQTY.BackColor = System.Drawing.Color.White;
            this.txbQTY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbQTY.BackgroundImage")));
            this.txbQTY.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbQTY.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbQTY.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbQTY.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbQTY.BorderRadius = 20;
            this.txbQTY.BorderThickness = 2;
            this.txbQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbQTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQTY.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txbQTY.DefaultText = "1";
            this.txbQTY.FillColor = System.Drawing.Color.White;
            this.txbQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbQTY.HideSelection = true;
            this.txbQTY.IconLeft = null;
            this.txbQTY.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQTY.IconPadding = 10;
            this.txbQTY.IconRight = null;
            this.txbQTY.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQTY.Lines = new string[] {
        "1"};
            this.txbQTY.Location = new System.Drawing.Point(264, 10);
            this.txbQTY.MaxLength = 32767;
            this.txbQTY.MinimumSize = new System.Drawing.Size(55, 36);
            this.txbQTY.Modified = false;
            this.txbQTY.Multiline = false;
            this.txbQTY.Name = "txbQTY";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbQTY.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties22.FillColor = System.Drawing.Color.White;
            stateProperties22.ForeColor = System.Drawing.Color.Empty;
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbQTY.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties23.ForeColor = System.Drawing.Color.Transparent;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbQTY.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties24.FillColor = System.Drawing.Color.White;
            stateProperties24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbQTY.OnIdleState = stateProperties24;
            this.txbQTY.PasswordChar = '\0';
            this.txbQTY.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbQTY.PlaceholderText = "";
            this.txbQTY.ReadOnly = false;
            this.txbQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbQTY.SelectedText = "";
            this.txbQTY.SelectionLength = 0;
            this.txbQTY.SelectionStart = 1;
            this.txbQTY.ShortcutsEnabled = true;
            this.txbQTY.Size = new System.Drawing.Size(55, 37);
            this.txbQTY.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbQTY.TabIndex = 9;
            this.txbQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbQTY.TextMarginBottom = 0;
            this.txbQTY.TextMarginLeft = 5;
            this.txbQTY.TextMarginTop = 0;
            this.txbQTY.TextPlaceholder = "";
            this.txbQTY.UseSystemPasswordChar = false;
            this.txbQTY.WordWrap = true;
            this.txbQTY.TextChange += new System.EventHandler(this.txbQTY_TextChange);
            this.txbQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQTY_KeyPress);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.SortUp;
            this.btnUp.IconColor = System.Drawing.Color.White;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 18;
            this.btnUp.Location = new System.Drawing.Point(322, 10);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 18);
            this.btnUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnUp.TabIndex = 10;
            this.btnUp.TabStop = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.SortDown;
            this.btnDown.IconColor = System.Drawing.Color.White;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 18;
            this.btnDown.Location = new System.Drawing.Point(322, 28);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 18);
            this.btnDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDown.TabIndex = 11;
            this.btnDown.TabStop = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // shadowPanel
            // 
            this.shadowPanel.AutoSize = true;
            this.shadowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shadowPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.shadowPanel.Controls.Add(this.lbTotal);
            this.shadowPanel.Controls.Add(this.icBtnTrash);
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.MaximumSize = new System.Drawing.Size(638, 66);
            this.shadowPanel.MinimumSize = new System.Drawing.Size(620, 66);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.PanelColor = System.Drawing.Color.Empty;
            this.shadowPanel.ShadowDept = 2;
            this.shadowPanel.ShadowTopLeftVisible = false;
            this.shadowPanel.Size = new System.Drawing.Size(638, 66);
            this.shadowPanel.TabIndex = 12;
            // 
            // BillInfoUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txbQTY);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNO);
            this.Controls.Add(this.shadowPanel);
            this.MaximumSize = new System.Drawing.Size(638, 66);
            this.MinimumSize = new System.Drawing.Size(620, 66);
            this.Name = "BillInfoUsrCtrl";
            this.Size = new System.Drawing.Size(638, 66);
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            this.shadowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private FontAwesome.Sharp.IconButton icBtnTrash;
        private System.Windows.Forms.Label lbNO;
        private System.Windows.Forms.Label lbTotal;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbQTY;
        private FontAwesome.Sharp.IconPictureBox btnUp;
        private FontAwesome.Sharp.IconPictureBox btnDown;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel shadowPanel;
    }
}

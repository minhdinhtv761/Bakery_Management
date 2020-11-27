namespace GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txbID = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManager = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCashier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.elipseBtnManager = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnCashier = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 229);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 2);
            this.panel3.TabIndex = 25;
            // 
            // txbPass
            // 
            this.txbPass.AcceptsReturn = false;
            this.txbPass.AcceptsTab = false;
            this.txbPass.AnimationSpeed = 200;
            this.txbPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbPass.BackColor = System.Drawing.Color.Transparent;
            this.txbPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbPass.BackgroundImage")));
            this.txbPass.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPass.BorderRadius = 25;
            this.txbPass.BorderThickness = 1;
            this.txbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPass.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.DefaultText = "";
            this.txbPass.FillColor = System.Drawing.Color.White;
            this.txbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPass.HideSelection = true;
            this.txbPass.IconLeft = null;
            this.txbPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPass.IconPadding = 10;
            this.txbPass.IconRight = null;
            this.txbPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPass.Lines = new string[0];
            this.txbPass.Location = new System.Drawing.Point(35, 146);
            this.txbPass.MaxLength = 32767;
            this.txbPass.MinimumSize = new System.Drawing.Size(100, 35);
            this.txbPass.Modified = false;
            this.txbPass.Multiline = false;
            this.txbPass.Name = "txbPass";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbPass.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbPass.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbPass.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbPass.OnIdleState = stateProperties12;
            this.txbPass.PasswordChar = '●';
            this.txbPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbPass.PlaceholderText = "password";
            this.txbPass.ReadOnly = false;
            this.txbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPass.SelectedText = "";
            this.txbPass.SelectionLength = 0;
            this.txbPass.SelectionStart = 0;
            this.txbPass.ShortcutsEnabled = true;
            this.txbPass.Size = new System.Drawing.Size(362, 35);
            this.txbPass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbPass.TabIndex = 24;
            this.txbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPass.TextMarginBottom = 0;
            this.txbPass.TextMarginLeft = 5;
            this.txbPass.TextMarginTop = 0;
            this.txbPass.TextPlaceholder = "password";
            this.txbPass.UseSystemPasswordChar = true;
            this.txbPass.WordWrap = true;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(43, 124);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(88, 19);
            this.lbPass.TabIndex = 23;
            this.lbPass.Text = "Password";
            // 
            // txbID
            // 
            this.txbID.AcceptsReturn = false;
            this.txbID.AcceptsTab = false;
            this.txbID.AnimationSpeed = 200;
            this.txbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbID.BackColor = System.Drawing.Color.Transparent;
            this.txbID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbID.BackgroundImage")));
            this.txbID.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbID.BorderRadius = 25;
            this.txbID.BorderThickness = 1;
            this.txbID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.DefaultText = "";
            this.txbID.FillColor = System.Drawing.Color.White;
            this.txbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbID.HideSelection = true;
            this.txbID.IconLeft = null;
            this.txbID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.IconPadding = 10;
            this.txbID.IconRight = null;
            this.txbID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.Lines = new string[0];
            this.txbID.Location = new System.Drawing.Point(35, 61);
            this.txbID.MaxLength = 32767;
            this.txbID.MinimumSize = new System.Drawing.Size(100, 35);
            this.txbID.Modified = false;
            this.txbID.Multiline = false;
            this.txbID.Name = "txbID";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbID.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbID.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbID.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbID.OnIdleState = stateProperties16;
            this.txbID.PasswordChar = '\0';
            this.txbID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbID.PlaceholderText = "Enter your ID";
            this.txbID.ReadOnly = false;
            this.txbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbID.SelectedText = "";
            this.txbID.SelectionLength = 0;
            this.txbID.SelectionStart = 0;
            this.txbID.ShortcutsEnabled = true;
            this.txbID.Size = new System.Drawing.Size(362, 37);
            this.txbID.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbID.TabIndex = 22;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbID.TextMarginBottom = 0;
            this.txbID.TextMarginLeft = 5;
            this.txbID.TextMarginTop = 0;
            this.txbID.TextPlaceholder = "Enter your ID";
            this.txbID.UseSystemPasswordChar = false;
            this.txbID.WordWrap = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(43, 39);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(96, 19);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "User name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnManager);
            this.panel2.Controls.Add(this.btnCashier);
            this.panel2.Location = new System.Drawing.Point(0, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 54);
            this.panel2.TabIndex = 9;
            // 
            // btnManager
            // 
            this.btnManager.Active = true;
            this.btnManager.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManager.BorderRadius = 0;
            this.btnManager.ButtonText = "  Manager";
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.DisabledColor = System.Drawing.Color.Transparent;
            this.btnManager.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnManager.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManager.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManager.Iconimage")));
            this.btnManager.Iconimage_right = null;
            this.btnManager.Iconimage_right_Selected = null;
            this.btnManager.Iconimage_Selected = null;
            this.btnManager.IconMarginLeft = 0;
            this.btnManager.IconMarginRight = 0;
            this.btnManager.IconRightVisible = true;
            this.btnManager.IconRightZoom = 0D;
            this.btnManager.IconVisible = true;
            this.btnManager.IconZoom = 50D;
            this.btnManager.IsTab = false;
            this.btnManager.Location = new System.Drawing.Point(209, 1);
            this.btnManager.Margin = new System.Windows.Forms.Padding(1);
            this.btnManager.Name = "btnManager";
            this.btnManager.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnManager.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnManager.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManager.selected = true;
            this.btnManager.Size = new System.Drawing.Size(141, 50);
            this.btnManager.TabIndex = 5;
            this.btnManager.Text = "  Manager";
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.Textcolor = System.Drawing.Color.White;
            this.btnManager.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Active = true;
            this.btnCashier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCashier.BorderRadius = 0;
            this.btnCashier.ButtonText = "  Cashier";
            this.btnCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashier.DisabledColor = System.Drawing.Color.Transparent;
            this.btnCashier.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCashier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCashier.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCashier.Iconimage")));
            this.btnCashier.Iconimage_right = null;
            this.btnCashier.Iconimage_right_Selected = null;
            this.btnCashier.Iconimage_Selected = null;
            this.btnCashier.IconMarginLeft = 0;
            this.btnCashier.IconMarginRight = 0;
            this.btnCashier.IconRightVisible = true;
            this.btnCashier.IconRightZoom = 0D;
            this.btnCashier.IconVisible = true;
            this.btnCashier.IconZoom = 60D;
            this.btnCashier.IsTab = false;
            this.btnCashier.Location = new System.Drawing.Point(66, 1);
            this.btnCashier.Margin = new System.Windows.Forms.Padding(1);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCashier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnCashier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCashier.selected = true;
            this.btnCashier.Size = new System.Drawing.Size(141, 50);
            this.btnCashier.TabIndex = 4;
            this.btnCashier.Text = "  Cashier";
            this.btnCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.Textcolor = System.Drawing.Color.White;
            this.btnCashier.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // elipseBtnManager
            // 
            this.elipseBtnManager.ElipseRadius = 20;
            this.elipseBtnManager.TargetControl = this.btnManager;
            // 
            // elipseBtnCashier
            // 
            this.elipseBtnCashier.ElipseRadius = 20;
            this.elipseBtnCashier.TargetControl = this.btnCashier;
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(386, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 11;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(424, 456);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(424, 456);
            this.MinimumSize = new System.Drawing.Size(424, 456);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUser;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbPass;
        private System.Windows.Forms.Label lbPass;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbID;
        private Bunifu.Framework.UI.BunifuFlatButton btnManager;
        private Bunifu.Framework.UI.BunifuFlatButton btnCashier;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnManager;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnCashier;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
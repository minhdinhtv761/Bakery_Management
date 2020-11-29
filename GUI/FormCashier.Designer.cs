namespace GUI
{
    partial class FormCashier
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
            System.Windows.Forms.Label lbName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashier));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.ToggleSwitch.ToggleState toggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuDrop = new System.Windows.Forms.Panel();
            this.menuSignOut = new FontAwesome.Sharp.IconButton();
            this.menuManage = new FontAwesome.Sharp.IconButton();
            this.menuInfo = new FontAwesome.Sharp.IconButton();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.MENU = new GUI.UsrCtrlMenu.MenuUsrCtrl();
            this.TABLE = new GUI.UsrCtrlMenu.TableUsrCtrl();
            this.pnRight = new System.Windows.Forms.Panel();
            this.layoutListBill = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPayment = new System.Windows.Forms.Panel();
            this.picName = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTextTotal = new System.Windows.Forms.Label();
            this.pnList = new System.Windows.Forms.Panel();
            this.icTable = new FontAwesome.Sharp.IconPictureBox();
            this.lbTableID = new System.Windows.Forms.Label();
            this.txbSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbTakeAway = new System.Windows.Forms.Label();
            this.toggleTakeAway = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.pnPaymentInfo = new System.Windows.Forms.Panel();
            this.txbSale = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbItems = new System.Windows.Forms.Label();
            this.lbTextNumQTY = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbTextSale = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbTextSutotal = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.more = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.elipsePnRight = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnTable = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnPay = new Bunifu.Framework.UI.BunifuElipse(this.components);
            lbName = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.menuDrop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icTable)).BeginInit();
            this.pnPaymentInfo.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.more)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbName.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbName.Location = new System.Drawing.Point(44, 8);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(191, 32);
            lbName.TabIndex = 5;
            lbName.Text = "Your name";
            lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.menuDrop);
            this.pnMain.Controls.Add(this.pnLeft);
            this.pnMain.Controls.Add(this.pnRight);
            this.pnMain.Controls.Add(this.pnHeader);
            this.pnMain.Location = new System.Drawing.Point(24, 0);
            this.pnMain.MaximumSize = new System.Drawing.Size(1318, 767);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1318, 589);
            this.pnMain.TabIndex = 0;
            // 
            // menuDrop
            // 
            this.menuDrop.BackColor = System.Drawing.Color.White;
            this.menuDrop.Controls.Add(this.menuSignOut);
            this.menuDrop.Controls.Add(this.menuManage);
            this.menuDrop.Controls.Add(this.menuInfo);
            this.menuDrop.ForeColor = System.Drawing.SystemColors.Control;
            this.menuDrop.Location = new System.Drawing.Point(1105, 27);
            this.menuDrop.Name = "menuDrop";
            this.menuDrop.Size = new System.Drawing.Size(124, 107);
            this.menuDrop.TabIndex = 11;
            this.menuDrop.Visible = false;
            // 
            // menuSignOut
            // 
            this.menuSignOut.BackColor = System.Drawing.Color.Transparent;
            this.menuSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSignOut.FlatAppearance.BorderSize = 0;
            this.menuSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.menuSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSignOut.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.menuSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.menuSignOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.menuSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSignOut.IconSize = 20;
            this.menuSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSignOut.Location = new System.Drawing.Point(0, 70);
            this.menuSignOut.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.menuSignOut.Name = "menuSignOut";
            this.menuSignOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuSignOut.Size = new System.Drawing.Size(124, 35);
            this.menuSignOut.TabIndex = 2;
            this.menuSignOut.Text = "Sign out";
            this.menuSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuSignOut.UseMnemonic = false;
            this.menuSignOut.UseVisualStyleBackColor = false;
            this.menuSignOut.Click += new System.EventHandler(this.menuSignOut_Click);
            // 
            // menuManage
            // 
            this.menuManage.BackColor = System.Drawing.Color.Transparent;
            this.menuManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuManage.FlatAppearance.BorderSize = 0;
            this.menuManage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.menuManage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuManage.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.menuManage.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.menuManage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.menuManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuManage.IconSize = 20;
            this.menuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuManage.Location = new System.Drawing.Point(0, 35);
            this.menuManage.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.menuManage.Name = "menuManage";
            this.menuManage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuManage.Size = new System.Drawing.Size(124, 35);
            this.menuManage.TabIndex = 1;
            this.menuManage.Text = "Manage";
            this.menuManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuManage.UseVisualStyleBackColor = false;
            this.menuManage.Click += new System.EventHandler(this.menuManage_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.BackColor = System.Drawing.Color.Transparent;
            this.menuInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuInfo.FlatAppearance.BorderSize = 0;
            this.menuInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.menuInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.menuInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuInfo.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.menuInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.menuInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInfo.IconSize = 20;
            this.menuInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuInfo.Location = new System.Drawing.Point(0, 0);
            this.menuInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuInfo.Size = new System.Drawing.Size(124, 35);
            this.menuInfo.TabIndex = 0;
            this.menuInfo.Text = "Infomation";
            this.menuInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menuInfo.UseVisualStyleBackColor = false;
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnLeft.Controls.Add(this.MENU);
            this.pnLeft.Controls.Add(this.TABLE);
            this.pnLeft.Location = new System.Drawing.Point(0, 45);
            this.pnLeft.MaximumSize = new System.Drawing.Size(644, 731);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(644, 544);
            this.pnLeft.TabIndex = 1;
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.MENU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.MaximumSize = new System.Drawing.Size(644, 731);
            this.MENU.MinimumSize = new System.Drawing.Size(644, 544);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(644, 544);
            this.MENU.TabIndex = 1;
            // 
            // TABLE
            // 
            this.TABLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABLE.Location = new System.Drawing.Point(0, 0);
            this.TABLE.MaximumSize = new System.Drawing.Size(644, 731);
            this.TABLE.Name = "TABLE";
            this.TABLE.Size = new System.Drawing.Size(644, 544);
            this.TABLE.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.Controls.Add(this.layoutListBill);
            this.pnRight.Controls.Add(this.pnPayment);
            this.pnRight.Controls.Add(this.pnList);
            this.pnRight.Controls.Add(this.pnPaymentInfo);
            this.pnRight.Location = new System.Drawing.Point(674, 45);
            this.pnRight.MaximumSize = new System.Drawing.Size(644, 731);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(644, 544);
            this.pnRight.TabIndex = 2;
            // 
            // layoutListBill
            // 
            this.layoutListBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.layoutListBill.AutoScroll = true;
            this.layoutListBill.BackColor = System.Drawing.SystemColors.Control;
            this.layoutListBill.Location = new System.Drawing.Point(0, 52);
            this.layoutListBill.MaximumSize = new System.Drawing.Size(644, 684);
            this.layoutListBill.Name = "layoutListBill";
            this.layoutListBill.Size = new System.Drawing.Size(644, 363);
            this.layoutListBill.TabIndex = 5;
            // 
            // pnPayment
            // 
            this.pnPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnPayment.BackColor = System.Drawing.Color.White;
            this.pnPayment.Controls.Add(lbName);
            this.pnPayment.Controls.Add(this.picName);
            this.pnPayment.Controls.Add(this.btnPay);
            this.pnPayment.Controls.Add(this.lbTotal);
            this.pnPayment.Controls.Add(this.lbTextTotal);
            this.pnPayment.Location = new System.Drawing.Point(0, 480);
            this.pnPayment.Name = "pnPayment";
            this.pnPayment.Size = new System.Drawing.Size(644, 65);
            this.pnPayment.TabIndex = 7;
            // 
            // picName
            // 
            this.picName.AllowFocused = false;
            this.picName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picName.BorderRadius = 0;
            this.picName.Image = ((System.Drawing.Image)(resources.GetObject("picName.Image")));
            this.picName.IsCircle = false;
            this.picName.Location = new System.Drawing.Point(6, 8);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(32, 32);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picName.TabIndex = 4;
            this.picName.TabStop = false;
            this.picName.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // btnPay
            // 
            this.btnPay.Active = true;
            this.btnPay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPay.BorderRadius = 0;
            this.btnPay.ButtonText = "PAY";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledColor = System.Drawing.Color.Transparent;
            this.btnPay.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPay.Iconimage")));
            this.btnPay.Iconimage_right = null;
            this.btnPay.Iconimage_right_Selected = null;
            this.btnPay.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnPay.Iconimage_Selected")));
            this.btnPay.IconMarginLeft = 60;
            this.btnPay.IconMarginRight = 0;
            this.btnPay.IconRightVisible = true;
            this.btnPay.IconRightZoom = 0D;
            this.btnPay.IconVisible = true;
            this.btnPay.IconZoom = 60D;
            this.btnPay.IsTab = false;
            this.btnPay.Location = new System.Drawing.Point(419, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnPay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnPay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPay.selected = true;
            this.btnPay.Size = new System.Drawing.Size(223, 59);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "PAY";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Textcolor = System.Drawing.Color.White;
            this.btnPay.TextFont = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotal.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTotal.Location = new System.Drawing.Point(263, 29);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(134, 35);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextTotal
            // 
            this.lbTextTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextTotal.AutoSize = true;
            this.lbTextTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextTotal.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTextTotal.Location = new System.Drawing.Point(292, 4);
            this.lbTextTotal.Name = "lbTextTotal";
            this.lbTextTotal.Size = new System.Drawing.Size(76, 25);
            this.lbTextTotal.TabIndex = 2;
            this.lbTextTotal.Text = "TOTAL";
            this.lbTextTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnList
            // 
            this.pnList.BackColor = System.Drawing.Color.Transparent;
            this.pnList.Controls.Add(this.icTable);
            this.pnList.Controls.Add(this.lbTableID);
            this.pnList.Controls.Add(this.txbSearch);
            this.pnList.Controls.Add(this.lbTakeAway);
            this.pnList.Controls.Add(this.toggleTakeAway);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 0);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(644, 51);
            this.pnList.TabIndex = 1;
            // 
            // icTable
            // 
            this.icTable.BackColor = System.Drawing.Color.White;
            this.icTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.icTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icTable.IconSize = 25;
            this.icTable.Location = new System.Drawing.Point(18, 15);
            this.icTable.Name = "icTable";
            this.icTable.Size = new System.Drawing.Size(25, 25);
            this.icTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icTable.TabIndex = 22;
            this.icTable.TabStop = false;
            // 
            // lbTableID
            // 
            this.lbTableID.AutoSize = true;
            this.lbTableID.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lbTableID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTableID.Location = new System.Drawing.Point(49, 19);
            this.lbTableID.Name = "lbTableID";
            this.lbTableID.Size = new System.Drawing.Size(58, 14);
            this.lbTableID.TabIndex = 21;
            this.lbTableID.Text = "Table ID";
            // 
            // txbSearch
            // 
            this.txbSearch.AcceptsReturn = false;
            this.txbSearch.AcceptsTab = false;
            this.txbSearch.AnimationSpeed = 200;
            this.txbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbSearch.BackColor = System.Drawing.Color.Transparent;
            this.txbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbSearch.BackgroundImage")));
            this.txbSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.BorderRadius = 25;
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.DefaultText = "";
            this.txbSearch.FillColor = System.Drawing.Color.White;
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSearch.HideSelection = true;
            this.txbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSearch.IconLeft")));
            this.txbSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.IconPadding = 10;
            this.txbSearch.IconRight = null;
            this.txbSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Lines = new string[0];
            this.txbSearch.Location = new System.Drawing.Point(432, 11);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txbSearch.Modified = false;
            this.txbSearch.Multiline = false;
            this.txbSearch.Name = "txbSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnIdleState = stateProperties4;
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSearch.PlaceholderText = "Enter your foods";
            this.txbSearch.ReadOnly = false;
            this.txbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSearch.SelectedText = "";
            this.txbSearch.SelectionLength = 0;
            this.txbSearch.SelectionStart = 0;
            this.txbSearch.ShortcutsEnabled = true;
            this.txbSearch.Size = new System.Drawing.Size(200, 35);
            this.txbSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbSearch.TabIndex = 20;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.TextMarginBottom = 0;
            this.txbSearch.TextMarginLeft = 5;
            this.txbSearch.TextMarginTop = 0;
            this.txbSearch.TextPlaceholder = "Enter your foods";
            this.txbSearch.UseSystemPasswordChar = false;
            this.txbSearch.WordWrap = true;
            // 
            // lbTakeAway
            // 
            this.lbTakeAway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTakeAway.AutoSize = true;
            this.lbTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTakeAway.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTakeAway.Location = new System.Drawing.Point(168, 19);
            this.lbTakeAway.Name = "lbTakeAway";
            this.lbTakeAway.Size = new System.Drawing.Size(73, 14);
            this.lbTakeAway.TabIndex = 19;
            this.lbTakeAway.Text = "Take away";
            this.lbTakeAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggleTakeAway
            // 
            this.toggleTakeAway.Animation = 5;
            this.toggleTakeAway.BackColor = System.Drawing.Color.Transparent;
            this.toggleTakeAway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleTakeAway.BackgroundImage")));
            this.toggleTakeAway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleTakeAway.Location = new System.Drawing.Point(123, 16);
            this.toggleTakeAway.Name = "toggleTakeAway";
            this.toggleTakeAway.Size = new System.Drawing.Size(35, 20);
            this.toggleTakeAway.TabIndex = 0;
            toggleState1.BackColor = System.Drawing.Color.Empty;
            toggleState1.BackColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState1.BorderColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderRadius = 1;
            toggleState1.BorderRadiusInner = 1;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.toggleTakeAway.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.White;
            toggleState2.BackColorInner = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 15;
            toggleState2.BorderThickness = 2;
            toggleState2.BorderThicknessInner = 1;
            this.toggleTakeAway.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            toggleState3.BorderColorInner = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 15;
            toggleState3.BorderThickness = 2;
            toggleState3.BorderThicknessInner = 1;
            this.toggleTakeAway.ToggleStateOn = toggleState3;
            this.toggleTakeAway.Value = false;
            // 
            // pnPaymentInfo
            // 
            this.pnPaymentInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnPaymentInfo.BackColor = System.Drawing.Color.White;
            this.pnPaymentInfo.Controls.Add(this.txbSale);
            this.pnPaymentInfo.Controls.Add(this.lbItems);
            this.pnPaymentInfo.Controls.Add(this.lbTextNumQTY);
            this.pnPaymentInfo.Controls.Add(this.lbPercent);
            this.pnPaymentInfo.Controls.Add(this.lbTextSale);
            this.pnPaymentInfo.Controls.Add(this.lbSubtotal);
            this.pnPaymentInfo.Controls.Add(this.lbTextSutotal);
            this.pnPaymentInfo.Location = new System.Drawing.Point(0, 415);
            this.pnPaymentInfo.Name = "pnPaymentInfo";
            this.pnPaymentInfo.Size = new System.Drawing.Size(644, 65);
            this.pnPaymentInfo.TabIndex = 6;
            // 
            // txbSale
            // 
            this.txbSale.AcceptsReturn = false;
            this.txbSale.AcceptsTab = false;
            this.txbSale.AnimationSpeed = 200;
            this.txbSale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbSale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbSale.BackColor = System.Drawing.Color.White;
            this.txbSale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbSale.BackgroundImage")));
            this.txbSale.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbSale.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.BorderRadius = 20;
            this.txbSale.BorderThickness = 2;
            this.txbSale.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSale.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txbSale.DefaultText = "0";
            this.txbSale.FillColor = System.Drawing.Color.White;
            this.txbSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.txbSale.HideSelection = true;
            this.txbSale.IconLeft = null;
            this.txbSale.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSale.IconPadding = 10;
            this.txbSale.IconRight = null;
            this.txbSale.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSale.Lines = new string[] {
        "0"};
            this.txbSale.Location = new System.Drawing.Point(508, 26);
            this.txbSale.MaxLength = 32767;
            this.txbSale.MinimumSize = new System.Drawing.Size(63, 29);
            this.txbSale.Modified = false;
            this.txbSale.Multiline = false;
            this.txbSale.Name = "txbSale";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSale.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSale.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSale.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSale.OnIdleState = stateProperties8;
            this.txbSale.PasswordChar = '\0';
            this.txbSale.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSale.PlaceholderText = "";
            this.txbSale.ReadOnly = false;
            this.txbSale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSale.SelectedText = "";
            this.txbSale.SelectionLength = 0;
            this.txbSale.SelectionStart = 0;
            this.txbSale.ShortcutsEnabled = true;
            this.txbSale.Size = new System.Drawing.Size(63, 29);
            this.txbSale.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbSale.TabIndex = 13;
            this.txbSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbSale.TextMarginBottom = 0;
            this.txbSale.TextMarginLeft = 5;
            this.txbSale.TextMarginTop = 0;
            this.txbSale.TextPlaceholder = "";
            this.txbSale.UseSystemPasswordChar = false;
            this.txbSale.WordWrap = true;
            this.txbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSale_KeyPress);
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbItems.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbItems.Location = new System.Drawing.Point(251, 8);
            this.lbItems.Name = "lbItems";
            this.lbItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbItems.Size = new System.Drawing.Size(62, 18);
            this.lbItems.TabIndex = 12;
            this.lbItems.Text = "0";
            this.lbItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTextNumQTY
            // 
            this.lbTextNumQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextNumQTY.AutoSize = true;
            this.lbTextNumQTY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextNumQTY.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextNumQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTextNumQTY.Location = new System.Drawing.Point(319, 8);
            this.lbTextNumQTY.Name = "lbTextNumQTY";
            this.lbTextNumQTY.Size = new System.Drawing.Size(46, 18);
            this.lbTextNumQTY.TabIndex = 11;
            this.lbTextNumQTY.Text = "items";
            this.lbTextNumQTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPercent
            // 
            this.lbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercent.AutoSize = true;
            this.lbPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPercent.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.lbPercent.Location = new System.Drawing.Point(576, 34);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(19, 18);
            this.lbPercent.TabIndex = 10;
            this.lbPercent.Text = "%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextSale
            // 
            this.lbTextSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextSale.AutoSize = true;
            this.lbTextSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextSale.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.lbTextSale.Location = new System.Drawing.Point(12, 34);
            this.lbTextSale.Name = "lbTextSale";
            this.lbTextSale.Size = new System.Drawing.Size(60, 18);
            this.lbTextSale.TabIndex = 8;
            this.lbTextSale.Text = "Sale off";
            this.lbTextSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSubtotal.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbSubtotal.Location = new System.Drawing.Point(495, 8);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(92, 18);
            this.lbSubtotal.TabIndex = 7;
            this.lbSubtotal.Text = "Subtotal";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTextSutotal
            // 
            this.lbTextSutotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTextSutotal.AutoSize = true;
            this.lbTextSutotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTextSutotal.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextSutotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTextSutotal.Location = new System.Drawing.Point(12, 8);
            this.lbTextSutotal.Name = "lbTextSutotal";
            this.lbTextSutotal.Size = new System.Drawing.Size(63, 18);
            this.lbTextSutotal.TabIndex = 6;
            this.lbTextSutotal.Text = "Subtotal";
            this.lbTextSutotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnHeader
            // 
            this.pnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.Controls.Add(this.more);
            this.pnHeader.Controls.Add(this.minimize);
            this.pnHeader.Controls.Add(this.close);
            this.pnHeader.Controls.Add(this.btnMenu);
            this.pnHeader.Controls.Add(this.btnTable);
            this.pnHeader.Location = new System.Drawing.Point(0, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1318, 41);
            this.pnHeader.TabIndex = 0;
            // 
            // more
            // 
            this.more.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.more.Image = ((System.Drawing.Image)(resources.GetObject("more.Image")));
            this.more.ImageActive = null;
            this.more.Location = new System.Drawing.Point(1205, 0);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(38, 24);
            this.more.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.more.TabIndex = 11;
            this.more.TabStop = false;
            this.more.Zoom = 10;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1242, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(38, 24);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 10;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1280, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 9;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnMenu.IconColor = System.Drawing.SystemColors.Control;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 17;
            this.btnMenu.Location = new System.Drawing.Point(107, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(92, 42);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "MENU";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTable.IconColor = System.Drawing.SystemColors.Control;
            this.btnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTable.IconSize = 17;
            this.btnTable.Location = new System.Drawing.Point(12, 4);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(92, 42);
            this.btnTable.TabIndex = 7;
            this.btnTable.Text = "TABLE";
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // elipsePnRight
            // 
            this.elipsePnRight.ElipseRadius = 30;
            this.elipsePnRight.TargetControl = this.pnRight;
            // 
            // elipseBtnMenu
            // 
            this.elipseBtnMenu.ElipseRadius = 15;
            this.elipseBtnMenu.TargetControl = this.btnMenu;
            // 
            // elipseBtnTable
            // 
            this.elipseBtnTable.ElipseRadius = 15;
            this.elipseBtnTable.TargetControl = this.btnTable;
            // 
            // elipseBtnPay
            // 
            this.elipseBtnPay.ElipseRadius = 30;
            this.elipseBtnPay.TargetControl = this.btnPay;
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1366, 625);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 625);
            this.MinimumSize = new System.Drawing.Size(1364, 625);
            this.Name = "FormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnMain.ResumeLayout(false);
            this.menuDrop.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnPayment.ResumeLayout(false);
            this.pnPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            this.pnList.ResumeLayout(false);
            this.pnList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icTable)).EndInit();
            this.pnPaymentInfo.ResumeLayout(false);
            this.pnPaymentInfo.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.more)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnHeader;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnTable;
        private System.Windows.Forms.Panel pnList;
        private Bunifu.Framework.UI.BunifuElipse elipsePnRight;
        private System.Windows.Forms.Panel pnPayment;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTextTotal;
        private System.Windows.Forms.FlowLayoutPanel layoutListBill;
        private System.Windows.Forms.Panel pnPaymentInfo;
        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.Label lbTextNumQTY;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label lbTextSale;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbTextSutotal;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch toggleTakeAway;
        private System.Windows.Forms.Label lbTakeAway;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnMenu;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnTable;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbSale;
        private UsrCtrlMenu.TableUsrCtrl TABLE;
        private UsrCtrlMenu.MenuUsrCtrl MENU;
        private Bunifu.Framework.UI.BunifuFlatButton btnPay;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnPay;
        private Bunifu.UI.WinForms.BunifuPictureBox picName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbSearch;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Panel menuDrop;
        private FontAwesome.Sharp.IconButton menuInfo;
        private FontAwesome.Sharp.IconButton menuSignOut;
        private FontAwesome.Sharp.IconButton menuManage;
        private Bunifu.Framework.UI.BunifuImageButton more;
        private FontAwesome.Sharp.IconPictureBox icTable;
        private System.Windows.Forms.Label lbTableID;
    }
}


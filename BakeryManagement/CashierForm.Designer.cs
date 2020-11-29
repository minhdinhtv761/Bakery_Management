namespace BakeryManagement
{
    partial class CashierForm
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.ctrMini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.ctrlMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelInfoBill = new System.Windows.Forms.Panel();
            this.icSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnTableInfo = new FontAwesome.Sharp.IconButton();
            this.pnTopBottom = new System.Windows.Forms.Panel();
            this.tgbTakeAway = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbTakeAway = new System.Windows.Forms.Label();
            this.txbSearching = new JMaterialTextbox.JMaterialTextbox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnPay = new FontAwesome.Sharp.IconButton();
            this.panelLeftBottom = new System.Windows.Forms.Panel();
            this.btnNote = new FontAwesome.Sharp.IconButton();
            this.lbCustumers = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.txbSaleOff = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSaleOff = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.layoutPanelBill = new System.Windows.Forms.FlowLayoutPanel();
            this.billInfoUsrCtrl1 = new BakeryManagement.UserControls.BillInfoUsrCtrl();
            this.pnLeft = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelControl.SuspendLayout();
            this.panelInfoBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icSearch)).BeginInit();
            this.pnRight.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.panelLeftBottom.SuspendLayout();
            this.layoutPanelBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.ctrMini);
            this.panelControl.Controls.Add(this.btnMenu);
            this.panelControl.Controls.Add(this.btnTable);
            this.panelControl.Controls.Add(this.ctrlMax);
            this.panelControl.Controls.Add(this.ctrlClose);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1308, 62);
            this.panelControl.TabIndex = 4;
            // 
            // ctrMini
            // 
            this.ctrMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrMini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrMini.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.ctrMini.HoverState.Parent = this.ctrMini;
            this.ctrMini.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ctrMini.Location = new System.Drawing.Point(1226, 3);
            this.ctrMini.Name = "ctrMini";
            this.ctrMini.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ctrMini.ShadowDecoration.Parent = this.ctrMini;
            this.ctrMini.Size = new System.Drawing.Size(30, 40);
            this.ctrMini.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnMenu.IconSize = 16;
            this.btnMenu.Location = new System.Drawing.Point(96, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(86, 62);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTable
            // 
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTable.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnTable.IconSize = 20;
            this.btnTable.Location = new System.Drawing.Point(10, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Rotation = 0D;
            this.btnTable.Size = new System.Drawing.Size(86, 62);
            this.btnTable.TabIndex = 4;
            this.btnTable.Text = "Table";
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // ctrlMax
            // 
            this.ctrlMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrlMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.ctrlMax.HoverState.Parent = this.ctrlMax;
            this.ctrlMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ctrlMax.Location = new System.Drawing.Point(1254, 3);
            this.ctrlMax.Name = "ctrlMax";
            this.ctrlMax.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ctrlMax.ShadowDecoration.Parent = this.ctrlMax;
            this.ctrlMax.Size = new System.Drawing.Size(30, 40);
            this.ctrlMax.TabIndex = 2;
            // 
            // ctrlClose
            // 
            this.ctrlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.ctrlClose.HoverState.Parent = this.ctrlClose;
            this.ctrlClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ctrlClose.Location = new System.Drawing.Point(1278, 3);
            this.ctrlClose.Name = "ctrlClose";
            this.ctrlClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ctrlClose.ShadowDecoration.Parent = this.ctrlClose;
            this.ctrlClose.Size = new System.Drawing.Size(30, 40);
            this.ctrlClose.TabIndex = 0;
            this.ctrlClose.Click += new System.EventHandler(this.boxClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 733);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1308, 35);
            this.panelBottom.TabIndex = 5;
            // 
            // panelInfoBill
            // 
            this.panelInfoBill.Controls.Add(this.icSearch);
            this.panelInfoBill.Controls.Add(this.btnTableInfo);
            this.panelInfoBill.Controls.Add(this.pnTopBottom);
            this.panelInfoBill.Controls.Add(this.tgbTakeAway);
            this.panelInfoBill.Controls.Add(this.lbTakeAway);
            this.panelInfoBill.Controls.Add(this.txbSearching);
            this.panelInfoBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoBill.Location = new System.Drawing.Point(0, 0);
            this.panelInfoBill.Name = "panelInfoBill";
            this.panelInfoBill.Size = new System.Drawing.Size(600, 58);
            this.panelInfoBill.TabIndex = 1;
            // 
            // icSearch
            // 
            this.icSearch.BackColor = System.Drawing.SystemColors.Control;
            this.icSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.icSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icSearch.IconSize = 26;
            this.icSearch.Location = new System.Drawing.Point(372, 15);
            this.icSearch.Name = "icSearch";
            this.icSearch.Size = new System.Drawing.Size(30, 26);
            this.icSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icSearch.TabIndex = 23;
            this.icSearch.TabStop = false;
            // 
            // btnTableInfo
            // 
            this.btnTableInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.btnTableInfo.FlatAppearance.BorderSize = 0;
            this.btnTableInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnTableInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnTableInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTableInfo.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnTableInfo.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTableInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnTableInfo.IconSize = 20;
            this.btnTableInfo.Location = new System.Drawing.Point(3, 7);
            this.btnTableInfo.Name = "btnTableInfo";
            this.btnTableInfo.Rotation = 0D;
            this.btnTableInfo.Size = new System.Drawing.Size(78, 42);
            this.btnTableInfo.TabIndex = 20;
            this.btnTableInfo.Text = "TB-01";
            this.btnTableInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTableInfo.UseVisualStyleBackColor = true;
            // 
            // pnTopBottom
            // 
            this.pnTopBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnTopBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTopBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnTopBottom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnTopBottom.Location = new System.Drawing.Point(0, 57);
            this.pnTopBottom.Name = "pnTopBottom";
            this.pnTopBottom.Size = new System.Drawing.Size(600, 1);
            this.pnTopBottom.TabIndex = 19;
            // 
            // tgbTakeAway
            // 
            this.tgbTakeAway.CheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.tgbTakeAway.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tgbTakeAway.CheckedState.InnerBorderColor = System.Drawing.Color.Transparent;
            this.tgbTakeAway.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgbTakeAway.CheckedState.Parent = this.tgbTakeAway;
            this.tgbTakeAway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgbTakeAway.Location = new System.Drawing.Point(102, 20);
            this.tgbTakeAway.Name = "tgbTakeAway";
            this.tgbTakeAway.ShadowDecoration.Parent = this.tgbTakeAway;
            this.tgbTakeAway.Size = new System.Drawing.Size(35, 20);
            this.tgbTakeAway.TabIndex = 18;
            this.tgbTakeAway.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tgbTakeAway.UncheckedState.BorderThickness = 2;
            this.tgbTakeAway.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.tgbTakeAway.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tgbTakeAway.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tgbTakeAway.UncheckedState.Parent = this.tgbTakeAway;
            // 
            // lbTakeAway
            // 
            this.lbTakeAway.AutoSize = true;
            this.lbTakeAway.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTakeAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbTakeAway.Location = new System.Drawing.Point(143, 20);
            this.lbTakeAway.Name = "lbTakeAway";
            this.lbTakeAway.Size = new System.Drawing.Size(74, 20);
            this.lbTakeAway.TabIndex = 17;
            this.lbTakeAway.Text = "Take away";
            // 
            // txbSearching
            // 
            this.txbSearching.BackColor = System.Drawing.Color.Transparent;
            this.txbSearching.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearching.Font_Size = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearching.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.HintText = "Please enter your food...";
            this.txbSearching.IsPassword = false;
            this.txbSearching.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.LineThickness = 2;
            this.txbSearching.Location = new System.Drawing.Point(394, 15);
            this.txbSearching.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSearching.MaxLength = 32767;
            this.txbSearching.Name = "txbSearching";
            this.txbSearching.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.ReadOnly = false;
            this.txbSearching.Size = new System.Drawing.Size(201, 25);
            this.txbSearching.TabIndex = 12;
            this.txbSearching.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearching.TextName = "Please enter your food...";
            // 
            // pnRight
            // 
            this.pnRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRight.AutoSize = true;
            this.pnRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnRight.Controls.Add(this.panelPayment);
            this.pnRight.Controls.Add(this.panelLeftBottom);
            this.pnRight.Controls.Add(this.layoutPanelBill);
            this.pnRight.Controls.Add(this.panelInfoBill);
            this.pnRight.Location = new System.Drawing.Point(691, 60);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(600, 675);
            this.pnRight.TabIndex = 3;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelPayment.Controls.Add(this.lbMoney);
            this.panelPayment.Controls.Add(this.lbTotal);
            this.panelPayment.Controls.Add(this.btnPay);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayment.Location = new System.Drawing.Point(0, 606);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(600, 69);
            this.panelPayment.TabIndex = 5;
            // 
            // lbMoney
            // 
            this.lbMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Source Serif Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.lbMoney.Location = new System.Drawing.Point(341, 31);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(87, 33);
            this.lbMoney.TabIndex = 30;
            this.lbMoney.Text = "15,000";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.lbTotal.Location = new System.Drawing.Point(354, 9);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(60, 22);
            this.lbTotal.TabIndex = 29;
            this.lbTotal.Text = "TOTAL";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPay.FlatAppearance.BorderSize = 2;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnPay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPay.Font = new System.Drawing.Font("Source Serif Pro Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPay.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnPay.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnPay.IconSize = 30;
            this.btnPay.Location = new System.Drawing.Point(430, 0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Rotation = 0D;
            this.btnPay.Size = new System.Drawing.Size(170, 69);
            this.btnPay.TabIndex = 28;
            this.btnPay.Text = "PAY";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // panelLeftBottom
            // 
            this.panelLeftBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.panelLeftBottom.Controls.Add(this.btnNote);
            this.panelLeftBottom.Controls.Add(this.lbCustumers);
            this.panelLeftBottom.Controls.Add(this.lbNumber);
            this.panelLeftBottom.Controls.Add(this.lbPercent);
            this.panelLeftBottom.Controls.Add(this.txbSaleOff);
            this.panelLeftBottom.Controls.Add(this.lbSaleOff);
            this.panelLeftBottom.Controls.Add(this.lbPrice);
            this.panelLeftBottom.Controls.Add(this.lbSubtotal);
            this.panelLeftBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftBottom.Location = new System.Drawing.Point(0, 532);
            this.panelLeftBottom.Name = "panelLeftBottom";
            this.panelLeftBottom.Size = new System.Drawing.Size(600, 74);
            this.panelLeftBottom.TabIndex = 4;
            // 
            // btnNote
            // 
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnNote.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNote.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnNote.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnNote.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnNote.IconSize = 20;
            this.btnNote.Location = new System.Drawing.Point(15, 26);
            this.btnNote.Name = "btnNote";
            this.btnNote.Rotation = 0D;
            this.btnNote.Size = new System.Drawing.Size(78, 42);
            this.btnNote.TabIndex = 27;
            this.btnNote.Text = "Note";
            this.btnNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // lbCustumers
            // 
            this.lbCustumers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustumers.AutoSize = true;
            this.lbCustumers.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustumers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbCustumers.Location = new System.Drawing.Point(21, 8);
            this.lbCustumers.Name = "lbCustumers";
            this.lbCustumers.Size = new System.Drawing.Size(85, 21);
            this.lbCustumers.TabIndex = 24;
            this.lbCustumers.Text = "Custumers";
            // 
            // lbNumber
            // 
            this.lbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbNumber.Location = new System.Drawing.Point(451, 8);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(18, 21);
            this.lbNumber.TabIndex = 23;
            this.lbNumber.Text = "1";
            // 
            // lbPercent
            // 
            this.lbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Source Serif Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbPercent.Location = new System.Drawing.Point(566, 34);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(29, 28);
            this.lbPercent.TabIndex = 22;
            this.lbPercent.Text = "%";
            // 
            // txbSaleOff
            // 
            this.txbSaleOff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSaleOff.BorderRadius = 5;
            this.txbSaleOff.BorderThickness = 2;
            this.txbSaleOff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSaleOff.DefaultText = "0.0";
            this.txbSaleOff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSaleOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSaleOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSaleOff.DisabledState.Parent = this.txbSaleOff;
            this.txbSaleOff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSaleOff.FillColor = System.Drawing.SystemColors.Control;
            this.txbSaleOff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSaleOff.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSaleOff.FocusedState.Parent = this.txbSaleOff;
            this.txbSaleOff.Font = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaleOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSaleOff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSaleOff.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.txbSaleOff.HoverState.Parent = this.txbSaleOff;
            this.txbSaleOff.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSaleOff.Location = new System.Drawing.Point(506, 32);
            this.txbSaleOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSaleOff.Name = "txbSaleOff";
            this.txbSaleOff.PasswordChar = '\0';
            this.txbSaleOff.PlaceholderText = "";
            this.txbSaleOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbSaleOff.SelectedText = "";
            this.txbSaleOff.SelectionStart = 3;
            this.txbSaleOff.ShadowDecoration.Parent = this.txbSaleOff;
            this.txbSaleOff.Size = new System.Drawing.Size(59, 32);
            this.txbSaleOff.TabIndex = 5;
            this.txbSaleOff.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // lbSaleOff
            // 
            this.lbSaleOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSaleOff.AutoSize = true;
            this.lbSaleOff.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaleOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbSaleOff.Location = new System.Drawing.Point(347, 39);
            this.lbSaleOff.Name = "lbSaleOff";
            this.lbSaleOff.Size = new System.Drawing.Size(59, 21);
            this.lbSaleOff.TabIndex = 4;
            this.lbSaleOff.Text = "Sale off";
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbPrice.Location = new System.Drawing.Point(512, 8);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(47, 21);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbSubtotal.Location = new System.Drawing.Point(343, 8);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(67, 21);
            this.lbSubtotal.TabIndex = 2;
            this.lbSubtotal.Text = "Subtotal";
            // 
            // layoutPanelBill
            // 
            this.layoutPanelBill.BackColor = System.Drawing.SystemColors.Control;
            this.layoutPanelBill.Controls.Add(this.billInfoUsrCtrl1);
            this.layoutPanelBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanelBill.Location = new System.Drawing.Point(0, 58);
            this.layoutPanelBill.Name = "layoutPanelBill";
            this.layoutPanelBill.Size = new System.Drawing.Size(600, 474);
            this.layoutPanelBill.TabIndex = 2;
            // 
            // billInfoUsrCtrl1
            // 
            this.billInfoUsrCtrl1.Location = new System.Drawing.Point(3, 3);
            this.billInfoUsrCtrl1.Name = "billInfoUsrCtrl1";
            this.billInfoUsrCtrl1.Size = new System.Drawing.Size(597, 67);
            this.billInfoUsrCtrl1.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnLeft.AutoSize = true;
            this.pnLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.pnLeft.Location = new System.Drawing.Point(10, 60);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Radius = 10;
            this.pnLeft.ShadowColor = System.Drawing.Color.Black;
            this.pnLeft.Size = new System.Drawing.Size(673, 675);
            this.pnLeft.TabIndex = 0;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1308, 768);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelInfoBill.ResumeLayout(false);
            this.panelInfoBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icSearch)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.panelLeftBottom.ResumeLayout(false);
            this.panelLeftBottom.PerformLayout();
            this.layoutPanelBill.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMax;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnTable;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2ControlBox ctrMini;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel panelInfoBill;
        private FontAwesome.Sharp.IconButton btnTableInfo;
        private System.Windows.Forms.Panel pnTopBottom;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgbTakeAway;
        private System.Windows.Forms.Label lbTakeAway;
        private JMaterialTextbox.JMaterialTextbox txbSearching;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnLeft;
        private FontAwesome.Sharp.IconPictureBox icSearch;
        private System.Windows.Forms.Panel panelLeftBottom;
        private System.Windows.Forms.Label lbPercent;
        private Guna.UI2.WinForms.Guna2TextBox txbSaleOff;
        private System.Windows.Forms.Label lbSaleOff;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.FlowLayoutPanel layoutPanelBill;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label lbCustumers;
        private FontAwesome.Sharp.IconButton btnNote;
        private FontAwesome.Sharp.IconButton btnPay;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbTotal;
        private UserControls.BillInfoUsrCtrl billInfoUsrCtrl1;
    }
}
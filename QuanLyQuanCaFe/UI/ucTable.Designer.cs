namespace Bakery_Management
{
    partial class ucTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTable));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnTable = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaMon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbChuyenban = new System.Windows.Forms.ComboBox();
            this.btnThanhtoan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbxTotalPrice = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnChuyenban = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTable
            // 
            this.pnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnTable.Controls.Add(this.panel3);
            this.pnTable.Controls.Add(this.panel1);
            this.pnTable.Controls.Add(this.panel2);
            this.pnTable.Controls.Add(this.flpTable);
            this.pnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTable.Location = new System.Drawing.Point(0, 0);
            this.pnTable.Name = "pnTable";
            this.pnTable.Size = new System.Drawing.Size(944, 495);
            this.pnTable.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(532, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 374);
            this.panel3.TabIndex = 5;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(412, 374);
            this.lsvBill.TabIndex = 8;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnXoaMon);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.nmFoodCount);
            this.panel1.Controls.Add(this.cbFood);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(532, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.AllowToggling = false;
            this.btnXoaMon.AnimationSpeed = 200;
            this.btnXoaMon.AutoGenerateColors = false;
            this.btnXoaMon.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaMon.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnXoaMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.BackgroundImage")));
            this.btnXoaMon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXoaMon.ButtonText = "Xóa";
            this.btnXoaMon.ButtonTextMarginLeft = 0;
            this.btnXoaMon.ColorContrastOnClick = 45;
            this.btnXoaMon.ColorContrastOnHover = 45;
            this.btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXoaMon.CustomizableEdges = borderEdges1;
            this.btnXoaMon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaMon.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnXoaMon.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXoaMon.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXoaMon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXoaMon.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.IconMarginLeft = 11;
            this.btnXoaMon.IconPadding = 10;
            this.btnXoaMon.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnXoaMon.IdleBorderRadius = 10;
            this.btnXoaMon.IdleBorderThickness = 1;
            this.btnXoaMon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnXoaMon.IdleIconLeftImage = null;
            this.btnXoaMon.IdleIconRightImage = null;
            this.btnXoaMon.IndicateFocus = false;
            this.btnXoaMon.Location = new System.Drawing.Point(308, 35);
            this.btnXoaMon.Name = "btnXoaMon";
            stateProperties1.BorderColor = System.Drawing.Color.DimGray;
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DimGray;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnXoaMon.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.DimGray;
            stateProperties2.BorderRadius = 10;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.DimGray;
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnXoaMon.OnPressedState = stateProperties2;
            this.btnXoaMon.Size = new System.Drawing.Size(101, 22);
            this.btnXoaMon.TabIndex = 5;
            this.btnXoaMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoaMon.TextMarginLeft = 0;
            this.btnXoaMon.UseDefaultRadiusAndThickness = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 15;
            this.btnThem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.btnThem.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnThem.AllowDrop = true;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 15;
            this.btnThem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnThem.IdleForecolor = System.Drawing.Color.White;
            this.btnThem.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(223, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 58);
            this.btnThem.TabIndex = 4;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodCount.Location = new System.Drawing.Point(308, 7);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(101, 23);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 34);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(217, 22);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(217, 22);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbChuyenban);
            this.panel2.Controls.Add(this.btnThanhtoan);
            this.panel2.Controls.Add(this.tbxTotalPrice);
            this.panel2.Controls.Add(this.btnChuyenban);
            this.panel2.Controls.Add(this.nmDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(532, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 61);
            this.panel2.TabIndex = 4;
            // 
            // cbChuyenban
            // 
            this.cbChuyenban.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenban.ForeColor = System.Drawing.Color.DimGray;
            this.cbChuyenban.FormattingEnabled = true;
            this.cbChuyenban.Location = new System.Drawing.Point(3, 36);
            this.cbChuyenban.Name = "cbChuyenban";
            this.cbChuyenban.Size = new System.Drawing.Size(102, 23);
            this.cbChuyenban.TabIndex = 6;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.ActiveBorderThickness = 1;
            this.btnThanhtoan.ActiveCornerRadius = 15;
            this.btnThanhtoan.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.btnThanhtoan.ActiveForecolor = System.Drawing.Color.White;
            this.btnThanhtoan.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.btnThanhtoan.AllowDrop = true;
            this.btnThanhtoan.BackColor = System.Drawing.Color.White;
            this.btnThanhtoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThanhtoan.BackgroundImage")));
            this.btnThanhtoan.ButtonText = "Thanh toán";
            this.btnThanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhtoan.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnThanhtoan.IdleBorderThickness = 1;
            this.btnThanhtoan.IdleCornerRadius = 15;
            this.btnThanhtoan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnThanhtoan.IdleForecolor = System.Drawing.Color.White;
            this.btnThanhtoan.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnThanhtoan.Location = new System.Drawing.Point(292, 0);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(117, 58);
            this.btnThanhtoan.TabIndex = 11;
            this.btnThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.AcceptsReturn = false;
            this.tbxTotalPrice.AcceptsTab = false;
            this.tbxTotalPrice.AnimationSpeed = 200;
            this.tbxTotalPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxTotalPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxTotalPrice.BackColor = System.Drawing.Color.White;
            this.tbxTotalPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxTotalPrice.BackgroundImage")));
            this.tbxTotalPrice.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxTotalPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.tbxTotalPrice.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.tbxTotalPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.tbxTotalPrice.BorderRadius = 15;
            this.tbxTotalPrice.BorderThickness = 2;
            this.tbxTotalPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTotalPrice.DefaultFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalPrice.DefaultText = "Total";
            this.tbxTotalPrice.FillColor = System.Drawing.Color.White;
            this.tbxTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.tbxTotalPrice.HideSelection = true;
            this.tbxTotalPrice.IconLeft = null;
            this.tbxTotalPrice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tbxTotalPrice.IconPadding = 10;
            this.tbxTotalPrice.IconRight = null;
            this.tbxTotalPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTotalPrice.Lines = new string[] {
        "Total"};
            this.tbxTotalPrice.Location = new System.Drawing.Point(178, 15);
            this.tbxTotalPrice.MaxLength = 32767;
            this.tbxTotalPrice.MinimumSize = new System.Drawing.Size(100, 35);
            this.tbxTotalPrice.Modified = false;
            this.tbxTotalPrice.Multiline = false;
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxTotalPrice.OnActiveState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbxTotalPrice.OnDisabledState = stateProperties4;
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxTotalPrice.OnHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxTotalPrice.OnIdleState = stateProperties6;
            this.tbxTotalPrice.PasswordChar = '\0';
            this.tbxTotalPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tbxTotalPrice.PlaceholderText = "Enter text";
            this.tbxTotalPrice.ReadOnly = true;
            this.tbxTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxTotalPrice.SelectedText = "";
            this.tbxTotalPrice.SelectionLength = 0;
            this.tbxTotalPrice.SelectionStart = 0;
            this.tbxTotalPrice.ShortcutsEnabled = true;
            this.tbxTotalPrice.Size = new System.Drawing.Size(111, 35);
            this.tbxTotalPrice.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbxTotalPrice.TabIndex = 10;
            this.tbxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxTotalPrice.TextMarginBottom = 0;
            this.tbxTotalPrice.TextMarginLeft = 5;
            this.tbxTotalPrice.TextMarginTop = 0;
            this.tbxTotalPrice.TextPlaceholder = "Enter text";
            this.tbxTotalPrice.UseSystemPasswordChar = false;
            this.tbxTotalPrice.WordWrap = true;
            // 
            // btnChuyenban
            // 
            this.btnChuyenban.ActiveBorderThickness = 1;
            this.btnChuyenban.ActiveCornerRadius = 10;
            this.btnChuyenban.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.btnChuyenban.ActiveForecolor = System.Drawing.Color.White;
            this.btnChuyenban.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.btnChuyenban.AllowDrop = true;
            this.btnChuyenban.BackColor = System.Drawing.Color.White;
            this.btnChuyenban.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenban.BackgroundImage")));
            this.btnChuyenban.ButtonText = "Chuyển bàn";
            this.btnChuyenban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenban.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenban.ForeColor = System.Drawing.Color.White;
            this.btnChuyenban.IdleBorderThickness = 1;
            this.btnChuyenban.IdleCornerRadius = 10;
            this.btnChuyenban.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnChuyenban.IdleForecolor = System.Drawing.Color.White;
            this.btnChuyenban.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnChuyenban.Location = new System.Drawing.Point(3, 0);
            this.btnChuyenban.Margin = new System.Windows.Forms.Padding(0);
            this.btnChuyenban.Name = "btnChuyenban";
            this.btnChuyenban.Size = new System.Drawing.Size(102, 38);
            this.btnChuyenban.TabIndex = 9;
            this.btnChuyenban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChuyenban.Click += new System.EventHandler(this.btnChuyenban_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.ForeColor = System.Drawing.Color.DimGray;
            this.nmDiscount.Location = new System.Drawing.Point(110, 19);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(62, 26);
            this.nmDiscount.TabIndex = 8;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(532, 495);
            this.flpTable.TabIndex = 0;
            this.flpTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpTable_MouseClick);
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnTable);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(944, 495);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ucTable_KeyUp);
            this.pnTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.ComboBox cbChuyenban;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXoaMon;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChuyenban;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThanhtoan;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbxTotalPrice;
    }
}

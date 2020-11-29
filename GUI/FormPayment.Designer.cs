namespace GUI
{
    partial class FormPayment
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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbQTY;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.icTimer = new FontAwesome.Sharp.IconPictureBox();
            this.icCalender = new FontAwesome.Sharp.IconPictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.icTable = new FontAwesome.Sharp.IconPictureBox();
            this.lbTableID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnRight = new System.Windows.Forms.Panel();
            this.btnCacel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnLine = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTextTotal = new System.Windows.Forms.Label();
            this.lbSale = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbTextSale = new System.Windows.Forms.Label();
            this.lbTextSutotal = new System.Windows.Forms.Label();
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipsePnRight = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipsePnLeft = new Bunifu.Framework.UI.BunifuElipse(this.components);
            txbQTY = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icTable)).BeginInit();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.pnRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbQTY
            // 
            txbQTY.AcceptsReturn = false;
            txbQTY.AcceptsTab = false;
            txbQTY.AnimationSpeed = 200;
            txbQTY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txbQTY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txbQTY.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            txbQTY.BackColor = System.Drawing.Color.White;
            txbQTY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbQTY.BackgroundImage")));
            txbQTY.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            txbQTY.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            txbQTY.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            txbQTY.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            txbQTY.BorderRadius = 20;
            txbQTY.BorderThickness = 1;
            txbQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txbQTY.Cursor = System.Windows.Forms.Cursors.Default;
            txbQTY.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            txbQTY.DefaultText = "0";
            txbQTY.Enabled = false;
            txbQTY.FillColor = System.Drawing.Color.White;
            txbQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            txbQTY.HideSelection = true;
            txbQTY.IconLeft = null;
            txbQTY.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            txbQTY.IconPadding = 10;
            txbQTY.IconRight = null;
            txbQTY.IconRightCursor = System.Windows.Forms.Cursors.Default;
            txbQTY.Lines = new string[] {
        "0"};
            txbQTY.Location = new System.Drawing.Point(81, 6);
            txbQTY.MaximumSize = new System.Drawing.Size(39, 26);
            txbQTY.MaxLength = 32767;
            txbQTY.MinimumSize = new System.Drawing.Size(39, 26);
            txbQTY.Modified = false;
            txbQTY.Multiline = false;
            txbQTY.Name = "txbQTY";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            txbQTY.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            txbQTY.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            txbQTY.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            txbQTY.OnIdleState = stateProperties4;
            txbQTY.PasswordChar = '\0';
            txbQTY.PlaceholderForeColor = System.Drawing.Color.Silver;
            txbQTY.PlaceholderText = "";
            txbQTY.ReadOnly = true;
            txbQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txbQTY.SelectedText = "";
            txbQTY.SelectionLength = 0;
            txbQTY.SelectionStart = 0;
            txbQTY.ShortcutsEnabled = true;
            txbQTY.Size = new System.Drawing.Size(39, 26);
            txbQTY.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            txbQTY.TabIndex = 15;
            txbQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txbQTY.TextMarginBottom = 0;
            txbQTY.TextMarginLeft = 5;
            txbQTY.TextMarginTop = 0;
            txbQTY.TextPlaceholder = "";
            txbQTY.UseSystemPasswordChar = false;
            txbQTY.WordWrap = true;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.close);
            this.pnHeader.Controls.Add(this.label2);
            this.pnHeader.Controls.Add(this.icTimer);
            this.pnHeader.Controls.Add(this.icCalender);
            this.pnHeader.Controls.Add(this.lbDate);
            this.pnHeader.Controls.Add(this.icTable);
            this.pnHeader.Controls.Add(this.lbTableID);
            this.pnHeader.Controls.Add(this.lbName);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(950, 86);
            this.pnHeader.TabIndex = 0;
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(900, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 10;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(221, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "BILL ID";
            // 
            // icTimer
            // 
            this.icTimer.BackColor = System.Drawing.Color.White;
            this.icTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.icTimer.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.icTimer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.icTimer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icTimer.IconSize = 25;
            this.icTimer.Location = new System.Drawing.Point(913, 53);
            this.icTimer.Name = "icTimer";
            this.icTimer.Size = new System.Drawing.Size(25, 25);
            this.icTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icTimer.TabIndex = 5;
            this.icTimer.TabStop = false;
            // 
            // icCalender
            // 
            this.icCalender.BackColor = System.Drawing.Color.White;
            this.icCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.icCalender.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.icCalender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.icCalender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icCalender.IconSize = 25;
            this.icCalender.Location = new System.Drawing.Point(884, 53);
            this.icCalender.Name = "icCalender";
            this.icCalender.Size = new System.Drawing.Size(25, 25);
            this.icCalender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icCalender.TabIndex = 4;
            this.icCalender.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.lbDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDate.Location = new System.Drawing.Point(733, 57);
            this.lbDate.Name = "lbDate";
            this.lbDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDate.Size = new System.Drawing.Size(145, 21);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // icTable
            // 
            this.icTable.BackColor = System.Drawing.Color.White;
            this.icTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.icTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.icTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icTable.IconSize = 23;
            this.icTable.Location = new System.Drawing.Point(27, 54);
            this.icTable.Name = "icTable";
            this.icTable.Size = new System.Drawing.Size(23, 23);
            this.icTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icTable.TabIndex = 2;
            this.icTable.TabStop = false;
            // 
            // lbTableID
            // 
            this.lbTableID.AutoSize = true;
            this.lbTableID.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTableID.Location = new System.Drawing.Point(56, 57);
            this.lbTableID.Name = "lbTableID";
            this.lbTableID.Size = new System.Drawing.Size(68, 17);
            this.lbTableID.TabIndex = 1;
            this.lbTableID.Text = "Table ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Roboto Medium", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbName.Location = new System.Drawing.Point(20, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(208, 28);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "BILL OF LADING -";
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.White;
            this.pnLeft.Controls.Add(this.bunifuDataGridView1);
            this.pnLeft.Location = new System.Drawing.Point(4, 89);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(560, 530);
            this.pnLeft.TabIndex = 1;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.name,
            this.qty,
            this.price,
            this.amount});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(560, 530);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.Width = 55;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.HeaderText = "Item name";
            this.name.Name = "name";
            this.name.Width = 180;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.Width = 90;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle4;
            this.price.FillWeight = 180F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.amount.DefaultCellStyle = dataGridViewCellStyle5;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.Controls.Add(this.btnCacel);
            this.pnRight.Controls.Add(this.btnPay);
            this.pnRight.Controls.Add(this.pnLine);
            this.pnRight.Controls.Add(this.lbTotal);
            this.pnRight.Controls.Add(this.lbTextTotal);
            this.pnRight.Controls.Add(this.lbSale);
            this.pnRight.Controls.Add(txbQTY);
            this.pnRight.Controls.Add(this.lbSubtotal);
            this.pnRight.Controls.Add(this.lbTextSale);
            this.pnRight.Controls.Add(this.lbTextSutotal);
            this.pnRight.Location = new System.Drawing.Point(568, 89);
            this.pnRight.Margin = new System.Windows.Forms.Padding(5);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(54, 62, 0, 0);
            this.pnRight.Size = new System.Drawing.Size(376, 533);
            this.pnRight.TabIndex = 2;
            // 
            // btnCacel
            // 
            this.btnCacel.Active = true;
            this.btnCacel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCacel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCacel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCacel.BorderRadius = 0;
            this.btnCacel.ButtonText = "CANCEL";
            this.btnCacel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCacel.DisabledColor = System.Drawing.Color.Transparent;
            this.btnCacel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCacel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCacel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCacel.Iconimage")));
            this.btnCacel.Iconimage_right = null;
            this.btnCacel.Iconimage_right_Selected = null;
            this.btnCacel.Iconimage_Selected = null;
            this.btnCacel.IconMarginLeft = 30;
            this.btnCacel.IconMarginRight = 0;
            this.btnCacel.IconRightVisible = true;
            this.btnCacel.IconRightZoom = 0D;
            this.btnCacel.IconVisible = true;
            this.btnCacel.IconZoom = 45D;
            this.btnCacel.IsTab = false;
            this.btnCacel.Location = new System.Drawing.Point(0, 472);
            this.btnCacel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCacel.Name = "btnCacel";
            this.btnCacel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCacel.OnHovercolor = System.Drawing.Color.White;
            this.btnCacel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCacel.selected = true;
            this.btnCacel.Size = new System.Drawing.Size(195, 64);
            this.btnCacel.TabIndex = 10;
            this.btnCacel.Text = "CANCEL";
            this.btnCacel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCacel.Textcolor = System.Drawing.Color.White;
            this.btnCacel.TextFont = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
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
            this.btnPay.Iconimage_Selected = null;
            this.btnPay.IconMarginLeft = 50;
            this.btnPay.IconMarginRight = 0;
            this.btnPay.IconRightVisible = true;
            this.btnPay.IconRightZoom = 0D;
            this.btnPay.IconVisible = true;
            this.btnPay.IconZoom = 60D;
            this.btnPay.IsTab = false;
            this.btnPay.Location = new System.Drawing.Point(195, 472);
            this.btnPay.Name = "btnPay";
            this.btnPay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnPay.OnHovercolor = System.Drawing.Color.White;
            this.btnPay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnPay.selected = true;
            this.btnPay.Size = new System.Drawing.Size(195, 64);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "PAY";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Textcolor = System.Drawing.Color.White;
            this.btnPay.TextFont = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(198, 65);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(151, 1);
            this.pnLine.TabIndex = 19;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTotal.Location = new System.Drawing.Point(279, 74);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(85, 19);
            this.lbTotal.TabIndex = 18;
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
            this.lbTextTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lbTextTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbTextTotal.Location = new System.Drawing.Point(12, 73);
            this.lbTextTotal.Name = "lbTextTotal";
            this.lbTextTotal.Size = new System.Drawing.Size(44, 19);
            this.lbTextTotal.TabIndex = 17;
            this.lbTextTotal.Text = "Total";
            this.lbTextTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSale
            // 
            this.lbSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSale.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(146)))), ((int)(((byte)(123)))));
            this.lbSale.Location = new System.Drawing.Point(279, 38);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(85, 19);
            this.lbSale.TabIndex = 16;
            this.lbSale.Text = "0";
            this.lbSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSubtotal.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbSubtotal.Location = new System.Drawing.Point(279, 12);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(85, 19);
            this.lbSubtotal.TabIndex = 14;
            this.lbSubtotal.Text = "0";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbTextSale.Location = new System.Drawing.Point(12, 38);
            this.lbTextSale.Name = "lbTextSale";
            this.lbTextSale.Size = new System.Drawing.Size(60, 18);
            this.lbTextSale.TabIndex = 10;
            this.lbTextSale.Text = "Sale off";
            this.lbTextSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbTextSutotal.Location = new System.Drawing.Point(12, 12);
            this.lbTextSutotal.Name = "lbTextSutotal";
            this.lbTextSutotal.Size = new System.Drawing.Size(63, 18);
            this.lbTextSutotal.TabIndex = 9;
            this.lbTextSutotal.Text = "Subtotal";
            this.lbTextSutotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 15;
            this.elipseForm.TargetControl = this;
            // 
            // elipsePnRight
            // 
            this.elipsePnRight.ElipseRadius = 30;
            this.elipsePnRight.TargetControl = this.pnRight;
            // 
            // elipsePnLeft
            // 
            this.elipsePnLeft.ElipseRadius = 30;
            this.elipsePnLeft.TargetControl = this.pnLeft;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 625);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(950, 625);
            this.MinimumSize = new System.Drawing.Size(950, 625);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayment";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icTable)).EndInit();
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTableID;
        private FontAwesome.Sharp.IconPictureBox icTable;
        private FontAwesome.Sharp.IconPictureBox icTimer;
        private FontAwesome.Sharp.IconPictureBox icCalender;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTextSale;
        private System.Windows.Forms.Label lbTextSutotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTextTotal;
        private System.Windows.Forms.Label lbSale;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnPay;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuFlatButton btnCacel;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private Bunifu.Framework.UI.BunifuElipse elipsePnRight;
        private Bunifu.Framework.UI.BunifuElipse elipsePnLeft;
    }
}
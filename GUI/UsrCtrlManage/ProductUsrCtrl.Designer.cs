namespace GUI.UsrCtrlManage
{
    partial class ProductUsrCtrl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUsrCtrl));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnRight = new System.Windows.Forms.Panel();
            this.dropdownCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.txbDVT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbCategory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbDVT = new System.Windows.Forms.Label();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.pnBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnPic = new System.Windows.Forms.Panel();
            this.lbAdding = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.btnAddPic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.elipsepnRight = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.elipsePnLeft = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnSave = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnUpdate = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnDel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddingImage_label = new System.Windows.Forms.Label();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.pnRight.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.pnBtn.SuspendLayout();
            this.pnPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnLeft.Controls.Add(this.bunifuDataGridView1);
            this.pnLeft.Location = new System.Drawing.Point(8, 60);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(953, 623);
            this.pnLeft.TabIndex = 0;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.price,
            this.DVT,
            this.ImageData});
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(953, 623);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellClick);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnRight.Controls.Add(this.dropdownCategory);
            this.pnRight.Controls.Add(this.label1);
            this.pnRight.Controls.Add(this.pnInfo);
            this.pnRight.Controls.Add(this.pnBtn);
            this.pnRight.Controls.Add(this.pnPic);
            this.pnRight.Location = new System.Drawing.Point(972, 10);
            this.pnRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(700, 673);
            this.pnRight.TabIndex = 2;
            // 
            // dropdownCategory
            // 
            this.dropdownCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dropdownCategory.BackColor = System.Drawing.Color.Transparent;
            this.dropdownCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dropdownCategory.BorderRadius = 3;
            this.dropdownCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownCategory.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.dropdownCategory.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.dropdownCategory.items = new string[] {
        "--Selection--"};
            this.dropdownCategory.Location = new System.Drawing.Point(402, 446);
            this.dropdownCategory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dropdownCategory.Name = "dropdownCategory";
            this.dropdownCategory.NomalColor = System.Drawing.SystemColors.Control;
            this.dropdownCategory.onHoverColor = System.Drawing.Color.White;
            this.dropdownCategory.selectedIndex = 0;
            this.dropdownCategory.Size = new System.Drawing.Size(293, 42);
            this.dropdownCategory.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Infomation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.txbDVT);
            this.pnInfo.Controls.Add(this.txbCategory);
            this.pnInfo.Controls.Add(this.lbDVT);
            this.pnInfo.Controls.Add(this.txbPrice);
            this.pnInfo.Controls.Add(this.txbName);
            this.pnInfo.Controls.Add(this.txbID);
            this.pnInfo.Controls.Add(this.lbPrice);
            this.pnInfo.Controls.Add(this.lbCategory);
            this.pnInfo.Controls.Add(this.lbName);
            this.pnInfo.Controls.Add(this.lbID);
            this.pnInfo.Location = new System.Drawing.Point(263, 68);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(421, 271);
            this.pnInfo.TabIndex = 3;
            // 
            // txbDVT
            // 
            this.txbDVT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbDVT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbDVT.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDVT.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbDVT.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbDVT.HintText = "";
            this.txbDVT.isPassword = false;
            this.txbDVT.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbDVT.LineIdleColor = System.Drawing.Color.Gray;
            this.txbDVT.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbDVT.LineThickness = 1;
            this.txbDVT.Location = new System.Drawing.Point(123, 200);
            this.txbDVT.Margin = new System.Windows.Forms.Padding(5);
            this.txbDVT.MaxLength = 32767;
            this.txbDVT.Name = "txbDVT";
            this.txbDVT.Size = new System.Drawing.Size(292, 39);
            this.txbDVT.TabIndex = 19;
            this.txbDVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbCategory
            // 
            this.txbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbCategory.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCategory.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbCategory.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbCategory.HintText = "";
            this.txbCategory.isPassword = false;
            this.txbCategory.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbCategory.LineIdleColor = System.Drawing.Color.Gray;
            this.txbCategory.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbCategory.LineThickness = 1;
            this.txbCategory.Location = new System.Drawing.Point(123, 110);
            this.txbCategory.Margin = new System.Windows.Forms.Padding(5);
            this.txbCategory.MaxLength = 32767;
            this.txbCategory.Name = "txbCategory";
            this.txbCategory.Size = new System.Drawing.Size(292, 36);
            this.txbCategory.TabIndex = 18;
            this.txbCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbDVT
            // 
            this.lbDVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDVT.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbDVT.Location = new System.Drawing.Point(4, 206);
            this.lbDVT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(111, 39);
            this.lbDVT.TabIndex = 18;
            this.lbDVT.Text = "Unit";
            this.lbDVT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbPrice
            // 
            this.txbPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPrice.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbPrice.HintText = "";
            this.txbPrice.isPassword = false;
            this.txbPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txbPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbPrice.LineThickness = 1;
            this.txbPrice.Location = new System.Drawing.Point(123, 154);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txbPrice.MaxLength = 32767;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(292, 36);
            this.txbPrice.TabIndex = 17;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // txbName
            // 
            this.txbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbName.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbName.HintText = "Product\'s name";
            this.txbName.isPassword = false;
            this.txbName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbName.LineIdleColor = System.Drawing.Color.Gray;
            this.txbName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbName.LineThickness = 1;
            this.txbName.Location = new System.Drawing.Point(124, 55);
            this.txbName.Margin = new System.Windows.Forms.Padding(5);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(292, 36);
            this.txbName.TabIndex = 15;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbID
            // 
            this.txbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbID.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbID.HintText = "ID is a unique identifier ";
            this.txbID.isPassword = false;
            this.txbID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbID.LineIdleColor = System.Drawing.Color.Gray;
            this.txbID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbID.LineThickness = 1;
            this.txbID.Location = new System.Drawing.Point(124, 6);
            this.txbID.Margin = new System.Windows.Forms.Padding(5);
            this.txbID.MaxLength = 32767;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(292, 37);
            this.txbID.TabIndex = 14;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbPrice
            // 
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPrice.Location = new System.Drawing.Point(4, 164);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(111, 42);
            this.lbPrice.TabIndex = 13;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCategory
            // 
            this.lbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategory.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbCategory.Location = new System.Drawing.Point(4, 110);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(111, 42);
            this.lbCategory.TabIndex = 12;
            this.lbCategory.Text = "Category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbName.Location = new System.Drawing.Point(4, 55);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 42);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Item name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbID
            // 
            this.lbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbID.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbID.Location = new System.Drawing.Point(4, 1);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(111, 42);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBtn
            // 
            this.pnBtn.Controls.Add(this.btnDel);
            this.pnBtn.Controls.Add(this.btnUpdate);
            this.pnBtn.Controls.Add(this.btnSave);
            this.pnBtn.Location = new System.Drawing.Point(263, 350);
            this.pnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(421, 65);
            this.pnBtn.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.Active = true;
            this.btnDel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.BorderRadius = 0;
            this.btnDel.ButtonText = " Delete";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledColor = System.Drawing.Color.Transparent;
            this.btnDel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDel.Iconimage")));
            this.btnDel.Iconimage_right = null;
            this.btnDel.Iconimage_right_Selected = null;
            this.btnDel.Iconimage_Selected = null;
            this.btnDel.IconMarginLeft = -3;
            this.btnDel.IconMarginRight = 0;
            this.btnDel.IconRightVisible = true;
            this.btnDel.IconRightZoom = 0D;
            this.btnDel.IconVisible = true;
            this.btnDel.IconZoom = 30D;
            this.btnDel.IsTab = false;
            this.btnDel.Location = new System.Drawing.Point(1, 1);
            this.btnDel.Margin = new System.Windows.Forms.Padding(1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnDel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnDel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDel.selected = true;
            this.btnDel.Size = new System.Drawing.Size(136, 62);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = " Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Textcolor = System.Drawing.Color.White;
            this.btnDel.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Active = true;
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 30D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(139, 1);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = true;
            this.btnUpdate.Size = new System.Drawing.Size(152, 62);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Active = true;
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = " Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 30D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(293, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = true;
            this.btnSave.Size = new System.Drawing.Size(124, 62);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = " Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnPic
            // 
            this.pnPic.Controls.Add(this.picFood);
            this.pnPic.Controls.Add(this.AddingImage_label);
            this.pnPic.Controls.Add(this.lbAdding);
            this.pnPic.Controls.Add(this.btnAddPic);
            this.pnPic.Location = new System.Drawing.Point(25, 68);
            this.pnPic.Margin = new System.Windows.Forms.Padding(4);
            this.pnPic.Name = "pnPic";
            this.pnPic.Size = new System.Drawing.Size(229, 271);
            this.pnPic.TabIndex = 0;
            // 
            // lbAdding
            // 
            this.lbAdding.AutoSize = true;
            this.lbAdding.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdding.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbAdding.Location = new System.Drawing.Point(47, 79);
            this.lbAdding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdding.Name = "lbAdding";
            this.lbAdding.Size = new System.Drawing.Size(128, 20);
            this.lbAdding.TabIndex = 1;
            this.lbAdding.Text = "+ Adding image";
            this.lbAdding.Visible = false;
            // 
            // picFood
            // 
            this.picFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFood.Image = ((System.Drawing.Image)(resources.GetObject("picFood.Image")));
            this.picFood.Location = new System.Drawing.Point(0, 0);
            this.picFood.Margin = new System.Windows.Forms.Padding(4);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(229, 206);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            this.picFood.Click += new System.EventHandler(this.picFood_Click);
            this.picFood.MouseLeave += new System.EventHandler(this.picFood_MouseLeave);
            this.picFood.MouseHover += new System.EventHandler(this.picFood_MouseHover);
            // 
            // btnAddPic
            // 
            this.btnAddPic.Active = true;
            this.btnAddPic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnAddPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnAddPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPic.BorderRadius = 0;
            this.btnAddPic.ButtonText = "Add Image";
            this.btnAddPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPic.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAddPic.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddPic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPic.Iconimage")));
            this.btnAddPic.Iconimage_right = null;
            this.btnAddPic.Iconimage_right_Selected = null;
            this.btnAddPic.Iconimage_Selected = null;
            this.btnAddPic.IconMarginLeft = 0;
            this.btnAddPic.IconMarginRight = 0;
            this.btnAddPic.IconRightVisible = true;
            this.btnAddPic.IconRightZoom = 0D;
            this.btnAddPic.IconVisible = true;
            this.btnAddPic.IconZoom = 30D;
            this.btnAddPic.IsTab = false;
            this.btnAddPic.Location = new System.Drawing.Point(51, 220);
            this.btnAddPic.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddPic.MaximumSize = new System.Drawing.Size(142, 35);
            this.btnAddPic.MinimumSize = new System.Drawing.Size(142, 35);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnAddPic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnAddPic.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPic.selected = true;
            this.btnAddPic.Size = new System.Drawing.Size(142, 35);
            this.btnAddPic.TabIndex = 4;
            this.btnAddPic.Text = "Add Image";
            this.btnAddPic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPic.Textcolor = System.Drawing.Color.White;
            this.btnAddPic.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // elipsepnRight
            // 
            this.elipsepnRight.ElipseRadius = 30;
            this.elipsepnRight.TargetControl = this.pnRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 58);
            this.panel1.TabIndex = 3;
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
            this.txbSearch.Location = new System.Drawing.Point(649, 9);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.MinimumSize = new System.Drawing.Size(133, 43);
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
            this.txbSearch.Size = new System.Drawing.Size(312, 43);
            this.txbSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbSearch.TabIndex = 21;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.TextMarginBottom = 0;
            this.txbSearch.TextMarginLeft = 5;
            this.txbSearch.TextMarginTop = 0;
            this.txbSearch.TextPlaceholder = "Enter your foods";
            this.txbSearch.UseSystemPasswordChar = false;
            this.txbSearch.WordWrap = true;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            // 
            // elipsePnLeft
            // 
            this.elipsePnLeft.ElipseRadius = 30;
            this.elipsePnLeft.TargetControl = this.pnLeft;
            // 
            // elipseBtnSave
            // 
            this.elipseBtnSave.ElipseRadius = 20;
            this.elipseBtnSave.TargetControl = this.btnSave;
            // 
            // elipseBtnUpdate
            // 
            this.elipseBtnUpdate.ElipseRadius = 20;
            this.elipseBtnUpdate.TargetControl = this.btnUpdate;
            // 
            // elipseBtnDel
            // 
            this.elipseBtnDel.ElipseRadius = 20;
            this.elipseBtnDel.TargetControl = this.btnDel;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.FillWeight = 137.6729F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.FillWeight = 65.65144F;
            this.name.HeaderText = "Iteam name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 180;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category.FillWeight = 145.7886F;
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.price.DefaultCellStyle = dataGridViewCellStyle4;
            this.price.FillWeight = 50.887F;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "Init";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // ImageData
            // 
            this.ImageData.HeaderText = "ImageData";
            this.ImageData.MinimumWidth = 6;
            this.ImageData.Name = "ImageData";
            this.ImageData.ReadOnly = true;
            this.ImageData.Visible = false;
            // 
            // AddingImage_label
            // 
            this.AddingImage_label.AutoSize = true;
            this.AddingImage_label.Location = new System.Drawing.Point(70, 154);
            this.AddingImage_label.Name = "AddingImage_label";
            this.AddingImage_label.Size = new System.Drawing.Size(94, 17);
            this.AddingImage_label.TabIndex = 5;
            this.AddingImage_label.Text = "Adding image";
            // 
            // ProductUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1683, 692);
            this.MinimumSize = new System.Drawing.Size(1683, 692);
            this.Name = "ProductUsrCtrl";
            this.Size = new System.Drawing.Size(1683, 692);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnBtn.ResumeLayout(false);
            this.pnPic.ResumeLayout(false);
            this.pnPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.FlowLayoutPanel pnBtn;
        private System.Windows.Forms.Panel pnPic;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAdding;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDel;
        private Bunifu.Framework.UI.BunifuElipse elipsepnRight;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse elipsePnLeft;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnSave;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnUpdate;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnDel;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbDVT;
        private System.Windows.Forms.Label lbDVT;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbCategory;
        private Bunifu.Framework.UI.BunifuDropdown dropdownCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageData;
        private System.Windows.Forms.Label AddingImage_label;
    }
}

namespace GUI.UsrCtrlManage
{
    partial class AccountUsrCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountUsrCtrl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPass = new System.Windows.Forms.Panel();
            this.txbRePass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcbNewPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.txbOldPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbRePass = new System.Windows.Forms.Label();
            this.lbOldPass = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.dropDownPosition = new Bunifu.Framework.UI.BunifuDropdown();
            this.lbPosition = new System.Windows.Forms.Label();
            this.txbEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.pnBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.elipsepnRight = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnCreate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txbSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.elipsePnLeft = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnUpdate = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnDel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.pnRight.SuspendLayout();
            this.pnPass.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.pnBtn.SuspendLayout();
            this.pnSearch.SuspendLayout();
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
            this.user,
            this.name,
            this.type});
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
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
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.user.DefaultCellStyle = dataGridViewCellStyle3;
            this.user.FillWeight = 137.6729F;
            this.user.HeaderText = "User name";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnRight.Controls.Add(this.label1);
            this.pnRight.Controls.Add(this.pnPass);
            this.pnRight.Controls.Add(this.lbInfo);
            this.pnRight.Controls.Add(this.pnInfo);
            this.pnRight.Controls.Add(this.pnBtn);
            this.pnRight.Location = new System.Drawing.Point(972, 10);
            this.pnRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(700, 673);
            this.pnRight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(25, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Change password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnPass
            // 
            this.pnPass.Controls.Add(this.txbRePass);
            this.pnPass.Controls.Add(this.tcbNewPass);
            this.pnPass.Controls.Add(this.lbNewPass);
            this.pnPass.Controls.Add(this.txbOldPass);
            this.pnPass.Controls.Add(this.lbRePass);
            this.pnPass.Controls.Add(this.lbOldPass);
            this.pnPass.Location = new System.Drawing.Point(25, 385);
            this.pnPass.Margin = new System.Windows.Forms.Padding(4);
            this.pnPass.Name = "pnPass";
            this.pnPass.Size = new System.Drawing.Size(659, 183);
            this.pnPass.TabIndex = 12;
            // 
            // txbRePass
            // 
            this.txbRePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbRePass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbRePass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbRePass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRePass.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbRePass.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbRePass.HintText = "123456";
            this.txbRePass.isPassword = true;
            this.txbRePass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbRePass.LineIdleColor = System.Drawing.Color.Gray;
            this.txbRePass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbRePass.LineThickness = 1;
            this.txbRePass.Location = new System.Drawing.Point(215, 106);
            this.txbRePass.Margin = new System.Windows.Forms.Padding(5);
            this.txbRePass.MaxLength = 32767;
            this.txbRePass.Name = "txbRePass";
            this.txbRePass.Size = new System.Drawing.Size(292, 42);
            this.txbRePass.TabIndex = 16;
            this.txbRePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tcbNewPass
            // 
            this.tcbNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tcbNewPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tcbNewPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tcbNewPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tcbNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcbNewPass.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcbNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.tcbNewPass.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.tcbNewPass.HintText = "123456";
            this.tcbNewPass.isPassword = true;
            this.tcbNewPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tcbNewPass.LineIdleColor = System.Drawing.Color.Gray;
            this.tcbNewPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.tcbNewPass.LineThickness = 1;
            this.tcbNewPass.Location = new System.Drawing.Point(215, 54);
            this.tcbNewPass.Margin = new System.Windows.Forms.Padding(5);
            this.tcbNewPass.MaxLength = 32767;
            this.tcbNewPass.Name = "tcbNewPass";
            this.tcbNewPass.Size = new System.Drawing.Size(292, 42);
            this.tcbNewPass.TabIndex = 15;
            this.tcbNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbNewPass
            // 
            this.lbNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNewPass.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbNewPass.Location = new System.Drawing.Point(3, 54);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(203, 42);
            this.lbNewPass.TabIndex = 10;
            this.lbNewPass.Text = "New password";
            this.lbNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbOldPass
            // 
            this.txbOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbOldPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbOldPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbOldPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbOldPass.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbOldPass.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbOldPass.HintText = "123456";
            this.txbOldPass.isPassword = true;
            this.txbOldPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbOldPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txbOldPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbOldPass.LineThickness = 1;
            this.txbOldPass.Location = new System.Drawing.Point(215, 1);
            this.txbOldPass.Margin = new System.Windows.Forms.Padding(5);
            this.txbOldPass.MaxLength = 32767;
            this.txbOldPass.Name = "txbOldPass";
            this.txbOldPass.Size = new System.Drawing.Size(292, 42);
            this.txbOldPass.TabIndex = 14;
            this.txbOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbRePass
            // 
            this.lbRePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRePass.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbRePass.Location = new System.Drawing.Point(3, 106);
            this.lbRePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(203, 42);
            this.lbRePass.TabIndex = 11;
            this.lbRePass.Text = "Re-enter password";
            this.lbRePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOldPass
            // 
            this.lbOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOldPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbOldPass.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbOldPass.Location = new System.Drawing.Point(3, 2);
            this.lbOldPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(203, 42);
            this.lbOldPass.TabIndex = 10;
            this.lbOldPass.Text = "Old password";
            this.lbOldPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInfo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbInfo.Location = new System.Drawing.Point(25, 7);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(257, 42);
            this.lbInfo.TabIndex = 11;
            this.lbInfo.Text = "Infomation";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.dropDownPosition);
            this.pnInfo.Controls.Add(this.lbPosition);
            this.pnInfo.Controls.Add(this.txbEmail);
            this.pnInfo.Controls.Add(this.lbEmail);
            this.pnInfo.Controls.Add(this.txbPhone);
            this.pnInfo.Controls.Add(this.lbPhone);
            this.pnInfo.Controls.Add(this.txbName);
            this.pnInfo.Controls.Add(this.txbID);
            this.pnInfo.Controls.Add(this.lbName);
            this.pnInfo.Controls.Add(this.lbUser);
            this.pnInfo.Location = new System.Drawing.Point(25, 62);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(659, 257);
            this.pnInfo.TabIndex = 3;
            // 
            // dropDownPosition
            // 
            this.dropDownPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dropDownPosition.BackColor = System.Drawing.Color.Transparent;
            this.dropDownPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dropDownPosition.BorderRadius = 3;
            this.dropDownPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownPosition.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.dropDownPosition.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.dropDownPosition.items = new string[] {
        "--Selection--",
        "Staff",
        "Manager"};
            this.dropDownPosition.Location = new System.Drawing.Point(215, 212);
            this.dropDownPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dropDownPosition.Name = "dropDownPosition";
            this.dropDownPosition.NomalColor = System.Drawing.SystemColors.Control;
            this.dropDownPosition.onHoverColor = System.Drawing.Color.White;
            this.dropDownPosition.selectedIndex = 0;
            this.dropDownPosition.Size = new System.Drawing.Size(293, 42);
            this.dropDownPosition.TabIndex = 36;
            // 
            // lbPosition
            // 
            this.lbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPosition.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPosition.Location = new System.Drawing.Point(3, 212);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(203, 42);
            this.lbPosition.TabIndex = 35;
            this.lbPosition.Text = "Position";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbEmail
            // 
            this.txbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.Enabled = false;
            this.txbEmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbEmail.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbEmail.HintText = "Employee\'s email";
            this.txbEmail.isPassword = false;
            this.txbEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txbEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbEmail.LineThickness = 1;
            this.txbEmail.Location = new System.Drawing.Point(215, 161);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txbEmail.MaxLength = 32767;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(292, 42);
            this.txbEmail.TabIndex = 32;
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbEmail
            // 
            this.lbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEmail.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbEmail.Location = new System.Drawing.Point(3, 161);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(203, 42);
            this.lbEmail.TabIndex = 31;
            this.lbEmail.Text = "E-mail";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbPhone
            // 
            this.txbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhone.Enabled = false;
            this.txbPhone.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbPhone.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbPhone.HintText = "Employee\'s ID";
            this.txbPhone.isPassword = false;
            this.txbPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txbPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbPhone.LineThickness = 1;
            this.txbPhone.Location = new System.Drawing.Point(215, 58);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txbPhone.MaxLength = 32767;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(292, 42);
            this.txbPhone.TabIndex = 14;
            this.txbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbPhone
            // 
            this.lbPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPhone.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPhone.Location = new System.Drawing.Point(3, 58);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(203, 42);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "ID";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbName
            // 
            this.txbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.txbName.HintForeColor = System.Drawing.SystemColors.ControlDark;
            this.txbName.HintText = "Employee\'s name";
            this.txbName.isPassword = false;
            this.txbName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbName.LineIdleColor = System.Drawing.Color.Gray;
            this.txbName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbName.LineThickness = 1;
            this.txbName.Location = new System.Drawing.Point(215, 110);
            this.txbName.Margin = new System.Windows.Forms.Padding(5);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(292, 42);
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
            this.txbID.HintText = "User name is a unique identifier ";
            this.txbID.isPassword = false;
            this.txbID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbID.LineIdleColor = System.Drawing.Color.Gray;
            this.txbID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.txbID.LineThickness = 1;
            this.txbID.Location = new System.Drawing.Point(215, 6);
            this.txbID.Margin = new System.Windows.Forms.Padding(5);
            this.txbID.MaxLength = 32767;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(292, 42);
            this.txbID.TabIndex = 14;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbName
            // 
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbName.Location = new System.Drawing.Point(3, 110);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(203, 42);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUser
            // 
            this.lbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbUser.Location = new System.Drawing.Point(3, 6);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(203, 42);
            this.lbUser.TabIndex = 10;
            this.lbUser.Text = "User name";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBtn
            // 
            this.pnBtn.Controls.Add(this.btnDel);
            this.pnBtn.Controls.Add(this.btnUpdate);
            this.pnBtn.Location = new System.Drawing.Point(388, 578);
            this.pnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(296, 65);
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
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.selected = true;
            this.btnUpdate.Size = new System.Drawing.Size(152, 62);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // elipsepnRight
            // 
            this.elipsepnRight.ElipseRadius = 30;
            this.elipsepnRight.TargetControl = this.pnRight;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnCreate);
            this.pnSearch.Controls.Add(this.txbSearch);
            this.pnSearch.Location = new System.Drawing.Point(0, 1);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(961, 58);
            this.pnSearch.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.AllowToggling = false;
            this.btnCreate.AnimationSpeed = 200;
            this.btnCreate.AutoGenerateColors = false;
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnCreate.ButtonText = "Adding";
            this.btnCreate.ButtonTextMarginLeft = 0;
            this.btnCreate.ColorContrastOnClick = 45;
            this.btnCreate.ColorContrastOnHover = 45;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCreate.CustomizableEdges = borderEdges1;
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreate.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.IconMarginLeft = 11;
            this.btnCreate.IconPadding = 10;
            this.btnCreate.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnCreate.IdleBorderRadius = 20;
            this.btnCreate.IdleBorderThickness = 1;
            this.btnCreate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCreate.IdleIconLeftImage = null;
            this.btnCreate.IdleIconRightImage = null;
            this.btnCreate.IndicateFocus = false;
            this.btnCreate.Location = new System.Drawing.Point(789, 5);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties1.BorderRadius = 20;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 0;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnCreate.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            stateProperties2.BorderRadius = 20;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 0;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnCreate.OnPressedState = stateProperties2;
            this.btnCreate.Size = new System.Drawing.Size(168, 49);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.TextMarginLeft = 0;
            this.btnCreate.UseDefaultRadiusAndThickness = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.AcceptsReturn = false;
            this.txbSearch.AcceptsTab = false;
            this.txbSearch.AnimationSpeed = 200;
            this.txbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
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
            this.txbSearch.Location = new System.Drawing.Point(8, 9);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.MinimumSize = new System.Drawing.Size(133, 43);
            this.txbSearch.Modified = false;
            this.txbSearch.Multiline = false;
            this.txbSearch.Name = "txbSearch";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnActiveState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSearch.OnDisabledState = stateProperties4;
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnIdleState = stateProperties6;
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSearch.PlaceholderText = "Search...";
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
            this.txbSearch.TextPlaceholder = "Search...";
            this.txbSearch.UseSystemPasswordChar = false;
            this.txbSearch.WordWrap = true;
            // 
            // elipsePnLeft
            // 
            this.elipsePnLeft.ElipseRadius = 30;
            this.elipsePnLeft.TargetControl = this.pnLeft;
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
            // AccountUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1683, 692);
            this.MinimumSize = new System.Drawing.Size(1683, 692);
            this.Name = "AccountUsrCtrl";
            this.Size = new System.Drawing.Size(1683, 692);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnPass.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnBtn.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.FlowLayoutPanel pnBtn;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbName;
        private System.Windows.Forms.Label lbInfo;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDel;
        private Bunifu.Framework.UI.BunifuElipse elipsepnRight;
        private System.Windows.Forms.Panel pnSearch;
        private Bunifu.Framework.UI.BunifuElipse elipsePnLeft;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnUpdate;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Panel pnPass;
        private System.Windows.Forms.Label lbNewPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbOldPass;
        private System.Windows.Forms.Label lbRePass;
        private System.Windows.Forms.Label lbOldPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbPhone;
        private System.Windows.Forms.Label lbPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbRePass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcbNewPass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown dropDownPosition;
        private System.Windows.Forms.Label lbPosition;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnDel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreate;
    }
}

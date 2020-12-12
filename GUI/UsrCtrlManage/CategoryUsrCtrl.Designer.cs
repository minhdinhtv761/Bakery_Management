namespace GUI.UsrCtrlManage
{
    partial class CategoryUsrCtrl

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUsrCtrl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elipsepnRight = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnCreate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txbSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.elipsePnLeft = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnUpdate = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnDel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnLeft.Controls.Add(this.bunifuDataGridView1);
            this.pnLeft.Location = new System.Drawing.Point(8, 60);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(1668, 623);
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
            this.food});
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
            this.bunifuDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1668, 623);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.FillWeight = 137.6729F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // food
            // 
            this.food.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.food.HeaderText = "Total foods";
            this.food.MinimumWidth = 6;
            this.food.Name = "food";
            this.food.ReadOnly = true;
            // 
            // elipsepnRight
            // 
            this.elipsepnRight.ElipseRadius = 30;
            this.elipsepnRight.TargetControl = this;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnCreate);
            this.pnSearch.Controls.Add(this.txbSearch);
            this.pnSearch.Location = new System.Drawing.Point(0, 1);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1676, 58);
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
            this.btnCreate.Location = new System.Drawing.Point(1504, 5);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnCreate.TabIndex = 22;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.TextMarginLeft = 0;
            this.btnCreate.UseDefaultRadiusAndThickness = true;
           // this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // elipsePnLeft
            // 
            this.elipsePnLeft.ElipseRadius = 30;
            this.elipsePnLeft.TargetControl = this.pnLeft;
            // 
            // elipseBtnUpdate
            // 
            this.elipseBtnUpdate.ElipseRadius = 20;
            this.elipseBtnUpdate.TargetControl = this;
            // 
            // elipseBtnDel
            // 
            this.elipseBtnDel.ElipseRadius = 20;
            this.elipseBtnDel.TargetControl = this;
            // 
            // CategoryUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1683, 692);
            this.MinimumSize = new System.Drawing.Size(1683, 692);
            this.Name = "CategoryUsrCtrl";
            this.Size = new System.Drawing.Size(1683, 692);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private Bunifu.Framework.UI.BunifuElipse elipsepnRight;
        private System.Windows.Forms.Panel pnSearch;
        private Bunifu.Framework.UI.BunifuElipse elipsePnLeft;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnUpdate;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreate;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
    }
}

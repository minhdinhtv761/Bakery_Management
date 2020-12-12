namespace GUI.UsrCtrlManage
{
    partial class InvoicesUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesUsrCtrl));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.dateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.dateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lbFrom = new System.Windows.Forms.Label();
            this.txbSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items = new System.Windows.Forms.DataGridViewLinkColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elipsePnMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnHeader.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.dateTo);
            this.pnHeader.Controls.Add(this.lbTo);
            this.pnHeader.Controls.Add(this.dateFrom);
            this.pnHeader.Controls.Add(this.lbFrom);
            this.pnHeader.Controls.Add(this.txbSearch);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1683, 58);
            this.pnHeader.TabIndex = 4;
            // 
            // dateTo
            // 
            this.dateTo.AllowDrop = true;
            this.dateTo.BackColor = System.Drawing.Color.White;
            this.dateTo.BorderRadius = 0;
            this.dateTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.FormatCustom = null;
            this.dateTo.Location = new System.Drawing.Point(1359, 11);
            this.dateTo.Margin = new System.Windows.Forms.Padding(5);
            this.dateTo.MaximumSize = new System.Drawing.Size(293, 42);
            this.dateTo.MinimumSize = new System.Drawing.Size(293, 42);
            this.dateTo.Name = "dateTo";
            this.dateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTo.Size = new System.Drawing.Size(293, 42);
            this.dateTo.TabIndex = 26;
            this.dateTo.Value = new System.DateTime(2020, 11, 26, 0, 0, 0, 0);
            this.dateTo.onValueChanged += new System.EventHandler(this.date_onValueChanged);
            // 
            // lbTo
            // 
            this.lbTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTo.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbTo.Location = new System.Drawing.Point(1288, 11);
            this.lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(63, 42);
            this.lbTo.TabIndex = 25;
            this.lbTo.Text = "To";
            this.lbTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateFrom
            // 
            this.dateFrom.AllowDrop = true;
            this.dateFrom.BackColor = System.Drawing.Color.White;
            this.dateFrom.BorderRadius = 0;
            this.dateFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.FormatCustom = null;
            this.dateFrom.Location = new System.Drawing.Point(961, 11);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(5);
            this.dateFrom.MaximumSize = new System.Drawing.Size(293, 42);
            this.dateFrom.MinimumSize = new System.Drawing.Size(293, 42);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateFrom.Size = new System.Drawing.Size(293, 42);
            this.dateFrom.TabIndex = 24;
            this.dateFrom.Value = new System.DateTime(2020, 11, 26, 0, 0, 0, 0);
            this.dateFrom.onValueChanged += new System.EventHandler(this.date_onValueChanged);
            // 
            // lbFrom
            // 
            this.lbFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFrom.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbFrom.Location = new System.Drawing.Point(891, 11);
            this.lbFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(63, 42);
            this.lbFrom.TabIndex = 23;
            this.lbFrom.Text = "From";
            this.lbFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txbSearch.Location = new System.Drawing.Point(13, 10);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.MinimumSize = new System.Drawing.Size(133, 43);
            this.txbSearch.Modified = false;
            this.txbSearch.Multiline = false;
            this.txbSearch.Name = "txbSearch";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSearch.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txbSearch.OnIdleState = stateProperties12;
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txbSearch.PlaceholderText = "Bill ID";
            this.txbSearch.ReadOnly = false;
            this.txbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSearch.SelectedText = "";
            this.txbSearch.SelectionLength = 0;
            this.txbSearch.SelectionStart = 0;
            this.txbSearch.ShortcutsEnabled = true;
            this.txbSearch.Size = new System.Drawing.Size(252, 43);
            this.txbSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txbSearch.TabIndex = 22;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearch.TextMarginBottom = 0;
            this.txbSearch.TextMarginLeft = 5;
            this.txbSearch.TextMarginTop = 0;
            this.txbSearch.TextPlaceholder = "Bill ID";
            this.txbSearch.UseSystemPasswordChar = false;
            this.txbSearch.WordWrap = true;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnMain.Controls.Add(this.bunifuDataGridView1);
            this.pnMain.Location = new System.Drawing.Point(13, 62);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1657, 630);
            this.pnMain.TabIndex = 5;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tableID,
            this.items,
            this.total,
            this.sale,
            this.date});
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1657, 630);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle13;
            this.id.FillWeight = 137.6729F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // tableID
            // 
            this.tableID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tableID.FillWeight = 65.65144F;
            this.tableID.HeaderText = "Table ID";
            this.tableID.MinimumWidth = 6;
            this.tableID.Name = "tableID";
            this.tableID.ReadOnly = true;
            this.tableID.Width = 150;
            // 
            // items
            // 
            this.items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.items.FillWeight = 145.7886F;
            this.items.HeaderText = "Items";
            this.items.MinimumWidth = 6;
            this.items.Name = "items";
            this.items.ReadOnly = true;
            this.items.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.items.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.items.Width = 150;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.total.DefaultCellStyle = dataGridViewCellStyle14;
            this.total.FillWeight = 50.887F;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // sale
            // 
            this.sale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sale.HeaderText = "Sale off";
            this.sale.MinimumWidth = 6;
            this.sale.Name = "sale";
            this.sale.ReadOnly = true;
            this.sale.Width = 150;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // elipsePnMain
            // 
            this.elipsePnMain.ElipseRadius = 30;
            this.elipsePnMain.TargetControl = this.pnMain;
            // 
            // InvoicesUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1683, 692);
            this.MinimumSize = new System.Drawing.Size(1683, 692);
            this.Name = "InvoicesUsrCtrl";
            this.Size = new System.Drawing.Size(1683, 692);
            this.pnHeader.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txbSearch;
        private Bunifu.Framework.UI.BunifuDatepicker dateTo;
        private System.Windows.Forms.Label lbTo;
        private Bunifu.Framework.UI.BunifuDatepicker dateFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Panel pnMain;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.Framework.UI.BunifuElipse elipsePnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableID;
        private System.Windows.Forms.DataGridViewLinkColumn items;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}

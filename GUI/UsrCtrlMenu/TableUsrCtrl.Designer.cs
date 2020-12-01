namespace GUI.UsrCtrlMenu
{
    partial class TableUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableUsrCtrl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.elipsePnLeft = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnList = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.btnOrdered = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEmpty = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.layoutListTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnList.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipsePnLeft
            // 
            this.elipsePnLeft.ElipseRadius = 30;
            this.elipsePnLeft.TargetControl = this;
            // 
            // pnList
            // 
            this.pnList.Controls.Add(this.pnLine);
            this.pnList.Controls.Add(this.btnOrdered);
            this.pnList.Controls.Add(this.btnEmpty);
            this.pnList.Controls.Add(this.btnAll);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 0);
            this.pnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(859, 63);
            this.pnList.TabIndex = 2;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 62);
            this.pnLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(859, 1);
            this.pnLine.TabIndex = 3;
            // 
            // btnOrdered
            // 
            this.btnOrdered.AllowToggling = false;
            this.btnOrdered.AnimationSpeed = 1;
            this.btnOrdered.AutoGenerateColors = false;
            this.btnOrdered.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdered.BackColor1 = System.Drawing.Color.Transparent;
            this.btnOrdered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdered.BackgroundImage")));
            this.btnOrdered.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrdered.ButtonText = "Ordered";
            this.btnOrdered.ButtonTextMarginLeft = 0;
            this.btnOrdered.ColorContrastOnClick = 45;
            this.btnOrdered.ColorContrastOnHover = 45;
            this.btnOrdered.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnOrdered.CustomizableEdges = borderEdges1;
            this.btnOrdered.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrdered.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnOrdered.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrdered.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrdered.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrdered.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOrdered.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnOrdered.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdered.IconMarginLeft = 11;
            this.btnOrdered.IconPadding = 10;
            this.btnOrdered.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdered.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnOrdered.IdleBorderRadius = 3;
            this.btnOrdered.IdleBorderThickness = 1;
            this.btnOrdered.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnOrdered.IdleIconLeftImage = null;
            this.btnOrdered.IdleIconRightImage = null;
            this.btnOrdered.IndicateFocus = false;
            this.btnOrdered.Location = new System.Drawing.Point(184, 0);
            this.btnOrdered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdered.MaximumSize = new System.Drawing.Size(92, 63);
            this.btnOrdered.MinimumSize = new System.Drawing.Size(92, 63);
            this.btnOrdered.Name = "btnOrdered";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Transparent;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnOrdered.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Transparent;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Transparent;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnOrdered.OnPressedState = stateProperties2;
            this.btnOrdered.Size = new System.Drawing.Size(92, 63);
            this.btnOrdered.TabIndex = 2;
            this.btnOrdered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrdered.TextMarginLeft = 0;
            this.btnOrdered.UseDefaultRadiusAndThickness = true;
            this.btnOrdered.Click += new System.EventHandler(this.btnOrdered_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.AllowToggling = false;
            this.btnEmpty.AnimationSpeed = 1;
            this.btnEmpty.AutoGenerateColors = false;
            this.btnEmpty.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpty.BackColor1 = System.Drawing.Color.Transparent;
            this.btnEmpty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpty.BackgroundImage")));
            this.btnEmpty.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpty.ButtonText = "Empty";
            this.btnEmpty.ButtonTextMarginLeft = 0;
            this.btnEmpty.ColorContrastOnClick = 45;
            this.btnEmpty.ColorContrastOnHover = 45;
            this.btnEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEmpty.CustomizableEdges = borderEdges2;
            this.btnEmpty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmpty.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnEmpty.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmpty.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmpty.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEmpty.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnEmpty.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpty.IconMarginLeft = 11;
            this.btnEmpty.IconPadding = 10;
            this.btnEmpty.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpty.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEmpty.IdleBorderRadius = 3;
            this.btnEmpty.IdleBorderThickness = 1;
            this.btnEmpty.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEmpty.IdleIconLeftImage = null;
            this.btnEmpty.IdleIconRightImage = null;
            this.btnEmpty.IndicateFocus = false;
            this.btnEmpty.Location = new System.Drawing.Point(92, 0);
            this.btnEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpty.MaximumSize = new System.Drawing.Size(92, 63);
            this.btnEmpty.MinimumSize = new System.Drawing.Size(92, 63);
            this.btnEmpty.Name = "btnEmpty";
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Transparent;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnEmpty.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.Transparent;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnEmpty.OnPressedState = stateProperties4;
            this.btnEmpty.Size = new System.Drawing.Size(92, 63);
            this.btnEmpty.TabIndex = 1;
            this.btnEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmpty.TextMarginLeft = 0;
            this.btnEmpty.UseDefaultRadiusAndThickness = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnAll
            // 
            this.btnAll.AllowToggling = false;
            this.btnAll.AnimationSpeed = 1;
            this.btnAll.AutoGenerateColors = false;
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAll.BackgroundImage")));
            this.btnAll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAll.ButtonText = "All";
            this.btnAll.ButtonTextMarginLeft = 0;
            this.btnAll.ColorContrastOnClick = 45;
            this.btnAll.ColorContrastOnHover = 45;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAll.CustomizableEdges = borderEdges3;
            this.btnAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAll.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnAll.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAll.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAll.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnAll.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.IconMarginLeft = 11;
            this.btnAll.IconPadding = 10;
            this.btnAll.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAll.IdleBorderRadius = 3;
            this.btnAll.IdleBorderThickness = 1;
            this.btnAll.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAll.IdleIconLeftImage = null;
            this.btnAll.IdleIconRightImage = null;
            this.btnAll.IndicateFocus = false;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAll.MaximumSize = new System.Drawing.Size(92, 63);
            this.btnAll.MinimumSize = new System.Drawing.Size(92, 63);
            this.btnAll.Name = "btnAll";
            stateProperties5.BorderColor = System.Drawing.Color.Transparent;
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.Transparent;
            stateProperties5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnAll.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Transparent;
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.Transparent;
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnAll.OnPressedState = stateProperties6;
            this.btnAll.Size = new System.Drawing.Size(92, 63);
            this.btnAll.TabIndex = 0;
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAll.TextMarginLeft = 0;
            this.btnAll.UseDefaultRadiusAndThickness = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // layoutListTable
            // 
            this.layoutListTable.BackColor = System.Drawing.SystemColors.Control;
            this.layoutListTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutListTable.Location = new System.Drawing.Point(0, 63);
            this.layoutListTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutListTable.Name = "layoutListTable";
            this.layoutListTable.Size = new System.Drawing.Size(859, 607);
            this.layoutListTable.TabIndex = 3;
            // 
            // TableUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.layoutListTable);
            this.Controls.Add(this.pnList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(859, 900);
            this.Name = "TableUsrCtrl";
            this.Size = new System.Drawing.Size(859, 670);
            this.pnList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLine;
        private Bunifu.Framework.UI.BunifuElipse elipsePnLeft;
        private System.Windows.Forms.Panel pnList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOrdered;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEmpty;
        private System.Windows.Forms.FlowLayoutPanel layoutListTable;
    }
}

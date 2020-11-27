namespace GUI.UsrCtrlMenu
{
    partial class MenuUsrCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsrCtrl));
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
            this.btnBread = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCake = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.pnList.Controls.Add(this.btnBread);
            this.pnList.Controls.Add(this.btnCake);
            this.pnList.Controls.Add(this.btnAll);
            this.pnList.Location = new System.Drawing.Point(0, 0);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(644, 51);
            this.pnList.TabIndex = 2;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 50);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(644, 1);
            this.pnLine.TabIndex = 3;
            // 
            // btnBread
            // 
            this.btnBread.AllowToggling = false;
            this.btnBread.AnimationSpeed = 200;
            this.btnBread.AutoGenerateColors = false;
            this.btnBread.BackColor = System.Drawing.Color.Transparent;
            this.btnBread.BackColor1 = System.Drawing.Color.Transparent;
            this.btnBread.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBread.BackgroundImage")));
            this.btnBread.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBread.ButtonText = "Bread";
            this.btnBread.ButtonTextMarginLeft = 0;
            this.btnBread.ColorContrastOnClick = 45;
            this.btnBread.ColorContrastOnHover = 45;
            this.btnBread.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnBread.CustomizableEdges = borderEdges1;
            this.btnBread.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBread.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnBread.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBread.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBread.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBread.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBread.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnBread.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnBread.IconMarginLeft = 11;
            this.btnBread.IconPadding = 10;
            this.btnBread.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnBread.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnBread.IdleBorderRadius = 3;
            this.btnBread.IdleBorderThickness = 1;
            this.btnBread.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnBread.IdleIconLeftImage = null;
            this.btnBread.IdleIconRightImage = null;
            this.btnBread.IndicateFocus = false;
            this.btnBread.Location = new System.Drawing.Point(138, 0);
            this.btnBread.Name = "btnBread";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Transparent;
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnBread.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Transparent;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Transparent;
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnBread.OnPressedState = stateProperties2;
            this.btnBread.Size = new System.Drawing.Size(69, 51);
            this.btnBread.TabIndex = 2;
            this.btnBread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBread.TextMarginLeft = 0;
            this.btnBread.UseDefaultRadiusAndThickness = true;
            this.btnBread.Click += new System.EventHandler(this.btnOrdered_Click);
            // 
            // btnCake
            // 
            this.btnCake.AllowToggling = false;
            this.btnCake.AnimationSpeed = 200;
            this.btnCake.AutoGenerateColors = false;
            this.btnCake.BackColor = System.Drawing.Color.Transparent;
            this.btnCake.BackColor1 = System.Drawing.Color.Transparent;
            this.btnCake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCake.BackgroundImage")));
            this.btnCake.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCake.ButtonText = "Cake";
            this.btnCake.ButtonTextMarginLeft = 0;
            this.btnCake.ColorContrastOnClick = 45;
            this.btnCake.ColorContrastOnHover = 45;
            this.btnCake.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCake.CustomizableEdges = borderEdges2;
            this.btnCake.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCake.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnCake.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCake.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCake.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCake.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCake.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCake.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCake.IconMarginLeft = 11;
            this.btnCake.IconPadding = 10;
            this.btnCake.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCake.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnCake.IdleBorderRadius = 3;
            this.btnCake.IdleBorderThickness = 1;
            this.btnCake.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCake.IdleIconLeftImage = null;
            this.btnCake.IdleIconRightImage = null;
            this.btnCake.IndicateFocus = false;
            this.btnCake.Location = new System.Drawing.Point(69, 0);
            this.btnCake.Name = "btnCake";
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Transparent;
            stateProperties3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnCake.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.Transparent;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnCake.OnPressedState = stateProperties4;
            this.btnCake.Size = new System.Drawing.Size(69, 51);
            this.btnCake.TabIndex = 1;
            this.btnCake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCake.TextMarginLeft = 0;
            this.btnCake.UseDefaultRadiusAndThickness = true;
            this.btnCake.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnAll
            // 
            this.btnAll.AllowToggling = false;
            this.btnAll.AnimationSpeed = 200;
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
            this.btnAll.Size = new System.Drawing.Size(69, 51);
            this.btnAll.TabIndex = 0;
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAll.TextMarginLeft = 0;
            this.btnAll.UseDefaultRadiusAndThickness = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.layoutPanel.Location = new System.Drawing.Point(0, 50);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(644, 494);
            this.layoutPanel.TabIndex = 3;
            // 
            // MenuUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.layoutPanel);
            this.MaximumSize = new System.Drawing.Size(644, 544);
            this.MinimumSize = new System.Drawing.Size(644, 544);
            this.Name = "MenuUsrCtrl";
            this.Size = new System.Drawing.Size(644, 544);
            this.pnList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLine;
        private Bunifu.Framework.UI.BunifuElipse elipsePnLeft;
        private System.Windows.Forms.Panel pnList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBread;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCake;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
    }
}

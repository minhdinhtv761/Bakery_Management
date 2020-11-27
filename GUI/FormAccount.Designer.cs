namespace GUI
{
    partial class FormAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropDownPosition = new Bunifu.Framework.UI.BunifuDropdown();
            this.lbPosition = new System.Windows.Forms.Label();
            this.txbID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txbRePass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbOldPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbRePass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.pnBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.elipseBtnUpdate = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnDel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elipseBtnSave = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.pnBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 15;
            this.elipseForm.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dropDownPosition);
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.txbRePass);
            this.panel1.Controls.Add(this.txbOldPass);
            this.panel1.Controls.Add(this.lbRePass);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Location = new System.Drawing.Point(35, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 175);
            this.panel1.TabIndex = 0;
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
            this.dropDownPosition.Location = new System.Drawing.Point(162, 124);
            this.dropDownPosition.Name = "dropDownPosition";
            this.dropDownPosition.NomalColor = System.Drawing.SystemColors.Control;
            this.dropDownPosition.onHoverColor = System.Drawing.Color.White;
            this.dropDownPosition.selectedIndex = 0;
            this.dropDownPosition.Size = new System.Drawing.Size(220, 34);
            this.dropDownPosition.TabIndex = 46;
            // 
            // lbPosition
            // 
            this.lbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPosition.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPosition.Location = new System.Drawing.Point(3, 124);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(152, 34);
            this.lbPosition.TabIndex = 45;
            this.lbPosition.Text = "Position";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txbID.Location = new System.Drawing.Point(162, 0);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.MaxLength = 32767;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(219, 34);
            this.txbID.TabIndex = 41;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbUser
            // 
            this.lbUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUser.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbUser.Location = new System.Drawing.Point(3, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(152, 34);
            this.lbUser.TabIndex = 37;
            this.lbUser.Text = "User name";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbRePass
            // 
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
            this.txbRePass.Location = new System.Drawing.Point(162, 83);
            this.txbRePass.Margin = new System.Windows.Forms.Padding(4);
            this.txbRePass.MaxLength = 32767;
            this.txbRePass.Name = "txbRePass";
            this.txbRePass.Size = new System.Drawing.Size(219, 34);
            this.txbRePass.TabIndex = 44;
            this.txbRePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbOldPass
            // 
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
            this.txbOldPass.Location = new System.Drawing.Point(162, 41);
            this.txbOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbOldPass.MaxLength = 32767;
            this.txbOldPass.Name = "txbOldPass";
            this.txbOldPass.Size = new System.Drawing.Size(219, 34);
            this.txbOldPass.TabIndex = 42;
            this.txbOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbRePass
            // 
            this.lbRePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRePass.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbRePass.Location = new System.Drawing.Point(3, 83);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(152, 34);
            this.lbRePass.TabIndex = 40;
            this.lbRePass.Text = "Re-enter password";
            this.lbRePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPass
            // 
            this.lbPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPass.Font = new System.Drawing.Font("Roboto", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPass.Location = new System.Drawing.Point(3, 42);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(152, 34);
            this.lbPass.TabIndex = 38;
            this.lbPass.Text = "Password";
            this.lbPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnBtn
            // 
            this.pnBtn.Controls.Add(this.btnCancel);
            this.pnBtn.Controls.Add(this.btnSave);
            this.pnBtn.Location = new System.Drawing.Point(123, 262);
            this.pnBtn.Name = "pnBtn";
            this.pnBtn.Size = new System.Drawing.Size(215, 53);
            this.pnBtn.TabIndex = 3;
            // 
            // elipseBtnUpdate
            // 
            this.elipseBtnUpdate.ElipseRadius = 20;
            // 
            // elipseBtnDel
            // 
            this.elipseBtnDel.ElipseRadius = 20;
            this.elipseBtnDel.TargetControl = this.btnCancel;
            // 
            // elipseBtnSave
            // 
            this.elipseBtnSave.ElipseRadius = 20;
            this.elipseBtnSave.TargetControl = this.btnSave;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbInfo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbInfo.Location = new System.Drawing.Point(12, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(227, 34);
            this.lbInfo.TabIndex = 12;
            this.lbInfo.Text = "Create a new account";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Active = true;
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = -3;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 30D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(1, 1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(102, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Location = new System.Drawing.Point(105, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = true;
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = " Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 327);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pnBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(780, 450);
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAccount";
            this.panel1.ResumeLayout(false);
            this.pnBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown dropDownPosition;
        private System.Windows.Forms.Label lbPosition;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbID;
        private System.Windows.Forms.Label lbUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbRePass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbOldPass;
        private System.Windows.Forms.Label lbRePass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.FlowLayoutPanel pnBtn;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnUpdate;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnDel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuElipse elipseBtnSave;
        private System.Windows.Forms.Label lbInfo;
    }
}
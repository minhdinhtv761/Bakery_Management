namespace BakeryManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnTop = new System.Windows.Forms.Panel();
            this.picBrandName = new System.Windows.Forms.PictureBox();
            this.boxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.boxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txbID = new JMetroTextBox.JMetroTextBox();
            this.btnSubmit = new JThinButton.JThinButton();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbPassword = new JMetroTextBox.JMetroTextBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrandName)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.AutoSize = true;
            this.pnTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.pnTop.Controls.Add(this.picBrandName);
            this.pnTop.Controls.Add(this.boxMinimize);
            this.pnTop.Controls.Add(this.boxClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(375, 105);
            this.pnTop.TabIndex = 1;
            // 
            // picBrandName
            // 
            this.picBrandName.Image = ((System.Drawing.Image)(resources.GetObject("picBrandName.Image")));
            this.picBrandName.Location = new System.Drawing.Point(86, 12);
            this.picBrandName.Name = "picBrandName";
            this.picBrandName.Size = new System.Drawing.Size(175, 90);
            this.picBrandName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrandName.TabIndex = 4;
            this.picBrandName.TabStop = false;
            // 
            // boxMinimize
            // 
            this.boxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.boxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.boxMinimize.HoverState.Parent = this.boxMinimize;
            this.boxMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.boxMinimize.Location = new System.Drawing.Point(331, 3);
            this.boxMinimize.Name = "boxMinimize";
            this.boxMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.boxMinimize.ShadowDecoration.Parent = this.boxMinimize;
            this.boxMinimize.Size = new System.Drawing.Size(21, 20);
            this.boxMinimize.TabIndex = 3;
            // 
            // boxClose
            // 
            this.boxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.boxClose.HoverState.Parent = this.boxClose;
            this.boxClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.boxClose.Location = new System.Drawing.Point(351, 3);
            this.boxClose.Name = "boxClose";
            this.boxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.boxClose.ShadowDecoration.Parent = this.boxClose;
            this.boxClose.Size = new System.Drawing.Size(21, 20);
            this.boxClose.TabIndex = 2;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.Transparent;
            this.txbID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbID.BorderRadius = 15;
            this.txbID.FillColor = System.Drawing.Color.White;
            this.txbID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbID.IsPassword = false;
            this.txbID.LineThickness = 2;
            this.txbID.Location = new System.Drawing.Point(68, 143);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID.MaxLength = 32767;
            this.txbID.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.txbID.Name = "txbID";
            this.txbID.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.OnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.txbID.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txbID.ReadOnly = false;
            this.txbID.Size = new System.Drawing.Size(247, 38);
            this.txbID.TabIndex = 2;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbID.TextName = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(254)))));
            this.btnSubmit.BorderRadius = 15;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Font = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Font_Size = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSubmit.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.btnSubmit.HoverBorder = System.Drawing.Color.Empty;
            this.btnSubmit.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSubmit.LineThickness = 2;
            this.btnSubmit.Location = new System.Drawing.Point(122, 311);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 44);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(82, 118);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 21);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(82, 202);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 21);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.Transparent;
            this.txbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbPassword.BorderRadius = 15;
            this.txbPassword.FillColor = System.Drawing.Color.White;
            this.txbPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbPassword.IsPassword = true;
            this.txbPassword.LineThickness = 2;
            this.txbPassword.Location = new System.Drawing.Point(68, 227);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPassword.MaxLength = 32767;
            this.txbPassword.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.OnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.txbPassword.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txbPassword.ReadOnly = false;
            this.txbPassword.Size = new System.Drawing.Size(247, 38);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPassword.TextName = "";
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Source Serif Pro", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            this.lbHome.Location = new System.Drawing.Point(154, 362);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(75, 20);
            this.lbHome.TabIndex = 8;
            this.lbHome.Text = "Go to home";
            this.lbHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHome_MouseDown);
            this.lbHome.MouseLeave += new System.EventHandler(this.lbHome_MouseLeave);
            this.lbHome.MouseHover += new System.EventHandler(this.lbHome_MouseHover);
            this.lbHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbHome_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Serif Pro", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "The ID or password you entered is incorrect.";
            this.label1.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBrandName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private JMetroTextBox.JMetroTextBox txbID;
        private JThinButton.JThinButton btnSubmit;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPassword;
        private JMetroTextBox.JMetroTextBox txbPassword;
        private System.Windows.Forms.Label lbHome;
        private Guna.UI2.WinForms.Guna2ControlBox boxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox boxClose;
        private System.Windows.Forms.PictureBox picBrandName;
        private System.Windows.Forms.Label label1;
    }
}


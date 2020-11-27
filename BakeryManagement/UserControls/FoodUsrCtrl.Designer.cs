namespace BakeryManagement.UserControls
{
    partial class FoodUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodUserControl));
            this.shadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.shadowPanel.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel.Controls.Add(this.panelInfo);
            this.shadowPanel.Controls.Add(this.btnImage);
            this.shadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shadowPanel.FillColor = System.Drawing.Color.White;
            this.shadowPanel.Location = new System.Drawing.Point(0, 0);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Radius = 4;
            this.shadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.shadowPanel.ShadowDepth = 125;
            this.shadowPanel.ShadowShift = 4;
            this.shadowPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.shadowPanel.Size = new System.Drawing.Size(135, 142);
            this.shadowPanel.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lbPrice);
            this.panelInfo.Controls.Add(this.lbName);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 97);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(135, 45);
            this.panelInfo.TabIndex = 1;
            this.panelInfo.Click += new System.EventHandler(this.panelInfo_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbPrice.Location = new System.Drawing.Point(0, 16);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrice.Size = new System.Drawing.Size(135, 16);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbName.Font = new System.Drawing.Font("Source Serif Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbName.Size = new System.Drawing.Size(135, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "<Item Name>";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImage
            // 
            this.btnImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage.CheckedState.Parent = this.btnImage;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImage.HoverState.ImageSize = new System.Drawing.Size(68, 68);
            this.btnImage.HoverState.Parent = this.btnImage;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImageRotate = 0F;
            this.btnImage.ImageSize = new System.Drawing.Size(50, 50);
            this.btnImage.Location = new System.Drawing.Point(0, 0);
            this.btnImage.Name = "btnImage";
            this.btnImage.PressedState.ImageSize = new System.Drawing.Size(68, 68);
            this.btnImage.PressedState.Parent = this.btnImage;
            this.btnImage.Size = new System.Drawing.Size(135, 95);
            this.btnImage.TabIndex = 0;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            this.btnImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImage_MouseDown);
            this.btnImage.MouseLeave += new System.EventHandler(this.btnImage_MouseLeave);
            this.btnImage.MouseHover += new System.EventHandler(this.btnImage_MouseHover);
            // 
            // FoodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shadowPanel);
            this.Name = "FoodUserControl";
            this.Size = new System.Drawing.Size(135, 142);
            this.shadowPanel.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel shadowPanel;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
    }
}

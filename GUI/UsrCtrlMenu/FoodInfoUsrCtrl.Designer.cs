namespace GUI.UsrCtrlMenu
{
    partial class FoodInfoUsrCtrl
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
            this.pnMain = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.picFood);
            this.pnMain.Controls.Add(this.lbPrice);
            this.pnMain.Controls.Add(this.lbName);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.PanelColor = System.Drawing.Color.Transparent;
            this.pnMain.ShadowDept = 2;
            this.pnMain.ShadowTopLeftVisible = false;
            this.pnMain.Size = new System.Drawing.Size(122, 147);
            this.pnMain.TabIndex = 0;
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(0, 0);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(115, 89);
            this.picFood.TabIndex = 8;
            this.picFood.TabStop = false;
            this.picFood.Click += new System.EventHandler(this.MousseClick);
            this.picFood.DoubleClick += new System.EventHandler(this.MousseDoubleClick);
            this.picFood.MouseLeave += new System.EventHandler(this.MousseLeave);
            this.picFood.MouseHover += new System.EventHandler(this.MousseHover);
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.lbPrice.Location = new System.Drawing.Point(1, 116);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(115, 25);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "0";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPrice.UseCompatibleTextRendering = true;
            this.lbPrice.UseMnemonic = false;
            this.lbPrice.Click += new System.EventHandler(this.MousseClick);
            this.lbPrice.DoubleClick += new System.EventHandler(this.MousseDoubleClick);
            this.lbPrice.MouseLeave += new System.EventHandler(this.MousseLeave);
            this.lbPrice.MouseHover += new System.EventHandler(this.MousseHover);
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.lbName.Location = new System.Drawing.Point(1, 92);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 24);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Item name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.UseCompatibleTextRendering = true;
            this.lbName.UseMnemonic = false;
            this.lbName.Click += new System.EventHandler(this.MousseClick);
            this.lbName.DoubleClick += new System.EventHandler(this.MousseDoubleClick);
            this.lbName.MouseLeave += new System.EventHandler(this.MousseLeave);
            this.lbName.MouseHover += new System.EventHandler(this.MousseHover);
            // 
            // FoodInfoUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Name = "FoodInfoUsrCtrl";
            this.Size = new System.Drawing.Size(122, 147);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel pnMain;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picFood;
    }
}

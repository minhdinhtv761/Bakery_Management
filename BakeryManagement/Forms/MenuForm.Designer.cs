namespace BakeryManagement.Forms
{
    partial class MenuForm
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
            this.pnCatetory = new System.Windows.Forms.Panel();
            this.icSearch = new FontAwesome.Sharp.IconPictureBox();
            this.pnTopBottom = new System.Windows.Forms.Panel();
            this.txbSearching = new JMaterialTextbox.JMaterialTextbox();
            this.btnAll = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.food1 = new BakeryManagement.UserControls.FoodUserControl();
            this.pnCatetory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icSearch)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCatetory
            // 
            this.pnCatetory.Controls.Add(this.icSearch);
            this.pnCatetory.Controls.Add(this.pnTopBottom);
            this.pnCatetory.Controls.Add(this.txbSearching);
            this.pnCatetory.Controls.Add(this.btnAll);
            this.pnCatetory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCatetory.Location = new System.Drawing.Point(0, 0);
            this.pnCatetory.Name = "pnCatetory";
            this.pnCatetory.Size = new System.Drawing.Size(679, 58);
            this.pnCatetory.TabIndex = 0;
            // 
            // icSearch
            // 
            this.icSearch.BackColor = System.Drawing.SystemColors.Control;
            this.icSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.icSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icSearch.IconSize = 26;
            this.icSearch.Location = new System.Drawing.Point(624, 14);
            this.icSearch.Name = "icSearch";
            this.icSearch.Size = new System.Drawing.Size(30, 26);
            this.icSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icSearch.TabIndex = 22;
            this.icSearch.TabStop = false;
            this.icSearch.Click += new System.EventHandler(this.icSearch1_Click);
            // 
            // pnTopBottom
            // 
            this.pnTopBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnTopBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnTopBottom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnTopBottom.Location = new System.Drawing.Point(0, 57);
            this.pnTopBottom.Name = "pnTopBottom";
            this.pnTopBottom.Size = new System.Drawing.Size(679, 1);
            this.pnTopBottom.TabIndex = 21;
            // 
            // txbSearching
            // 
            this.txbSearching.BackColor = System.Drawing.Color.Transparent;
            this.txbSearching.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearching.Font_Size = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearching.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.HintText = "Please enter your food...";
            this.txbSearching.IsPassword = false;
            this.txbSearching.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.LineThickness = 2;
            this.txbSearching.Location = new System.Drawing.Point(453, 15);
            this.txbSearching.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSearching.MaxLength = 32767;
            this.txbSearching.Name = "txbSearching";
            this.txbSearching.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbSearching.ReadOnly = false;
            this.txbSearching.Size = new System.Drawing.Size(201, 25);
            this.txbSearching.TabIndex = 14;
            this.txbSearching.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbSearching.TextName = "Please enter your food...";
            this.txbSearching.Visible = false;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAll.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAll.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnAll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnAll.IconSize = 20;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Rotation = 0D;
            this.btnAll.Size = new System.Drawing.Size(69, 58);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "All";
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.food1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 58);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(679, 617);
            this.panelMenu.TabIndex = 1;
            // 
            // food1
            // 
            this.food1.BackColor = System.Drawing.Color.Transparent;
            this.food1.Location = new System.Drawing.Point(3, 3);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(135, 142);
            this.food1.TabIndex = 0;
            this.food1.Click += new System.EventHandler(this.food1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 675);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnCatetory);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuForm";
            this.pnCatetory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icSearch)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCatetory;
        private FontAwesome.Sharp.IconButton btnAll;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private UserControls.FoodUserControl food1;
        private JMaterialTextbox.JMaterialTextbox txbSearching;
        private System.Windows.Forms.Panel pnTopBottom;
        private FontAwesome.Sharp.IconPictureBox icSearch;
    }
}
namespace BakeryManagement.UserControls
{
    partial class BillInfoUsrCtrl
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
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.icNote = new FontAwesome.Sharp.IconButton();
            this.txbNote = new JMaterialTextbox.JMaterialTextbox();
            this.icTrash = new FontAwesome.Sharp.IconPictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.numericQTY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel.BorderRadius = 4;
            this.panel.Controls.Add(this.icNote);
            this.panel.Controls.Add(this.txbNote);
            this.panel.Controls.Add(this.icTrash);
            this.panel.Controls.Add(this.lbTotal);
            this.panel.Controls.Add(this.numericQTY);
            this.panel.Controls.Add(this.lbPrice);
            this.panel.Controls.Add(this.lbName);
            this.panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(597, 67);
            this.panel.TabIndex = 0;
            // 
            // icNote
            // 
            this.icNote.AutoSize = true;
            this.icNote.BackColor = System.Drawing.Color.Transparent;
            this.icNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icNote.FlatAppearance.BorderSize = 0;
            this.icNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icNote.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icNote.ForeColor = System.Drawing.Color.Transparent;
            this.icNote.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icNote.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icNote.IconSize = 16;
            this.icNote.Location = new System.Drawing.Point(18, 39);
            this.icNote.Name = "icNote";
            this.icNote.Rotation = 0D;
            this.icNote.Size = new System.Drawing.Size(25, 24);
            this.icNote.TabIndex = 15;
            this.icNote.UseVisualStyleBackColor = false;
            // 
            // txbNote
            // 
            this.txbNote.BackColor = System.Drawing.Color.Transparent;
            this.txbNote.Font = new System.Drawing.Font("Source Serif Pro", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNote.Font_Size = new System.Drawing.Font("Source Serif Pro", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNote.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbNote.HintText = "Note";
            this.txbNote.IsPassword = false;
            this.txbNote.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbNote.LineThickness = 2;
            this.txbNote.Location = new System.Drawing.Point(39, 41);
            this.txbNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNote.MaxLength = 32767;
            this.txbNote.Name = "txbNote";
            this.txbNote.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbNote.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txbNote.ReadOnly = false;
            this.txbNote.Size = new System.Drawing.Size(99, 22);
            this.txbNote.TabIndex = 14;
            this.txbNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbNote.TextName = "Note";
            // 
            // icTrash
            // 
            this.icTrash.BackColor = System.Drawing.SystemColors.Control;
            this.icTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icTrash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icTrash.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.icTrash.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.icTrash.Location = new System.Drawing.Point(556, 11);
            this.icTrash.Name = "icTrash";
            this.icTrash.Size = new System.Drawing.Size(32, 32);
            this.icTrash.TabIndex = 4;
            this.icTrash.TabStop = false;
            this.icTrash.Click += new System.EventHandler(this.icTrash_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Source Serif Pro", 12.5F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbTotal.Location = new System.Drawing.Point(479, 15);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(50, 24);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Total";
            // 
            // numericQTY
            // 
            this.numericQTY.BackColor = System.Drawing.Color.Transparent;
            this.numericQTY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.numericQTY.BorderRadius = 5;
            this.numericQTY.BorderThickness = 2;
            this.numericQTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericQTY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numericQTY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numericQTY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numericQTY.DisabledState.Parent = this.numericQTY;
            this.numericQTY.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numericQTY.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numericQTY.FillColor = System.Drawing.SystemColors.Control;
            this.numericQTY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.numericQTY.FocusedState.Parent = this.numericQTY;
            this.numericQTY.Font = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQTY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.numericQTY.Location = new System.Drawing.Point(331, 13);
            this.numericQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericQTY.Name = "numericQTY";
            this.numericQTY.ShadowDecoration.Parent = this.numericQTY;
            this.numericQTY.Size = new System.Drawing.Size(74, 29);
            this.numericQTY.TabIndex = 2;
            this.numericQTY.TextOffset = new System.Drawing.Point(4, 0);
            this.numericQTY.ThousandsSeparator = true;
            this.numericQTY.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.numericQTY.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(171)))));
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Source Serif Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbPrice.Location = new System.Drawing.Point(213, 17);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 21);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Price";
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbName.Location = new System.Drawing.Point(13, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(125, 26);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "<Item name>";
            // 
            // BillInfoUsrCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "BillInfoUsrCtrl";
            this.Size = new System.Drawing.Size(597, 67);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQTY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericQTY;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTotal;
        private FontAwesome.Sharp.IconPictureBox icTrash;
        private FontAwesome.Sharp.IconButton icNote;
        private JMaterialTextbox.JMaterialTextbox txbNote;
    }
}

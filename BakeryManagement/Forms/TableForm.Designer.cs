namespace BakeryManagement.Forms
{
    partial class TableForm
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
            this.pnStatus = new System.Windows.Forms.Panel();
            this.pnBorder = new System.Windows.Forms.Panel();
            this.btnEmpty = new FontAwesome.Sharp.IconButton();
            this.btnOrdered = new FontAwesome.Sharp.IconButton();
            this.btnAll = new FontAwesome.Sharp.IconButton();
            this.layoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStatus
            // 
            this.pnStatus.Controls.Add(this.pnBorder);
            this.pnStatus.Controls.Add(this.btnEmpty);
            this.pnStatus.Controls.Add(this.btnOrdered);
            this.pnStatus.Controls.Add(this.btnAll);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(624, 45);
            this.pnStatus.TabIndex = 0;
            this.pnStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnStatus_Paint);
            // 
            // pnBorder
            // 
            this.pnBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnBorder.Location = new System.Drawing.Point(0, 57);
            this.pnBorder.Name = "pnBorder";
            this.pnBorder.Size = new System.Drawing.Size(679, 1);
            this.pnBorder.TabIndex = 0;
            // 
            // btnEmpty
            // 
            this.btnEmpty.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmpty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmpty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnEmpty.FlatAppearance.BorderSize = 0;
            this.btnEmpty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.btnEmpty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEmpty.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnEmpty.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnEmpty.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnEmpty.IconSize = 20;
            this.btnEmpty.Location = new System.Drawing.Point(188, 0);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEmpty.Rotation = 0D;
            this.btnEmpty.Size = new System.Drawing.Size(95, 45);
            this.btnEmpty.TabIndex = 10;
            this.btnEmpty.Text = "Empty";
            this.btnEmpty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpty.UseVisualStyleBackColor = false;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnOrdered
            // 
            this.btnOrdered.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrdered.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrdered.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOrdered.FlatAppearance.BorderSize = 0;
            this.btnOrdered.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.btnOrdered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.btnOrdered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdered.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOrdered.Font = new System.Drawing.Font("Source Serif Pro SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnOrdered.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btnOrdered.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnOrdered.IconSize = 20;
            this.btnOrdered.Location = new System.Drawing.Point(81, 0);
            this.btnOrdered.Name = "btnOrdered";
            this.btnOrdered.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOrdered.Rotation = 0D;
            this.btnOrdered.Size = new System.Drawing.Size(107, 45);
            this.btnOrdered.TabIndex = 9;
            this.btnOrdered.Text = "Ordered";
            this.btnOrdered.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdered.UseVisualStyleBackColor = false;
            this.btnOrdered.Click += new System.EventHandler(this.btnOrdered_Click);
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
            this.btnAll.Size = new System.Drawing.Size(81, 45);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "All";
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // layoutPanelTable
            // 
            this.layoutPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelTable.Location = new System.Drawing.Point(0, 45);
            this.layoutPanelTable.Name = "layoutPanelTable";
            this.layoutPanelTable.Size = new System.Drawing.Size(624, 645);
            this.layoutPanelTable.TabIndex = 2;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 690);
            this.Controls.Add(this.layoutPanelTable);
            this.Controls.Add(this.pnStatus);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuForm";
            this.pnStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStatus;
        private FontAwesome.Sharp.IconButton btnAll;
        private FontAwesome.Sharp.IconButton btnEmpty;
        private FontAwesome.Sharp.IconButton btnOrdered;
        private System.Windows.Forms.Panel pnBorder;
        private System.Windows.Forms.FlowLayoutPanel layoutPanelTable;
    }
}
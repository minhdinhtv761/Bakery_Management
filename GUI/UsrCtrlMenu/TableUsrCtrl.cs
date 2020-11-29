using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace GUI.UsrCtrlMenu
{
    public partial class TableUsrCtrl : UserControl
    {

        public Panel bottomBorderBtn;
        private BunifuButton currButton;
        public TableUsrCtrl()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(69, 2);
            bottomBorderBtn.BackColor = Styles.RGBs.pink;
            pnList.Controls.Add(bottomBorderBtn);
            this.btnAll_Click(btnAll, new EventArgs());
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                //Button
                DisableButton();
                currButton = (BunifuButton)senderButton;
                currButton.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //Border Button
                bottomBorderBtn.Location = new Point(currButton.Location.X, 49);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnOrdered_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void insertTable()
        {
            Bunifu.Framework.UI.BunifuTileButton table = new Bunifu.Framework.UI.BunifuTileButton();
            // 
            // table
            // 
            table.BackColor = System.Drawing.SystemColors.Control;
            table.color = System.Drawing.SystemColors.Control;
            table.colorActive = System.Drawing.Color.Transparent;
            table.Cursor = System.Windows.Forms.Cursors.Hand;
            table.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            table.Image = Properties.Resources.icons8_table_64;
            table.ImagePosition = 19;
            table.ImageZoom = 50;
            table.LabelPosition = 39;
            table.LabelText = "TB001";
            table.Location = new System.Drawing.Point(2, 3);
            table.Margin = new System.Windows.Forms.Padding(2, 3, 1, 1);
            table.Size = new System.Drawing.Size(112, 141);
            table.TabIndex = 0;
            //
            // end
            //
            this.layoutListTable.Controls.Add(table);
            
        }
    }
}

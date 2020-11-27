using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormManager : Form
    {

        public Panel bottomBorderBtn;
        public IconButton currButton;
        public FormManager()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(205, 2);
            bottomBorderBtn.BackColor = Styles.RGBs.pink;
            pnList.Controls.Add(bottomBorderBtn);
            bottomBorderBtn.Visible = false;
            this.btnProduct_Click(btnProduct, new EventArgs());
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                //Button
                DisableButton();
                currButton = (IconButton)senderButton;
                pages.SetPage(((Control)senderButton).Text);
                currButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
                currButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
                //Border Button
                bottomBorderBtn.Location = new Point(currButton.Location.X, 50);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
                currButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
        }
    }
}



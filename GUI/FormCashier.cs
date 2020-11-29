using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FontAwesome.Sharp;
using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCashier : Form
    {

        private IconButton currButton;
        public FormCashier()
        {
            InitializeComponent();
            this.btnTable_Click(btnTable, new EventArgs());
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                //Button
                DisableButton();
                currButton = (IconButton)senderButton;
                currButton.ForeColor = Styles.RGBs.pink;
                currButton.IconColor = Styles.RGBs.pink;
                currButton.BackColor = SystemColors.Control;
                currButton.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.ForeColor = SystemColors.Control;
                currButton.IconColor = SystemColors.Control;
                currButton.BackColor = Styles.RGBs.dark;
                currButton.FlatAppearance.MouseOverBackColor = Styles.RGBs.pink;
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.TABLE.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            this.MENU.BringToFront();
        }

        private void txbSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public int Items
        {
            get { return Convert.ToInt32(lbItems.Text); }
            set
            { lbItems.Text = value.ToString(); }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {

        }

        private void menuManage_Click(object sender, EventArgs e)
        {

        }

        private void menuSignOut_Click(object sender, EventArgs e)
        {

        }

        private void more_Click(object sender, EventArgs e)
        {
            if (this.menuDrop.Visible)
                this.menuDrop.Visible = false;
            else
                this.menuDrop.Visible = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form formPayment = new FormPayment();
            formPayment.ShowDialog();
        }
    }
}

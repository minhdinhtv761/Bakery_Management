using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BakeryManagement.Forms;

namespace BakeryManagement
{
    public partial class CashierForm : Form
    {
        private IconButton currButton;
        private Form activateForm;
        public CashierForm()
        {
            InitializeComponent();
            //  this.DoubleBuffered = true;
            //   this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableButton();
                currButton = (IconButton)senderButton;
                currButton.BackColor = Control.DefaultBackColor;
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.BackColor = StyleTheme.RGBs.color4;
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.pnLeft.Controls.Add(childForm);
            childForm.Show();
        }

        private void boxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TableForm(), sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuForm(), sender);
        }


        private void CashierForm_Load(object sender, EventArgs e)
        {

            OpenChildForm(new TableForm(), btnTable);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnNote_Click(object sender, EventArgs e)
        {

        }
    }
}

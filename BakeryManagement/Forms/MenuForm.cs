using BakeryManagement.UserControls;
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

namespace BakeryManagement.Forms
{
    public partial class MenuForm : Form
    {
        private IconButton currButton;
        public MenuForm()
        {
            InitializeComponent();
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                DisableButton();
                currButton = (IconButton)senderButton;
                currButton.Font = StyleTheme.FontChildForm.activateFont;
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.Font = StyleTheme.FontChildForm.disableFont;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void food1_Click(object sender, EventArgs e)
        {
        }
        private bool clicked = false;
        private void icSearch1_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                this.icSearch.Location = new Point(433, 14);
                this.txbSearching.Visible = true;
            }
            else
            {
                this.icSearch.Location = new Point(624, 14);
                this.txbSearching.Visible = false;
            }
            clicked = !clicked;
        }
    }
}

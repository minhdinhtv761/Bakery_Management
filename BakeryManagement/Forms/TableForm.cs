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
    public partial class TableForm : Form
    {
        private IconButton currButton;
        public TableForm()
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

        private void btnOrdered_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void pnStatus_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

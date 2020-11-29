using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.UsrCtrlManage
{
    public partial class AccountUsrCtrl : UserControl
    {
        public AccountUsrCtrl()
        {
            InitializeComponent();
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form formAccount = new FormAccount();
            formAccount.ShowDialog();
        }

      
    }
}

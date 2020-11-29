using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            Form formCashier = new FormCashier();
            formCashier.Show();
            this.Hide();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Form formManager = new FormManager();
            formManager.Show();
            this.Hide();
        }
    }
}

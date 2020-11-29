using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form cashierForm = new CashierForm();
            this.Hide();
            cashierForm.Show();
        }
        private void lbHome_MouseHover(object sender, EventArgs e)
        {
            lbHome.Font = new Font(lbHome.Font, FontStyle.Underline | FontStyle.Italic);
        }

        private void lbHome_MouseLeave(object sender, EventArgs e)
        {
            lbHome.Font = new Font(lbHome.Font, FontStyle.Italic);
        }

        private void lbHome_MouseDown(object sender, MouseEventArgs e)
        {
            lbHome.Font = new Font(lbHome.Font, FontStyle.Underline | FontStyle.Italic);
            lbHome.ForeColor = StyleTheme.RGBs.color5;
        }

        private void lbHome_MouseUp(object sender, MouseEventArgs e)
        {
            lbHome.Font = new Font(lbHome.Font,FontStyle.Italic);
            lbHome.ForeColor = StyleTheme.RGBs.color3;
        }
    }
}

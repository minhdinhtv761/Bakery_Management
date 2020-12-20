using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.DAL;
using GUI.DTO;

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

        private bool LoginAdmin(string username, string password)
        {
            return AccountDAL.Instance.LoginAdmin(username, password);
        }

        private bool LoginStaff(string username, string password)
        {
            return AccountDAL.Instance.LoginStaff(username, password);
        }

        private bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            string username = this.txbID.Text;
            string password = this.txbPass.Text;
            try
            {
                if (Login(username, password))
                {
                    Form formCashier = new FormCashier();
                    formCashier.Show();
                    this.Hide();
                    this.txbID.Text = this.txbPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Username or Password does not correct!", "Error");
                }
            }
            catch
            {

            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            string username = this.txbID.Text;
            string password = this.txbPass.Text;
            try
            {
                if (Login(username, password))
                {
                    Form formManager = new FormManager();
                    formManager.Show();
                    this.Hide();
                    this.txbID.Text = this.txbPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Username or Password does not correct!", "Error");
                }
            }
            catch
            {

            }
        }
    }
}

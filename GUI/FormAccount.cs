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
using GUI.UsrCtrlManage;

namespace GUI
{
    public partial class FormAccount : Form
    {
        private AccountUsrCtrl parent;
        public FormAccount(AccountUsrCtrl parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void addAccount(string username, string password, int type)
        {
            //AccountDAL.Instance.addAccount(username, password, type);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txbID.Text;
            string password = txbOldPass.Text;
            string rePassword = txbRePass.Text;
            int type = int.Parse(txbChucVu.Text);

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter your username", "Error");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your password", "Error");
            }
            else if (string.IsNullOrEmpty(rePassword))
            {
                MessageBox.Show("Enter your re-password", "Error");
            }
            else if (txbRePass.Text != txbOldPass.Text)
            {
                MessageBox.Show("Re-password does not match", "Error");
            }
            else
            {
                bool res = AccountDAL.Instance.addAccount(username, password, type);
                if (res != false)
                {
                    parent.LoadDataGridView();
                    MessageBox.Show("Add successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username is existed");
                }
            }
        }
    }
}

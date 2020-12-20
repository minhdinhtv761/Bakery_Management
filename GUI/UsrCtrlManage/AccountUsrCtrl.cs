using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.DAL;

namespace GUI.UsrCtrlManage
{
    public partial class AccountUsrCtrl : UserControl
    {
        public AccountUsrCtrl()
        {
            InitializeComponent();
            LoadDataGridView();
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
            Form formAccount = new FormAccount(this);
            formAccount.ShowDialog();
        }
        public void LoadDataGridView()
        {
            this.bunifuDataGridView1.Rows.Clear();
            foreach (var item in AccountDAL.Instance.GetAccount())
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bunifuDataGridView1);
                newRow.Cells[0].Value = item.MaNV1;
                newRow.Cells[2].Value = item.Type1;
                bunifuDataGridView1.Rows.Add(newRow);
            }
            txbID.Text = bunifuDataGridView1.Rows[0].Cells[0].Value.ToString();
            //txbOldPass.Text = bunifuDataGridView1.Rows[0].Cells[5].Value.ToString();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //txbChucVu.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //txbOldPass.Text = bunifuDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string username = txbID.Text;
            DelAccount(username);
        }

        void DelAccount(string username)
        {
            AccountDAL.Instance.deleteAccount(username);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private bool Login(string username, string password)
        {
            return AccountDAL.Instance.Login(username, password);
        }

        bool ChangePassword(string username, string password, string newPass)
        {
            password = txbOldPass.Text;
            newPass = txbNewPass.Text;
            string reNewPass = txbRePass.Text;

            if(password == newPass)
            {
                MessageBox.Show("New password does match ", "Error");
            }
            else if(newPass != reNewPass)
            {
                MessageBox.Show("Re-new password does not match", "Error");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your old password", "Error");
            }
            else if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Enter your new password", "Error");
            }
            else if (string.IsNullOrEmpty(reNewPass))
            {
                MessageBox.Show("Enter your re-new password", "Error");
            }
            if(Login(username, password))
            {
                AccountDAL.Instance.changePassword(username, newPass);
                MessageBox.Show("Change password succesfully");
                return true;
            }
            else
            {
                MessageBox.Show("Old password does not correct", "Error");
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txbID.Text;
            string password = txbOldPass.Text;
            string newPass = txbNewPass.Text;
            ChangePassword(username, password, newPass);
        }
    }
}

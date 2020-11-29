using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.DAL;
using GUI.DTO;

namespace GUI.UsrCtrlManage
{
    public partial class EmployeeUsrCtrl : UserControl
    {
        public EmployeeUsrCtrl()
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

        private void picFood_MouseHover(object sender, EventArgs e)
        {
            this.lbAdding.Visible = true;
        }

        private void picFood_MouseLeave(object sender, EventArgs e)
        {
            this.lbAdding.Visible = false;
        }



        private void radioMale_Click(object sender, EventArgs e)
        {
            lbMale.Enabled = true;
            lbFemale.Enabled = false;
        }

     

        private void radioFemale_Click(object sender, EventArgs e)
        {

            lbMale.Enabled = false;
            lbFemale.Enabled = true;
        }

        void LoadDataGridView()
        {
            this.bunifuDataGridView1.Controls.Clear();
            foreach (var item in EmployeeDAL.Instance.GetFood())
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bunifuDataGridView1);
                newRow.Cells[0].Value = item.MaNV1;
                newRow.Cells[1].Value = item.TenNV1;
                newRow.Cells[2].Value = item.ChucVu1;
                newRow.Cells[3].Value = item.SoDT1;
                bunifuDataGridView1.Rows.Add(newRow);
            }
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = bunifuDataGridView1.SelectedCells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.SelectedCells[1].Value.ToString();
            txbPhone.Text = bunifuDataGridView1.SelectedCells[3].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            deleteEmployee(id);
        }

        void deleteEmployee(string id)
        {
            EmployeeDAL.Instance.DeleteEmployee(id);
            this.bunifuDataGridView1.Controls.Clear();
            LoadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        void AddEmployee(string MaNV, string TenNV, string SoDT, DateTime NgVL, int ChucVu)
        {
            EmployeeDAL.Instance.AddEmployee(MaNV, TenNV, SoDT, NgVL, ChucVu);
            this.bunifuDataGridView1.Controls.Clear();
        }
    }
}

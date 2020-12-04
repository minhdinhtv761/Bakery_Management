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
                newRow.Cells[4].Value = item.NgVL1;
                bunifuDataGridView1.Rows.Add(newRow);
            }
            txbID.Text = bunifuDataGridView1.Rows[0].Cells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.Rows[0].Cells[1].Value.ToString();
            txbChucVu.Text = bunifuDataGridView1.Rows[0].Cells[2].Value.ToString();
            txbPhone.Text = bunifuDataGridView1.Rows[0].Cells[3].Value.ToString();
            txbdateworking.Text = bunifuDataGridView1.Rows[0].Cells[4].Value.ToString();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txbChucVu.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txbPhone.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txbdateworking.Text = bunifuDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)        //delete
        {
            string id = txbID.Text;
            deleteEmployee(id);
        }

        void deleteEmployee(string id)
        {
            EmployeeDAL.Instance.DeleteEmployee(id);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)             //update - Add
        {
            string Manv = txbID.Text;
            string Tennv = txbName.Text;
            string Sodt = txbPhone.Text;
            string Ngvl = txbdateworking.Text ;
            string Chucvu = txbChucVu.Text;
            AddEmployee(Manv, Tennv, Sodt, Ngvl, Chucvu);
        }

        void AddEmployee(string MaNV, string TenNV, string SoDT, string NgVL, string ChucVu)
        {
            EmployeeDAL.Instance.AddEmployee(MaNV, TenNV, SoDT, NgVL, ChucVu);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)          //Save - Edit 
        {
            string Manv = txbID.Text;
            string Tennv = txbName.Text;
            string Sodt = txbPhone.Text;
            string Ngvl = txbdateworking.Text;
            string Chucvu = txbChucVu.Text;
            EditEmployee(Manv, Tennv, Sodt, Ngvl, Chucvu);
        }

        void EditEmployee(string MaNV, string TenNV, string SoDT, string NgVL, string ChucVu)
        {
            EmployeeDAL.Instance.EditEmployee(MaNV, TenNV, SoDT, NgVL, ChucVu);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        string getLink()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return open.FileName;
            }
            else
            {
                return "";
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            string link = this.getLink();
            picUser.Image = new Bitmap(link);
        }


        public void searchEmployee(string search)
        {
            List<EmployeeDTO> staffs = EmployeeDAL.Instance.GetFood();
            this.bunifuDataGridView1.Rows.Clear();
            foreach (EmployeeDTO staff in staffs)
            {
                if (staff.TenNV1.ToLower().Contains(this.txbSearch.Text.ToLower()))
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(bunifuDataGridView1);
                    newRow.Cells[0].Value = staff.MaNV1;
                    newRow.Cells[1].Value = staff.TenNV1;
                    newRow.Cells[2].Value = staff.ChucVu1;
                    newRow.Cells[3].Value = staff.SoDT1;
                    newRow.Cells[4].Value = staff.NgVL1;
                    this.bunifuDataGridView1.Rows.Add(newRow);
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            searchEmployee(txbSearch.Text);
        }
    }
}

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
using System.Data.SqlClient;
using System.IO;

namespace GUI.UsrCtrlManage
{
    public partial class EmployeeUsrCtrl : UserControl
    {
        public EmployeeUsrCtrl()
        {
            InitializeComponent();
            LoadDataGridView();
        }


        string imgLocation = "";
        byte[] images = null;

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
                newRow.Cells[5].Value = item.Image;
                bunifuDataGridView1.Rows.Add(newRow);
            }
            txbID.Text = bunifuDataGridView1.Rows[0].Cells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.Rows[0].Cells[1].Value.ToString();
            txbChucVu.Text = bunifuDataGridView1.Rows[0].Cells[2].Value.ToString();
            txbPhone.Text = bunifuDataGridView1.Rows[0].Cells[3].Value.ToString();
            dateworking.Value = (DateTime)bunifuDataGridView1.Rows[0].Cells[4].Value;

            if (bunifuDataGridView1.Rows[0].Cells[5].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])bunifuDataGridView1.SelectedRows[0].Cells[5].Value);
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();
                picUser.Image = a;
            }
            else
            {
                picUser.Refresh();
            }
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txbChucVu.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txbPhone.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateworking.Value = (DateTime)bunifuDataGridView1.SelectedRows[0].Cells[4].Value;

            if (bunifuDataGridView1.SelectedRows[0].Cells[5].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])bunifuDataGridView1.SelectedRows[0].Cells[5].Value);       
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();
                picUser.Image = a;
                picUser.BringToFront();
            }
            else    
            {
                picUser.Image = null;
                picUser.Invalidate();
               // AddingImage_label.BringToFront();
            }

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UKMBISK7;Initial Catalog=QUANLY_TIEMBANH;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from NHANVIEN", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                if (da["MANV"].ToString() == txbID.Text)
                {
                    txbAdd.Text = (da["DIACHI"].ToString());
                    txbEmail.Text = (da["EMAIL"].ToString());
                    if (da["GIOITINH"].ToString() == "Male")
                    {
                        radioMale.Checked = true;
                        radioFemale.Checked = false;
                    }
                    else if (da["GIOITINH"].ToString() == "Female")
                    {
                        radioFemale.Checked = true;
                        radioMale.Checked = false;
                    }                       
                    break;
                }
            }
            con.Close();
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

        void EditEmployee(string MaNV, string TenNV, string SoDT, DateTime NgVL, string ChucVu, string DiaChi, string email, string gioitinh, byte[] image)
        {
            EmployeeDAL.Instance.EditEmployee(MaNV, TenNV, SoDT, NgVL, ChucVu, DiaChi, email, gioitinh, image);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)             //update - Edit
        {
            string gioitinh = "";
            if (radioMale.Checked)
            {
                gioitinh = "Male";
            }
            else if (radioFemale.Checked)
            {
                gioitinh = "Female";
            }
            string Manv = txbID.Text;
            string Tennv = txbName.Text;
            string Sodt = txbPhone.Text;
            DateTime Ngvl = dateworking.Value;
            string Chucvu = txbChucVu.Text;
            string diachi = txbAdd.Text;
            string email = txbEmail.Text;

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            EditEmployee(Manv, Tennv, Sodt, Ngvl, Chucvu, diachi, email, gioitinh, images);
            MessageBox.Show("Update successfully");
        }

        void AddEmployee(string MaNV, string TenNV, string SoDT, DateTime NgVL, string ChucVu, string DiaChi, string email, string gioitinh, byte[] image)
        {
            EmployeeDAL.Instance.AddEmployee(MaNV, TenNV, SoDT, NgVL, ChucVu, DiaChi, email, gioitinh, image);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)          //Save - Add 
        {
            string gioitinh = "";
            if (radioMale.Checked)
            {
                gioitinh = "Male";
            }
            else if (radioFemale.Checked)
            {
                gioitinh = "Female";
            }
            string Manv = txbID.Text;
            string Tennv = txbName.Text;
            string Sodt = txbPhone.Text;
            DateTime Ngvl = dateworking.Value;
            string Chucvu = txbChucVu.Text;
            string DiaChi = txbAdd.Text;
            string email = txbEmail.Text;

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            AddEmployee(Manv, Tennv, Sodt, Ngvl, Chucvu, DiaChi, email, gioitinh, images);
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picUser.ImageLocation = imgLocation;
            }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.DAL;
using GUI.DTO;
using GUI.UsrCtrlMenu;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;

namespace GUI.UsrCtrlManage
{
    public partial class ProductUsrCtrl : UserControl
    {
        public ProductUsrCtrl()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        string imgLocation = "";
        byte[] images = null;
        SqlCommand cmd;

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

        void LoadDataGridView()
        {
            this.bunifuDataGridView1.Controls.Clear();
            foreach (var item in FoodDAL.Instance.GetFood())
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bunifuDataGridView1);
                newRow.Cells[0].Value = item.MaMA;
                newRow.Cells[1].Value = item.TenMA;
                newRow.Cells[2].Value = item.MaLoai;
                newRow.Cells[3].Value = item.DonGia;
                newRow.Cells[4].Value = item.DVT;
                newRow.Cells[5].Value = item.Image;
                bunifuDataGridView1.Rows.Add(newRow);
            }
            txbID.Text = bunifuDataGridView1.Rows[0].Cells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.Rows[0].Cells[1].Value.ToString();
            txbCategory.Text = bunifuDataGridView1.Rows[0].Cells[2].Value.ToString();   
            txbPrice.Text = bunifuDataGridView1.Rows[0].Cells[3].Value.ToString();
            txbDVT.Text = bunifuDataGridView1.Rows[0].Cells[4].Value.ToString();

            if (bunifuDataGridView1.Rows[0].Cells[5].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])bunifuDataGridView1.SelectedRows[0].Cells[5].Value);
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();
                picFood.Image = a;
            }
            else
            {
                picFood.Refresh();
            }
        }

        private void picFood_MouseLeave(object sender, EventArgs e)
        {
            this.lbAdding.Visible = false;
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txbCategory.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txbPrice.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txbDVT.Text = bunifuDataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            if (bunifuDataGridView1.SelectedRows[0].Cells[5].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])bunifuDataGridView1.SelectedRows[0].Cells[5].Value);
                Bitmap a = new Bitmap(Image.FromStream(ms));
                a.MakeTransparent();
                picFood.Image = a;
                picFood.BringToFront();
            }
            else
            {
                picFood.Image = null;
                picFood.Invalidate();
                AddingImage_label.BringToFront();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            DeleteFood(id);         
        }      //Delete

        void DeleteFood(string id)
        {
            FoodDAL.Instance.DeleteFood(id);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        void AddFood(string maMA, string tenMA, int donGia, string DTV, string maLoai,byte[] Image)
        {
            FoodDAL.Instance.AddFood(maMA, tenMA, donGia, DTV, maLoai, Image);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)           //Add
        {
            string maMA = txbID.Text;
            string tenMA = txbName.Text;
            int donGia = int.Parse(txbPrice.Text);
            string DVT = txbDVT.Text;
            string maLoai = txbCategory.Text;

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            AddFood(maMA, tenMA, donGia, DVT, maLoai, images);    
        }

        void EditFood(string maMa, string tenMa, int donGia, string DVT, string maLoai, byte[] Image)
        {
            FoodDAL.Instance.EditFood(maMa, tenMa, donGia, DVT, maLoai, Image);
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)     //Edit
        {
            string maMA = txbID.Text;
            string tenMA = txbName.Text;
            int donGia = int.Parse(txbPrice.Text);
            string DVT = txbDVT.Text;
            string maLoai = txbCategory.Text;

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            EditFood(maMA, tenMA, donGia, DVT, maLoai, images);
            MessageBox.Show("Update successfully");
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picFood.ImageLocation = imgLocation;
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            searchFood(txbSearch.Text);
        }
        private void txbSearch_Click(object sender, EventArgs e)
        {
            searchFood(txbSearch.Text);
        }

        public void searchFood(string search)
        {
            List<FoodDTO> foods = FoodDAL.Instance.GetFood();
            this.bunifuDataGridView1.Rows.Clear();
            foreach(FoodDTO food in foods)
            {
                if (food.TenMA.ToLower().Contains(this.txbSearch.Text.ToLower()))
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(bunifuDataGridView1);
                    newRow.Cells[0].Value = food.MaMA;
                    newRow.Cells[1].Value = food.TenMA;
                    newRow.Cells[2].Value = food.MaLoai;
                    newRow.Cells[3].Value = food.DonGia;
                    newRow.Cells[4].Value = food.DVT;
                    this.bunifuDataGridView1.Rows.Add(newRow);
                }
            }
        }

        private void picFood_Click(object sender, EventArgs e)
        {

        }
    }
}

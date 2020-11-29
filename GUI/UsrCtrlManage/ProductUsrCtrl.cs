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
    public partial class ProductUsrCtrl : UserControl
    {
        public ProductUsrCtrl()
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
                bunifuDataGridView1.Rows.Add(newRow);

            }

        }

        private void picFood_MouseLeave(object sender, EventArgs e)
        {
            this.lbAdding.Visible = false;
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = bunifuDataGridView1.SelectedCells[0].Value.ToString();
            txbName.Text = bunifuDataGridView1.SelectedCells[1].Value.ToString();
            txbPrice.Text = bunifuDataGridView1.SelectedCells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maMA = txbID.Text;
            string tenMA = txbName.Text;
            int donGia = int.Parse(txbPrice.Text);
            AddFood(maMA, tenMA,donGia);
        }

        void AddFood(string maMA, string tenMA, int donGia)
        {
            FoodDAL.Instance.AddFood(maMA, tenMA, donGia);
            this.bunifuDataGridView1.Controls.Clear();
            LoadDataGridView();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            DeleteFood(id);         
        }

        void DeleteFood(string id)
        {
            FoodDAL.Instance.DeleteFood(id);
            this.bunifuDataGridView1.Controls.Clear();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        void AddFood(string maMa, string tenMa, int donGia, string DVT, string maLoai)
        {
            FoodDAL.Instance.EditFood(maMa, tenMa, donGia, DVT, maLoai);
            this.bunifuDataGridView1.Controls.Clear();
            LoadDataGridView();
        }
    }
}

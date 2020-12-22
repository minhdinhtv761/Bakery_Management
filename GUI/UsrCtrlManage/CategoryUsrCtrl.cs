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
    public partial class CategoryUsrCtrl : UserControl
    {
        public CategoryUsrCtrl()
        {
            InitializeComponent();
            LoadDataGridVew();

            updateCategory();
        }

        void LoadDataGridVew()
        {
            this.bunifuDataGridView1.Controls.Clear();
            foreach (var item in CategoryDAL.Instance.GetCategory())
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bunifuDataGridView1);
                newRow.Cells[0].Value = item.MaLoai;
                newRow.Cells[1].Value = item.TenLoai;
                newRow.Cells[2].Value = item.Total1;
                bunifuDataGridView1.Rows.Add(newRow);
            }
        }

        public void updateCategory()
        {
            CategoryDAL.Instance.updateCategory();
            bunifuDataGridView1.Rows.Clear();
            LoadDataGridVew();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            searchFood(txbSearch.Text);
        }

        public void searchFood(string search)
        {
            List<CategoryDTO> categorys = CategoryDAL.Instance.GetCategory();
            this.bunifuDataGridView1.Rows.Clear();
            foreach (CategoryDTO category in categorys)
            {
                if (category.TenLoai.ToLower().Contains(this.txbSearch.Text.ToLower()))
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(bunifuDataGridView1);
                    newRow.Cells[0].Value = category.MaLoai;
                    newRow.Cells[1].Value = category.TenLoai;
                    newRow.Cells[2].Value = category.Total1;
                    this.bunifuDataGridView1.Rows.Add(newRow);
                }
            }
        }
    }
}

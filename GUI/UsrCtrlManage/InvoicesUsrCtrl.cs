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
    public partial class InvoicesUsrCtrl : UserControl
    {
        public InvoicesUsrCtrl()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        void LoadDataGridView()
        {
            this.bunifuDataGridView1.Controls.Clear();
            foreach (var item in BillDAL.Instance.GetBill())
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bunifuDataGridView1);
                newRow.Cells[0].Value = item.MaHD1;
                newRow.Cells[1].Value = item.MaBan1;
                newRow.Cells[2].Value = item.MaNV1;
                newRow.Cells[3].Value = item.TriGia1;
                newRow.Cells[4].Value = item.GiamGia1;
                newRow.Cells[5].Value = item.NgXuat1;
                bunifuDataGridView1.Rows.Add(newRow);
            }
        }

        public void searchBill(string search)
        {
            List<BillDTO> bills = BillDAL.Instance.GetBill();
            this.bunifuDataGridView1.Rows.Clear();
            foreach (BillDTO bill in bills)
            {
                if (bill.MaHD1.ToString().Contains(this.txbSearch.Text.ToLower()))
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(bunifuDataGridView1);
                    newRow.Cells[0].Value = bill.MaHD1;
                    newRow.Cells[1].Value = bill.MaBan1;
                    newRow.Cells[2].Value = bill.MaNV1;
                    newRow.Cells[3].Value = bill.TriGia1;
                    newRow.Cells[4].Value = bill.GiamGia1;
                    newRow.Cells[5].Value = bill.NgXuat1;
                    this.bunifuDataGridView1.Rows.Add(newRow);
                }
            }
        }

        public void searchDateBill()
        {
            List<BillDTO> bills = BillDAL.Instance.GetBill().FindAll(x => x.NgXuat1 >= dateFrom.Value && x.NgXuat1 <= dateTo.Value);
            this.bunifuDataGridView1.Rows.Clear();
            foreach(BillDTO bill in bills)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(bunifuDataGridView1);
                newRow.Cells[0].Value = bill.MaHD1;
                newRow.Cells[1].Value = bill.MaBan1;
                newRow.Cells[2].Value = bill.MaNV1;
                newRow.Cells[3].Value = bill.TriGia1;
                newRow.Cells[4].Value = bill.GiamGia1;
                newRow.Cells[5].Value = bill.NgXuat1;
                this.bunifuDataGridView1.Rows.Add(newRow);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            searchBill(txbSearch.Text);
        }


        private void date_onValueChanged(object sender, EventArgs e)
        {
            if(dateFrom.Value != null && dateTo.Value != null)
            {
                searchDateBill();
            }
        }
    }
}

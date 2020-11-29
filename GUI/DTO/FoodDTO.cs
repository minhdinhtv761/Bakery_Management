using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
namespace GUI.DTO
{
    public class FoodDTO
    {
        private string maMA;
        private string tenMA;
        private int donGia;
        private string dVT;
        private string maLoai;

        public string MaMA { get => maMA; set => maMA = value; }
        public string TenMA { get => tenMA; set => tenMA = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string DVT { get => dVT; set => dVT = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }

        public FoodDTO(string maMA, string tenMA, int donGia, string dvt, string maLoai)
        {
            this.maMA = maMA;
            this.TenMA = tenMA;
            this.donGia = donGia;
            this.dVT = dvt;
            this.maLoai = maLoai;
        }
        public FoodDTO(DataRow row)
        {
            this.maMA = row["MAMA"].ToString();
            this.TenMA = row["TENMA"].ToString();
            this.donGia = (int)row["DonGia"];
            this.dVT = row["DVT"].ToString();
            this.maLoai = row["maLOAI"].ToString();
        }
    }
}

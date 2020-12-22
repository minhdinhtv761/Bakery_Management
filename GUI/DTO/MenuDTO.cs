using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GUI.DTO
{
    public class MenuDTO
    {
        private int MaHD;
        private string MaMA;
        private string TenMA;
        private int price;
        private int count;

        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaMA1 { get => MaMA; set => MaMA = value; }
        public string TenMA1 { get => TenMA; set => TenMA = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }

        public MenuDTO(int MaHD, string MaMA, string TenMA, int price, int count)
        {
            this.MaHD = MaHD;
            this.MaMA = MaMA;
            this.TenMA = TenMA;
            this.price = price;
            this.count = count;
        }

        public MenuDTO(DataRow row)
        {
            this.MaHD = (int)row["MAHD"];
            this.MaMA = row["MAMA"].ToString();
            this.TenMA = row["TENMA"].ToString();
            this.price = (int)row["TRIGIA"];
            this.count = (int)row["SOLUONG"];
        }
    }
}

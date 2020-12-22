using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GUI.DTO
{
    public class BillInfoDTO
    {
        private int MaHD;
        private string MaMA;
        private int SoLuong;

        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaMA1 { get => MaMA; set => MaMA = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }

        public BillInfoDTO(int MaHD, string MaMA, int SoLuong)
        {
            this.MaHD = MaHD;
            this.MaMA = MaMA;
            this.SoLuong = SoLuong;
        }

        public BillInfoDTO(DataRow row)
        {
            this.MaHD = (int)row["MAHD"];
            this.MaMA = row["MAMA"].ToString();
            this.SoLuong = (int)row["SOLUONG"];
        }
    }
}

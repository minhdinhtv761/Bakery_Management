using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
namespace GUI.DTO
{
    public class BillDTO
    {
        private int MaHD;
        private string MaNV;
        private DateTime NgXuat;
        private int TriGia;
        private int GiamGia;
        private string MaBan;

        public int MaHD1 { get => MaHD; set => MaHD = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgXuat1 { get => NgXuat; set => NgXuat = value; }
        public int TriGia1 { get => TriGia; set => TriGia = value; }
        public int GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public string MaBan1 { get => MaBan; set => MaBan = value; }

        public BillDTO(int MaHD, string MaNV, DateTime NgXuat, int TriGia, int GiamGia, string MaBan)
        {
            this.MaHD = MaHD;
            this.MaNV = MaNV;
            this.NgXuat = NgXuat;
            this.TriGia = TriGia;
            this.GiamGia = GiamGia;
            this.MaBan = MaBan;
        }
        public BillDTO(DataRow row)
        {
            this.MaHD = (int)row["MAHD"];
            this.MaNV = row["MANV"].ToString();
            this.NgXuat = (DateTime)row["NGXUAT"];
            this.TriGia = int.Parse(row["TRIGIA"].ToString());
            this.GiamGia = (int)row["GIAMGIA"];
            this.MaBan = row["MABAN"].ToString();
        }
    }
}

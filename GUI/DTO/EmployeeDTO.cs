using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class EmployeeDTO
    {
        private string MaNV;
        private string TenNV;
        private string SoDT;
        private DateTime NgVL;
        private int ChucVu;
        private string DiaChi;
        private string Email;
        private string GioiTinh;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public DateTime NgVL1 { get => NgVL; set => NgVL = value; }
        public int ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }

        public EmployeeDTO(string MaNV, string TenNV, int ChucVu, string SoDT, DateTime NgVL, string DiaChi, string Email, string GioiTinh)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.SoDT = SoDT;
            this.NgVL = NgVL;
            this.ChucVu = ChucVu;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.GioiTinh = GioiTinh;
        }
        public EmployeeDTO(DataRow row)
        {
            this.MaNV = row["MANV"].ToString();
            this.TenNV = row["TENNV"].ToString();
            this.SoDT = row["SODT"].ToString();
            this.NgVL = (DateTime)row["NGVL"];
            this.ChucVu = (int)row["CHUCVU"];
            this.DiaChi = row["DIACHI"].ToString();
            this.Email = row["EMAIL"].ToString();
            this.GioiTinh = row["GIOITINH"].ToString();
        }
    }
}

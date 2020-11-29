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

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public DateTime NgVL1 { get => NgVL; set => NgVL = value; }
        public int ChucVu1 { get => ChucVu; set => ChucVu = value; }

        public EmployeeDTO(string MaNV, string TenNV, int ChucVu, string SoDT, DateTime NgVL)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.SoDT = SoDT;
            this.NgVL = NgVL;
            this.ChucVu = ChucVu;
        }
        public EmployeeDTO(DataRow row)
        {
            this.MaNV = row["MANV"].ToString();
            this.TenNV = row["TENNV"].ToString();
            this.SoDT = row["SODT"].ToString();
            this.NgVL = (DateTime)row["NGVL"];
            this.ChucVu = (int)row["CHUCVU"];
        }
    }
}

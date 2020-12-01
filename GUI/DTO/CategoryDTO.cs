using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class CategoryDTO
    {
        private string maLoai;
        private string tenLoai;
        private int Total;

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public int Total1 { get => Total; set => Total = value; }

        public CategoryDTO(string maLoai, string tenLoai, int Total)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.Total = Total;
        }

        public CategoryDTO(DataRow row)
        {
            this.maLoai = row["MALOAI"].ToString();
            this.tenLoai = row["TENLOAI"].ToString();
            this.Total = (int)row["TOTAL"];
        }
    }
}

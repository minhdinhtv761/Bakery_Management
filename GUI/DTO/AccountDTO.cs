using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class AccountDTO
    {
        private string MaNV;
        private string Pass;
        private int Type;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public int Type1 { get => Type; set => Type = value; }

        public AccountDTO(string MaNV, string Pass, int Type)
        {
            this.MaNV = MaNV;
            this.Pass = Pass;
            this.Type = Type;
        }
        public AccountDTO(DataRow row)
        {
            this.MaNV = row["MANV"].ToString();
            this.Pass = row["MATKHAU"].ToString();
            this.Type = (int)row["Type"];
        }
    }
}

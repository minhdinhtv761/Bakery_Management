using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using GUI.DTO;
using GUI.DAL;

namespace GUI.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance
        {
            get { if (instance == null) instance = new BillInfoDAL(); return instance; }
            private set { BillInfoDAL.instance = value; }
        }

        private BillInfoDAL() { }

        public List<BillInfoDTO> GetBillInfo()
        {
            List<BillInfoDTO> billInfos = new List<BillInfoDTO>();

            string query = "select * from CTHD";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfoDTO billInfo = new BillInfoDTO(item);
                billInfos.Add(billInfo);
            }
            return billInfos;
        }

        public void InsertBillInfo(int idBill, string idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @MaHD , @MaMA , @count ", new object[] { idBill, idDrink, count });
        }

        public void UpdateBillInfo(int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("update CTHD set SOLUONG = " + count + " where MAMA = '" + idDrink + "'");
        }

        public void DeleteBillInfobyIDDrink(string iddrink, int billid)
        {
            DataProvider.Instance.ExecuteNonQuery(string.Format("Delete from CTHD where MAMA = {0} and MAHD = {1}", iddrink , billid));
        }

    }
}

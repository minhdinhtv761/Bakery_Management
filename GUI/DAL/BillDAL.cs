using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DTO;
using GUI.DAL;

namespace GUI.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return instance; }
            private set { BillDAL.instance = value; }
        }

        private BillDAL() { }

        public List<BillDTO> GetBill()
        {
            List<BillDTO> bills = new List<BillDTO>();

            string query = "select * from HOADON";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillDTO bill = new BillDTO(item);
                bills.Add(bill);
            }

            return bills;
        }

        public bool ExistBillbyIDBill(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM HOADON where MAHD = {0}", idBill));

            return data.Rows.Count > 0;
        }

        public int GetMAXIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(MAHD) from HOADON");
            }
            catch
            {
                return 0;
            }
        }

        public void InsertBill(int id, string staffID)
        {
            string query = string.Format("insert into HOADON (MAHD, MANV) values ({0}, {1})", id, staffID);
            DataProvider.Instance.ExecuteNonQuery(query);
            //DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @ID , @StaffID , @Note", new object[] { id, staffID, "Đặt món" });
        }
    }
}

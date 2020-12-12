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
    }
}

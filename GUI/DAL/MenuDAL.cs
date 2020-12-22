using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GUI.DTO;
using GUI.DAL;
using System.Data;

namespace GUI.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return instance; }
            set => instance = value;
        }

        private MenuDAL() { }

        public List<MenuDTO> GetListMenu()
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            string query = "select bd.MAHD as IDBillInfo, d.MAMA as IDFood, d.TENMA, d.DONGIA, bd.SOLUONG " +
                            "from CTHD as bd " +
                            "inner join MONAN as d " +
                            "on bd.MAMA = d.MAMA";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<MenuDTO> GetListMenu(int idBill)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_getListFoodbyBillID @MaHD ", new object[] { idBill });

            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public int GetCount(int billID)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(string.Format("SELECT SUM(bf.SOLUONG) FROM CTHD bf " +
                    "JOIN MONAN d ON d.MAMA = bf.MAMA " +
                    "WHERE MAHD = {0}", billID));
            }
            catch
            {
                return 0;
            }
        }

        public int GetTotalPrice(int billID)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(string.Format("SELECT SUM(d.DONGIA * bf.SOLUONG) FROM CTHD bf " +
                    "JOIN MONAN d ON d.MAMA = bf.MAMA " +
                    "WHERE MAHD = {0}", billID));
            }
            catch
            {
                return 0;
            }
        }
    }
}

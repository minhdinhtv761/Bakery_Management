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
    public class CategoryDAL
    {

        private static CategoryDAL instance;

        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set { CategoryDAL.instance = value; }
        }

        private CategoryDAL() { }

        public List<CategoryDTO> GetCategory()
        {
            List<CategoryDTO> categorys = new List<CategoryDTO>();

            string query = "select * from PHANLOAI";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                categorys.Add(category);
            }

            return categorys;
        }

        public void updateCategory()
        {
            string query = string.Format("update PHANLOAI set TOTAL = (select count(MAMA) as SL from MONAN " +
                "where MONAN.MALOAI = PHANLOAI.MALOAI )");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}

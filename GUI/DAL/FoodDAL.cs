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
    public class FoodDAL
    {
        private static FoodDAL instance;

        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return instance; }
            private set { FoodDAL.instance = value; }
        }

        private FoodDAL() { }

        public List<FoodDTO> GetFood()
        {
            List<FoodDTO> foods = new List<FoodDTO>();

            string query = "SELECT * FROM MONAN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                foods.Add(food);
            }

            return foods;
        }

        public void DeleteFood(string id)
        {
            string query = string.Format("DELETE FROM MONAN WHERE MAMA = '{0}'", id);

            DataProvider.Instance.ExecuteQuery(query);
        }

        public void AddFood(string maMA, string tenMA,int donGia,string DTV,string maLoai,byte[] Image)
        {
            /*string query = string.Format("insert into MONAN (MAMA,TENMA,DONGIA,DVT,MALOAI,LinkImage) values ('{0}','{1}','{2}','{3}','{4}','{5}')", maMA, tenMA, donGia.ToString(), DTV, maLoai,Image);

            DataProvider.Instance.ExecuteQuery(query);*/
            DataProvider.Instance.ExecuteQuery("USP_AddDrink @MAMA , @TENMA , @DONGIA , @DVT , @MALOAI , @LinkImage ",
                new object[] { maMA, tenMA, donGia, DTV, maLoai, Image });
        }

        public void EditFood(string maMa,string tenMa,int donGia,string DVT,string maLoai)
        {
            string query = string.Format("update MONAN set TENMA = '{0}',DONGIA = '{1}' ,DVT = '{2}',MALOAI = '{3}' where MAMA = '{4}'", tenMa, donGia.ToString(), DVT, maLoai,maMa);
            DataProvider.Instance.ExecuteQuery(query);
        }


    }
}

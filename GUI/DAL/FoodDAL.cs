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

    }
}
